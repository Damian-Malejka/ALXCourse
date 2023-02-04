using HttpClientShowcase.Interfaces;
using HttpClientShowcase.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientShowcase
{
    public class HttpClientDemo: IHttpClientDemo//strzelamy do  testowych api z neta i do api prowadzacego
    {
        private const string OutputFolderPath = @"C:\ProgramTest\Img";//sciezka do zapisu zdjec pobranych ze stron
        private readonly HttpClient _httpClient;
        public HttpClientDemo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> Hello(string name)//asyncTaks<string> string zwracana wartosc w metodach klas przed async daje znac ze to kod asynchroniczny
        {
            return $"Hello {name}";
        }
        public async Task GetRandomJoke()//metody te musze byc asynchroniczne bo wewnatrz korzystamy z awaita i innje metody asynchronicznej
        {
            var requestUri = "https://official-joke-api.appspot.com/random_joke"; //to uri testowe wklejalismy to do postmana jak uzywalismy metody get
            var response = await _httpClient.GetAsync(requestUri);// await spowoduje ze my zapiszemy do response dopiero jak otrzymamy odpowiedz ale program leci dalej on nie mrozi sie w tym miejscu
            var responseContentJson = await response.Content.ReadAsStringAsync();//zapisz do responseContentJson jak otrzymasz odpowiedz, ale nie czekaj tylko leć dalej z programem
            var joke = JsonConvert.DeserializeObject<JokeResponse>(responseContentJson);//przeksztalcamy jsona w stringu na obiekt JokeResponse
            Console.WriteLine($"Joke for today:\n{joke.Setup}\n >{joke.Punchline}\n");
        }
        public async Task GetRandomCatInfo()
        {
            var requestUri = "https://catfact.ninja/fact";
            var response = await _httpClient.GetAsync(requestUri);
            var responseContentJson = await response.Content.ReadAsStringAsync();
            var catFact = JsonConvert.DeserializeObject<CatFactResponse>(responseContentJson);
            Console.WriteLine($"Fun facts about cats:\n{catFact.Fact}\n");


        }

        public async Task GetRandomDogImage()
        {
            var requestUri = "https://dog.ceo/api/breeds/image/random";
            var response = await _httpClient.GetAsync(requestUri);
            var responseContentJson = await response.Content.ReadAsStringAsync();
            var dogRandomImageResponse = JsonConvert.DeserializeObject<DogImageResponse>(responseContentJson);

            try
            {
                SaveImage(dogRandomImageResponse.Message, "something");
                Process.Start("explorer.exe", OutputFolderPath);//uruchamiany proces explorera plikow w systemie
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

            }
        }

        public async Task PredictGender(string name)
        {
            var baseRequestUri = "https://api.genderize.io";// tutaj podczas geta w postmanie trzeba dac params name i wprowadzic imie
            var uriBuilder = new UriBuilder(baseRequestUri);
            uriBuilder.Query = $"name={name}";//mozna by normalnie do stringa uri dodac ?name=damian itp ale tutaj zaawansowana metoda pokazana
            var uri = uriBuilder.Uri;
            var response = await _httpClient.GetAsync(uri);//korzystamy z metody get
            var responseContentJson = await response.Content.ReadAsStringAsync();
            var genderPredictionResponse = JsonConvert.DeserializeObject<GenderPredictionResponse>(responseContentJson);
            Console.WriteLine($"Name{genderPredictionResponse.Name}\nGender:{genderPredictionResponse.Gender}\nProbability: {genderPredictionResponse.Probability*100}%\n");

        }

        public async Task SendEmail(Email email)//tutaj prywatne api prowadzącego
        {
            var baseRequestUri = "https://cnemailingservice20230203214349.azurewebsites.net/api/CNEMailingFunction";
            var emailJson = JsonConvert.SerializeObject(email);
            var requestContent = new StringContent(emailJson);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, baseRequestUri);//mowimy o tym ze korzysytamy z metody post
            requestMessage.Content = requestContent;
            requestMessage.Headers.Add("x-functions-key", "TU MA BYĆ KLUCZ AUTORYZACYJNY!"); //tutaj dodajemy klucz autoryzacyjny
            var result = await _httpClient.SendAsync(requestMessage);
            var resultContent = await result.Content.ReadAsStringAsync(); //wyciagamy krotka odpowiedz, zamiast response status itp to tylko informacja o tym czy zostal wyslany czy nie
            Console.WriteLine(resultContent);
        }

        private void SaveImage(string imageUri, string fileName)//metoda do zapisywania obrazka otrzymanego w odpowiedzi   argumenty adres oraz nazwa zapisywanego pliku
        {
            using(WebClient webClient = new WebClient())
            {
                var stream = webClient.OpenRead(imageUri);//tworzymy strumien danych z uri
                var bitmap = new Bitmap(stream);//instalujemy pakiet alt + enter i instaluj package automatycznie
                if(bitmap!=null)
                {
                    bitmap.Save($"{OutputFolderPath}\\{fileName}.png", ImageFormat.Png);//zapisujemy bitmape   $"{OutputFolderPath}\\{fileName}.png"   sciezka do pliku+ nazwa
                }
            }
        }
    }
}

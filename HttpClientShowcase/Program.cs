using HttpClientShowcase;
using HttpClientShowcase.Models;

Console.WriteLine("Hello, World!");

var serializationDemo = new SerializationDemo();
/*var jsonStrings= serializationDemo.RunSerialization();
serializationDemo.RunDeserialization(jsonStrings);*/

var client = new HttpClient();
var httpClientDemo = new HttpClientDemo(client);
/*var hello = await httpClientDemo.Hello("Mateusz");//await po to zeby poczekac na odpowiedz, że najpierw skonczy to zeby isc dalej, jak nie ma await to zwraca Task<string> jesli jest await to zwraca nam string
Console.WriteLine(hello)*/
await httpClientDemo.GetRandomJoke(); //musi byc await! zeby otrzymać wszystkie odpowiedzi w miejscu wewnetrznych awaitow, bo jakby tego nie było to by poleciało bez poczekania na wewnetrzne odpowidz
Console.WriteLine("\n");
await httpClientDemo.GetRandomCatInfo();

Console.WriteLine("\n");
await httpClientDemo.GetRandomDogImage();
await httpClientDemo.PredictGender("Ala");

var email = new Email
{
    To = "damian4166@tlen.pl",
    Subject = "Testowanie applikacji",
    Message = "Alx course test email message"

};
await httpClientDemo.SendEmail(email);
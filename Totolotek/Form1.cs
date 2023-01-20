namespace Totolotek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int[] insertArray = new int[6];
            if (insertBox1.Text!=""&& insertBox2.Text != "" && insertBox3.Text != "" && insertBox4.Text != "" && insertBox5.Text != "" && insertBox6.Text != "")
            {
                try
                {
                    insertArray[0] = Int32.Parse(insertBox1.Text);
                    insertArray[1] = Int32.Parse(insertBox2.Text);
                    insertArray[2] = Int32.Parse(insertBox3.Text);
                    insertArray[3] = Int32.Parse(insertBox4.Text);
                    insertArray[4] = Int32.Parse(insertBox5.Text);
                    insertArray[5] = Int32.Parse(insertBox6.Text);

                    var repeating = false;
                    var outOfRange = false;
                    for (var i = 0; i < 6; i++)
                    {
                        for (var j = i+1; j < 6; j++)
                        {
                            if (insertArray[i]== insertArray[j])
                            {
                                repeating = true;
                            }
                        }
                        if(insertArray[i]>49 || insertArray[i]<1)
                        {
                            outOfRange = true;
                        }
                    }
                    if(repeating)
                    {
                        LogBox.Text = "Wprowadzono powtarzaj¹ce siê liczby";
                    }
                    else if(outOfRange)
                    {
                        LogBox.Text = "Liczby musz¹ zawieraæ siê z przedzia³u od 1 do 49";
                    }
                    else
                    {
                        Random generator = new Random();
                        int[] randomArray = new int[6];

                        for(var i = 0; i < 6; i++)
                        {
                            do
                            {
                                repeating = false;
                                randomArray[i] = generator.Next(1, 49);
                                for(var j = 0; j < i; j++)
                                {
                                    if (randomArray[i] == randomArray[j]) 
                                    {
                                        repeating = true;
                                    }
                                }
                            } while(repeating == true); 
                        }
                        outputBox1.Text = randomArray[0].ToString();
                        outputBox2.Text = randomArray[1].ToString();
                        outputBox3.Text = randomArray[2].ToString();
                        outputBox4.Text = randomArray[3].ToString();
                        outputBox5.Text = randomArray[4].ToString();
                        outputBox6.Text = randomArray[5].ToString();

                        var winNumbers = 0;
                        string winNumbersToShow = "";
                        for (var i = 0; i < 6; i++)
                        {
                            for (var j = 0; j < 6; j++)
                            {
                                if (insertArray[i] == randomArray[j])
                                {
                                    winNumbers++;
                                    winNumbersToShow = winNumbersToShow + insertArray[i].ToString() + ", ";
                                }
                                LogBox.Text = "Trafiono: " + winNumbers.ToString() + ", s¹ to: " + winNumbersToShow;
                            }
                        }
                    }

                }
                catch
                {
                    LogBox.Text = "Wpisujemy tylko liczby";
                }
            }
            else
            {
                LogBox.Text = "Musisz wprowadziæ wszystkie liczby";
            }
        
        }
    }
}
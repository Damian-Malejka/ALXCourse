namespace HardcodedFormApp
{
    internal static class Program//tutaj program cs jest wywolywany na dotnecie
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());//domyœlnie siê uruchamia Run z formularzem
        }
    }
}
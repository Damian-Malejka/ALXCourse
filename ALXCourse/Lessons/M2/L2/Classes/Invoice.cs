﻿namespace ALXCourse.Lessons.M2.L2.Classes
{
    public class Invoice//faktura
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int NIP { get; set; }
        public double BruttoAmount { get; set; }
        public double NettoAmount { get; set; }

        public void PresentInvoice()
        {
            Console.Write($"[Invoice] ID: {Id}");
            Console.WriteLine($"\tCustomer name: {CustomerName}");
            Console.WriteLine($"\tNIP: {NIP}");
            Console.WriteLine($"\tBruttoAmount: {BruttoAmount}");
            Console.WriteLine($"\tNettoAmount: {NettoAmount}");
        }
    }
}

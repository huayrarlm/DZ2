using System;
using tumakov.perechislenie;
using tumakov.structuere;


namespace tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 1");
            Console.WriteLine($"Счет сберегательный: {bank.saveBank} Основной: {bank.mainBank}");


            Console.WriteLine("Упражнение 2");
            bankAnketa bankAnketa = new bankAnketa();
            bankAnketa.balance = 333001;
            bankAnketa.type = "saveCount";
            bankAnketa.number = "00065411";
            Console.WriteLine($"Информация о банковском счете: номер: {bankAnketa.number} тип: {bankAnketa.type} баланс: {bankAnketa.number}");



            Console.WriteLine("Упражнение 3");
            Worker worker = new Worker();
            worker.Name = "Рамзес";
            worker.MyUnic = University.kgu;
            Console.WriteLine($"Имя студента - {worker.Name}. Он обучается в {worker.MyUnic}");
            
        }
    }
}

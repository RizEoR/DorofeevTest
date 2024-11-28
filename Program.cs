using System;
using InspectorLib;

namespace InspectorTest
{
    class Program
    {
        static void Main()
        {
            FunctionInsp inspector = new FunctionInsp();

            // Тестирование метода GetInspector()
            Console.WriteLine($"Главный инспектор: {inspector.GetInspector()}");

            // Тестирование метода GetCarInspection()
            Console.WriteLine($"Название автоинспекции: {inspector.GetCarInspection()}");

            // Тестирование метода SetInspector()
            Console.WriteLine("Выбор нового главного инспектора:");
            inspector.SetInspector();
            Console.WriteLine($"Новый главный инспектор: {inspector.GetInspector()}");

            // Тестирование метода GenerateNumber()
            Console.WriteLine($"Сгенерированный номер: {inspector.GenerateNumber()}");

            // Тестирование метода GetWorker()
            Console.WriteLine("Список сотрудников:");
            foreach (var worker in inspector.GetWorker())
            // Перебираем массив сотрудников
            {
                Console.WriteLine(worker);
            }

            // Тестирование метода AddWorker()
            Console.Write("Введите ФИО нового сотрудника: ");
            string newWorker = Console.ReadLine(); // Считываем ФИО нового сотрудника
            inspector.AddWorker(newWorker); // Добавляем нового сотрудника
            Console.WriteLine("Список сотрудников после добавления нового:");
            foreach (var worker in inspector.GetWorker()) 
                // Перебираем обновленный массив

            {
                Console.WriteLine(worker);
            }
        }
    }
}
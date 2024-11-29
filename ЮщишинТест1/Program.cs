using System;
using InspectorLib;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionInsp inspector = new FunctionInsp();

            // Проверка главного инспектора
            Console.WriteLine(inspector.GetInspector());

            // Проверка названия автоинспекции
            Console.WriteLine(inspector.GetCarInspection());

            // Изменение главного инспектора
            inspector.SetInspector("Иванов И.И.");
            Console.WriteLine(inspector.GetInspector());

            // Генерация номера
            Console.WriteLine(inspector.GenerateNumber(1234, 'A', 75));

            // Получение списка сотрудников
            var workers = inspector.GetWorker();
            Console.WriteLine(string.Join(", ", workers));

            // Добавление нового сотрудника
            inspector.AddWorker("Петров П.П.");
            Console.WriteLine(string.Join(", ", inspector.GetWorker()));
        }
    }
}
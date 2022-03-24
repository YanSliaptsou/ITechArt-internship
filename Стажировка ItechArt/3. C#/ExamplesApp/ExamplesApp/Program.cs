using System;
using System.Collections.Generic;
using Generics;

namespace ExamplesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryCatchFinalyChecker.CheckTryCatchFinaly();
            int res = DelegatesWorker.ReturnResultFromDelegate();

            DelegatesWorker.Sum Sum1 = delegate (int[] arr)
            {
                int sum = 0;

                foreach(var e in arr)
                {
                    sum += e;
                }
                    
                return sum;
            };

            DelegatesWorker.Sum Sum2 = (array) =>
            {
                int sum = 0;

                foreach(var element in array)
                {
                    sum += element;
                }

                return sum;
            };

            int result = Sum2(1, 2, 3, 4, 5);

            ReceiptEnterpreter<DesertReceipt> Receipt = new ReceiptEnterpreter<DesertReceipt>();

            Receipt.ShowReceipt();
        }
    }

    public static class TryCatchFinalyChecker
    {
        public static void CheckTryCatchFinaly()
        {
            try
            {
                int x = 6;
                int y = 2;
                int z = x / y;
            }
            catch(Exception e)
            {
                Console.WriteLine("Catch block");
            }
            finally
            {
                Console.WriteLine("Finaly block");
                Console.ReadKey();
            }
        }
    }

    public static class DelegatesWorker
    {
        public delegate int Sum(params int[] par);

        private static int CountSum(int[] par)
        {
            int sum = 0;

            foreach (var e in par)
            {
                sum += e;
            }

            return sum;
        }

        public static int ReturnResultFromDelegate()
        {
            Sum sum = new Sum(CountSum);

            return sum(1, 2, 3, 4, 5);
        }
    }
}

namespace Generics
{
    class DishReceipt
    {
        public virtual List<EngredientItem> Engredients { get; set; }
    }

    class SaladReceipt : DishReceipt
    {
        public override List<EngredientItem> Engredients { get => new List<EngredientItem> { new EngredientItem { Engredient = new Engredient { Name = "Salad engredient" }, Quantity = 1 } }; set => new List<EngredientItem> { new EngredientItem {Engredient = new Engredient { Name = "Salad engredient"}, Quantity = 1 } }; }
    }

    class DesertReceipt : DishReceipt
    {
        public override List<EngredientItem> Engredients { get => new List<EngredientItem> { new EngredientItem { Engredient = new Engredient { Name = "Desert engredient" }, Quantity = 1 } }; set => new List<EngredientItem> { new EngredientItem { Engredient = new Engredient { Name = "Desert engredient" }, Quantity = 1 } }; }
    }

    class Engredient
    {
        public string Name { get; set; }
    }

    class EngredientItem
    {
        public Engredient Engredient { get; set; }
        public int Quantity { get; set; }
    }

    class ReceiptEnterpreter<T> where T : DishReceipt, new()
    {
        public T Receipt = new T();

        public void ShowReceipt()
        {
            foreach (var element in Receipt.Engredients)
            {
                Console.WriteLine("Engredient - " + element.Engredient.Name + " Count - " + element.Quantity);
            }
        }
    }
}

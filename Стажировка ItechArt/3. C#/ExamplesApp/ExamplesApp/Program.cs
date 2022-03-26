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

            ReceiptEnterpreter<SaladReceipt> Receipt = new ReceiptEnterpreter<SaladReceipt>();
            Receipt.ShowReceipt<DesertReceipt>();

            //Receipt.ShowReceipt();
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
    abstract class DishReceipt
    {
        public abstract List<EngredientItem> GetEngredients();
    }

    class SaladReceipt : DishReceipt
    {
        public override List<EngredientItem> GetEngredients()
        {
            return new List<EngredientItem>
            {
                new EngredientItem
                {
                    Name = "Салат",
                    Quantity = 5
                },
                new EngredientItem
                {
                    Name = "Масло",
                    Quantity = 1
                }
            };
        }
    }

    class DesertReceipt : DishReceipt
    {
        public override List<EngredientItem> GetEngredients()
        {
            return new List<EngredientItem>
            {
                new EngredientItem
                {
                    Name = "Шоколад",
                    Quantity = 2
                },
                new EngredientItem
                {
                    Name = "Мороженное",
                    Quantity = 1
                }
            };
        }
    }

    class EngredientItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }

    class ReceiptEnterpreter<T> where T : DishReceipt, new()
    {
        public T Receipt = new T();

        public void ShowReceipt()
        {
            foreach (var element in Receipt.GetEngredients())
            {
                Console.WriteLine("Engredient - " + element.Name + " Count - " + element.Quantity);
            }
        }

        public void ShowReceipt<K>() where K : DishReceipt, new()
        {
            K receipt = new K();

            foreach(var element in receipt.GetEngredients())
            {
                Console.WriteLine($"Engredient - {element.Name}  Count - {element.Quantity}");
            }
        }
    }
}

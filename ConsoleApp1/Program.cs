using System;

namespace ConsoleApp1
{
    // Step 0: 
    public delegate int CustomFunc(string arg01);
    public delegate bool CustomPredicate<in T>(T num);
    
    internal class Program
    {
        #region Find Odd 
        public static List<int> FindOdds(List<int> Numbers)
        {
            List<int> numbers = new List<int>();
            if (Numbers?.Count > 0)
            {
                foreach (int num in Numbers)
                {
                    if (num % 2 == 1)
                    {
                        numbers.Add(num);
                    }
                }
                return numbers;
            }
            return numbers;
        }

        #endregion
        //it is totally wrong to wite 2 functions doing he same fucntionality all the chage in a liitle bit imagine if u want to get prime nubers or numbers that is divisble by 7 
        //i wnat a fuction take Condition and list
        #region Find Even
        //public static List<int> FindEvens(List<int> Numbers)
        //{
        //    List<int> numbers = new List<int>();
        //    if (Numbers?.Count > 0)
        //    {
        //        foreach (int num in Numbers)
        //        {
        //            if (num % 2 == 0)
        //            {
        //                numbers.Add(num);
        //            }
        //        }
        //        return numbers;
        //    }
        //    return numbers;
        //} 
        #endregion

        #region Find Elements
        public static List<T> FindElements<T>(List<T> Numbers,  CustomPredicate <T>Predicate)
        {
            List<T> numbers = new List<T>();
            if (numbers?.Count > 0)
            {
                foreach (T num in numbers)
                {
                   
                    if(Predicate(num))

                        numbers.Add(num);
                    
                }
               
            }
            return numbers;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Delegation
            // Delegate is a C# feature [2.0]
            // Has 2 usages:
            // 1. Functional Paradigm
            // 2. Event-Driven Paradigm (Notifications)
            #endregion
            #region Delegations Example 1 

            //step1 Declare Delegate Reference
            CustomFunc reference; //(Can name it anything else);
            //step 2:intailize the delegate referce 
            reference = new CustomFunc(StringFunctions.GetCountOfUpperCases);
            reference += new CustomFunc(StringFunctions.GetCountOfLowerrCases);
            //step 3 
            int result = reference.Invoke("Mira");
            Console.WriteLine(result);
            #endregion

            #region Delegation Example 2
            int[] Numbers = { 1, 6, 5, 8, 90, 0 };
            //  SortingAlogrithms.BubbleSort(Numbers,new Ascomparer());
            CustomFunc<int,int,bool > func = SortingTypes.Grt;
            func = default;
            SortingAlogrithms<int>.BubbleSort(Numbers, SortingTypes.Grt );
            string[] Names = ["Mira", "Dina", "Farah","Mona"];
            SortingAlogrithms<string>.BubbleSort(Names,SortingTypes.Grt );
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
            
            foreach (int number in Numbers)
            {
                Console.WriteLine(number);
            }
            #endregion

            #region Delegation Example 3'
            List<int> Numberss = Enumerable.Range(0, 100).ToList();
            CustomPredicate<int> predicate = ConditionsFunctios.IsODD;
            List<int>OddNumbers= FindElements(Numberss,predicate);
            foreach(int number in OddNumbers)
            {
                Console.WriteLine(number);
            }
            predicate = ConditionsFunctios.IsEven;
            List<int> EvenNumbers = FindElements(Numberss,predicate);
            foreach (int number in EvenNumbers)
            {
                Console.WriteLine(number);
            }
            #endregion

            #region Delegation Example 4
            List<String>names= new List<string>(10) { "Mira","Dina","Ahmed","Zeina","Omar","Maivyyyyyyyyyyyyyyy"};
            CustomPredicate<string> predicate2 = ConditionsFunctios.Islength4;
            List<String> nameslength_4 = FindElements<string>(names, predicate2);
            #endregion
            //We dont need to create own delegates 
            //your own delegate in case fucntions takes 17 parameters
            #region Ex1
            Predicate<int> p1 = SomeFunctions.Test;
            //Predicate buit in delegate (take 1 paarmeter) return boolean
            //Func take till 17 parameters must return 
            Func<int, string> func1 = SomeFunctions.Cast;
            func1.Invoke(123);

            //Actions
            Action A1 = SomeFunctions.Print;
            A1.Invoke();
            #endregion

            #region New Feature 
            //Implict type to local variable
            var name = "Mira";
            //  name = 0;
            #endregion

            #region list take method funtions as paramaters
            List<int> NumbersF = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            NumbersF.FindLast(n => n % 2 == 0);
            foreach(int num in NumbersF)
            {
                Console.WriteLine(num);
            }
            #endregion
           
        }
    }
    class SomeFunctions
    {
        public static bool Test (int Number)
        {
            return Number > 0;
        }
        public  static string Cast(int Number)
        {
            return Number.ToString();
        }
        public static void Print()
        {
            Console.WriteLine("Hello");
        }
    }

    class StringFunctions
    {
        public static int GetCountOfUpperCases(string Name)
        {
            int count = 0;
            Console.WriteLine("GetCountOfUpperCases Function Called");

            if (Name is not null)
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (char.IsUpper(Name[i]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public static int GetCountOfLowerrCases(string Name)
        {
            int count = 0;
            Console.WriteLine("GetCountOflowerCases Function Called");

            if (Name is not null)
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (char.IsUpper(Name[i]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
    class ConditionsFunctios
    {
        public static bool IsODD(int Number) => Number % 2 == 1;
        public static bool IsEven (int Number )=> Number % 2 == 0;

        public static bool Islength4(String name) => name.Length > 4;
    }
}

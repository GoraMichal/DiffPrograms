﻿using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace ConsoleApp2
{
    class Program
    {

        #region override virtual method
        //public interface IUndoable
        //{
        //    void Undo();
        //}
        //public class Textbox : IUndoable
        //{
        //    public virtual void Undo() => Console.WriteLine("TextBox.Undo");
        //}
        //public class RichTextBox : Textbox
        //{
        //    public override void Undo() => Console.WriteLine("RichTextBox.Undo");
        //}
        //public class ExtraTextBox : Textbox
        //{
        //    public new void Undo() => Console.WriteLine("ExtraTextBox.Undo");
        //}


        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        RichTextBox richText = new RichTextBox();
        //        richText.Undo();  //RichTextBox.Undo
        //        ((Textbox)richText).Undo(); //to samo wypisze co wyżej
        //        ((IUndoable)richText).Undo(); //tutaj też

        //        ExtraTextBox extra = new ExtraTextBox();
        //        extra.Undo();  //ExtraTextBox.Undo
        //        ((Textbox)extra).Undo(); //TextBox.Undo
        //        ((IUndoable)extra).Undo();  //TextBox.Undo

        //        Console.ReadKey();

        //    }
        //}
        #endregion

        #region override virtual method 2
        //class A
        //{
        //    public void Test() { Console.WriteLine("A::Test()"); }
        //}

        //class B : A
        //{
        //    public new virtual void Test() { Console.WriteLine("B::Test()"); }
        //}

        //class C : B
        //{
        //    public override void Test() { Console.WriteLine("C::Test()"); }
        //}

        //class D : C
        //{
        //    public new void Test() { Console.WriteLine("D::Test()"); }
        //}

        //class Program
        //{
        //    static void Main(string[] args)
        //    {

        //        A a = new A();
        //        B b = new B();
        //        C c = new C();
        //        D d = new D();

        //        //a.Test(); // output --> "A::Test()"
        //        //b.Test(); // output --> "B::Test()"
        //        //c.Test(); // output --> "C::Test()"
        //        //d.Test();

        //        a = new B();
        //        a.Test(); // output --> "A::Test()"

        //        b = new C();
        //        b.Test(); // output --> "C::Test()"

        //        d = new D();
        //        d.Test();

        //        Console.ReadKey();
        //    }
        //}
        #endregion

        #region licznik samoglosek, spolglosek
        //public class Counter
        //{
        //    public int Vowels { get; set; }
        //    public int Consonants { get; set; }
        //    public Counter(int vowels, int consonants)
        //    {
        //        Vowels = vowels;
        //        Consonants = consonants;
        //    }
        //}

        //class Program
        //{
        //    public static Counter GetCount(object word)
        //    {
        //        string w = word.ToString();
        //        if (word is string)
        //        {
        //            return new Counter(w.Count ("aeiouAEIOU".Contains),
        //                               w.Count("bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ".Contains));
        //        }
        //        else
        //        {
        //            //Jezeli pusty to 0
        //            return new Counter(0, 0);
        //        }
        //    }

        //    static void Main(string[] args)
        //    {
        //        Counter re = GetCount("Kurcze Pieczone");

        //        Console.WriteLine("Samogloski {0}", re.Vowels);
        //        Console.WriteLine("Spolgloski {0}", re.Consonants);
        //        Console.ReadKey();
        //    }

        //}

        #endregion

        #region wskazniki
        //class Program
        //{
        //    public unsafe void Swap(int* a, int* b)
        //    {
        //        int temp = *a;
        //        *a = *b;
        //        *b = temp;
        //    }
        //    unsafe static void Main(string[] args)
        //    {
        //        Program pr = new Program();
        //        int a = 10;
        //        int b = 20;
        //        int* ap = &a;
        //        int* bp = &b;
        //        Console.WriteLine("Przed zmianą: a = {0}, b = {1}", a, b);
        //        pr.Swap(ap, bp);
        //        Console.WriteLine("Po zmianie: a = {0}, b = {1}", a, b);
        //        Console.ReadKey();
        //    }
        //}
        #endregion

        #region Take, Skip (zwraca indeksy rownych sum z brzegow tablicy)
        //static int Main(string[] args)
        //{
        //    int[] arr = { 1, 2, 3, 4, 3, 2, 1 };

        //    for (var i = 1; i < arr.Length;  i++)
        //    {
        //        if (arr.Take(i).Sum() == arr.Skip(i + 1).Sum())
        //        {
        //            return i;
        //        }
        //    }

        //    return -1;
        //}
        #endregion

        #region asci to char
        static void Main(string[] args)
        {
            //String unicodeString = "111 108 108 101 72 32 101 114 101 104 116 32 41 58";

            byte[] bytes = { 111, 108, 108, 101, 72, 32, 101, 114, 101, 104, 116, 32, 41, 58 };
            Array.Reverse(bytes);
            string str = Encoding.ASCII.GetString(bytes);

            
            Console.WriteLine(str);

            Console.ReadKey();
        }
        #endregion
            
        #region sprawdza czy liczba sie pierwiastkuje		
        public class Program
        {
            public static bool Square(int n)
            {
                return Math.Sqrt(n) % 1 == 0;
            }

            public static void Main()
            {	
                int n = 100;
                Console.WriteLine(Square(n));
            }
        }
        #endregion
            
        #region zwraca true jezeli jest ta sama ilos x i o	
        using System;
        using System.Linq;

        public class Program
        {
            public static bool countXandO(string input)
            {
                input = input.ToLower();
                return input.Count(x => x == 'x') == input.Count(o => o == 'o') ? true : false;
            }

            public static void Main()
            {
                 string n = "xxoo";
                 Console.WriteLine(countXandO(n));
            }
        }
        #endregion
            
        #region sortowanie stringow po dlugosci
        public class Program
        {
             public static void Main() 
             { 
                string s = "Wydarzenie artystyczne oraz zjawisko społeczne obejmujące swoim zasięgiem."; 

                string[] sWord = s.Split(' ', '.');
                Array.Sort(sWord, (w1, w2) => w1.Length.CompareTo(w2.Length));

                foreach(string text in sWord) 
                { 
                    Console.Write(text + " "); 
                } 
            } 
        }
        #endregion
            
            
        #region szukanie unikalnej liczby w tablicy
        public class Program
        {
            public int GetUniqueNumber(IEnumerable<int> numbers)
            {
                List<int> numList = numbers.ToList();
                numList.Sort();
                if (numList[0] != numList[1])
                {
                    return numList[0];
                }
                return numList[numList.Count - 1];
            }

            public void Main(string[] args)
            {
                int[] numbers = {1, 1, 1, 1, 2, 1};
                Console.WriteLine(GetUniqueNumber(numbers));
            }
        }
            
        #endregion  
            
    }
}


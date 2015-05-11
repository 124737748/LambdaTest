using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LambdaTest
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var books = new List<Book>
        //    {
        //        new Book{Name="C# learning guide",Year=2005},
        //        new Book{Name="C# step by step",Year=2005},
        //        new Book{Name="Java learning guide",Year=2004},
        //        new Book{Name="Java step by step",Year=2004},
        //        new Book{Name="Python learning guide",Year=2003},
        //        new Book{Name="C# in depth",Year=2012},
        //        new Book{Name="Java in depth",Year=2014},
        //        new Book{Name="Python in depth",Year=2013},
        //    };
        //    Action<Book> printer = book => Console.WriteLine("name={0},year={1}", book.Name, book.Year);
        //    books.ForEach(printer);
        //    Console.ReadKey(false);
        //    books.FindAll(book => book.Year > 2010).ForEach(printer);
        //    Console.ReadKey(false);
        //    books.FindAll(book => book.Name.Contains("c#")).ForEach(printer);
        //    Console.ReadKey(false);
        //    books.Sort((book1, book2) => book1.Name.CompareTo(book2.Name));
        //    books.ForEach(printer);
        //    Console.ReadKey(false);
        //}
        static void Main(string[] args)
        {
            //将Lambda表达式转换为类型Expression<T>的表达式树
            //expression不是可执行代码
            Expression<Func<int, int, int>> expression = (a, b) => a + b;

            Console.WriteLine(expression);
            //获取Lambda表达式的主体
            BinaryExpression body = (BinaryExpression)expression.Body;
            Console.WriteLine(expression.Body);
            //获取Lambda表达式的参数
            Console.WriteLine(" param1: {0}, param2: {1}", expression.Parameters[0], expression.Parameters[1]);
            ParameterExpression left = (ParameterExpression)body.Left;
            ParameterExpression right = (ParameterExpression)body.Right;
            Console.WriteLine(" left body of expression: {0}{4} NodeType: {1}{4} right body of expression: {2}{4} Type: {3}{4}", left.Name, body.NodeType, right.Name, body.Type, Environment.NewLine);

            //将表达式树转换成委托并执行
            Func<int, int, int> addDelegate = expression.Compile();
            Console.WriteLine(addDelegate(10, 16));
            Console.Read();
        }
    }

    public class Book
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }
}

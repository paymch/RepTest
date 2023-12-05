using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{

    public class PaginationHelper<T> 
    { 
        List<T> Data;
        int ElementInPage;

        public PaginationHelper(List<T> Data, int Page) 
        { 
            this.Data = Data;
            this.ElementInPage = Page;
        }

        public int DataCount
        {
            get { return Data.Count; }
        }

        public double PageCount
        {
            get { return Data.Count / ElementInPage; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ListData = new List<int> {1, 3,2 ,4,6,435,34,5,2,3};
            int ElementInPage = 4;
            PaginationHelper<int> helper = new  PaginationHelper<int>(ListData, ElementInPage);

            Console.WriteLine($"Количество элементов: {helper.DataCount}\nКоличество доступных страниц: {Math.Ceiling(helper.PageCount)}");
        }
    }
}

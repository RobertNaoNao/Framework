using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("今天第一次学习架构知识");
            int iparameter = 34534;
            DateTime dparameter = DateTime.Now;
            People people = new People
            {
                Id = 11,
                Name = "闹闹"
            };
            Common.ShowDateTime(dparameter);
            Common.ShowInt(iparameter);
            Common.ShowPeople(people);


            Console.WriteLine("*************************************************");
            Common.ShowObject(people);
            Common.ShowObject(iparameter);

            Console.WriteLine("********这里是Generic*********************");

            GenericClass.ShowObject<int>(iparameter);
            Console.ReadKey();
                    
        }
    }
}

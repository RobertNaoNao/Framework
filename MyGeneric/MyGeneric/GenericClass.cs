using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{
    class GenericClass
    {
        /// <summary>
        /// 这是泛型接口
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Oparameter"></param>
        public static void ShowObject<T>(T Oparameter)
        {
            Console.WriteLine("这里是Common，ShowObject，parameter={0}，parameter={1}", Oparameter, Oparameter.GetType());

        }
    }
}

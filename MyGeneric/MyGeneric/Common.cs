using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{
   public  class Common
    {
        public static void ShowInt(int IParameter) {

            Console.WriteLine("这里是Common，ShowInt，parameter={0}，parameter={1}",IParameter,IParameter.GetType());
        }
        public static void ShowDateTime(DateTime Dparameter) {
            Console.WriteLine("这里是Common，ShowInt，parameter={0}，parameter={1}", Dparameter, Dparameter.GetType());

        }
        public static void ShowPeople(People PParameter) {
            Console.WriteLine("这里是Common，ShowInt，parameter={0}，parameter={1}", PParameter, PParameter.GetType());

        }
        /// <summary>
        /// 性能会造成损失
        /// </summary>
        /// <param name="Oparameter"></param>
        public static void ShowObject(Object Oparameter) {
            Console.WriteLine("这里是Common，ShowObject，parameter={0}，parameter={1}", Oparameter, Oparameter.GetType());

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{
    class GenericContstraint
    {
        public static T Get<T>(T　t) where T:class ,new (){//引用类型,  还可以new一个对象
            return default(T);
        }
        public static T Query<T>(T t) where T : struct //是一个值类型
        {
            return default(T);
        }
    }
}

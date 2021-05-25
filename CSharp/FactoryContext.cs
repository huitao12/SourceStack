using CSharp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class FactoryContext: Entity
    {
        //设计一个类FactoryContext，保证整个程序运行过程中，无论如何，外部只能获得它的唯一的一个实例化对象。（提示：设计模式之单例）
        private static FactoryContext instance = null;//静态私有成员变量

        private FactoryContext()//私有构造方法
        {

        }

        //静态公有工厂的方法，返回唯一实例
        public static FactoryContext instanc
        {
            get { 
            if (instance==null)
            {
                return new FactoryContext();
            }
            return instance;
            }
        }

    }
}

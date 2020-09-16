using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSiteGate.Tests.testClass
{
    abstract class MyAbstractClass : MyInterface
    {
        public void GetSalary()
        {
            throw new NotImplementedException();//看来要是冒号了一个接口，那么就必须实现全部抽象方法
        }

        public abstract void DoMoreThing();
    }
}

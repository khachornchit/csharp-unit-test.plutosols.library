using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unittest.plutosols.libraries.MultipleInheritanceTests
{
    [TestClass]
    public class MultipleInheritanceTests
    {
        [TestMethod]
        public void VitualOverrideFunctionTest()
        {
            Main main = new Main();
            main.WritableFunction();
            main.WritableFunctionInAbstract();
        }
    }

    public interface IOne : ITwo, IThree, IFour, IFive { }
    public interface ITwo : IThree, IFour, IFive { }
    public interface IThree : IFour, IFive { }
    public interface IFour : IFive { }
    public interface IFive
    {
        void FirstFunction();
        string PropertyInIFive { get; set; }
    }
    public abstract class AbstractClass
    {
        public int MyProperty { get; set; }
        protected int number;
        int Sum() { return 5; }
        void FirstFunction() { }
        public virtual void WritableFunctionInAbstract()
        {
            Console.WriteLine("I'm a writable function in Abstract class, using virtual keyword");
        }
    }

    public class SimpleClass : AbstractClass
    {
        void FirstFunction() { }
        public virtual void WritableFunction()
        {
            Console.WriteLine("I came from a virtual function in Simple Class");
        }
    }

    public class Two : Three { }
    public class Three { }
    public class Four { }
    public class Five { }

    public class Main : SimpleClass, IOne, ITwo, IThree, IFour, IFive
    {
        public string PropertyInIFive { get; set; }

        public Main()
        {
            PropertyInIFive = "I'm a property in IFive";
        }
        
        public void FirstFunction()
        {
            throw new NotImplementedException();
        }

        public override void WritableFunction()
        {
            base.WritableFunction();
            Console.WriteLine("I came from the overide function in Main class.");
        }

        public override void WritableFunctionInAbstract()
        {
            base.WritableFunctionInAbstract();
            Console.WriteLine(PropertyInIFive);
        }
    }
}

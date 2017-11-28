using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlutoLibrary.DuckTyping.ActionDefine;
using PlutoLibrary.DuckTyping.Interfaces;
using PlutoLibrary.DuckTyping.Models;
using System.Reflection;

namespace unittest.plutosols.libraries.DuckTyping
{
    [TestClass]
    public class DuckTypingTests
    {
        [TestMethod]
        public void StaticTest()
        {
            ILegAnimals duck = new Duck();
            duck.Walk();
        }
        
        [TestMethod]
        public void DuckTypingTest()
        {
            new Action(Actions.Walk, new Dog());
            new Action(Actions.Run, new Duck());
            new Action(Actions.Fly, new Cup());
            new Action(Actions.Fly, new Bird());
            new Action(Actions.Fly, new Man());
            new Action(Actions.Walk, new Man());
            new Action(Actions.Run, new Man());
            new Action(Actions.Talk, new Man());
            new Action(Actions.Talk, new Bird());
            new Action(Actions.Talk, new Dog());
            new Action(Actions.Run, new Ant());
        }

        [TestMethod]
        public void DuckTypingAllTest()
        {
            Actions action = new Actions();
            foreach (var item in action.Items)
            {
                new Action(item, new Dog());
                new Action(item, new Duck());
                new Action(item, new Cup());
                new Action(item, new Bird());
                new Action(item, new Man());
                new Action(item, new Ant());
            }
        }
    }
}

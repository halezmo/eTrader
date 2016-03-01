using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTrader.Windows.Tests.UnitTests
{
    [TestClass]
    public class ActionCommandTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorThrowsExceptionIfActionParameterIsNull()
        {
            var ac = new ActionCommand(null);
        }

        [TestMethod]
        public void ExecuteInvokeAction()
        {
            var invoked = false;

            Action<object> action = obj =>
            {
                Assert.IsNotNull(obj);
                invoked = true;
            };

            var command = new ActionCommand(action);
            command.Execute(new object());

            Assert.IsTrue(invoked);

        }

        [TestMethod]
        public void CanExecuteIsTrueByDefauls()
        {
            var command = new ActionCommand(obj => { });

            Assert.IsTrue(command.CanExecute(null));

        }

        [TestMethod]
        public void CanExecuteOverlaodExcecutesTruePredicate()
        {
            var command = new ActionCommand(obj => { }, obj => (int)obj == 1);

            Assert.IsTrue(command.CanExecute(1));

        }

        [TestMethod]
        public void CanExecuteOverlaodExcecutesFalsePredicate()
        {
            var command = new ActionCommand(obj => { }, obj => (int)obj == 1);

            Assert.IsFalse(command.CanExecute(0));

        }
    }
}

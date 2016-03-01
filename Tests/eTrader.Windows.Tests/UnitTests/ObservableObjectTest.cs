using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eTrader.Windows.Tests.UnitTests
{
    /// <summary>
    /// Summary description for ObservableObjectTest
    /// </summary>
    [TestClass]
    public class ObservableObjectTest
    {
        [TestMethod]
        public void PropertyChangedEventHandlerIsRaised()
        {
            var obj = new StubObservableObject();

            bool raised = false;
            obj.PropertyChanged += (sender, e) =>
            {
                Assert.IsTrue(e.PropertyName == "ChangedProperty");
                raised = true;
            };

            obj.ChangedProperty = "NewValue";

            if (!raised) Assert.Fail("Property change nevere occured");
        }

        class StubObservableObject : ObservableObject
        {
            private string changedProperty;
            public string ChangedProperty
            {
                get
                {
                    return changedProperty;
                }
                set
                {
                    changedProperty = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}

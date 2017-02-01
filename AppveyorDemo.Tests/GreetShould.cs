using NUnit.Framework;
using Shouldly;

namespace AppveyorDemo.Tests
{
    [TestFixture]
    public class GreetShould
    {
        [Test]
        public void SayHello()
        {
            var greet = new Greet();
            var result = greet.SayHallo();
            result.ShouldBe("Hello");
        }
    }
}

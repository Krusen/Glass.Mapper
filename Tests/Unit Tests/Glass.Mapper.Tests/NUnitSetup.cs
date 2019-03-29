using System;
using NUnit.Framework;

[SetUpFixture]
public class NUnitSetup
{
    [OneTimeSetUp]
    public void RunBeforeAnyTests()
    {
        Environment.CurrentDirectory = TestContext.CurrentContext.TestDirectory;
    }
}
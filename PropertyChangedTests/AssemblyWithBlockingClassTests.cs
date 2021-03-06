﻿using NUnit.Framework;

[TestFixture]
public class AssemblyWithBlockingClassTests
{
    [Test]
    public void TestClassIsNotBlocked()
    {
        var weaverHelper = new WeaverHelper(@"AssemblyWithBlockingClass\AssemblyWithBlockingClass.csproj");
        var instance = weaverHelper.Assembly.GetInstance("B");
        EventTester.TestProperty(instance, false);
    }
}
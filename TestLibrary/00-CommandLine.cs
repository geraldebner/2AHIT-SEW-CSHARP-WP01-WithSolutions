using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.Reflection;


namespace TestLibrary;

[TestClass]
public class CommandLineTest
{

    [TestMethod]
    [DataRow(5.0, 6.0, '+', 11.0)]
    [DataRow(5.0, 6.0, '-', -1.0)]
    [DataRow(3.0, 3.0, '*', 9.0)]
    [DataRow(9.0, 3.0, '/', 3.0)]
    public void TestCommandLineCalc(double a, double b, char op, double result)
    {
        MethodInfo? methodInfo = typeof(WP01.CommandLine).GetMethod("Calculator");

        if (methodInfo == null || !methodInfo.IsStatic)
            throw new NotImplementedException("Function Calculator not implemented");
        
        var output = new StringWriter();        
        Console.SetOut(output);
        
        
        object[] parameters = new object[] {a,b,op };
        methodInfo.Invoke(null, parameters);
        string consoleOutput = output.ToString();
        if( String.IsNullOrEmpty(consoleOutput))
            Assert.Fail("no console output");
        StringAssert.Equals("result: " + result,consoleOutput);
    }

    [TestMethod]
    [DataRow("Hello World!")]
    public void TestCommandLineInputStringPrint(string inputStr)
    {
        MethodInfo? methodInfo = typeof(WP01.CommandLine).GetMethod("InputStringPrint");

        if (methodInfo == null || !methodInfo.IsStatic)
            throw new NotImplementedException("Function InputStringPrint not implemented");
        
        var input = new StringReader(inputStr);        
        Console.SetIn(input);
        var output = new StringWriter();        
        Console.SetOut(output);
        
        
        object[] parameters = new object[] { };
        methodInfo.Invoke(null, parameters);
        
        string consoleOutput = output.ToString();
        if( String.IsNullOrEmpty(consoleOutput))
            Assert.Fail("no console output");

        StringAssert.Equals(inputStr,consoleOutput);
    }

    [TestMethod]
    [DataRow(5.2)]
    public void TestCommandLineInputDoublePrint(double value)
    {
        MethodInfo? methodInfo = typeof(WP01.CommandLine).GetMethod("InputDoublePrint");

        if (methodInfo == null || !methodInfo.IsStatic)
            throw new NotImplementedException("Function InputDoublePrint not implemented");
        
        var input = new StringReader(value.ToString());        
        Console.SetIn(input);
        var output = new StringWriter();        
        Console.SetOut(output);
        
        
        object[] parameters = new object[] { };
        methodInfo.Invoke(null, parameters);

        Assert.AreEqual(value,System.Convert.ToDouble(output.ToString()));
    }
}
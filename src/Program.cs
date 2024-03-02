using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
    static void Main()
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");

        // Simulate insecure deserialization
        string serializedData = "AAEAAAD/////AQAAAAAAAAAMAgAAAFN0cmluZ1NlcmlhbGl6YXRpb25Qcm9jZXNzVGltZQECBAEDBwAAAENvbnNvbGUuV2ViLlN0cmluZ0NvbGxlY3Rpb25JbnN0YWxsUHJvY2VzcwUAAAAOU3lzdGVtLlJlYWQuU3lzdGVtLkNvbGxlY3Rpb25JbnN0YW5jZQIAAAASAQAMSWRlbnRpZmllcjogV2luZG93cyBJbnN0YW5jZSBvZiBTdHJpbmcgc2VyaWFsaXphdGlvbnMgKG9yIG5vIG90aGVyIHNoYXJlZCBkZXNlcmlhbGl6YXRpb25zKQEAZAICAAAAPklzIG5vdCBhIG5ldyB2YWxpZGF0aW9uIG9mIHN0cmluZyBhcHBsaWNhdGlvbnMgZm9yIG1vZGlmaWNhdGlvbiBhZGRyZXNzIHNjaGVtZXMgKHN0cmluZyBpbiBkZWxldGluZyB0aGF0IGFyZ3VtZW50cyBpbiB0aGUgcGF0aCkpAQBAAQAAAAVNYWluLklzRHJvcGRvd24uU3lzdGVtLlJlYWQuQW5zd2VyBwAAAAVNYWluLklzRHJvcGRvd24uU3lzdGVtLlJlYWQuU2VydmljZXMFAAAACm1haW4uY29udmVyc2F0aW9uLk1haW4BAAAABw==";
        byte[] bytes = Convert.FromBase64String(serializedData);
        MemoryStream memStream = new MemoryStream(bytes);
        BinaryFormatter formatter = new BinaryFormatter();
        object obj = formatter.Deserialize(memStream);
    }
}

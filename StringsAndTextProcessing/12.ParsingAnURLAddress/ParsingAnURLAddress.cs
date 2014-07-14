/*Write a program that parses an URL address given in the format:
 [protocol]://[server]/[resource]
 and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php 
 the following information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php"*/
using System;
using System.Text;

class ParsingAnURLAddress
{
    static void Main()
    {
        //If you want to enter the URL manually just uncomment the two rows bellow and comment "string address = "http://www.devbg.org/forum/index.php";"
        //Console.Write("Enter the address: ");
        //string address = Console.ReadLine();
        string address = "http://www.devbg.org/forum/index.php";
        StringBuilder protocol = new StringBuilder();
        StringBuilder server = new StringBuilder();
        StringBuilder resource = new StringBuilder();


        GettingTheElementsFromTheURL(address, protocol, server, resource);

        Console.WriteLine("[protocol] -> \"{0}\"", protocol.ToString());
        Console.WriteLine("[server] -> \"{0}\"", server.ToString());
        Console.WriteLine("[resource] -> \"{0}\"", resource.ToString());
    }

    private static void GettingTheElementsFromTheURL(string address, StringBuilder protocol, StringBuilder server, StringBuilder resource)
    {
        int counter = 0;
        while (address[counter] != ':')
        {
            protocol.Append(address[counter]);
            counter++;
        }
        counter += 3;

        while (address[counter] != '/')
        {
            server.Append(address[counter]);
            counter++;
        }

        while (counter != address.Length)
        {
            resource.Append(address[counter]);
            counter++;
        }
    }
}

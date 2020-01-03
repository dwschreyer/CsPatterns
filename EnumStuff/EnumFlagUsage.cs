using System;
using System.Collections.Generic;
using System.Text;

namespace EnumStuff
{
    public static class EnumFlagUsage
    {
        public static void Use()
        {
            var customerChannels = new Dictionary<string, Channel>()
            {
                { "Customer 1", Channel.Email | Channel.Text },
                { "Customer 2", Channel.Email | Channel.Voice }
            };

            foreach (var customerChannel in customerChannels)
            {
                var hasText = (customerChannel.Value & Channel.Text) == Channel.Text;
                Console.WriteLine($"{customerChannel.Key} : Has Text: {hasText}");
            }
        }
    }
}

public abstract class A
{
    public A(string name)
    {

    }
}

public class B : A
{
    public B() : base("From B")
    {

    }
}

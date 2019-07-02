using CreationalPatterns.Prototype;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns
{
    public static class PrototypeUsage
    {
        public static List<Dog> CreateDogsFromDog()
        {
            var result = new List<Dog>();

            var germanShepherd = new GermanShepherd();

            var dog1 = germanShepherd.Clone();
            dog1.Name = "Lady1";
            result.Add(dog1);

            var dog2 = germanShepherd.Clone();
            dog2.Name = "Lady2";
            result.Add(dog2);

            return result;
        }
    }
}

﻿using System;

namespace Collector
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var spy = new Spy();

            string result = spy.CollectGettersAndSetters("Stealer.Hacker");

            Console.WriteLine(result);
        }
    }


}

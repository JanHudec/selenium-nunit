﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_nunit
{
    public class CommonTest
    {
        /// <summary>
        /// Method <c>SetUp</c> logs a test that is just starting.
        /// </summary>        
        public void SetUp()
        {
            Console.WriteLine("SetUp is running");            
        }

        /// <summary>
        /// Method <c>TearDown</c> logs a test result.
        /// </summary>        
        public void TearDown()
        {
            Console.WriteLine("TearDown method called");
        }
    }
}
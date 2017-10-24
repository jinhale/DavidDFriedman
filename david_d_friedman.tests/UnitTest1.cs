using System;
using Xunit;
using david_d_friedman.Controllers;

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using david_d_friedman.Models;

namespace david_d_friedman.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var home = new HomeController();
            var actionResult = home.Index();

	    Type b = typeof(IActionResult);
            
            Assert.True(actionResult != null);
        }
    }
}

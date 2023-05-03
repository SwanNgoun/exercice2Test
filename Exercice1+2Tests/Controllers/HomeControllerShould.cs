using Exercice2.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1_2Tests.Controllers
{
    public class HomeControllerShould
    {

        [Fact]
        public void Home()
        {
            var homeCC = new HomeController();
            var result = homeCC.Index3();
            var TextResult = Assert.IsType<ViewResult>(result);
        }
        /*
        2.1 GOOD
        2.2 GOOD
        2.3 GOOD
        2.4 N//A
        2.5 N//A
        2.6 N//A
        */
    }
}

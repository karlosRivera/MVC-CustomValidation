using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using System.Web.Mvc;
using AuthTest.Models;
using AuthTest.Controllers;

namespace UnitTestProject1
{
	[TestClass]
    public class DatValControllerTest
    {
        // GET: DatVal
         [TestMethod]
        public void GetIndex_test()
        {
            var controller = new DatValController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("", result.ViewName);
        }

         [TestMethod]
         public void PostIndex_test()
         {
             DateValTest d = new DateValTest();
             var controller = new DatValController();
             var result = controller.Index(d) as ViewResult;
             Assert.AreEqual("", result.ViewName);
         }
    }
}

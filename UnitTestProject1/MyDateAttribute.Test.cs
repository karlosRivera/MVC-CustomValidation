using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using System.Web.Mvc;
using AuthTest.Models;
using System.ComponentModel.DataAnnotations;

namespace UnitTestProject1
{
    [TestClass]
    public class MyDateAttribute_Test
    {

        //[TestMethod]
        //public void IsValid_Test()
        //{
        //    var model = new MyDateAttribute { _MinDate = DateTime.Today.AddDays(-10) }; //set value
        //    ExecuteValidation(model, "Back date entry not allowed");
        //}

        //private void ExecuteValidation(object model, string exceptionMessage)
        //{
        //    try
        //    {
        //        var contex = new ValidationContext(model);
        //        Validator.ValidateObject(model, contex);
        //    }
        //    catch (ValidationException exc)
        //    {
        //        Assert.AreEqual(exceptionMessage, exc.Message);
        //        return;
        //    }
        //}

        [TestMethod]
        //[ExpectedException(typeof(ValidationException))]
        public void Test_EndDateIsInvalidIFBackDate()
        {
            var validationResults = new List<ValidationResult>();
            DateValTest model = new DateValTest() { StartDate = DateTime.Today, EndDate = DateTime.Today.AddDays(10) };
            ValidationContext context = new ValidationContext(model);
            Validator.TryValidateObject(model, context, validationResults, true);
            //Assert.IsFalse(validationResults.Count > 0);
            Assert.AreEqual(false, (validationResults.Count > 0), "Test Equalateral");
            //Assert.IsTrue(validationResults.Any(vr => vr.ErrorMessage == "Back date entry not allowed"));

            //MyDateAttribute attribute = new MyDateAttribute();
            //attribute.Validate(model.EndDate, context);

        }
    }

    [TestClass]
    public class DateGreaterThanAttribute_Test
    {
        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void Test_EndDateIsInvalidIfLessThanStartDate()
        {
            // Initialize a model with invalid values
            DateValTest model = new DateValTest() { StartDate = DateTime.Today, EndDate = DateTime.Today.AddDays(-1) };
            ValidationContext context = new ValidationContext(model);
            DateGreaterThanAttribute attribute = new DateGreaterThanAttribute("StartDate", "End date must be greater than start date");
            attribute.Validate(model.EndDate, context);
        }
    }

}

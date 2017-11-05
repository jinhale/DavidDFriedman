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
        Type actionResult = typeof(IActionResult);

        [Fact]
        public void TestHomeIndex()
        {
            var home = new HomeController();
            var index = home.Index();

            Assert.True(actionResult.IsAssignableFrom(index.GetType()));
        }

        [Fact]
        public void TestHomeAbout()
        {
            var home = new HomeController();
            var about = home.About();

            Assert.True(actionResult.IsAssignableFrom(about.GetType()));
        }
        
        [Fact]
        public void TestHomeContact()
        {
            var home = new HomeController();
            var contact = home.Contact();

            Assert.True(actionResult.IsAssignableFrom(contact.GetType()));
        }
        
       //  [Fact]
       //  public void TestHomeError()
       //  {
       //      var home = new HomeController();
       //      var error = home.Error();
       // 
       //      Assert.True(actionResult.IsAssignableFrom(error.GetType()));
       //  }
        
        [Fact]
        public void TestAcademicEducation()
        {
            var academic = new AcademicController();
            var education = academic.Education();

            Assert.True(actionResult.IsAssignableFrom(education.GetType()));
        }

        [Fact]
        public void TestAcademicReviewsWhitePapers()
        {
            var academic = new AcademicController();
            var reviewedWhitePapers = academic.ReviewedWhitePapers();

            Assert.True(actionResult.IsAssignableFrom(reviewedWhitePapers.GetType()));
        }
        
        [Fact]
        public void TestAcademicReferenceWork()
        {
            var academic = new AcademicController();
            var referenceWork = academic.ReferenceWork();

            Assert.True(actionResult.IsAssignableFrom(referenceWork.GetType()));
        }
        
        [Fact]
        public void TestAcademicArticles()
        {
            var academic = new AcademicController();
            var articles = academic.Articles();

            Assert.True(actionResult.IsAssignableFrom(articles.GetType()));
        }
        
        [Fact]
        public void TestAcademicUnpublishedWork()
        {
            var academic = new AcademicController();
            var unpublishedWork = academic.UnpublishedWork();

            Assert.True(actionResult.IsAssignableFrom(unpublishedWork.GetType()));
        }
        
        [Fact]
        public void TestAcademicCourseOutlines()
        {
            var academic = new AcademicController();
            var courseOutlines = academic.CourseOutlines();

            Assert.True(actionResult.IsAssignableFrom(courseOutlines.GetType()));
        }
        
        // [Fact]
        // public void TestAcademicError()
        // {
        //     var academic = new AcademicController();
        //     var books = academic.Error();
        // 
        //     Assert.True(actionResult.IsAssignableFrom(books.GetType()));
        // }
    }
}

using Microsoft.AspNetCore.Mvc;
using myApi;
using myApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class EventControllerTest
    {
        private readonly EventsController _controller;
        public EventControllerTest()
        {
            var context = new DataContextFake();//TODO להחליף את המימוש
            _controller = new EventsController(context);
        }


        //  של Get() שיטת בדיקה זו מוודאת שכאשר קוראים לשיטת  
        //OkObjectResult היא מחזירה ,EventsController ה
        [Fact]
        public void Get_ReturnsOk()
        {

            //Arrange

            //Act
            var result = _controller.Get() as OkObjectResult;

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }


        //הפונקציה
        // GET מוודא שהפןנקציה
        // מחזירה רשימה של 3 אלמנטים

        [Fact]
        public void Get_ReturnsAllItems()
        {
            // Act
            var okResult = _controller.Get() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<Event>>(okResult?.Value);
            Assert.Equal(3, items.Count);
        }


        //EventsController-של ה Post() שיטת בדיקה זו מוודאת שכאשר שיטת
        // OkObjectResult. חוקי, היא מחזירה Event נקראת עם אובייקט     
        [Fact]
        public void Add_ValidObjectPassed_ReturnsCreatedResponse()
        {
            // Arrange
            Event testItem = new Event()
            {
                id = 1,
                title = "default event22",
                start = DateTime.Now
            };
            // Act
            var createdResponse = _controller.Post(testItem);
            // Assert
            Assert.IsType<OkObjectResult>(createdResponse);
        }


        //EventsController-של ה Delete() שיטת בדיקה זו בודקת אם שיטת  
        // לא קיים. GUID כאשר קוראים עם NotFoundResult מחזירה
        [Fact]
        public void Remove_NotExistingGuidPassed_ReturnsNotFoundResponse()
        {
            // Arrange
            
            // Act
            var badResponse = _controller.Delete(100);
            // Assert
            Assert.IsType<NotFoundResult>(badResponse);
        }





    }
}

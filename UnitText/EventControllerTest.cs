using Microsoft.AspNetCore.Mvc;
using myAPI;
using myAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitText
{
    public class EventControllerTest
    {
        private readonly EventsController _controller;

        public EventControllerTest()
        {
            var context = new DataContextFake();//TODO להחליף את המימוש
            _controller = new EventsController(context);
        }
        [Fact]
        public void Get_ReturnsOk()
        {
            //AA"A

            //Arrange

            //Act
            var result = _controller.Get() as OkObjectResult;

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Get_ReturnsAllItems()
        {
            var result1 = _controller.Get() as OkObjectResult;
            var items = Assert.IsType<List<Event>>(result1.Value);
            Assert.Equal(3, items.Count);
        }

        //[Fact]

        //public void Add_ValidObjectPassed_ReturnedResponseHasCreatedItem()
        //{
        //    // Arrange
        //    var e = new Event{id=12, title = "tttt ", start = DateTime.Today };

        //    // Act
        //    var createdResponse = _controller.Post(e) as CreatedAtActionResult;
        //    var item = createdResponse.Value as Event;
        //    // Assert
        //    Assert.IsType<Event>(item);
        //    Assert.Equal("Guinness Original 6 Pack", item.title);
        //}


    }
}

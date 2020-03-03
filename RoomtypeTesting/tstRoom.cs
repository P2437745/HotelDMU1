using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoomtypeClasses;

namespace RoomtypeTesting
{
    public class RoomtypeTest
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsRoomType ARoomType = new clsRoomType();
            //test to see that it exists
            Assert.IsNotNull(ARoomType);
        }
    }
}

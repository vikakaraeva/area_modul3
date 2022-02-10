﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryRests
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            //исходные данны
            int a = 3;
            int b = 5;
            int expected = 15;

            //получнные значения с помощью тестируемого метода
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            //сранение ожидание результата с полученным
            Assert.AreEqual(expected, actual);
        }
    }
}

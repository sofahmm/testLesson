using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
/*Мавлин Данис, Тимофеев Андрей, Кумышбаева София*/

namespace Containers
{
    [TestClass]
    public class UnitTest1
    {
        /* DynArray dynArray = new DynArray(10);
         DynArray dynArray1 = new DynArray(10);
         DynArray dynArray2 = new DynArray(10);*/
        [TestMethod]
        public void TestInsertMethod()
        {
            var newArr = new DynArray();
            var newArr2 = new DynArray();
            var newArr3 = new DynArray();

            newArr.Insert(1, 2);
            newArr.Insert(2, 3);

            newArr2.Insert(1, 2);
            newArr2.Insert(2, 3);


            newArr3.Insert(2, 3);
            newArr3.Insert(3, 4);

            //dynArray.FillRandom(2, 9);

            Assert.AreEqual(newArr, newArr2);
        }
        [TestMethod]
        public void TestDeleteMethod()
        {
            var newArr = new DynArray(10);
            var newArr2 = new DynArray(10);

            newArr.FillRandom(1, 5);
            newArr2.FillRandom(1, 5);


            newArr.Delete(2);
            Assert.AreEqual(newArr.GetLength(), newArr2.GetLength());



        }
    }
}

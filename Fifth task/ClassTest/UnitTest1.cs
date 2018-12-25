﻿namespace ClassTest
{
    using System;
    using System.Collections.Generic;
    using ClassLibrary1;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetTest()
        {
            User user = new User();
            user = user.Get(1);
            string actualThemeName = user.Get(1).Name;
            string expectedThemeName = "Ivan";
            Assert.AreEqual(expectedThemeName, actualThemeName, "You got the wrong theme");
        }

        [TestMethod]
        public void GetAllTest()
        {
            User user = new User();
            user.InitiallizeUserRatingAndName();
            List<User> getList = null;
            getList = user.GetAll();
            int actual = getList.Count;
            int expected = 2;
            Assert.AreEqual(expected, actual, "You got the wrong list!");
        }

        [TestMethod]
        public void SaveTest()
        {
            User user = new User();
            user.InitiallizeUserRatingAndName();
            bool expected = true;
            List<Themes> pavelsList = new List<Themes>();
            pavelsList.Add(new Themes("Basic", 0, 12));
            bool actual = user.Save(new User("Pavel", pavelsList, 3));
            Assert.AreEqual(expected, actual, "You saved it wrong");
        }

        [TestMethod]
        public void DeleteTest()
        {
            User user = new User();
            user.InitiallizeUserRatingAndName();
            bool expected = true;
            bool actual = user.Delete(1);
            Assert.AreEqual(expected, actual, "deleted the wrong element");
        }

        [TestMethod]
        public void ManagerDelete()
        {
            Manager manager = new Manager();
            manager.InitiallizeNewManagerAndAttachedUsers();
            bool actual = manager.Delete(1);
            bool expected = true;
            Assert.AreEqual(expected, actual, "You got the wrong theme");
        }

        [TestMethod]
        public void ManagerSave()
        {
            Manager manager = new Manager();
            manager.InitiallizeNewManagerAndAttachedUsers();
            Manager pavel = new Manager();
            pavel.InitiallizeNewManagerAndAttachedUsers();
            bool actual = manager.Save(pavel);
            bool expected = true;
            Assert.AreEqual(expected, actual, "You attached a new user in a wrong way!");
        }

        [TestMethod]
        public void ManagerGetTest()
        {
            Manager manager = new Manager();
            manager.InitiallizeNewManagerAndAttachedUsers();
            string actual = manager.Get(1).Name;
            string expected = "Anna";
            Assert.AreEqual(expected, actual, "You got the wrong name");
        }

        [TestMethod]
        public void ManagerGetAllTest()
        {
            Manager manager = new Manager();
            manager.InitiallizeNewManagerAndAttachedUsers();
            int expected = 2;
            List<Manager> actualList = manager.GetAll();
            int actual = actualList.Count;
            Assert.AreEqual(expected, actual, "You got wrong items in your list");
        }
    }
}

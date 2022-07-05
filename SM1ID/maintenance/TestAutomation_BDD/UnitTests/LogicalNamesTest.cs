﻿using Kantar_BDD.Support.General;
using Kantar_BDD.Support.Selenium;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kantar_BDD.UnitTests
{
    public class LogicalNamesTest
    {
        private Dictionary<string, string> GetDuplicateLogicalNamesList(List<AbstractedBy> locators)
        {
            int count = 0;
            Dictionary<string, By> duplicateCheck = new Dictionary<string, By>();
            Dictionary<string, string> logicalNamesList = new Dictionary<string, string>();
            foreach (var locator in locators)
            {
                if(duplicateCheck.ContainsKey(locator.LogicalName))
                {
                    if(!logicalNamesList.ContainsKey(locator.LogicalName))
                    {
                        logicalNamesList.Add(locator.LogicalName, locator.ByToString);
                    }
                }
                else
                {
                    duplicateCheck.Add(locator.LogicalName, locator.SeleniumBy);
                    count++;
                }
            }

            return logicalNamesList;
        }

        private Dictionary<string, string> GetDuplicateLogicalClassNamesList(List<AbstractedByClass> locators)
        {
            Dictionary<string, string> duplicateCheckForClass = new Dictionary<string, string>();
            foreach (var classLocator in locators)
            {
                //logical name duplicates per class
                Dictionary<string, string> logicalNamesList = new Dictionary<string, string>();
                foreach (AbstractedBy select in classLocator.Selectors)
                {
                    if (logicalNamesList.ContainsKey(select.LogicalName))
                    {
                        if (!duplicateCheckForClass.ContainsKey(select.LogicalName + ":" + classLocator.Name))
                        {
                            duplicateCheckForClass.Add(select.LogicalName+":"+classLocator.Name, select.ByToString);
                        }
                    }
                    else
                    {
                        logicalNamesList.Add(select.LogicalName, classLocator.Name);
                    }
                }
            }

            return duplicateCheckForClass;
        }

        private bool CheckForDuplicateLogicalNames(List<AbstractedBy> locators)
        {
            Dictionary<string, By> duplicateCheck = new Dictionary<string, By>();
            try
            {
                foreach (var locator in locators)
                {
                    duplicateCheck.Add(locator.LogicalName, locator.SeleniumBy);
                }
                return false;
            }
            catch (ArgumentException)
            {
                return true;
            }
        }

        /// <summary>
        /// validates that there are no duplicate logical names 
        /// </summary>
        [Test]
        public void TestLogicalNamesBoolean()
        {
            PageObjectModeler modeler = new();
            List<AbstractedBy> locators = modeler.GetAllLocators();
            Assert.IsFalse(CheckForDuplicateLogicalNames(locators));
        }

        /// <summary>
        /// prints out a list of dublicate logical names
        /// </summary>
        [Test]
        public void GetDuplicatesList()
        {
            PageObjectModeler modeler = new();
            List<AbstractedByClass> locators = modeler.GetAllClassLocators();
            Dictionary<string, string> locatorduplicates = GetDuplicateLogicalClassNamesList(locators);
            foreach (KeyValuePair<string, string> lc in locatorduplicates)
            {
                Console.WriteLine("Duplicate Logical Name: |"+lc.Key+"|");
            }
            Assert.AreEqual(locatorduplicates.Count, 0, "There are duplicates that can be seen above.");
        }
    }
}

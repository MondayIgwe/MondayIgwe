﻿using Kantar_BDD.Pages;
using Kantar_BDD.Pages.Grids;
using Kantar_BDD.Pages.Popups;
using Kantar_BDD.Support.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kantar_BDD.Support.Helpers.SFA
{
    public class DiscountListsStepHelpers : StepHelpers
    {
        public DiscountListsStepHelpers(IWebDriver driver) : base(driver)
        {
        }

        public void PopulateNewDiscountListPopUp(string type = null, string listCode = null, string customerLevel = null, string customerCode = null, string startDate = null, string endDate = null, string applicationType = null, string enableBrackets = null)
        {
            if (type != null)
            {
                Selenium.Click(GenericElementsPage.RadioButton(type.ToLower().Trim()));
            }

            if (listCode != null)
            {
                Selenium.Click(GenericElementsPage.InputByLabelName("List Code"));
                Selenium.SendKeys(GenericElementsPage.InputByLabelName("List Code"), listCode);
                Selenium.LooseFocusFromAnElement();
            }
            else
            {
                Selenium.Click(GenericElementsPage.GenericGenerateCodeButton("List Code"));
            }

            if(Selenium.ValidateEnabledAndDisplayed(GenericElementsPage.GenericDropDownTrigger("Node code")))
            {
                Selenium.Click(GenericElementsPage.GenericDropDownTrigger("Node code"));
                Selenium.ValidateAllElementsLoaded(CustomerNodesGrid.SelectRow(1.ToString()));

                if (customerLevel != null)
                {
                    FilterGrid("Level", "Like", customerLevel);
                }

                if (customerCode != null)
                {
                    FilterGrid("Customer code", "Like", customerCode);
                }

                Selenium.Click(CustomerNodesGrid.SelectRow(1.ToString()), 15);
                Selenium.Click(PopupGenericElements.PopupOkButton("Customer Hierarchy Nodes"));
            }
            
            if (startDate != null && endDate != null)
            {
                startDate = CommonDates.DateParser(startDate);
                endDate = CommonDates.DateParser(endDate);
                SelectDatePeriod(GenericElementsPage.GenericDropDownTrigger("Validity period"), startDate, endDate);
            }

            if (applicationType != null)
            {
                Selenium.Click(GenericElementsPage.InputByLabelName("Application Type"));
                Selenium.ClearByKeys(GenericElementsPage.InputByLabelName("Application Type"));
                Selenium.SendKeys(GenericElementsPage.InputByLabelName("Application Type"), applicationType);
                Selenium.LooseFocusFromAnElement();
            }

            if (enableBrackets != null)
            {
                if(enableBrackets.Trim().ToLower().Equals("no"))
                {
                    enableBrackets = "No";
                }
                else if (enableBrackets.Trim().ToLower().Equals("yes"))
                {
                    enableBrackets = "Yes";
                }
                Selenium.Click(GenericElementsPage.RadioButton(enableBrackets), 15);
            }
        }
    }
}

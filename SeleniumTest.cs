using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;
namespace SeleniumCsharp
{
    public class Tests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://medicentrev3.hanmak.co.ke/Security/Login");
        }

        [TearDown]
        public void TearDown()
        {
            //close the browser window
            //driver.Quit();
        }

        [Test]
        public void EnterCredentials()
        {
            //Arrange
            #region Security Login Elements
            IWebElement hospCode = driver.FindElement(By.Id("hospCode"));
            IWebElement btnProceed = driver.FindElement(By.Id("btnProceed"));
            #endregion
            //Act
            #region Actions
            driver.Manage().Window.Size = new System.Drawing.Size(958, 768);
            hospCode.SendKeys("demo");
            btnProceed.Click();
            #endregion
            //Assert
            //Arrange
            #region Credentials
            Thread.Sleep(5000);
            IWebElement selectBranch = driver.FindElement(By.Id("select2-CompanyBranchID-container"));
            IWebElement BranchName = driver.FindElement(By.CssSelector("#LoginForm > span.select2.select2-container.select2-container--default > span.selection > span"));
            IWebElement BranchOption = driver.FindElement(By.CssSelector("#CompanyBranchID > option:nth-child(2)"));
            IWebElement UserName = driver.FindElement(By.Id("userName"));
            IWebElement PassWord = driver.FindElement(By.Id("userPassword"));
            IWebElement BtnLogin = driver.FindElement(By.Id("btnLogin"));
            string MyUserName = "NdirituG";
            string MyPassWord = "Denis123!";
            #endregion
            //Act
            #region Actions
            selectBranch.Click();
            BranchName.Click();
            BranchOption.Click();
            UserName.SendKeys(MyUserName);
            PassWord.SendKeys(MyPassWord);
            BtnLogin.Click();
            #endregion
            //Assert
            Assert.IsTrue(driver.FindElement(By.CssSelector("#page-wrapper > div > div.row.marginRow.well.well-sm > div:nth-child(2) > h5 > a > span")).Text.Contains("Main branch"));
        }
        
        [Test]
        public void RegisterPatient()
        {
            EnterCredentials();
            driver.Navigate().GoToUrl("https://medicentrev3.hanmak.co.ke/Clinical/Registry");
            #region Registry Fields
            //----------- Registry Fields ------------//
            IWebElement SurnameField = driver.FindElement(By.Id("Surname"));
            IWebElement OtherNamesField = driver.FindElement(By.Id("OtherNames"));
            SelectElement SexField = new SelectElement(driver.FindElement(By.Id("Sex")));
            //IWebElement SexField = driver.FindElement(By.Id("Surname"));
            IWebElement DateField = driver.FindElement(By.Id("DateOfBirth"));
            SelectElement IDTypeField = new SelectElement(driver.FindElement(By.Id("IDTypeID")));
            //IWebElement IDTypeField = driver.FindElement(By.Id("Surname"));
            IWebElement IDNumberField = driver.FindElement(By.Id("IDNumber"));
            IWebElement TelephoneOneField = driver.FindElement(By.Id("Telephone1"));
            IWebElement TelephoneTwoField = driver.FindElement(By.Id("Telephone2"));
            IWebElement EmailField = driver.FindElement(By.Id("EmailAddress"));
            IWebElement PostalAddressField = driver.FindElement(By.Id("PostalAddress"));
            IWebElement PostalCodeField = driver.FindElement(By.Id("PostalCode"));

            IWebElement OccupationSelect = driver.FindElement(By.CssSelector("#registryForm > div > div:nth-child(2) > div:nth-child(6) > div > span.select2.select2-container.select2-container--default > span.selection > span"));
            //IWebElement OccupationIDContainer = driver.FindElement(By.Id("#select2-OccupationID-container"));
            IWebElement OccupationField = driver.FindElement(By.CssSelector("#OccupationID > option:nth-child(4)"));

            IWebElement SelectTownIDContainer = driver.FindElement(By.Id("select2-TownID-container"));
            IWebElement TownSpanClass = driver.FindElement(By.CssSelector("#registryForm > div > div:nth-child(3) > div:nth-child(2) > div > span.select2.select2-container.select2-container--default > span.selection > span")); 
            IWebElement SelectTownOptionNyeri = driver.FindElement(By.CssSelector("#TownID > option:nth-child(27)"));

            IWebElement ResidenceField = driver.FindElement(By.Id("Residence"));
            
            //IWebElement TownField = driver.FindElement(By.Id("Surname"));
            IWebElement ReferenceField = driver.FindElement(By.Id("ReferenceNo"));

            //IWebElement NationalityIDContainer = driver.FindElement(By.Id("select2-NationalityID-container"));
            IWebElement NationalityIDContainerClass = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[2]/div[3]/div/div/div[2]/form/div/div[3]/div[4]/div/span[1]/span[1]/span"));
            IWebElement NationalitySelect = driver.FindElement(By.CssSelector("#NationalityID > option:nth-child(3)"));
                                                                
            IWebElement NextofKinField = driver.FindElement(By.Id("NextOfKin"));
            IWebElement RelationshipField = driver.FindElement(By.Id("NextOfKinRelationship"));
            IWebElement NextofKinContactField = driver.FindElement(By.Id("NextOfKinContact"));
            IWebElement NotesField = driver.FindElement(By.Id("Note"));
            IWebElement CustomerSchemesButton = driver.FindElement(By.Id("btnCustSchemes"));
            IWebElement AddCustomerButton = driver.FindElement(By.Id("btnaddcust"));
            //------------End of registry fields-----------//

            //----------Customer Schemes fields-----------//
            IWebElement SelectSchemeClass = driver.FindElement(By.CssSelector("#CustomerSchemeForm > div > div:nth-child(1) > div:nth-child(1) > span > span.selection > span"));
            SelectElement SelectSchemeOption = new SelectElement(driver.FindElement(By.Id("SchemeID")));
            IWebElement MembershipNumber = driver.FindElement(By.Id("MembershipNo"));
            IWebElement PrincipleMember = driver.FindElement(By.Id("PrincipalMember"));
            IWebElement IsPrincipleMemberCheckBox = driver.FindElement(By.Id("IsPrincipalMember"));
            IWebElement CloseButton = driver.FindElement(By.Id("btnCloseModal"));
            
            //----------End Customer Schemes fields-------//
            #endregion

            //Actions
            SurnameField.SendKeys("Ndiritu");
            OtherNamesField.SendKeys("Ken Walibora");
            SexField.SelectByText("Male");
            DateField.SendKeys("23");
            DateField.SendKeys("3");
            new Actions(driver)
                .KeyDown(Keys.Tab)
                .SendKeys("1998")
                .Perform();
            IDTypeField.SelectByText("None");
            //IDNumberField.SendKeys("21342345");
            TelephoneOneField.SendKeys("0723675677");
            EmailField.SendKeys("denisndiritu1@gmail.com");
            OccupationSelect.Click(); 
            OccupationField.Click();
            TownSpanClass.Click();
            SelectTownOptionNyeri.Click();
            ResidenceField.SendKeys("Othaya");

            NationalityIDContainerClass.Click();
            //NationalityIDContainer.Click();
            NationalitySelect.Click();

            NextofKinField.SendKeys("Peter Ndiritu");
            RelationshipField.SendKeys("Brother");
            NextofKinContactField.SendKeys("0760456278");

            CustomerSchemesButton.Click();
            

            
            
            if (SelectSchemeClass != null)
            {
                Console.WriteLine("Element found on the webpage");
            }
            else
            {
                Console.WriteLine("Element not found on the webpage");
            }
            SelectSchemeClass.Click();
            SelectSchemeOption.SelectByText("Jubilee Insuarance - Ndiritu&Sons");
            MembershipNumber.Click();
            IsPrincipleMemberCheckBox.Click();
            //IAlert SchemeAlert = driver.SwitchTo().Alert();
            //if (SchemeAlert.Text.Equals("Ok"))
            //{
            //    SchemeAlert.Accept();
            //}
            //else
            //{
            //    SchemeAlert.Dismiss();
            //}
        }
    }
}
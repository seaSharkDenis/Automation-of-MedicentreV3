using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
namespace SeleniumCsharp
{
    public class MockupLogin
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            //close the browser window
            //driver.Quit();
        }

        [Test]
        public void ProceedtoLogin_WithValidAccessCode()
        {
            /*
            //Arrange
            #region registry fields
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
            IWebElement OccupationSelect = driver.FindElement(By.CssSelector("#registryForm > div > div:nth-child(2) > div:nth-child(6) > div > span.select2.select2-container.select2-container--default.select2-container--below.select2-container--open > span.selection > span"));
            IWebElement OccupationField = driver.FindElement(By.CssSelector("#select2-OccupationID-result-iz6k-5"));
            IWebElement TownSpanClass = driver.FindElement(By.CssSelector("#registryForm > div > div:nth-child(3) > div:nth-child(2) > div > span.select2.select2-container.select2-container--default.select2-container--below.select2-container--open > span.selection > span"));
            IWebElement ResidenceField = driver.FindElement(By.Id("Residence"));
            IWebElement SelectTownIDContainer = driver.FindElement(By.Id("select2-TownID-container"));
            IWebElement SelectTownOptionNyeri = driver.FindElement(By.Id("select2-TownID-result-1lph-28"));
            //IWebElement TownField = driver.FindElement(By.Id("Surname"));
            IWebElement ReferenceField = driver.FindElement(By.Id("ReferenceNo"));
            IWebElement NationalityParentClassField = driver.FindElement(By.CssSelector("#registryForm > div > div:nth-child(3) > div:nth-child(4) > div > span.select2.select2-container.select2-container--default.select2-container--below.select2-container--focus > span.selection > span"));
            IWebElement NationalityKenyanOption = driver.FindElement(By.Id("select2-NationalityID-result-4nxk-2"));
            IWebElement NextofKinField = driver.FindElement(By.Id("NextOfKin"));
            IWebElement RelationshipField = driver.FindElement(By.Id("NextOfKinRelationship"));
            IWebElement NextofKinContactField = driver.FindElement(By.Id("NextOfKinContact"));
            IWebElement NotesField = driver.FindElement(By.Id("Note"));
            IWebElement CustomerSchemesButton = driver.FindElement(By.Id("btnCustSchemes"));
            IWebElement AddCustomerButton = driver.FindElement(By.Id("btnaddcust"));
            //------------End of registry fields-----------//
#endregion
            */
            //Navigate to MedicentreV3
            string MyUserName = "NdirituG";
            string MyPassWord = "Denis123!";
            driver.Navigate().GoToUrl("https://medicentrev3.hanmak.co.ke/Security/Login");
            driver.Manage().Window.Size = new System.Drawing.Size(958, 768);
            //Locate the code input field and enter a code
            IWebElement hospCode = driver.FindElement(By.Id("hospCode"));
            hospCode.SendKeys("demo");


            IWebElement btnProceed = driver.FindElement(By.Id("btnProceed"));
            btnProceed.Click();

            Thread.Sleep(10000);
            Assert.IsTrue(driver.FindElement(By.Id("txtClient")).Text.Contains("Demo Hospital"));


            IWebElement selectBranch = driver.FindElement(By.Id("select2-CompanyBranchID-container"));
            Thread.Sleep(5000);
            selectBranch.Click();
            Thread.Sleep(5000);
            IWebElement BranchName = driver.FindElement(By.CssSelector("#LoginForm > span.select2.select2-container.select2-container--default.select2-container--below.select2-container--open > span.selection > span"));
            BranchName.Click();

            IWebElement BranchOption = driver.FindElement(By.CssSelector("#CompanyBranchID > option:nth-child(2)"));
            BranchOption.Click();


            //IWebElement BranchOption = driver.FindElement(By.CssSelector("#select2-CompanyBranchID-result-c4dj-1"));
            //BranchOption.Click();

            IWebElement UserName = driver.FindElement(By.Id("userName"));
            UserName.SendKeys(MyUserName);

            IWebElement PassWord = driver.FindElement(By.Id("userPassword"));
            PassWord.SendKeys(MyPassWord);

            IWebElement BtnLogin = driver.FindElement(By.Id("btnLogin"));
            BtnLogin.Click();

            Thread.Sleep(5000);

            driver.Navigate().GoToUrl("https://medicentrev3.hanmak.co.ke/Clinical/Registry");
            //driver.FindElement(By.Id("Surname")).SendKeys("Ndiritu").Click();

            //IWebElement hospLabel= driver.FindElement(By.Id("txtClient"));
            //IWebElement BranchSelect = driver.FindElement(By.CssSelector("#select2-CompanyBranchID-container"));
            //SelectElement BranchRole = new SelectElement(driver.FindElement(By.Id("select2-CompanyBranchID-result-70ve-1")));
            //IWebElement BranchRole = driver.FindElement(By.Id("select2-CompanyBranchID-result-vwzb-1"));

            //Act

            //BranchSelect.Click();
            //BranchRole.Click();

            //Assert
            //Assert.AreEqual("Demo Hospital", hospLabel.Text);
        }
    }
}
using OpenQA.Selenium;
using System.Threading;

namespace Specflow_task1.SpecDefinition
{
    public class SignIn
    {
        private static IWebElement SignInBtn =>  Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
        private static IWebElement Email => Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
        private static IWebElement Password => Driver.driver.FindElement(By.XPath("//INPUT[@type='password']"));
        private static IWebElement LoginBtn => Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));
        public static void SigninStep()
        {
            Driver.NavigateUrl();
           
            //Email.SendKeys(ExcelLibHelper.ReadData(2,"username"));
            //Password.SendKeys(ExcelLibHelper.ReadData(2, "password"));
            
        }

        public static void selectLogin()
        {
            SignInBtn.Click();
        }

        public static void enterUserNamePw( string p0, string p1)
        {
            //Enter Username
            Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys(p0);

            //Enter password
            Driver.driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys(p1);

            //Click on Login Button
            Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();


        }

        //public static void Login()
        //{
        //    //Driver.NavigateUrl();

        //    //Enter Url
        //    //Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();




        //}


        //Login Assertions
        public string getProfileName(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement profileName = driver.FindElement(By.ClassName("title"));
            return profileName.Text;
        }
    }

   
}
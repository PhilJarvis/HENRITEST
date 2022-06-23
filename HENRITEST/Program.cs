using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Go to the Website
// *********************************************************************************
IWebDriver driver = new ChromeDriver(@"C:\BrowserDrivers\Chrome\");
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
driver.Manage().Window.Maximize();

// Select Dresses Menu
driver.FindElement(By.CssSelector("#block_top_menu > ul > li:nth-child(2) > a")).Click();
Thread.Sleep(10000);

// Select most expensive dress
driver.FindElement(By.CssSelector("#center_column > ul > li:nth-child(2) > div > div.left-block > div > a.product_img_link > img")).Click();

// Add to Cart
var iframe = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/iframe"));
driver.SwitchTo().Frame(iframe);
driver.FindElement(By.Name("Submit")).Click();

// See if its added to Cart before closing
Thread.Sleep(10000);

// Close out
driver.Close();



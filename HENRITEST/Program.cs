// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Go to the Wesite
// *********************************************************************************
IWebDriver driver = new ChromeDriver(@"C:\ChromeDriver\");
driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
string text = driver.Title;
Console.WriteLine(text);
System.Threading.Thread.Sleep(4000);
// *********************************************************************************

// Select Dresses Menu
driver.FindElement(By.CssSelector("#block_top_menu > ul > li:nth-child(2) > a")).Click();
Thread.Sleep(10000);

// Select most expensive dress
driver.FindElement(By.CssSelector("#center_column > ul > li:nth-child(2) > div > div.left-block > div > a.product_img_link")).Click();
Thread.Sleep(30000);

// Add to Cart
driver.FindElement(By.CssSelector("#add_to_cart > button")).Click();
System.Threading.Thread.Sleep(4000);
driver.Close();



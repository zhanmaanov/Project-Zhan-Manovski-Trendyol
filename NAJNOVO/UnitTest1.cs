using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using System.IO;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using System.Security.Policy;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
using static System.Collections.Specialized.BitVector32;

namespace BRAIN
{
    public class ZadacaRandom
    {
        [TestFixture]
        public class Domasna
        {
            public IWebDriver Driver = new ChromeDriver();
            public WebDriverWait wait;
            public static Random random = new Random();

            [OneTimeSetUp]
            public void OneTimeSetUp()
            {

            }

            [SetUp]
            public void SetUp()
            {
            
                Driver = new ChromeDriver();
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
                Driver.Manage().Window.Maximize();
                wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));

                Driver.Navigate().GoToUrl("https://www.sportsdirect.com/");
                
            }

            [Test]
            public void submitButtonValidationERROR()
            {
                IWebElement cookiesButton = Driver.FindElement(By.Id("onetrust-accept-btn-handler"));
                cookiesButton.Click();

                IWebElement profileIcon = Driver.FindElement(By.ClassName("login"));
                profileIcon.Click();

                IWebElement signUpButton = Driver.FindElement(By.CssSelector("a[href='/registration?returnUrl=%2f']"));
                signUpButton.Click();




                string titleText = Driver.FindElement(By.CssSelector("label[for='Registration_Title']")).Text;
                Assert.That(titleText, Is.EqualTo("Title"));
                Console.WriteLine(titleText);


                string firstName = Driver.FindElement(By.CssSelector("label[for='Registration_FirstName']")).Text;
                Assert.That(firstName, Is.EqualTo("First name"));
                Console.WriteLine(firstName);


                string lastName = Driver.FindElement(By.CssSelector("label[for='Registration_LastName']")).Text;
                Assert.That(lastName, Is.EqualTo("Last name"));
                Console.WriteLine(lastName);


                string emailAdress = Driver.FindElement(By.CssSelector("label[for='Registration_EmailAddress']")).Text;
                Assert.That(emailAdress, Is.EqualTo("Email address"));
                Console.WriteLine(emailAdress);


                string dateOfBirth = Driver.FindElement(By.CssSelector("label[for='Registration_DateOfBirthDay']")).Text;
                Assert.That(dateOfBirth, Is.EqualTo("Date of birth (optional)"));
                Console.WriteLine(dateOfBirth);

                string password = Driver.FindElement(By.CssSelector("label[for='Registration_Password']")).Text;
                Assert.That(password, Is.EqualTo("Password"));
                Console.WriteLine(password);


                string confirmPassword = Driver.FindElement(By.CssSelector("label[for='Registration_ConfirmPassword']")).Text;
                Assert.That(confirmPassword, Is.EqualTo("Confirm Password"));
                Console.WriteLine(confirmPassword);

                string checkbox = Driver.FindElement(By.CssSelector("div[class='SignupConfirm']")).Text;
                Assert.That(checkbox, Is.EqualTo("Yes, send me FREE email updates from SportsDirect.com about products, services, promotions and offers inline with our privacy policy."));
                Console.WriteLine(checkbox);


                string registrationButton = Driver.FindElement(By.Id("RegistrationSubmit")).Text;
                Assert.That(registrationButton, Is.EqualTo("Register"));
                Console.WriteLine(registrationButton);



                IWebElement firstName1 = Driver.FindElement(By.Id("Registration_FirstName"));
                firstName1.Click();
                firstName1.Clear();
                firstName1.SendKeys("Zhan");


                IWebElement lastName1 = Driver.FindElement(By.Id("Registration_LastName"));
                lastName1.Click();
                lastName1.Clear();
                lastName1.SendKeys("Manovski");


                //Verify that not filling the mandatory fields and clicking the submit button will lead to validation error

                IWebElement birthdayDatum = Driver.FindElement(By.CssSelector("select[class='DateSelector Day']"));
                SelectElement birthdayDatum1 = new SelectElement(birthdayDatum);
                birthdayDatum1.SelectByValue("13");

                IWebElement birthdayMonth = Driver.FindElement(By.CssSelector("select[class='DateSelector Month']"));
                SelectElement birthdayMonth1 = new SelectElement(birthdayMonth);
                birthdayMonth1.SelectByValue("1");


                IWebElement birthdayYear = Driver.FindElement(By.CssSelector("select[class='DateSelector Year']"));
                SelectElement birthdayYear1 = new SelectElement(birthdayYear);
                birthdayYear1.SelectByValue("1993");

                IWebElement password1 = Driver.FindElement(By.Id("txtPassword"));
                password1.Click();
                password1.Clear();
                password1.SendKeys("12345678m!");


                IWebElement confirmPassword1 = Driver.FindElement(By.Id("Registration_ConfirmPassword"));
                confirmPassword1.Click();
                confirmPassword1.Clear();
                confirmPassword1.SendKeys("12345678m!");


                IWebElement checkButtonBox = Driver.FindElement(By.Id("Registration_IsSubscriber"));
                checkButtonBox.Click();

                IWebElement registrationSubmitButton = Driver.FindElement(By.Id("RegistrationSubmit"));
                registrationSubmitButton.Click();

                string expectedUrl = "Please enter a valid email address";
                string result = Driver.FindElement(By.CssSelector("span[id='Registration_EmailAddress-error']")).Text;
                Assert.That(expectedUrl, Is.EqualTo(result));

                




                
                

            }

           

            [Test]
            public void blancSpaces()
            {
                //Verify that entering blank spaces on mandatory fields leads to validation error.
                IWebElement cookiesButton = Driver.FindElement(By.Id("onetrust-accept-btn-handler"));
                cookiesButton.Click();

                IWebElement profileIcon = Driver.FindElement(By.ClassName("login"));
                profileIcon.Click();

                IWebElement signUpButton = Driver.FindElement(By.CssSelector("a[href='/registration?returnUrl=%2f']"));
                signUpButton.Click();




                string titleText = Driver.FindElement(By.CssSelector("label[for='Registration_Title']")).Text;
                Assert.That(titleText, Is.EqualTo("Title"));
                Console.WriteLine(titleText);


                string firstName = Driver.FindElement(By.CssSelector("label[for='Registration_FirstName']")).Text;
                Assert.That(firstName, Is.EqualTo("First name"));
                Console.WriteLine(firstName);


                string lastName = Driver.FindElement(By.CssSelector("label[for='Registration_LastName']")).Text;
                Assert.That(lastName, Is.EqualTo("Last name"));
                Console.WriteLine(lastName);


                string emailAdress = Driver.FindElement(By.CssSelector("label[for='Registration_EmailAddress']")).Text;
                Assert.That(emailAdress, Is.EqualTo("Email address"));
                Console.WriteLine(emailAdress);


                string dateOfBirth = Driver.FindElement(By.CssSelector("label[for='Registration_DateOfBirthDay']")).Text;
                Assert.That(dateOfBirth, Is.EqualTo("Date of birth (optional)"));
                Console.WriteLine(dateOfBirth);

                string password = Driver.FindElement(By.CssSelector("label[for='Registration_Password']")).Text;
                Assert.That(password, Is.EqualTo("Password"));
                Console.WriteLine(password);


                string confirmPassword = Driver.FindElement(By.CssSelector("label[for='Registration_ConfirmPassword']")).Text;
                Assert.That(confirmPassword, Is.EqualTo("Confirm Password"));
                Console.WriteLine(confirmPassword);

                string checkbox = Driver.FindElement(By.CssSelector("div[class='SignupConfirm']")).Text;
                Assert.That(checkbox, Is.EqualTo("Yes, send me FREE email updates from SportsDirect.com about products, services, promotions and offers inline with our privacy policy."));
                Console.WriteLine(checkbox);


                string registrationButton = Driver.FindElement(By.Id("RegistrationSubmit")).Text;
                Assert.That(registrationButton, Is.EqualTo("Register"));
                Console.WriteLine(registrationButton);



                IWebElement firstName1 = Driver.FindElement(By.Id("Registration_FirstName"));
                firstName1.Click();
                firstName1.Clear();
                firstName1.SendKeys("Zhan");


                IWebElement lastName1 = Driver.FindElement(By.Id("Registration_LastName"));
                lastName1.Click();
                lastName1.Clear();
                lastName1.SendKeys("Manovski");

                IWebElement birthdayDatum = Driver.FindElement(By.CssSelector("select[class='DateSelector Day']"));
                SelectElement birthdayDatum1 = new SelectElement(birthdayDatum);
                birthdayDatum1.SelectByValue("13");

                IWebElement birthdayMonth = Driver.FindElement(By.CssSelector("select[class='DateSelector Month']"));
                SelectElement birthdayMonth1 = new SelectElement(birthdayMonth);
                birthdayMonth1.SelectByValue("1");


                IWebElement birthdayYear = Driver.FindElement(By.CssSelector("select[class='DateSelector Year']"));
                SelectElement birthdayYear1 = new SelectElement(birthdayYear);
                birthdayYear1.SelectByValue("1993");

                IWebElement password1 = Driver.FindElement(By.Id("txtPassword"));
                password1.Click();
                password1.Clear();
                password1.SendKeys("12345678m!");


                IWebElement confirmPassword1 = Driver.FindElement(By.Id("Registration_ConfirmPassword"));
                confirmPassword1.Click();
                confirmPassword1.Clear();
                confirmPassword1.SendKeys("12345678m!");


                IWebElement checkButtonBox = Driver.FindElement(By.Id("Registration_IsSubscriber"));
                checkButtonBox.Click();

                IWebElement registrationSubmitButton = Driver.FindElement(By.Id("RegistrationSubmit"));
                registrationSubmitButton.Click();

                string expectedUrl = "Please enter a valid email address";
                string result = Driver.FindElement(By.CssSelector("span[id='Registration_EmailAddress-error']")).Text;
                Assert.That(expectedUrl, Is.EqualTo(result));

            }


            public class addToCart1
            {

                public IWebDriver Driver1 = new ChromeDriver();
                public WebDriverWait wait1;
                public static Random random1 = new Random();

                [OneTimeSetUp]
                public void OneTimeSetUp()
                {

                }

                [SetUp]
                public void SetUp()
                {

                    Driver1 = new ChromeDriver();
                    Driver1.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    Driver1.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
                    Driver1.Manage().Window.Maximize();
                    wait1 = new WebDriverWait(Driver1, TimeSpan.FromSeconds(5));               
                    Driver1.Navigate().GoToUrl("https://www.trendyol.com/en/select-country?cb=/en");
                }






                [Test]
                public void addToCartLOGIN()
                {
                    //Verify that the user can add to cart one or more products.

                    IWebElement languageList1 = Driver1.FindElement(By.XPath("//*[@id=\"country-selection\"]/div/div/div[2]/div[2]/select"));
                    languageList1.Click();


                    IWebElement countyChoosing = Driver1.FindElement(By.XPath("//*[@id=\"country-selection\"]/div/div/div[2]/div[2]/select"));
                    SelectElement countyChoosing1 = new SelectElement(countyChoosing);
                    countyChoosing1.SelectByText("United Kingdom");

                    IWebElement selectButton = Driver1.FindElement(By.ClassName("country-actions"));
                    selectButton.Click();

                    IWebElement coockies = Driver1.FindElement(By.Id("onetrust-accept-btn-handler"));
                    coockies.Click();


                    IWebElement userICON = Driver1.FindElement(By.ClassName("user-icon"));
                    userICON.Click();


                    IWebElement logInMail = Driver1.FindElement(By.Id("login-email-input"));
                    logInMail.Click();
                    logInMail.Clear();
                    logInMail.SendKeys("zhan.manov13@gmail.com");


                    IWebElement logInPassword = Driver1.FindElement(By.Id("login-password-input"));
                    logInPassword.Click();
                    logInPassword.Clear();
                    logInPassword.SendKeys("12345678m!");



                    IWebElement logInButtonT = Driver1.FindElement(By.ClassName("login-button"));
                    logInButtonT.Click();



                    var startShoppingButton = wait1.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button.start-shopping-link")));
                    startShoppingButton.Click();

                    IWebElement clickOnNewSeason = Driver1.FindElement(By.CssSelector("img[src='https://cdn.dsmcdn.com/ty1172/20240216114204386890_finalBanner.png']"));
                    clickOnNewSeason.Click();

                    IWebElement calvinKleinTshirt = Driver1.FindElement(By.CssSelector("a[href='/en/calvin-klein/t-shirt-men-bright-white-p-758193585?boutiqueId=48&merchantId=968']"));
                    calvinKleinTshirt.Click();

                    IWebElement addToCart = Driver1.FindElement(By.Id("add-to-basket"));
                    addToCart.Click();

                    IWebElement secontTshirt = Driver1.FindElement(By.CssSelector("a[href='/en/ac-co-altinyildiz-classics/men-s-white-100-cotton-slim-fit-narrow-cut-crew-neck-short-sleeve-t-shirt-p-224555799']"));
                    secontTshirt.Click();
                    IWebElement addToCart1 = Driver1.FindElement(By.Id("add-to-basket"));
                    addToCart1.Click();
                    ///



                    IWebElement cart = Driver1.FindElement(By.CssSelector("a[href='/en/cart']"));
                    cart.Click();


                    // Verify that users can add products to the wishlist(favorites).


                    var startShoppingButton1 = wait1.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[href='/en']")));
                    startShoppingButton1.Click();


                    IWebElement clickOnNewSeasonFav = Driver1.FindElement(By.CssSelector("img[src='https://cdn.dsmcdn.com/ty1172/20240216114204386890_finalBanner.png']"));
                    clickOnNewSeasonFav.Click();
                   


                    IWebElement fistFavoriteProduct = Driver1.FindElement(By.CssSelector("a[href='/en/tommy-hilfiger/1985-knit-solid-sf-shirt-p-449729427?boutiqueId=48&merchantId=968']"));
                    fistFavoriteProduct.Click();


                    IWebElement fistFavoriteProductADD = Driver1.FindElement(By.Id("add-to-favorites"));
                    fistFavoriteProductADD.Click();

                    IWebElement favoriteIcon = Driver1.FindElement(By.ClassName("favorite-icon"));
                    favoriteIcon.Click();

                    string verFavorite = Driver1.FindElement(By.CssSelector("span[class='brand-name']")).Text;
                    Assert.That(verFavorite, Is.EqualTo("TOMMY HILFIGER"));
                    Console.WriteLine(verFavorite);



                    var checkOut = wait1.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("basket-preview-icon")));
                    checkOut.Click();

                    IWebElement checkOutButton = Driver1.FindElement(By.CssSelector("span[style='display:inline-block;-webkit-mask-image:url(https://cdn.dsmcdn.com/sfint/production/secure_1677750729128.svg);mask-image:url(https://cdn.dsmcdn.com/sfint/production/secure_1677750729128.svg);-webkit-mask-size:cover;background-color:white;width:20px;height:20px']"));




                    List<IWebElement> adressfields = Driver1.FindElements(By.CssSelector("input[placeholder='Search for your address']")).ToList();

                    wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("input[placeholder='Search for your address']")));
                    adressfields.First().SendKeys("London. UK");
                    List<IWebElement> autoPickUpAdress = Driver1.FindElements(By.XPath("//*[@id=\"poseidon-popup\"]/div/div/div[2]/div[1]/div[2]/div[1]")).ToList();
                    autoPickUpAdress[0].Click();


                    IWebElement confirmAdress = Driver1.FindElement(By.CssSelector("button[class ='p-button-wrapper p-primary p-large p-fluid confirm-address-button']"));
                    confirmAdress.Click();

                   
                    IWebElement nameAdressPayment = Driver1.FindElement(By.Id("name"));
                    nameAdressPayment.Click();
                    nameAdressPayment.Clear();
                    nameAdressPayment.SendKeys("Zhan");

                    IWebElement lastNameAdressPayment = Driver1.FindElement(By.Id("surname"));
                    lastNameAdressPayment.Click();
                    lastNameAdressPayment.Clear();
                    lastNameAdressPayment.SendKeys("Manovski");


                    IWebElement phoneNumber = Driver1.FindElement(By.Id("phone"));
                    phoneNumber.Click();
                    phoneNumber.Clear();
                    phoneNumber.SendKeys("207123 4567");


                    IWebElement adressPaymentt = Driver1.FindElement(By.CssSelector("input[class='input-2 s location-prediction__input pac-target-input']"));
                    adressPaymentt.Clear();
                    adressPaymentt.SendKeys("London UK");

                    IWebElement adressPaymenttCode = Driver1.FindElement(By.CssSelector("input[id='postal-code']"));
                    adressPaymenttCode.Click();
                    adressPaymenttCode.Clear();
                    adressPaymenttCode.SendKeys("E1 8RU");


                    IWebElement adressPaymenttCity = Driver1.FindElement(By.CssSelector("input[class='input-2 s location-prediction__input pac-target-input']"));
                    adressPaymenttCity.Click();
                    adressPaymenttCity.Clear();
                    adressPaymenttCity.SendKeys("London UK");



                    IWebElement adressPaymenttNumber = Driver1.FindElement(By.CssSelector("input[id='address-text']"));
                    adressPaymenttNumber.Click();
                    adressPaymenttNumber.Clear();
                    adressPaymenttNumber.SendKeys("W1 5DU");


                    IWebElement saveAndSelect = Driver1.FindElement(By.CssSelector("button[class='p-button-wrapper p-primary p-large']"));
                    saveAndSelect.Click();

                    IWebElement message2 = Driver1.FindElement(By.CssSelector("h1[class='secure-checkout']"));
                    string text2 = message2.Text;
                    Assert.Equals("SECURE PAYMENT", text2);



                    // Verify that the user can logout successfully.

               
                    var userIcon  = Driver1.FindElement(By.CssSelector("div.user"));
                    Actions action = new Actions(Driver1);
                    action.MoveToElement(userIcon).Perform();


                    var signOutElement = wait1.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[@class='name' and contains(text(), 'Sign out')]")));
                    signOutElement.Click();


                    //Report the answer to one of the questions asked in the help section in TestResult

                    wait1.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[data-testid='corporate-2-link']")));
                    var helpContactLink = Driver1.FindElement(By.CssSelector("a[data-testid='corporate-2-link']"));
                    helpContactLink.Click();


                    var chatbotButton =Driver1.FindElement(By.CssSelector(".start-chat-button"));
                    chatbotButton.Click();

                    wait1.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(), 'Return & Refund')]")));

                    var returnRefundButton = Driver1.FindElement(By.XPath("//span[contains(text(), 'Return & Refund')]/ancestor::button"));
                    returnRefundButton.Click();



                    wait1.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(), 'How can I Return?')]")));

                    var howCanIReturnElement = Driver1.FindElement(By.XPath("//span[contains(text(), 'How can I Return?')]/ancestor::button"));
                    howCanIReturnElement.Click();

                    wait1.Until(ExpectedConditions.ElementExists(By.CssSelector("div.player-wrapper video.video-react-video")));


                    var videoElement = Driver1.FindElement(By.CssSelector("div.player-wrapper video.video-react-video"));
                    bool isVideoPresent = videoElement.Displayed;
                    string videoSrc = videoElement.GetAttribute("src");


                    if (isVideoPresent)
                    {
                        Console.WriteLine("TestResult: The chatbot responded with a video.");
                        Console.WriteLine("Video URL: " + videoSrc);
                    }
                    else
                    {
                        Console.WriteLine("TestResult: The chatbot did not respond with a video.");
                    }



                }












            }


            [TearDown]
            public void TearDown()
            {
                //Driver.Close();
                //Driver.Dispose();
            }

            
        }

    }
}

using NUnit.Framework;
using login_c_sharp.e2e.pages;

namespace login_c_sharp.e2e
{
    using Microsoft.Playwright;
    using System.Threading.Tasks;
    [TestFixture]
    public class LoginTests
    {
        private IPlaywright _playwright;
        private IBrowser _browser;
        private IPage _page;
        private LoginPage _loginPage;

        [SetUp]
        public async Task SetUpAsync()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = true });
            _page = await _browser.NewPageAsync();
            _loginPage = new LoginPage(_page);
        }

        [TearDown]
        public async Task TearDownAsync()
        {
            await _browser.CloseAsync();
            _playwright.Dispose();
        }

        [Test]
        [Category("Smoke")]
        public async Task Login_WithValidCredentials_ShouldSucceed()
        {
            await _loginPage.GoToAsync();
            await _loginPage.EnterUsernameAsync("tomsmith");
            await _loginPage.EnterPasswordAsync("SuperSecretPassword!");
            await _loginPage.ClickLoginAsync();
            var flash = await _loginPage.GetFlashMessageAsync();
            Assert.That(flash, Does.Contain("You logged into a secure area!"));
        }

        [Test]
        public async Task Login_WithInvalidCredentials_ShouldFail()
        {
            await _loginPage.GoToAsync();
            await _loginPage.EnterUsernameAsync("invalid");
            await _loginPage.EnterPasswordAsync("invalid");
            await _loginPage.ClickLoginAsync();
            var flash = await _loginPage.GetFlashMessageAsync();
            Assert.That(flash, Does.Contain("Your username is invalid!"));
        }
    }
}

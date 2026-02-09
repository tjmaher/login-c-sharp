
namespace login_c_sharp.e2e.pages
{
    using Microsoft.Playwright;
    public class LoginPage
    {
        private readonly IPage _page;
        private readonly string _url = "https://the-internet.herokuapp.com/login";

        public LoginPage(IPage page)
        {
            _page = page;
        }

        public async Task GoToAsync()
        {
            await _page.GotoAsync(_url);
        }

        public async Task EnterUsernameAsync(string username)
        {
            await _page.FillAsync("#username", username);
        }

        public async Task EnterPasswordAsync(string password)
        {
            await _page.FillAsync("#password", password);
        }

        public async Task ClickLoginAsync()
        {
            await _page.ClickAsync("button[type='submit']");
        }

        public async Task<string> GetFlashMessageAsync()
        {
            return await _page.InnerTextAsync("#flash");
        }
    }
}

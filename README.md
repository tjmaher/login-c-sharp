## Local Development Setup

### Windows 11
1. Install .NET SDK (https://dotnet.microsoft.com/download)
2. Install Chrome browser
3. Open PowerShell and run:
   - `dotnet restore`
   - `dotnet add package NUnit`
   - `dotnet add package Microsoft.Playwright`
   - `dotnet tool install --global Microsoft.Playwright.CLI`
   - `powershell bin/Debug/net10.0/playwright.ps1 install`
   - `dotnet test`

### Macbook
1. Install .NET SDK (https://dotnet.microsoft.com/download)
2. Install Chrome browser
3. Open Terminal and run:
   - `dotnet restore`
   - `dotnet add package NUnit`
   - `dotnet add package Microsoft.Playwright`
   - `dotnet tool install --global Microsoft.Playwright.CLI`
   - `pwsh bin/Debug/net10.0/playwright.ps1 install` (if PowerShell is installed)
   - Or use `playwright install` if using Playwright CLI
   - `dotnet test`
# login-c-sharp

Automated test framework for https://the-internet.herokuapp.com/login using C#, NUnit, and Playwright.

## Structure
- Tests: e2e/
- Page Objects: e2e/pages/

## Setup
1. Install .NET SDK (if not already installed)
2. Install Chrome browser
3. Run:
   - `dotnet add package NUnit`
   - `dotnet add package Microsoft.Playwright`
   - `dotnet tool install --global Microsoft.Playwright.CLI`

## Running Tests
1. Navigate to the project directory
2. Run:
   - `powershell bin/Debug/net10.0/playwright.ps1 install`
   - `dotnet test`

## Sample Test
See e2e/LoginTests.cs for example tests.

---

**Note:** Run browser install step after Playwright package updates.

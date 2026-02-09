# Copilot Instructions for login-c-sharp

- [x] Clarify Project Requirements
- [x] Scaffold the Project
- [x] Customize the Project
- [ ] Install Required Extensions
- [ ] Compile the Project
- [ ] Create and Run Task
- [ ] Ensure Documentation is Complete

## Project Overview
Automated test framework for https://the-internet.herokuapp.com/login using C#, NUnit, and Playwright.

## Structure
- Tests: e2e/
- Page Objects: e2e/pages/

## Setup
1. Install .NET SDK
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

---

**Note:** Run browser install step after Playwright package updates.

# Login-C-Sharp

## Introduction by T.J. Maher

_Like this project? View sample code from the last ten years of T.J. Maher's automation development work at [TJMaher.com / Programming Projects](https://www.tjmaher.com/p/programming-projects.html) and his articles about software testing at [TJMaher.com / Media](https://www.tjmaher.com/p/media.html). And be sure to check out his [LinkedIn Profile](https://www.linkedin.com/in/tjmaher1/)!_ 

**The test:** Given a website, such as https://the-internet.herokuapp.com/login, can GitHub Copilot examine the website, and create through only prompting an automated test framework using C#, NUnit, and Playwright? 

Want to see what prompts were used for this site? The last section contains a summary used to create this project and its documentation, along with the actions Copilot executed. GitHub Copilot was with GPT-4.1, the free version. Only very few minor tweaks of this documentation and code below were needed, such as weird formating issues in YAML files, and new text in this README placed incorrectly. 

WARNING! Chat-GPT 4.1 has a cutoff date of two years ago. When creating a workflow, it did not realize that it was using a deprecated version of actions/upload-artifact (v3) causing the workflow to fail. Caveat emptor!

So, how did GitHub Copilot + Chat GPT do creating an automation framework? I would say it did so good that it was hideously frustrating when it messed up the simple things. 

It's like an eager-to-please junior dev who doesn't completely know the material and doesn't know it isn't reading the latest documentation. 

 Why would it not know it was implementing out-of-date libraries when creating the GitHub Actions Workflow? It was so sure it had everything correct until I copied-and-pasted the error I received from the GitHub Actions log files and fed the error back to it. 

 Why does it not read actual documentation? Why does it skip carefully enumerated steps? And why does it always profusely apologize to me while doing the same mistake over and over again? 

 I feel that it got me 80% there, but it was super frustrating needing to drag it bodily across the finish line. 

# GitHub CoPilot: Activate!

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

# Project Structure

The project is organized as follows:

- `e2e/` — Contains end-to-end tests
- `e2e/pages/` — Contains Page Object classes for test automation
- `.github/workflows/` — Contains GitHub Actions CI workflows
- `README.md` — Project documentation
- `.github/copilot-instructions.md` — Copilot instructions and checklist
- `login-c-sharp.csproj` — C# project file


# Tools and Technology

This project uses:

- **Microsoft Playwright**: Released in January 2020, Playwright is a modern browser automation tool developed by Microsoft. The Playwright C# plugin was created and is maintained by the Microsoft Playwright team. It enables .NET developers to use Playwright for browser automation and testing.

   - Official announcement: [Introducing Playwright for .NET](https://devblogs.microsoft.com/dotnet/introducing-playwright-for-net/)
   - Documentation: [Playwright .NET Docs](https://playwright.dev/dotnet/docs/intro)
   - Microsoft Tech Blog: [Playwright for .NET Announcement](https://devblogs.microsoft.com/dotnet/introducing-playwright-for-net/)

- **NUnit**: NUnit is a popular unit testing framework for .NET, first released in 2002. It was created by Charlie Poole and is maintained by the NUnit team. NUnit provides attributes and assertions for writing and running automated tests.
  - Official announcement: [NUnit 3 Release](https://nunit.org/news/nunit-3-release.html)
  - Documentation: [NUnit Documentation](https://docs.nunit.org/)
  - Project site: [NUnit.org](https://nunit.org/)

- **Allure**: Allure is a flexible, lightweight test reporting tool, first released in 2013. It was created by the Yandex team and is maintained by the Allure community. Allure integrates with many test frameworks and CI systems to provide rich, interactive reports.
  - Official announcement: [Allure Framework](https://github.com/allure-framework/allure2)
  - Documentation: [Allure Docs](https://docs.qameta.io/allure/)
  - Project site: [Allure Framework GitHub](https://github.com/allure-framework/allure2)


## Why Use NUnit?

NUnit is chosen for this project because it is mature, widely adopted, and integrates seamlessly with .NET and CI tools. It offers:
- Rich attribute-based test definitions
- Strong assertion library
- Parallel test execution
- Excellent IDE and CI integration
- Active community and documentation


### Why NUnit was chosen by GitHub Copilot
- More flexible test case and fixture setup than MSTest
- More mature and feature-rich than xUnit.net for complex scenarios
- Better support for parameterized tests and custom attributes
- Extensive documentation and community support
- Works well with Playwright and Allure reporting

### Alternatives
- [xUnit.net](https://xunit.net/): Released in 2007. A modern unit testing framework for .NET, designed for extensibility and community-driven development. It is known for its simple syntax and strong support for parallel test execution.
- [MSTest](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest): Released in 2005. Microsoft's official test framework for .NET, integrated with Visual Studio and Azure DevOps. MSTest is easy to use and well-supported in enterprise environments.
- [MbUnit](https://github.com/mbunit/mbunit): Released in 2004. An older, extensible unit testing framework for .NET, known for its advanced test generation and combinatorial testing features. Development is largely discontinued.
- [Fixie](https://fixie.github.io/): Released in 2013. A convention-based test framework for .NET, allowing developers to define their own test conventions and behaviors. It is lightweight and highly customizable.

# CI/ CD with GitHub Actions

## Brief History of GitHub Actions Workflows

GitHub Actions was announced by GitHub in 2018 as a new way to automate software workflows directly in repositories. It enables CI/CD, automation, and custom workflows using YAML files. GitHub Actions became generally available in November 2019, allowing developers to build, test, and deploy code with integrated automation.

- Official announcement: [GitHub Actions: Automate your workflow](https://github.blog/2018-10-17-robotic-workflows-github-actions/)
- General availability: [GitHub Actions is now generally available](https://github.blog/2019-11-13-github-actions-now-generally-available/)
- Documentation: [GitHub Actions Docs](https://docs.github.com/en/actions)

## Running GitHub Actions Workflow

The GitHub Actions workflow `playwright-tests` will run automatically:

- On every push to the `main` branch
- On every pull request targeting the `main` branch

To trigger the workflow manually:
1. Push your changes to GitHub:
   - `git push origin main`
2. Or create a pull request to `main`
3. The workflow will execute and generate Allure test reports in CI


# How GitHub Copilot Created This Project

### Prompts Used
- Create an automated test framework called "login-c-sharp". Tests will be in "login-c-sharp/e2e". Page Objects will be in "login-c-sharp/e2e/pages". It will be testing https://the-internet.herokuapp.com/login
- Continue with #new workspace setup
- We are using Playwright and C#.
- Verify the tests run
- Add to README how to setup development locally on 1) Windows 11 machine 2) On a Macbook
- Push this project to my Github.
- Create a GitHub Action workflow that runs automated tests, configured with Allure reports.
- Change it to playwright-tests.yml
- Have two stages for testing and then reporting.
- Add workflow_dispatch input for test_suite with smoke/all options
- Tag tests with [Category("Smoke")] and update workflow to filter by category
- Review and correct .NET target framework version

### Commands Executed
- `dotnet new nunit -o .`
- `dotnet add package NUnit`
- `dotnet add package Microsoft.Playwright`
- `dotnet tool install --global Microsoft.Playwright.CLI`
- `powershell bin/Debug/net10.0/playwright.ps1 install`
- `dotnet build`
- `dotnet test`
- `git init`
- `git add .`
- `git commit -m "Initial Playwright C# test framework setup"`
- Created .github/workflows/playwright-tests.yml (and renamed from playwright-allure.yml)
- Used GitHub Actions steps for checkout, setup-dotnet, install dependencies, install Playwright browsers, run tests, upload artifacts, generate Allure report
- Updated README.md and copilot-instructions.md

### How GitHub Copilot Added Allure Reports
GitHub Copilot added Allure reporting based on the prompt: "Create a GitHub Action workflow that runs automated tests, configured with Allure reports." Copilot used knowledge of common C# test reporting practices and public documentation for Allure, NUnit, and Playwright integration. It included:
- Adding Allure.Commons and NUnit.Allure packages to test dependencies
- Configuring test results output to the `allure-results` directory
- Using the `simple-elf/allure-report-action` GitHub Action to generate and upload Allure reports

This ensured the CI pipeline produces and publishes Allure test reports automatically.

### Documentation Prompts Used

The following prompts were used to generate and update project documentation:
- Add to README how to setup development locally on Windows 11 and Macbook
- Add a section documenting project structure
- Add a section "Tools and technology" that gives a brief history of the tool, date it was released
- Add information about the Playwright + C# plugin. Who created it. Add documentation links to announcements in Microsoft tech blogs
- Add the same for NUnit and Allure
- Why use NUnit? List other alternatives, and list why NUnit is better
- Provide links for all Alternatives and describe them
- Add the year these alternatives were released
- Add a section on browser test history and why Playwright supports multiple browsers
- Add documentation links for all workflow commands and actions
- Add instructions for running Allure reports locally
- Add Java setup and explanation for Allure CLI
- Add workflow_dispatch input for test_suite with smoke/all options
- Tag tests with [Category("Smoke")] and update workflow to filter by category
- Add troubleshooting and GitHub Pages setup instructions

## Allure Reporting for Multiple Browsers

- After suggested prompts, the CI workflow runs Playwright tests in parallel for Chromium, Firefox, and WebKit browsers. Each browser job generates its own Allure results. After all jobs complete, a final job merges the results and generates a unified Allure report. This report is then published to GitHub Pages, providing a single dashboard with results for all browsers.

- Each browser's results are labeled and merged for clarity.
- The Allure report is always available via GitHub Pages after each workflow run.

# Workflow Command Reference

Below are key commands used in the GitHub Actions workflow, with links to official documentation, per request of T.J. Maher:

- [`dotnet tool install --global Microsoft.Playwright.CLI`](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-install): Installs the Playwright CLI as a global .NET tool. See [Playwright .NET CLI Docs](https://playwright.dev/dotnet/docs/cli).
- [`playwright install`](https://playwright.dev/docs/cli#install): Installs Playwright browsers. See [Playwright Install Docs](https://playwright.dev/docs/installation#install-browsers).
- [`dotnet restore`](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-restore): Restores NuGet dependencies for the project.
- [`dotnet build`](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-build): Builds the .NET project.
- [`dotnet test`](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-test): Runs tests using the specified test framework.
- [`actions/setup-dotnet`](https://github.com/actions/setup-dotnet): GitHub Action to set up the .NET environment.
- [`actions/cache`](https://github.com/actions/cache): GitHub Action to cache dependencies.
- [`actions/upload-artifact`](https://github.com/actions/upload-artifact): Uploads test results and artifacts.
- [`simple-elf/allure-report-action`](https://github.com/simple-elf/allure-report-action): Generates Allure reports from test results.
- [`peaceiris/actions-gh-pages`](https://github.com/peaceiris/actions-gh-pages): Deploys the Allure report to GitHub Pages.

For more details, see the [GitHub Actions Documentation](https://docs.github.com/en/actions).

# GitHub Actions Used in Workflow

The following GitHub Actions are used in the CI workflow. Each automates a key step in the test and reporting pipeline:

- [`actions/checkout`](https://github.com/actions/checkout): Checks out your repository code so workflow jobs can access it.
- [`actions/setup-dotnet`](https://github.com/actions/setup-dotnet): Sets up the .NET environment for building and testing C# projects.
- [`actions/cache`](https://github.com/actions/cache): Caches dependencies (like NuGet packages) to speed up workflow runs.
- [`actions/upload-artifact`](https://github.com/actions/upload-artifact): Uploads test results and other files as artifacts for later jobs or download.
- [`actions/download-artifact`](https://github.com/actions/download-artifact): Downloads previously uploaded artifacts for use in subsequent jobs.
- [`simple-elf/allure-report-action`](https://github.com/simple-elf/allure-report-action): Generates Allure test reports from results.
- [`peaceiris/actions-gh-pages`](https://github.com/peaceiris/actions-gh-pages): Deploys the generated Allure report to GitHub Pages for public access.

Each action is documented in its linked repository, with usage instructions and configuration options.

# Workflow Runner Environment

The workflow uses `runs-on: ubuntu-latest` for its jobs. This specifies that each job will execute on a fresh virtual machine running the latest stable version of Ubuntu Linux provided by GitHub Actions.

- **Why use ubuntu-latest?**
  - It is the default and most widely supported runner for CI workflows.
  - Provides a consistent, up-to-date environment with pre-installed tools for .NET, Node.js, Python, and browser automation.
  - Ensures compatibility with Playwright, NUnit, and Allure reporting tools.
  - Offers fast startup times and broad community support.

For more details, see the [GitHub-hosted runners documentation](https://docs.github.com/en/actions/using-github-hosted-runners/about-github-hosted-runners).

# How Playwright Supports Multiple Browsers

Playwright was designed to enable reliable end-to-end testing across all major browser engines—Chromium, Firefox, and WebKit. By supporting these browsers, Playwright ensures that web applications are tested for compatibility, performance, and correctness in environments used by real users worldwide.

- **Cross-browser coverage**: Testing in Chromium, Firefox, and WebKit helps catch issues that may only appear in specific engines, improving quality and user experience.
- **Web standards compliance**: Each browser implements web standards differently. Playwright’s multi-browser support helps developers verify their apps work as intended everywhere.
- **Mobile and desktop parity**: WebKit powers Safari on iOS, Chromium powers Chrome and Edge, and Firefox is widely used on desktop and mobile. Playwright’s support covers both desktop and mobile platforms.

For more details, see:
- [Playwright Browser Support](https://playwright.dev/docs/browsers)
- [Playwright Announcement Blog](https://playwright.dev/blog/introducing-playwright)

# Brief History of Browsers Built into Playwright

- **Chromium**: Released in 2008 by Google, Chromium is the open-source project that powers Google Chrome and Microsoft Edge. It is known for its speed, security, and developer tools. [Chromium Project](https://www.chromium.org/) | [Chromium Wikipedia](https://en.wikipedia.org/wiki/Chromium_(web_browser))

- **Firefox**: First released in 2004 by Mozilla, Firefox is a free and open-source browser recognized for its privacy features, extensibility, and strong web standards support. [Mozilla Firefox](https://www.mozilla.org/en-US/firefox/new/) | [Firefox Wikipedia](https://en.wikipedia.org/wiki/Firefox)

- **WebKit**: Originally developed by Apple in 2003, WebKit is the engine behind Safari and many mobile browsers. It is known for its performance and wide adoption in the mobile ecosystem. [WebKit Project](https://webkit.org/) | [WebKit Wikipedia](https://en.wikipedia.org/wiki/WebKit)

# Java Setup in Workflow

The workflow uses:
- `distribution: 'temurin'`: Specifies the Temurin distribution of OpenJDK, a popular, open-source Java runtime maintained by the Eclipse Adoptium project. [Temurin Documentation](https://adoptium.net/temurin/)
- `java-version: '17'`: Installs Java 17, a long-term support (LTS) version of the Java platform. [Java 17 Release Notes](https://www.oracle.com/java/technologies/javase/17-relnote-issues.html)

This setup is required for running Allure CLI, which generates test reports from results.

For more details, see:
- [actions/setup-java GitHub Action](https://github.com/actions/setup-java)
- [Allure CLI Documentation](https://docs.qameta.io/allure/#_installing_a_commandline)

# 🧪 SeleniumSpecflowFramework

**Professional Selenium + SpecFlow + MSTest UI Automation Framework (.NET 8)**  
A clean, scalable, and maintainable UI automation framework built with enterprise practices.

---

## 📌 1. Project Setup in Visual Studio

### 🔧 Prerequisites:
- ✅ Windows 10/11
- ✅ [Visual Studio 2022+](https://visualstudio.microsoft.com/vs/) with:
  - ".NET desktop development"
  - ".NET 8 SDK"
  - "Test Tools Core Features"

---

### 🛠 Step-by-Step Setup

1. **Open Visual Studio**
2. Click: `Create a new project`
3. Choose: `Class Library (.NET)`
4. Name your project: `SeleniumSpecflowFramework`
5. Choose Framework: `.NET 8.0 (Long-Term Support)`
6. Create the solution

---

## 📁 2. Folder Structure Design

Once the project is created, organize your folders as:

Selenium
├── StepDefinitions/ # SpecFlow step implementations
├── Pages/ # Page Object Model (POM) classes
├── Drivers/ # WebDriver and browser setup
├── Helpers/ # Utilities, waiters, config readers
├── Hooks/ # BeforeScenario, AfterScenario logic
├── TestData/ # Test input files (JSON, XML)
├── Reports/ # ExtentReports & screenshots
└── SeleniumSpecflowFramework.csproj



> ℹ️ This modular structure mirrors professional QA automation practices.

---

## 📦 3. Install Required NuGet Packages

In Visual Studio:

1. Right-click on the **project** → `Manage NuGet Packages`
2. Install the following under the **Browse** tab:

```plaintext
Selenium.WebDriver
Selenium.Support
Selenium.WebDriver.ChromeDriver
SpecFlow
SpecFlow.MSTest
SpecFlow.Tools.MsBuild.Generation
MSTest.TestFramework

These packages enable BDD test writing, execution, and browser control.

🧪 4. Run Tests via Visual Studio
Open Test Explorer → Run all or selected tests

Or right-click on → Run SpecFlow Scenarios.feature

Tag-based execution supported (e.g., @Smoke, @Regression)

🌐 5. Upload Framework to GitHub (Feature Branch Workflow)
🔄 Steps using Visual Studio Git Integration:
Click Git → Create Git Repository

Set remote GitHub URL

Select Add solution to source control

Create Feature Branch

From bottom-left Git panel or Git > New Branch

Example: feature/login-tests

Push Code to GitHub

Open Git Changes tab

Add commit message → Commit All

Click Push

Create Pull Request (PR)

Go to GitHub → New Pull Request from feature/... to main

Add title, description, and reviewers

Code Review & Merge

After review, merge PR into main

GitHub automatically updates the main branch

✅ Your folder structure and framework are now versioned and live on GitHub.


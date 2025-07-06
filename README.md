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
Cell
├── Drivers/ # WebDriver and browser setup
├── Helpers/ # Utilities, waiters, config readers
├── Hooks/ # [BeforeScenario], [AfterScenario] setup/teardown
├── TestData/ # Test input files (.resx, JSON, XML)
├── Reports/ # ExtentReports & screenshots
└── SeleniumSpecflowFramework.csproj


> ℹ️ This modular structure mirrors professional QA automation practices.

## 📦 3. Install Required NuGet Packages

In Visual Studio:

1. Right-click on the **project** → `Manage NuGet Packages`
2. Install the following under the **Browse** tab:

Selenium.WebDriver
Selenium.Support
Selenium.WebDriver.ChromeDriver
SpecFlow
SpecFlow.MSTest
SpecFlow.Tools.MsBuild.Generation
MSTest.TestFramework


These packages enable BDD-style test writing, MSTest execution, and browser automation with Selenium.

---

## 🧪 4. Run Tests via Visual Studio

- Open **Test Explorer** → Run all or selected tests
- Or right-click on any `.feature` file → Select **Run SpecFlow Scenarios**
- Supports tag-based execution (e.g., `@Smoke`, `@Regression`, `@Login`)

### ✅ Tips:
- Ensure `SpecFlow.MSTest` is properly installed.
- Use `[BeforeScenario]`, `[AfterScenario]` in `Hooks` to manage driver lifecycle.
- Reports (e.g., ExtentReports) can be configured to generate HTML output under `Reports/`.

---

## 🌐 5. Upload Framework to GitHub (Feature Branch Workflow)

### 🔄 Steps using Visual Studio Git Integration:

1. **Initialize Git Repository**
   - Click `Git` > `Create Git Repository`
   - Choose "GitHub" and log in if prompted
   - Enter repo name, description (optional), and visibility
   - Select "Add solution to source control"

2. **Create a Feature Branch**
   - Click `Git` (bottom left of Visual Studio) > `New Branch`
   - Example: `feature/login-tests`
   - Make your changes: add feature files, page classes, step definitions, etc.

3. **Push Code to GitHub**
   - Go to `Git Changes` tab
   - Add a commit message → Click `Commit All`
   - Click `Push` to send changes to your remote feature branch

4. **Create Pull Request (PR)**
   - Go to [github.com](https://github.com)
   - Navigate to your repo → Click **Compare & Pull Request**
   - Set base = `main`, compare = your `feature/...` branch
   - Add PR title, description, and assign reviewers if needed

5. **Review and Merge**
   - After review, click **Merge Pull Request**
   - Optionally delete the feature branch after merging

✅ Your professional automation framework is now versioned and maintained on GitHub.

---

## 🧩 Optional Add-ons

- 🔧 Add `TestData.resx` for centralized test data (URL, credentials, etc.)
- 📸 Add screenshot logic in `[AfterScenario]` hook for failure tracking
- 📊 Integrate ExtentReports or Allure for rich HTML reporting
- ⚙️ Add dynamic browser selection from config

---

Happy Testing!  
⭐ Star this repository if you found it useful.




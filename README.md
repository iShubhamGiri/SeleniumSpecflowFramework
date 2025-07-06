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

## 🧪 4. Run Tests via Visual Studio

- Open **Test Explorer** → Run all or selected tests
- Or right-click on any `.feature` file → Select **Run SpecFlow Scenarios**
- Supports tag-based execution (e.g., `@Smoke`, `@Regression`, `@Login`)

### ✅ Tips:
- Ensure `SpecFlow.MSTest` is properly installed.
- Use `[BeforeScenario]`, `[AfterScenario]` in `Hooks` to manage driver lifecycle.
- Reports (like ExtentReports) can be generated in the `Reports/` folder.

---

## 🌐 5. Upload Framework to GitHub (Feature Branch Workflow)

### 🔄 Steps using Visual Studio Git Integration:

1. **Initialize Git Repository**
   - Click `Git` > `Create Git Repository`
   - Enter GitHub remote URL (or create new repo)
   - Select "Add solution to source control"

2. **Create a Feature Branch**
   - Click `Git` (bottom left) > `New Branch`
   - Example name: `feature/login-tests`
   - Make changes, add your `.feature` and automation code

3. **Push Code to GitHub**
   - Go to `Git Changes` tab
   - Write a commit message → Click `Commit All`
   - Click `Push` to send to remote branch

4. **Create Pull Request (PR)**
   - On GitHub → Open your repo → Click **Compare & Pull Request**
   - Ensure base is `main` and compare is your `feature/...` branch
   - Add title, description, and assign reviewers if needed

5. **Review and Merge**
   - After code review and approval, click **Merge Pull Request**
   - Delete the feature branch after merge (optional but clean)

✅ Now your framework is updated and merged to the `main` branch on GitHub with the full folder structure and test setup.



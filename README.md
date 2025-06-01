# 🧑‍💼 Employee Management System – ASP.NET Core MVC

A simple Employee Management System built with **ASP.NET Core MVC**, demonstrating enterprise-level practices such as:

- ✅ Entity Framework Core
- ✅ Repository Pattern
- ✅ Authentication & Role-Based Authorization (Admin & Employee)
- ✅ MVC Structure (No Razor Pages)
- ✅ SQL Server Backend
- ✅ Global Resource File Support (`.resx`)
- ✅ Profile Image Upload Support

---

## 📌 Features

- **Login System** for Admin and Employee
- **Role-based access**:
  - Employees can **view only their own details**
  - Admins can **view and manage** all employees
- CRUD operations for Employees and Departments
- Global `.resx` file for localizable text
- Clean separation of concerns using **Repository Pattern**
- MVC architecture with views (not Razor Pages)

---

## 🛠️ Tech Stack

| Layer         | Technology                         |
|---------------|-------------------------------------|
| Frontend      | ASP.NET Core MVC                   |
| Backend       | .NET Core 6+                       |
| Database      | SQL Server + Entity Framework Core |
| Authentication| Custom Forms/Login Auth            |
| Authorization | Session + Custom Role Checks       |
| Architecture  | MVC + Repository Pattern           |

---

## 🗂️ Project Structure
EmployeeManagement/
EmployeeManagement.Web/
├── Controllers/
│   └── EmployeeController.cs
├── Models/
│   └── Employee.cs
├── Views/
│   ├── Employee/
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   ├── Delete.cshtml
│   │   └── Index.cshtml
│   └── Shared/
│       ├── _Layout.cshtml
│       └── _ValidationScriptsPartial.cshtml
├── wwwroot/
│   ├── css/
│   │   └── site.css
│   ├── js/
│   │   └── site.js
│   └── lib/
│       └── bootstrap/
├── appsettings.json
├── Program.cs
└── Startup.cs


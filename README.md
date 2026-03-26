# Restaurant Management System

A complete desktop application built with C# (Windows Forms) that manages restaurant operations – from table floor plans and kitchen orders to staff management and sales reports. Uses XML serialization for data persistence.

## Features

### 🏠 Dashboard & Floor Plan
- **DashboardForm** – overview of income, expenses, and key metrics.
- **FloorPlanForm** – visual layout of tables; assign orders to tables.

### 🧾 Point of Sale (POS)
- **POSForm** – main order entry screen for cashiers.
- **PaymentDialog** – process payments, split bills, etc.
- Supports dine‑in, takeaway, delivery.

### 👩‍🍳 Kitchen Management
- **KitchenForm** – displays orders waiting to be prepared.
- **KitchenOrderManager** – tracks order status (pending, cooking, ready).

### 📦 Product & Inventory
- **Product**, **ProductStorage** – manage menu items, prices, stock.
- **ProductAddEditForm**, **productsForm** – UI for adding/editing products.

### 👥 Staff Management
- **StaffMember**, **StaffStorage** – handle employee records.
- **StaffForm**, **StaffAddEditForm** – manage staff accounts and roles.

### 🪑 Table Management
- **Table**, **TableStorage** – table data (capacity, status).
- **Tables**, **TableAddEditForm** – assign tables and track occupancy.

### 📊 Reports & Statistics
- **ReportsForm** – generate sales, inventory, staff reports.
- **StatisticsForm** – interactive charts (income/expense trends, category breakdown).
- **Export to CSV** – save reports as CSV files.

### ⚙️ Settings
- **Settings**, **SettingsStorage** – configure tax, discounts, receipt format.
- **frmSettings** – user interface for system settings.

### 🔐 Login & Security
- **login** – role‑based authentication (cashier / admin).

## Technologies Used
- **C#** – core logic, LINQ, event handling.
- **.NET Framework / .NET Core** – application framework.
- **Windows Forms** – GUI.
- **XML Serialization** – persistent storage (using `OrderStorage`, `ProductStorage`, `TableStorage`, etc.).

## How to Run
1. Clone the repository:  
   `git clone https://github.com/RohmaNadeem/RestaurantManagementSystem.git`
2. Open the solution in Visual Studio (`.sln` or `.slnx`).
3. Build and run (F5).  
   *Requires .NET desktop development workload.*

## Default Login Credentials

| Role     | Username | Password  |
|----------|----------|----------|
| Cashier  | cashier  | cashier123 |
| Admin    | admin    | admin123  |

*Credentials can be changed in the XML data files.*

## Project Structure

```plaintext
RestaurantManagementSystem/
├── Forms/
│   ├── login.cs
│   ├── DashboardForm.cs
│   ├── FloorPlanForm.cs
│   ├── frmMain.cs
│   ├── frmSettings.cs
│   ├── KitchenForm.cs
│   ├── POSForm.cs
│   ├── PaymentDialog.cs
│   ├── productsForm.cs
│   ├── ProductAddEditForm.cs
│   ├── ReportsForm.cs
│   ├── StatisticsForm.cs
│   ├── StaffForm.cs
│   ├── StaffAddEditForm.cs
│   ├── Tables.cs
│   └── TableAddEditForm.cs
├── Classes/Models/
│   ├── Order.cs
│   ├── Product.cs
│   ├── StaffMember.cs
│   ├── Table.cs
│   └── Settings.cs
├── Storage/
│   ├── OrderStorage.cs
│   ├── ProductStorage.cs
│   ├── StaffStorage.cs
│   ├── TableStorage.cs
│   └── SettingsStorage.cs
├── Helpers/
│   └── KitchenOrderManager.cs
└── Program.cs
```
## Screenshots

<img width="1254" height="777" alt="image" src="https://github.com/user-attachments/assets/acaa110d-ce52-477b-9b33-a0df7ab92539" />
<img width="1919" height="1198" alt="image" src="https://github.com/user-attachments/assets/8ede587b-ada4-4bcc-bb1e-fbe0dab1b116" />
<img width="961" height="685" alt="image" src="https://github.com/user-attachments/assets/85de888d-5577-4fbe-81e6-264b515d397c" />
<img width="1916" height="1199" alt="image" src="https://github.com/user-attachments/assets/83f2db6a-db49-42fd-b3f7-74deab901b30" />
<img width="1916" height="1199" alt="image" src="https://github.com/user-attachments/assets/2a832164-d7d3-42b5-a96d-10c3354b2196" />

## Future Enhancements
- Integrate a database (SQL Server / SQLite) for scalability.
- Real‑time kitchen notifications.
- Cloud sync for multi‑branch support.

## Acknowledgements
- Developed as a 2nd semester project at SSUET.
- Built to emulate real‑world restaurant management systems.

## Connect with Me
- [LinkedIn](https://www.linkedin.com/in/rohma-nadeem-25b041382/)
- [GitHub](https://github.com/RohmaNadeem)

# Simple Inventory Management System

## Overview
This is a **C# console application** that serves as a simple inventory management system for a retail store. The system allows users to **add, remove, update, and list products**, as well as calculate the total value of the inventory.

## Features
- **Add Product**: Allows users to add new products to the inventory.
- **Remove Product**: Removes a product from the inventory using its unique ID.
- **Update Product**: Updates the quantity of an existing product.
- **List Products**: Displays all products currently in inventory.
- **Get Total Value**: Calculates and displays the total monetary value of the inventory.

## Technologies Used
- **C#** (Console Application)
- **.NET Core**

## Installation & Setup
### 1. Clone the repository
```sh
git clone https://github.com/Jasonyecyec/elinnov_assesment.git
cd elinnov_assesment
```

### 2. Compile and Run
You can run the project using the **.NET CLI**:
```sh
dotnet run
```
Alternatively, open the solution in **Visual Studio** and press `F5` to run the application.

## Usage
Upon running the application, a menu will appear:
```sh
Inventory Management System
1️⃣. Add Product
2️⃣. Remove Product
3️⃣. Update Product
4️⃣. List Products
5️⃣. Get Total Inventory Value
6️⃣. Exit
Enter choice:
```
- Enter the corresponding number to perform an action.
- Follow the on-screen prompts to provide product details.
- The system ensures data validation to prevent negative values.

## Screenshots
![image](https://github.com/user-attachments/assets/6d936869-4e6d-475e-b0ea-f874284b9236)
![image](https://github.com/user-attachments/assets/db54e89e-0315-4ac2-8364-2f0c4b35c028)
![image](https://github.com/user-attachments/assets/0c551b09-0ae6-4072-868a-66de57e78c30)


## Code Documentation
- The application follows **object-oriented programming (OOP)** principles.
- It consists of two main classes:
  1. **Product** (Holds product details such as ID, name, quantity, and price)
  2. **InventoryManager** (Manages the list of products and provides CRUD operations)
- **Validation** is implemented to ensure proper data entry.

## Folder Structure
```
📂 InventoryManagementSystem
 ├── 📄 Program.cs (Main entry point)
 ├── 📄 Product.cs (Product class)
 ├── 📄 InventoryManager.cs (Inventory logic)
 ├── 📄 README.md (This file)
```



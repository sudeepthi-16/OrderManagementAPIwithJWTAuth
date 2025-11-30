# Order Management API with JWTAuth

This project is a Secure Order Management System API built using:
ASP.NET Core Web API
Entity Framework Core
ASP.NET Core Identity
JWT Authentication
SQL Server

Users must register and login to access protected endpoints.
Authenticated users can perform full CRUD operations on their own orders.

📦 Features
🔐 Authentication (JWT + Identity)
User Registration
User Login
JWT Token Generation
Protected Order APIs using [Authorize]

📄 Order Management (CRUD)
Each order includes:
ProductName
Quantity
UnitPrice
TotalPrice (auto-calculated)
UserName (owner)


**🧱 Project Structure**

<img width="838" height="865" alt="OrderManagementAPI Project Structure" src="https://github.com/user-attachments/assets/3f4a4183-b1da-45ef-b33f-22fcf324ae06" />


**AUTH Register API:**

<img width="1905" height="1070" alt="Auth Register API" src="https://github.com/user-attachments/assets/00cc0004-b3dd-4028-9afa-179182e3e986" />

**AUTH Login API(Token Generated):**
<img width="1918" height="1056" alt="Auth Login (Token Generated)" src="https://github.com/user-attachments/assets/9b57d462-90da-474b-ae3f-59e3791d9cfe" />

**⚠️ 401 UnAuthorized Call:**
<img width="1907" height="1064" alt="401 unAuthorized call Test" src="https://github.com/user-attachments/assets/6509fbd6-68ac-4b08-a8a1-4ce7dbf920e1" />

**JWT Token Entered For Auth:**
<img width="1803" height="999" alt="JWT Token Entered for Auth" src="https://github.com/user-attachments/assets/53607721-18bb-4967-ad8f-d203dab9b657" />

**ORDERS GET API:**
<img width="1919" height="1074" alt="Orders GET API" src="https://github.com/user-attachments/assets/fbed21e9-07f4-4681-859d-06f5a8e22407" />

**ORDERS PUT API (Quantity updated to 2 => Total price changes automatically):**
<img width="1919" height="1056" alt="Orders PUT API" src="https://github.com/user-attachments/assets/0fe896ad-9403-4b0f-a6d9-ff164d16d03a" />

**ORDERS POST API:**
<img width="1918" height="1066" alt="Orders POST API" src="https://github.com/user-attachments/assets/71ff1ec5-fcb8-417e-ae24-aae50f01df20" />

**ORDERS Delete API:**
<img width="1919" height="1049" alt="Orders Delete API" src="https://github.com/user-attachments/assets/4758f10d-5a88-4544-9290-652eb0ff7431" />


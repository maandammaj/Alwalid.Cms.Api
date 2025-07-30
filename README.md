# **Alwalid.CMS API Project Documentation**  

## **📌 Overview**  
This project is a **Content Management System (CMS) API** built with:  
- **ASP.NET Core** (for API development)  
- **Entity Framework Core** (for database operations)  
- **JWT Authentication** (for secure access)  
- **Swagger UI** (for API documentation)  

### **🔹 Purpose**  
A flexible CMS backend that can be used for:  
✔ Websites  
✔ Admin dashboards  
✔ Blogs or E-commerce platforms  

---

## **⚙️ Setup & Installation**  

### **Prerequisites**  
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download)  
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)  
- A database (e.g., **SQL Server**, **MySQL**, or **PostgreSQL**)  

### **Installation Steps**  
1. **Clone the repository**:  
   ```bash
   git clone https://github.com/maandammaj/Alwalid.Cms.Api.git
   cd Alwalid.Cms.Api
   ```
2. **Restore dependencies**:  
   ```bash
   dotnet restore
   ```
3. **Configure the database** in `appsettings.json`:  
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER;Database=AlwalidCMS;User=YOUR_USER;Password=YOUR_PASSWORD;"
   }
   ```
4. **Apply database migrations**:  
   ```bash
   dotnet ef database update
   ```
5. **Run the project**:  
   ```bash
   dotnet run
   ```
6. **Access Swagger UI**:  
   Open `https://localhost:5001/swagger` to explore API endpoints.  

---

## **📂 Project Structure**  
| File/Folder | Description |
|-------------|------------|
| **`Controllers/`** | API controllers (e.g., `AuthController`, `PostsController`). |
| **`Models/`** | Entity classes (e.g., `User`, `Post`, `Category`). |
| **`Data/`** | Database context and configurations. |
| **`DTOs/`** | Data Transfer Objects (request/response models). |
| **`Services/`** | Business logic (e.g., `AuthService`, `PostService`). |
| **`appsettings.json`** | Configuration (database, JWT, logging). |

---

## **🔐 Authentication (JWT)**  
The API uses **JWT (JSON Web Tokens)** for secure access.  
- **`POST /api/Auth/register`** → User registration.  
- **`POST /api/Auth/login`** → User login (returns JWT token).  

### **Example Login Request:**  
```http
POST /api/Auth/login
Content-Type: application/json

{
  "username": "admin",
  "password": "123456"
}
```

---

## **📝 Key API Endpoints**  
| Endpoint | Description | Method |
|----------|-------------|--------|
| **`/api/Posts`** | CRUD operations for blog posts. | GET, POST, PUT, DELETE |
| **`/api/Categories`** | Manage post categories. | GET, POST, PUT, DELETE |
| **`/api/Users`** | User management (admin-only). | GET, POST, PUT, DELETE |

---

## **🛠️ How to Contribute**  
1. **Open an Issue** to report bugs or suggest improvements.  
2. **Fork & Submit a PR** to add new features.  
3. **Improve documentation** if needed.  

---

## **🔎 Conclusion**  
✅ **A fully functional CMS API.**  
✅ **Secure JWT authentication.**  
✅ **Easy setup with Swagger support.**  
✅ **Extensible (can add comments, media uploads, etc.).**  

🚀 **Need more details? Ask me anything!**

# 🎪 Simple ASP.NET Web API – Camps & Students Controllers

A simple ASP.NET Web API project that demonstrates how to build basic controllers and RESTful endpoints using in-memory data storage.  
This project is intended for learning purposes and understanding API fundamentals before integrating a real database.

## ✨ Features
- Manage camps using RESTful endpoints
- Manage students using RESTful endpoints
- Simple CRUD-style operations (GET, POST, DELETE)
- Uses in-memory lists instead of a database
- Clean and beginner-friendly structure

## 🛠 Technologies Used
- Language: C#
- Framework: ASP.NET Web API , POSTMAN
- Architecture: RESTful API
- Storage: In-Memory Data (List<string>)
 ---
## 🎪 CampsController
CampsController is responsible for managing camps inside the API.  
All operations related to adding, retrieving, and deleting camps are handled through this controller.

### Available Endpoints
#### GET /api/camps  
Returns all camps stored in memory.  
If no camps exist, an empty list is returned.

#### POST /api/camps  
Accepts a camp name (string) from the request body and adds it to the list.  
Returns a confirmation message:
Added camp: <camp name>

#### DELETE /api/camps/{campName}  
Deletes a camp by its name.  
If the camp exists, it is removed successfully.  
If the camp does not exist, a NotFound response is returned.

### CampsController Notes
- Uses List<string> as a temporary data store
- Data is lost when the application restarts
- Designed for simplicity and learning
---

## 🎓 StudentsController
StudentsController is responsible for managing students inside the API.  
It follows the same logic and structure as CampsController but operates on student data.

### Available Endpoints
#### GET /api/students  
Returns all students stored in memory.

#### POST /api/students  
Accepts a student name (string) from the request body and adds it to the list.  
Returns a confirmation message:
Added student: <student name>

#### DELETE /api/students/{studentName}  
Deletes a student by name.  
If the student exists, it is removed successfully.  
If the student does not exist, a NotFound response is returned.

### StudentsController Notes
- Uses in-memory storage only
- No relationship between students and camps
- Each controller manages its own data independently
---

## 📊 Controllers Comparison
CampsController manages camp names and supports GET, POST, and DELETE operations to handle camps.  
StudentsController manages student names and supports GET, POST, and DELETE operations to handle students.

---
## 🎯 Project Purpose
- Learn how ASP.NET Web API controllers work
- Practice building RESTful endpoints
- Understand routing and request handling
- Prepare for future integration with a real database such as SQL Server or Entity Framework Core

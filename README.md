# API Rest .Net core 6 database memory project
Bibliothèque API
![image](https://github.com/Osiris-ouaga/API-Rest-.Net-core-6-database-memory-project/assets/54855716/0ec06143-f57e-426b-a641-10f3ae52154d)
![image](https://github.com/Osiris-ouaga/API-Rest-.Net-core-6-database-memory-project/assets/54855716/58452a60-1c4a-4660-ad3f-607818a162db)
Bibliothèque API is a .NET Core-based web API for managing users and books in a library system. The API provides endpoints for retrieving, adding, updating, and deleting user and book information. It is designed to be a robust backend for a library management system.

Table of Contents
Introduction
Features
Getting Started
Prerequisites
Installation
Usage
User Controller
Book Controller
API Documentation
Contributing
License
Introduction
The Bibliothèque API is developed using .NET Core and offers a RESTful interface for managing users and books in a library. It includes controllers for handling user-related operations, such as fetching user information, and book-related operations, such as adding new books to the library.

Features
User Controller:

Retrieve a list of users
Retrieve a specific user by ID
Add a new user
Update user information
Delete a user
Book Controller:

Retrieve a list of books
Retrieve a specific book by ID
Add a new book
Update book information
Delete a book
Getting Started
Prerequisites
Ensure you have the following prerequisites installed:

.NET SDK
Installation
Clone the repository: git clone https://github.com/yourusername/bibliotheque-api.git
Navigate to the project directory: cd bibliotheque-api
Run the application: dotnet run
Usage
User Controller
The User Controller provides endpoints for managing user information.

Get Users:

Endpoint: /api/user
Method: GET
Retrieve a list of users.
Get User by ID:

Endpoint: /api/user/{id}
Method: GET
Retrieve a specific user by ID.
Add User:

Endpoint: /api/user
Method: POST
Add a new user.
Update User:

Endpoint: /api/user
Method: PUT
Update user information.
Delete User:

Endpoint: /api/user
Method: DELETE
Delete a user by ID.
Book Controller
The Book Controller provides endpoints for managing book information.

Get Books:

Endpoint: /api/maroute/book/monget/mongetget
Method: GET
Retrieve a list of books.
Get Book by ID:

Endpoint: /api/maroute/book/{id}
Method: GET
Retrieve a specific book by ID.
Add Book:

Endpoint: /api/maroute/book
Method: POST
Add a new book.
Update Book:

Endpoint: /api/maroute/book
Method: PUT
Update book information.
Delete Book:

Endpoint: /api/maroute/book
Method: DELETE
Delete a book by ID.
API Documentation
Detailed documentation for each API endpoint, including request and response examples, can be found in the source code comments.

Contributing
If you would like to contribute to the project, please follow our Contribution Guidelines.

License
This project is licensed under the MIT License.



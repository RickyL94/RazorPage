# Product Management App

This is a simple web application for managing products. It allows users to add products to a database and view the list of products.

## Features

- **Database Link:** The database connection is configured in the `Program.cs` file.
- **SQL Database Communication:** The application communicates with a SQL database to store and retrieve product data.
- **Add Products:** Users can add new products to the database.
- **Show Products:** Users can view the list of products stored in the database.
- **MVC Framework:** The code is organised using the Model-View-Controller (MVC) architecture for better maintainability and separation of concerns.

## Setup Instructions

1. **Database Configuration:**
   - Make sure you have a SQL database set up.

2. **Running the Application:**
   - Build and run the application.
   - Navigate to the `/ProductForms/AddProduct` page to add new products.
   - Navigate to the home page or `/ProductForms/DisplayProduct` page to view the list of products.

## Project Structure

- **Models:** Contains the `ProductModel.cs` class representing the product entity.
- **Data:** Contains the `ProductContext.cs` class for database interactions.
- **Pages:** Contains Razor Pages for various functionalities.
  - `AddProduct.cshtml`: Page for adding new products.
  - `AddProductModel.cs`: Page model for handling product addition.
  - `DisplayProduct.cshtml`: Page for adding new products.
  - `DisplayProduct.cs`: Page model for handling product addition.

## Technologies Used

- ASP.NET Core Razor Pages
- Entity Framework Core (for database access)
- Dapper (for database communication)
- Bootstrap

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

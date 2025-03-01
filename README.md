# E-Commerce Project

## 📌 Overview
This is an **ASP.NET Core MVC** e-commerce application that allows users to browse products, add them to a cart, and place orders. The project includes product listing, order management, and user order history functionality.

## 🚀 Features
- **Product Listing** (GET /Products) - Fetch and display all available products.
- **Add to Cart** - Users can add products to their cart.
- **View Cart** - Display items added to the cart with a total price.
- **Place Order** - Users can submit their cart as an order.
- **Order History** (GET /Orders/{userId}) - View past orders with details.

## 🛠️ Technologies Used
- **Backend:** ASP.NET Core MVC
- **Frontend:** Razor Views (HTML, CSS, Bootstrap)
- **Database:** In-Memory Data Layer (Can be extended to SQL Server, MySQL, etc.)
- **Dependency Injection:** Built-in ASP.NET Core DI

## 🔧 Installation & Setup
1. **Clone the repository:**
   ```sh
   git clone https://github.com/yourusername/ecommerce-project.git
   cd ecommerce-project
   ```
2. **Run the application:**
   ```sh
   dotnet run
   ```
3. Open your browser and navigate to:
   - **Products Page:** `http://localhost:5000/Product/ProductListing`
   - **Cart Page:** `http://localhost:5000/Order/Cart`
   - **Order History:** `http://localhost:5000/Order/OrdersHistory`

## 📂 Project Structure
```
ECommerceProject/
│── Controllers/
│   ├── HomeController.cs     # Home
│   ├── ProductController.cs  # Handles product listing
│   ├── OrderController.cs    # Handles cart & orders
│
│── Models/
│   ├── Product.cs            # Product model
│   ├── CartItem.cs           # Cart item model
│   ├── Order.cs              # Order model
│   ├── OrderDetails.cs       # Order details model
│   ├── CartViewModel.cs      # Cart view model
│   ├── OrderViewModel.cs     # Order view model
│   ├── User.cs               # User model
│ 
│
│── Views/
│   ├── Home/Index.cshtml  # Home page
│   ├── Product/ProductListing.cshtml     # Product listing page
│   ├── Order/Cart.cshtml     # Cart view page
│   ├── Order/OrderForm.cshtml     # Form to add product to the cart
│   ├── Order/OrdersHistory.cshtml  # Order history page
│
│── _Layout.cshtml            # Main layout (navbar, styling)
│── Program.cs                # Application entry point
│── appsettings.json          # Configuration settings
```




## 🎯 Future Enhancements
- 🛒 Implement user authentication
- 📦 Integrate a real database (SQL Server, MySQL, or MongoDB)
- 💳 Add payment gateway integration
- 📊 Admin panel for order & product management

---

### 👨‍💻 Developed by **Turki Aloufi**
📧 Contact: turkialoufi44@gmail.com  
🌐 GitHub: [yourgithub](https://github.com/turki-aloufi)  
🚀 Happy Coding! 🎉


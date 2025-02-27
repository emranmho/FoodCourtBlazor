# Foodcourt

Foodcourt is a web application that allows users to place orders, make payments, and manage food-related transactions in an online food court. This project showcases the use of modern web technologies, including Blazor, ASP.NET, and PostgreSQL, with role-based authentication (RBAC) and integrated payment functionality using Stripe.

## Features

- **User Authentication**: 
  - Users can register and log in using .NET Identity for secure access.
  - Supports role-based authentication (RBAC) for managing user permissions (Admin, User, etc.).

- **Order Management**:
  - Users can place food orders and view their order history.
  - Admins can view and manage all orders.

- **Payment Integration**:
  - Stripe integration for secure payments.
  - Users can make payments for their orders via Stripe.

- **Role-based Access Control (RBAC)**:
  - Different roles with varying levels of access.
  - Admins have the ability to manage orders, users, and other admin functionalities.

- **Database**:
  - PostgreSQL is used for storing user data, orders, and payment details.
  - Neon is used to manage the PostgreSQL database.

## Tech Stack

- **Frontend**: Blazor (WebAssembly)
- **Backend**: ASP.NET Core
- **Database**: PostgreSQL (managed using Neon)
- **Authentication**: .NET Identity (Role-based authentication)
- **Payment Gateway**: Stripe

## Getting Started

### Prerequisites

To run this project locally, you will need:

- .NET SDK (preferably version 6.0 or higher)
- PostgreSQL (using Neon for cloud database)
- Stripe account (for payment functionality)


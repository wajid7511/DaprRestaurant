
# DaprRestaurant

This repository contains the DaprRestaurant project, a microservices-based application designed to demonstrate the use of [Dapr](https://dapr.io/) (Distributed Application Runtime) in building scalable and resilient restaurant management systems.

## Features

- **Microservices Architecture**: The application is divided into multiple microservices, each responsible for a specific business function.
- **Dapr Integration**: Leverages Dapr for service-to-service communication, state management, pub/sub messaging, and observability.
- **ASP.NET Core**: Built using ASP.NET Core, ensuring a robust and scalable application.
- **Docker Support**: The project includes Docker support for easy deployment and scaling.
- **Service Invocation**: Services communicate with each other using Dapr's service invocation feature.
- **State Management**: Uses Dapr's state management to handle application state in a distributed environment.
- **Pub/Sub Messaging**: Implements pub/sub messaging for event-driven communication between services.

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/get-started)
- [Dapr CLI](https://docs.dapr.io/getting-started/install-dapr-cli/)

## Getting Started

1. **Clone the repository**:
   ```bash
   git clone https://github.com/wajid7511/DaprRestaurant.git
   cd DaprRestaurant
   ```

2. **Install Dapr**:
   Follow the official [Dapr installation guide](https://docs.dapr.io/getting-started/install-dapr-cli/) to install Dapr on your local machine.

3. **Start Dapr**:
   Run the following command to initialize Dapr:
   ```bash
   dapr init
   ```

4. **Run the Application**:
  You can run each service individually using the .NET CLI:
   ```bash
   appport (like 2047 which assign when you normally run app)
   
   cd src/DaprRestaurantKitchen
   dapr run --app-id kitchenapi --app-port appport -- dotnet run
   
   cd src/DaprRestaurantClient
   dapr run --app-id clientapp --app-port appport -- dotnet run
   ```

5. **Access the Application**:
   - The application should be running on `http://localhost:<port>`.
   - Access the Dapr dashboard to monitor the services at `http://localhost:8080`.

## Project Structure

- **src/**: Contains the source code for the microservices. 
- **README.md**: Project documentation.

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue for any suggestions or improvements.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Contact

For any questions or suggestions, feel free to contact me at wajid7511@gmail.com.

---

Thank you for checking out the DaprRestaurant project! I hope it serves as a useful example of building microservices with Dapr.
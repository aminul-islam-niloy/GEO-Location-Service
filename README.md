# GEO Location Service

A web application to track friends' locations and find the shortest route to meet them using Leaflet and Leaflet Routing Machine.

## Features

- Display friends' locations on a map with custom icons.
- Calculate and display the shortest route to a friend on the map.
- Show distance to each friend.
- Full CRUD operations for managing friends' data.

### Prerequisites

- .NET 6.0 SDK
- Visual Studio or Visual Studio Code

### Installation

1. **Clone the repository**

   ```bash
   git clone https://github.com/your-username/geo-location-service.git
   cd geo-location-service
   ```

2. **Install .NET dependencies**

   ```bash
   dotnet restore
   ```

3. **Install front-end dependencies**

   ```bash
   npm install
   ```

4. **Run the application**

   ```bash
   dotnet run
   ```

5. **Open in a browser**

   Navigate to `https://localhost:5001` or `http://localhost:5000`.

### CRUD Operations for Friends

### How to Use the Map

1. On page load, the map will center on a default location.
2. Friends' locations are marked with custom icons.
3. Click on a friend's icon to see the distance and get directions from your current location to the friend.

### Adding Custom Icons

- Place your custom icons in the `wwwroot/icons` folder.
- Update the icon paths in the JavaScript code in `Views/Friends/Index.cshtml`.

### Troubleshooting

- Ensure that the OSRM service URL is accessible and not blocked by any network restrictions.
- Check the browser console for any errors and ensure all required scripts are loaded properly.

## Contributing

1. Fork the repository.
2. Create your feature branch (`git checkout -b feature/AmazingFeature`).
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`).
4. Push to the branch (`git push origin feature/AmazingFeature`).
5. Open a pull request.

## License

Distributed under the MIT License. See `LICENSE` for more information.

```

### Example Screenshot

Ensure you have a screenshot of your application in the `icons` folder named `screenshot.png`. Replace the `icons/screenshot.png` in the markdown with the path to your actual screenshot.

### Project Structure

Make sure your project has the necessary folders and files. Here is a simplified example structure:

```

geo-location-service/
├── Controllers/
│ └── FriendsController.cs
├── Models/
│ └── Friend.cs
├── Views/
│ └── Friends/
│ └── Index.cshtml
├── wwwroot/
│ └── icons/
│ └── 3001764.png
│ └── 146031.png
│ └── man_person17.png
│ └── screenshot.png
├── geo-location-service.csproj
├── package.json
├── Program.cs
├── README.md
└── Startup.cs

```


![Notification Image](https://github.com/aminul-islam-niloy/Notification-Service-for-ASP.NET-core-/blob/master/Notification%20Management/wwwroot/notification.png?raw=true)

### Adding CRUD Functionality

Ensure you have a `FriendsController` and corresponding views for CRUD operations:


By following these instructions and ensuring that your project is structured correctly, you should have a functional web application with CRUD operations for friends and mapping functionalities.
```

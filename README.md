# Technical Challenge IPS Health and Wellness

This application is a simple marketplace using React 18, with an ASP.net 7 backend.
JWT token's are used for enhanced security with a 30 minute expiry after login.
The backend is also wrapped with Docker for ease-of-use
By default, the token will last 30 minutes, so if you are logged out, please be aware that the reason is token expiry.

All data in the frontend is created from queries to the backend which uses a Database.

### For initial set up of the front end, simply run
>npm install.
npm start will start the React-based frontend.

If the database is live, the application will work as expected from here.

### To run the front end:
> npm start

### To run the backend:

Ensure you have docker installed and open.
Inside of the .\IPS ASP.net backend\' folder run the command "docker compose up". this will install and run all the necessary files

Ensure you have Visual Studio, and Docker installed.
Once you open the project within Visual Studio, VS should notice Docker and allow you to build the project with a simple click of the build button.
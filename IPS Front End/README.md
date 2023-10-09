# Technical Challenge IPS Health and Wellness

This application is a simple marketplace using React 18, with an ASP.net 7 backend.
JWT token's are used for enhanced security with a 30 minute expiry after login.
By default, the token will last 30 minutes, so if you are logged out, please be aware that the reason is token expiry.

A log out button was unfortunately not added as I was crunching this between other tasks, but you can deletey our local storage entry for the website and it will log you out due to a failed handshake with the backend.

### For initial set up of the front end, simply run
>npm install.
npm start will start the React-based frontend.

If the database is live, the application will work as expected from here.

### To run the front end:
> npm start

This application will run simply and emulates a basic marketplace.
For details of the backend, please consult the corresponding README.md within that folder

const requestOptions = {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ token: token })
    };
    fetch('https://reqres.in/api/posts', requestOptions)
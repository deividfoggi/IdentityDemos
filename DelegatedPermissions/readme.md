# Delegated permission
IdentityLabs

This scenario explores the delegated permissions using the authorize codegrant flow, such as a node app that will authenticate user and get the profile from Graph API.

Setup:

1. Register an application on Azure AD with the following delegated permissions:

    - User.Read
    - Calendars.Read

2. Configure the client id in the line 31 of index.html file
3. Open a terminal in the root directory and run the following command to start the server:

    node server.js

4. Open a private window browser and navigate to localhost:3007.
5. Click sign in and authenticate with a user that has a bunch of events in the calendar.
6. After sign in, Azure AD will callback locahost:3007 then application will show signed in user's username and the top 10 events in calendar.
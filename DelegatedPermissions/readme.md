# Delegated permission
IdentityLabs

## Pre-reqs

 - Node.js (https://nodejs.org/en/download/)
 - Any code editor to adjust settings like VSCode (http://aka.ms/vscode)
 - Azure AD trial account
 - Office 365 or Outlook.com account

This scenario explores the delegated permissions using the client credentials grant flow, such as an automation that will get mails from user's inbox.

## Setup

1. Register an application on Azure AD with the following delegated permissions (https://docs.microsoft.com/en-us/azure/active-directory/develop/quickstart-register-app#:~:text=%20Follow%20these%20steps%20to%20create%20the%20app,for%20your%20application.%20Users%20of%20your...%20More%20)

    - User.Read
    - Calendars.Read

2. Configure the client id in the line 31 of index.html file
3. Open a terminal in the root directory and run the following command to start the server:

    node server.js

4. Open a private window browser and navigate to localhost:3007.
5. Click sign in and authenticate with a user that has a bunch of events in the calendar.
6. After sign in, Azure AD will callback locahost:3007 then application will show signed in user's username and the top 10 events in calendar.
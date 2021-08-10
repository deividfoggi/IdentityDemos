# Application permission
IdentityLabs

## Pre-reqs

 - .net 5.0
 - Any code editor to adjust settings like VSCode

This scenario explores the application permissions using the client credentials grant flow, such as an automation that will get mails from user's inbox.

Setup:

1. Register an application on Azure AD with the following admin consent granted application permissions:

    - Mail.Read

2. Configure client id, tenant id, client secret and the target user's id in the appsettings.json
3. Open a terminal in the root directory and run the following command to demo: 

    dotnet run

4. The console should list user's inbox email. Make sure the target user has some e-mails in the mailbox.
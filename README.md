# HOW TO BUILD AND RUN:

• Download the file folder from GitHub named MoulaCodingChallenge.

• Start Visual Studio Code and open the project folder (MoulaCodingChallenge).

- File > Open Folder > MoulaCodingChallenge

• In the project directory (Terminal > New Terminal), you can run:

- cd Challenge (to go directly with the project file)

• When already directed to the "Challenge" project, you can run:

- dotnet build Challenge (in order to build the app and see if there are any
  lint errors in the console)

• Once the build has succeded, you can run:

- dotnet run (runs the app in the development mode)

• You can now open [ http://localhost:5000/api/account/ ] to view it in the browser.

# ARCHITECTURAL DESCRIPTIONS:

• We have a Program and a Startup class.

• Model - the end in MVC or the internal representation of the data.

• Controllers - API endpoints and key pieces of infrastructure.

• Data Access (DB Context) - part of Entity Framework Core, one that connects to the
SQL Server Database.

• Repository.

• DTO (Data Transfer Object) - external representation of internal models out to the
consuming endpoints.

• API Client (Postman) - in this project, I used Postman to make the requests to the
controllers and get responses back via HTTP (JSON format).

# ASSUMPTIONS:

- A user who has an account in this system wants to check his remaining balance
  and the list of payment that he has.

- The list shows the Date of Payment when the user had the transaction and
  the Amount of Payment that he made. The Account Balance updates everytime the
  user makes a transaction, as well as the Status of the payment that was made.

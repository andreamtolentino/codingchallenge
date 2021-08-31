# HOW TO BUILD AND RUN:

• Copy the URL link from GitHub named MoulaCodingChallenge.
  - Code > HTTPS

• Start Visual Studio 2019 and open "Clone a Repository", then paste the URL you
copied from GitHub. Choose the path where you want to save the file and click "Clone".

• In the project directory (View > Terminal), you can run:

  - cd <path> MoulaCodingChallenge (to go directly to the project file)

• When already directed to the "Challenge" project, you can run:

  - dotnet build (in order to build the app and see if there are any lint errors in
the console)

• Once the build has succeded, you can run:

  - dotnet run (runs the app in the development mode)

• You can now open [ https://localhost:5001/api/account/ ]  or
[https://moulaaccount.azurewebsites.net ] to view it in the browser and see the Account
Balance and List of Payment of the user.

• You can also open [ https://localhost:5001/api/account/A ]  or
[ https://moulaaccount.azurewebsites.net/api/account/A ] to view the recent transaction
that the user has made.


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

• A user who has an account in this system wants to check his remaining balance
and the list of payment that he has.

• The list shows the Date of Payment when the user had the transaction and
the Amount of Payment that he made. The Account Balance updates everytime the
user makes a transaction, as well as the Status of the payment that was made.

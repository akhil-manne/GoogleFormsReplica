# GoogleFormsReplica
A simple replica of google forms using Visual Basic in the frontend and Express server with Typescript in the backend.

This application is specific to Windows operating system only.
In order to run this, Visual Studio 2022 or above version is needed, with .NET 8.0 LTS, within which a project folder of 'Forms App' in VisualBasic programming language. Within that folder, the necessary files for the frontend of the form are provided in the frontend folder of this repository.
For the backend, first, a seperate directory (please name it as 'google-forms-backend') must be created, and node modules must be installed inside it, in order to set up the express server. Once that is done, the files in the backend folder of this repository can be added to the backend directory (google-forms-backend).

After the above setup is done, firstly, in the terminal, locate to the backend directory, where node modules and the given backend files exist. Next, run the command 'npm run dev'. This will setup the Express server at port 3000. 
Once the backend is set up, next, come to the Visual Studio project folder, which is the frontend of this application, and run the application in the editor (Press F5 or locate to the top center).
While running, a form would open up and give options of viewing and creating a submission. The options can be used as required. One thing to note is that, while creating submissions, the entries of the data would be stored in a file called 'db.json', which would be there in the 'src' folder of the  user's backend directory (google-forms-backend).

# GoogleFormsReplica
A simple replica of google forms using Visual Basic in the frontend and Express server with Typescript in the backend.

This application is specific to Windows operating system only.
To run this application, first the backend server must be set up and then the frontend project folder must be run via Visual Studio.
Note that the node modules in the backend folder must be downloaded by the user seperately and have not been provided in this repository. The download steps have been given below. Following it will help.

Firstly, download the backend folder (google-forms-backend) into one of the system's directories and navigate to that backend folder via terminal/command prompt. Then run the following commands in order to install the necessary node modules needed for setting up the Express server:
npm init -y
npm install express body-parser

Once this is done, run the following command to start the Express server:
npm run dev

This will run the server on port 3000. Once the backend is set up, move on to the frontend, by downloading the frontend project folder (WinFormsApp2) into the same system directory where the backend folder was downloaded (for simplicity). Open this folder (WinFormsApp2) in Visual Studio and run it (by pressing Ctrl+F5 or by locating the 'run' button in the top center, preferably in Debug mode and not in Release mode). This will display the main form, and the user can use it as per their needs. 
The data that would be entered by the user in the forms while creating a submission, will be stored in the 'db.json' file in the src folder in the backend folder (google-forms-backend).

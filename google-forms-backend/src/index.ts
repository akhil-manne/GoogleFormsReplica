import express, { Request, Response } from 'express';
import bodyParser from 'body-parser';
import fs from 'fs';
import path from 'path';

const app = express();
const port = 3000;

// Define the Submission interface with updated variable names
interface Submission {
    Name: string;
    Email: string;
    Phone: string;
    GitHubLink: string;
    StopwatchTime: string;
}

// Define the SubmissionDTO interface with updated variable names
interface SubmissionDTO {
    Name: string;
    Email: string;
    Phone: string;
    GitHubLink: string;
    StopwatchTime: string;
}

// Middleware
app.use(bodyParser.json());

// JSON Database File Path
const dbFilePath = path.join(__dirname, 'db.json');

// Helper Function to Read Data from JSON File
const readDatabase = (): { submissions: Submission[] } => {
    try {
        const data = fs.readFileSync(dbFilePath, 'utf-8');
        if (data.trim() === '') {
            return { submissions: [] }; // Return an empty submissions array if the file is empty
        }
        const parsedData = JSON.parse(data);
        if (!parsedData.submissions) {
            parsedData.submissions = []; // Ensure submissions array exists
        }
        return parsedData as { submissions: Submission[] };
    } catch (error) {
        console.error('Error reading database:', error);
        return { submissions: [] }; // Return an empty submissions array on error
    }
};

// Helper Function to Write Data to JSON File
const writeDatabase = (data: any) => {
    fs.writeFileSync(dbFilePath, JSON.stringify(data, null, 2), 'utf-8');
};

// Ping Endpoint
app.get('/ping', (req: Request, res: Response) => {
    res.send(true);
});

// Submit Endpoint
app.post('/submit', (req: Request, res: Response) => {
    const { Name, Email, Phone, GitHubLink, StopwatchTime } = req.body;

    console.log('Received submission:', req.body); // Log the received data

    const newSubmission: Submission = {
        Name,
        Email,
        Phone,
        GitHubLink,
        StopwatchTime
    };

    try {
        const data = readDatabase();
        console.log('Current database state:', data); // Log the current state of the database

        data.submissions.push(newSubmission);
        console.log('Updated database state:', data); // Log the updated state of the database

        writeDatabase(data);

        res.status(201).send(newSubmission);
    } catch (error) {
        console.error('Error processing submission:', error);
        res.status(500).send({ error: 'Failed to process submission' });
    }
});

// Read Endpoint
app.get('/read', (req: Request, res: Response) => {
    const data = readDatabase();

    if (data && data.submissions) {
        const submissionsDTO: SubmissionDTO[] = data.submissions.map((submission: Submission) => ({
            Name: submission.Name,
            Email: submission.Email,
            Phone: submission.Phone,
            GitHubLink: submission.GitHubLink,
            StopwatchTime: submission.StopwatchTime
        }));

        res.status(200).send(submissionsDTO);
    } else {
        res.status(404).send({ error: 'No submissions found' });
    }
});

// Initialize JSON File
if (!fs.existsSync(dbFilePath)) {
    fs.writeFileSync(dbFilePath, JSON.stringify({ submissions: [] }, null, 2), 'utf-8');
}

// Start the Server
app.listen(port, () => {
    console.log(`Server running at http://localhost:${port}`);
});
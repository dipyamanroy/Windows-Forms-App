import express, { Request, Response } from 'express';
import bodyParser from 'body-parser';
import fs from 'fs';
import path from 'path';

const app = express();
const port = 3000;
const dbPath = path.resolve(__dirname, 'db.json');

app.use(bodyParser.json());

interface Submission {
  Name: string;
  Email: string;
  Phone: string;
  GithubLink: string;
  StopwatchTime: string;
}

// Initialize database file if it doesn't exist
if (!fs.existsSync(dbPath)) {
  fs.writeFileSync(dbPath, JSON.stringify({ submissions: [] }, null, 2));
}

// Endpoint to check if the server is running
app.get('/ping', (req: Request, res: Response) => {
  res.send(true);
});

// Endpoint to submit a new form submission
app.post('/submit', (req: Request, res: Response) => {
  const { Name, Email, Phone, GithubLink, StopwatchTime } = req.body;
  const newSubmission: Submission = {
    Name: Name,
    Email: Email,
    Phone: Phone,
    GithubLink: GithubLink,
    StopwatchTime: StopwatchTime
  };
  console.log('Received body:', req.body); // Log the entire body
  console.log('Parsed submission:', newSubmission); // Debugging line
  const db = JSON.parse(fs.readFileSync(dbPath, 'utf-8'));
  db.submissions.push(newSubmission);
  fs.writeFileSync(dbPath, JSON.stringify(db, null, 2));
  res.send('Submission saved successfully!');
});

// Endpoint to read a form submission by index
app.get('/read', (req: Request, res: Response) => {
  const index = parseInt(req.query.index as string);
  const db = JSON.parse(fs.readFileSync(dbPath, 'utf-8'));
  const submission = db.submissions[index];
  if (submission) {
    res.json(submission);
  } else {
    res.status(404).send('Submission not found');
  }
});

// Endpoint to delete a form submission by index
app.delete('/delete', (req: Request, res: Response) => {
  const index = parseInt(req.query.index as string);
  const db = JSON.parse(fs.readFileSync(dbPath, 'utf-8'));
  db.submissions.splice(index, 1);
  fs.writeFileSync(dbPath, JSON.stringify(db, null, 2));
  res.send('Submission deleted successfully!');
});

// Endpoint to update a form submission by index
app.put('/update', (req: Request, res: Response) => {
  const index = parseInt(req.query.index as string);
  const db = JSON.parse(fs.readFileSync(dbPath, 'utf-8'));
  const updatedSubmission: Submission = req.body;
  db.submissions[index] = updatedSubmission;
  fs.writeFileSync(dbPath, JSON.stringify(db, null, 2));
  res.send('Submission updated successfully!');
});

app.listen(port, () => {
  console.log(`Server is running at http://localhost:${port}`);
});
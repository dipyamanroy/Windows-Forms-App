# Windows Forms App Backend (Node.js and Express)

## Overview
This backend is built using Node.js and Express. It serves as the server-side component for the Windows Forms application, handling data storage, retrieval, and other backend functionalities.

## Features

1. **Ping Server (`GET /ping`):** Endpoint to check if the server is running.
2. **Submit Form (`POST /submit`):** Endpoint to submit a new form submission.
3. **Read Submission by Index (`GET /read`):** Endpoint to read a specific form submission by its index.
4. **Delete Submission by Index (`DELETE /delete`):** Endpoint to delete a specific form submission by its index.
5. **Update Submission by Index (`PUT /update`):** Endpoint to update a specific form submission by its index.
6. **Search by Email (`GET /search`):** Endpoint to search for a form submission by email.
7. **Check for Duplicates (`POST /checkDuplicate`):** Endpoint to check for duplicate submissions by name and email.
8. **Read All Submissions (`GET /readAll`):** Endpoint to read all form submissions.
9. **Export to CSV: (`GET /exportCsv`)** Endpoint to export all submissions to a CSV file.

<br>

# Running the Backend

## Prerequisites

- [Node.js and npm](https://nodejs.org/) installed on your machine.

## Running the Backend

1. Clone the full repository, using `git clone https://github.com/dipyamanroy/Windows-Forms-App/`.
2. Navigate to the backend directory (`/backend`) (**Note:** Ignore if you are in the current directory for **this** `README.md`):

   ```
   cd backend
   ```

3. Install the dependencies:

   ```
   npm install
   ```

4. Start the server:

   ```
   npm start
   ```

The backend server will start running at `http://localhost:3000`.
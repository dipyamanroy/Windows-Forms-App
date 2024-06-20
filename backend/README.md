# Windows Forms App 

## Backend (Node.js and Express)

The backend of the application is built using Node.js and Express. It provides the following endpoints:

1. **GET /ping**: Checks if the server is running.
2. **POST /submit**: Submits a new form submission.
3. **GET /read**: Reads a form submission by index.
4. **DELETE /delete**: Deletes a form submission by index.
5. **PUT /update**: Updates a form submission by index.
6. **GET /search**: Searches for a form submission by email.

<br>

# Running the Backend

## Prerequisites

- [Node.js and npm](https://nodejs.org/) installed on your machine.

## Running the Backend

1. Navigate to the backend directory (**Note:** Ignore if you are in the current directory for **this** `README.md`):

   ```
   cd backend
   ```

2. Install the dependencies:

   ```
   npm install
   ```

3. Start the server:

   ```
   npm start
   ```

The backend server will start running at `http://localhost:3000`.
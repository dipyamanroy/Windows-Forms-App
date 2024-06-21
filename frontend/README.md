# Windows Forms App Frontend (VB.NET)

## Overview

The frontend of the application is built using VB.NET and consists of three forms:

| Sl no | Form  |  How it looks |
|---|---|---|
| 1  | **Form1:** The main form that provides options to view submissions and create new submissions.  |  ![Form1](/assets/landing.png) |
| 2  |  **CreateSubmissionForm:** A form for creating and editing submissions. It includes fields for name, email, phone number, GitHub link, and stopwatch time. | ![CreateSub](/assets/createsub.png)  |
| 3  | **ViewSubmissionsForm:** A form for viewing and managing submissions. It allows users to navigate through submissions, delete submissions, edit submissions, and search for submissions by email.  | ![ViewSubs](/assets/viewsubs.png)  |


## Features

1. **Create and Edit Submissions:** Users can create new submissions and edit existing ones.
2. **View Submissions:** Users can view all submissions.
3. **Delete Submissions:** Users can delete submissions.
4. **Search by Email:** Users can search for submissions using an email address.
5. **Export to CSV:** Users can export all submissions to a CSV file.
6. **Duplicate Check:** The app prevents duplicate submissions based on name and email.
7. **Validation Checks:** Ensures name, email, and phone number fields are valid.

<br>

# Running the App
## Prerequisites

- [Visual Studio](https://visualstudio.microsoft.com/) installed on your machine, running Windows >8.1.
- You **may** need to install the Newtonsoft.Json package using NuGet **manually**. Follow the installation instructions [here](https://learn.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-in-visual-studio).

## Running the Frontend

1. Open the frontend project in Visual Studio (or just click on the solution file, `/FormsApp.sln`).
2. Build the project to ensure that all dependencies are resolved.
3. Run the project.

The frontend application will start, and you can interact with it using the provided forms.

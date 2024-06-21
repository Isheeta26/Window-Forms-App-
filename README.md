# Windows Forms App
## Description
Created a Windows desktop application using Visual Studio and Visual Basic for efficient submission management. 
Features include viewing existing submissions with navigation controls and creating new submissions with detailed input fields and a functional stopwatch.

### Main Form
The main form serves as the entry point to navigate between viewing existing submissions and creating new submissions.

![Screenshot 2024-06-21 115318](https://github.com/Isheeta26/Window-Forms-App-/assets/160028018/4d34ddcc-c214-4917-aa60-6bea43553429)


### View Submission Form (Ctrl+V)
Clicking this button opens a new form (View Submissions Form) dedicated to displaying existing submission entries.
The ViewSubmissionsForm includes two navigation buttons:
* Previous: Allows users to navigate to the previous submission entry.
* Next: Allows users to navigate to the next submission entry.
By default, upon opening ViewSubmissionsForm, the first submission entry is displayed.


![Screenshot 2024-06-21 113826](https://github.com/Isheeta26/Window-Forms-App-/assets/160028018/4fc609c4-0322-4bc6-888e-2540871f16aa)


### Create New Submission Button (Ctrl+N)
Clicking this button opens a new form (Create Submission Form) where users can input details for a new submission.
The CreateSubmissionForm includes the following fields:
* Name: Editable textbox for entering the name of the submitter.
* Email: Editable textbox for entering the email address of the submitter.
* Phone Number: Editable textbox for entering the phone number of the submitter.
* GitHub Repo Link: Editable textbox for entering a link to the submitter's GitHub repository.
* Stopwatch: A button to start and pause a stopwatch, allowing the submitter to track time.
* Submit Button: Clicking this button saves the entered details to the backend storage.

![Screenshot 2024-06-21 113810](https://github.com/Isheeta26/Window-Forms-App-/assets/160028018/873ab8d1-8933-4d58-ac96-fe69057650ef)


### Message Box
After clicking the Submit button in the Create Submission Form, it displays a message box to inform the user that their submission was successful.


![Screenshot 2024-06-21 113759](https://github.com/Isheeta26/Window-Forms-App-/assets/160028018/4d6df194-314f-48e4-93b5-952964faeb36)

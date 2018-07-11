# Fulvipes Orientation Exam

## 1) Matrix Checker

You will create a web page which can check if the matrix is increasing or not.

# Matrix Checker

![main](assets/index.png)

## Frontend

  - the **frontend** should have:
    - a heading with the title
    - nice intro text
    - text area for the matrix input
    - submit button for sending the matrix to backend to check


## Backend

  - only a square matrix should be submitted in the input field,
    - otherwise the app should send an error message
  - do the validation methods in backend
  - in case the matrix is valid send a success message in 'Result' section
  - in case the matrix is not valid send an error message in 'Result' section
  - if success, save the matrix into a database with the following fields:
    - id, date, matrixNumbers
  - handle errors written in the README.md


## Endpoints
  - you should create these endpoints:

### GET `/`
  - the endpoint should render an HTML displaying the main page

### POST `/matrix/:validtype`
  - this endpoint is responsible for receiving, validating and saving to the database

### GET `/matrices`
  - this endpoint should query every matrix that were successfully saved and valid return in JSON format

## 2) Question time

### What is the difference between primary key and foreign key in database?

### What is the difference between the onload and the readystatechange provided by the XMLHttpRequest object?

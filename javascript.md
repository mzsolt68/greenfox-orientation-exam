# Fulvipes Orientation Exam

## 1) Symmetric Matrix

You will create a web page which can check if the matrix is symmetric or not.

# Matrix Checker

![main](assets/index1.png)

## Frontend

- the **frontend** should have:
    - a heading with the title
    - nice intro text
    - radio buttons for the matrix validation options
    - input text area for the matrix
    - submit button for sending the matrix to backend to check


## Backend

- the app must approve a square matrix only in the input field,
  - otherwise it should send an error message
- user can choose which validation type will the matrix ride through
- do the validation methods in backend
- in case the matrix is valid send a success message in 'Result' section
- in case the matrix is not valid send an error
- if success, save the matrix into a database with the following fields:
  - id, type, date, matrix


## Endpoints
- you should create these endpoints:

### GET `/`
- the endpoint should render an HTML displaying the main page

### POST `/matrix/:validtype`
- this endpoint should be responsible for sending the matrix with the need of relevant validation type

### GET `/matrixes`
- this endpoint should query every matrix that were successfully saved and valid

## 2) Question time

### What is the difference between primary key and foreign key in database?

### What is the main difference between the onload and the readystatechange provided by the XMLHttpRequest object?

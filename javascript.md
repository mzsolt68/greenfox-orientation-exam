3 endpoint
1 general, 1 post, amivel beküldjük a matrixot és paraméterben küldi, hogy hogyan ellenőriz, 1 get, amivel a mentett matrixokat jsonben kidobja

# Fulvipes Orientation Exam

## 1) Symmetric Matrix

You will create a web page which can check if the matrix is symmetric or not.

# Matrix Checker

![main](assets/index1.png)

## Frontend

- the **frontend** should have:
    - a heading with the title
    - nice intro text, you can use loremipsum
    - titles of the different selection parts
    - selection field with the main types of waffle
    - radio buttons for the base
    - checkboxes for the fruits and sprinkles
    - submit button for sending the choosen ingredients of the waffle
    - don't take too much time with copying the style,
    you can play with it after the main functionalities are working

## Backend

- the selection input field must be dynamic giving options of waffle `type`s
- user can choose one `base`
- user can choose as many from the `fruits` and `sprinkles` as they want
- when submitting the form a new page should be rendered with the relevant info

# Sum page

## Frontend

- the **frontend** should have:
    - a heading with the title
    - summary text of the choosen ingredients
    - list of the extras (fruits, sprinkles)
    - the total price of the choosen ingredients
    - one picture at the bottom `(assets/bubble-waffle.jpg)`
    - don't take too much time with copying the style,
    you can play with it after the main functionalities are working

## Backend

- the backend should send a new waffle object with the selected ingredients
- it should render the text with the relevant ingredients
- the first word of this text should be capitalised
- the page should receive the total sum of the prices of ingredients
- when sending the "order" the `quantity` of the ingredients should be decreased by 1
- it should send an error message to the user if the quantity of selected ingredient is 0 (anyewhere, anyhow, but the error should be handled)

![create](assets/create-page.png)

## Endpoints
- you should create these endpoints:

### GET `/`
- the endpoint should render an HTML displaying the main page

### POST `/`
- this endpoint should be responsible for providing information of the created waffle

### GET `/ingredients`
- the endpoint should be able to query the ingredients lower than the given prices
- example query: `/ingredients?priceLowerThan=200`

```json
[
  {
    "id":11,
    "category":"sprinkles",
    "name":"smarties",
    "price":120,
    "quantity":41
  },
  {
    "id":12,
    "category":"sprinkles",
    "name":"marshmallow",
    "price":150,
    "quantity":2
  },
  {
    "id":13,
    "category":"sprinkles",
    "name":"sugar pearl",
    "price":120,
    "quantity":0
  },
  {
    "id":14,
    "category":"sprinkles",
    "name":"whipped cream",
    "price":150,
    "quantity":1
  }
]
```

## 2) Question time

### What is the difference between primary key and foreign key in database?

### What kind of HTTP methods do you know and what are they used for? (write 4 example)

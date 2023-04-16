## DinnerHost API

- [DinnerHost API](#dinnerhost-api)
- [Auth](#auth)
- [Register](#register)
  - [Register Request](#register-request)
  - [Register Response](#register-response)
- [Login](#login)
  - [Login Request](#login-request)
  - [Login Response](#login-response)

## Auth

## Register

`POST {{host}}/auth/register`

### Register Request

```json
{
    "firstName": "John",
    "lastName": "Doe",
    "email": "john@email.com",
    "password": "Abc123!"
}
```

### Register Response

`200 OK `

```json
{
  "id": "498d3f04-3b22-4737-aee1-433454d8c1fb",
  "firstName": "John",
  "lastName": "Doe",
  "email": "john@email.com",
  "token": "eyJh....eps"
}
```

## Login

`POST {{host}}/auth/login`

### Login Request

```json
{
    "email": "john@email.com",
    "password": "Abc123!"
}
```

### Login Response

`200 OK `

```json

{
  "id": "36cb72ef-e36f-429d-90e3-a42964fe00cc",
  "firstName": "John",
  "lastName": "Doe",
  "email": "john@email.com",
  "token": "eyJhbGc...5Wfso"
}
```


## DinnerHost API

- [DinnerHost API](#dinnerhost-api)
- [Auth](#auth)
- [Register](#register)
  - [Register Request](#register-request)
  - [Register Response](#register-response)

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
    "id": "70f6833f-e783-4053-bde5-7793bf4b26be",
    "firstName": "John",
    "lastName": "Doe",
    "email": "john@email.com",
    "token": "fdglkmkmm4...dfduibmmz"
}
```


- [An awesome guide on how to build RESTful APIs with ASP.NET Core](#an-awesome-guide-on-how-to-build-restful-apis-with-aspnet-core)
  - [The Scope](#the-scope)
  - [Steps](#steps)
    - [Creating the API](#creating-the-api)
    - [Creating the Domain Models](#creating-the-domain-models)
    - [The Categories API](#the-categories-api)
    - [Implementing the Categories Service](#implementing-the-categories-service)
    - [The Categories Repository and the Persistence Layer](#the-categories-repository-and-the-persistence-layer)
    - [Configuring Dependency Injection](#configuring-dependency-injection)
    - [Testing the Categories API](#testing-the-categories-api)
    - [Creating a Category Resource](#creating-a-category-resource)
    - [Creating new Categories](#creating-new-categories)
    - [Validating the Request Body Using the Model State](#validating-the-request-body-using-the-model-state)
    - [Mapping the new Resource](#mapping-the-new-resource)
    - [Applying the Request-Response Pattern to Handle the Saving Logic](#applying-the-request-response-pattern-to-handle-the-saving-logic)
    - [The Database Logic and the Unit of Work Pattern](#the-database-logic-and-the-unit-of-work-pattern)
    - [Testing our POST Endpoint using Postman](#testing-our-post-endpoint-using-postman)
    - [Updating Categories](#updating-categories)
    - [The Update Logic](#the-update-logic)
    - [Deleting Categories](#deleting-categories)
    - [The Products API](#the-products-api)


# An awesome guide on how to build RESTful APIs with ASP.NET Core

Build a structured RESTful API  using the ASP.NET Core framework. I’m going to detail common patterns and strategies to simplify the development process. I’ll also show you how to integrate common frameworks and libraries, such as Entity Framework Core and AutoMapper, to deliver the necessary functionalities.

## The Scope

Let’s write a fictional web API for a supermarket. 

Let’s imagine we have to implement the following scope:

- reate a RESTful service that allows client applications to manage the supermarket’s product catalog. 
- It needs to expose endpoints to create, read, edit and delete products categories, such as dairy products and cosmetics, and also to manage products of these categories.
  - For categories, we need to store their names. 
  - For products, we need to store their names, unit of measurement (for example, KG for products measured by weight), quantity in the package (for example, 10 if the product is a pack of biscuits) and their respective categories.
- To simplify the example, I won’t handle products in stock, product shipping, security and any other functionality. The given scope is enough to show you how ASP.NET Core works.

To develop this service, we basically need two API endpoints: one to manage categories and one to manage products. 
In terms of JSON communication, we can think of responses as follow:

**API endpoint: /api/categories**

JSON Response (for GET requests):
```json
{
  [
    { "id": 1, "name": "Fruits and Vegetables" },
    { "id": 2, "name": "Breads" },
    … // Other categories
  ]
}
```

**API endpoint: /api/products**

JSON Response (for GET requests):
```json
{
  [
    {
      "id": 1,
      "name": "Sugar",
      "quantityInPackage": 1,
      "unitOfMeasurement": "KG"
      "category": {
        "id": 3,
        "name": "Sugar"
      }
    },
    … // Other products
  ]
}
```

## Steps

### Creating the API


### Creating the Domain Models
### The Categories API
### Implementing the Categories Service
### The Categories Repository and the Persistence Layer
### Configuring Dependency Injection
### Testing the Categories API
### Creating a Category Resource
### Creating new Categories
### Validating the Request Body Using the Model State
### Mapping the new Resource
### Applying the Request-Response Pattern to Handle the Saving Logic
### The Database Logic and the Unit of Work Pattern
### Testing our POST Endpoint using Postman
### Updating Categories
### The Update Logic
### Deleting Categories
### The Products API
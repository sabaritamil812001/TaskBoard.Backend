TaskBoard API
Overview

TaskBoard API is a RESTful backend application built using ASP.NET Core 8 and Entity Framework Core.

The API provides full task management functionality including:

Create Task

Retrieve Tasks

Update Task

Delete Task

Add Comments

Retrieve Comments

Audit Logging

This project demonstrates clean architecture principles, DTO usage, middleware-based header authentication, Swagger integration, and database persistence using SQL Server.

Technology Stack

ASP.NET Core 8 Web API

Entity Framework Core

SQL Server

Swagger (OpenAPI)

Custom Middleware

Header-based Authentication

Audit Logging

Architecture

The project follows a layered structure:

Controllers
→ DTOs
→ DbContext
→ Models
→ SQL Server

Key Components

Controllers

TasksController handles all task-related endpoints.

DTOs

TaskCreateDto

TaskUpdateDto

CommentCreateDto

DTOs are used to avoid exposing database entities directly.

Models

TaskItem

Comment

AuditLog

Middleware

Custom header validation middleware requiring X-User header.

Global error handling middleware.

Database

SQL Server with Entity Framework Core.

Migrations enabled.

Concurrency control using RowVersion.

Authentication Mechanism

The API uses simple header-based authentication.

Each request must include:

X-User: admin

If the header is missing, the API returns:

401 Unauthorized

Swagger is configured to support this header.

API Endpoints
Task Endpoints

GET /api/tasks
Returns all tasks with total count.

POST /api/tasks
Creates a new task.

PUT /api/tasks/{id}
Updates an existing task.

DELETE /api/tasks/{id}
Deletes a task.

Comment Endpoints

POST /api/tasks/{id}/comments
Adds a comment to a task.

GET /api/tasks/{id}/comments
Retrieves comments for a task.

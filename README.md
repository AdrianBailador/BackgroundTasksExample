# BackgroundTasksDemo

This project demonstrates how to run background tasks in ASP.NET Core using `Channel`-based queues.

## Features

- Enqueue tasks via an API.
- Tasks are processed asynchronously in the background.

## Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/yourusername/BackgroundTasksDemo.git
    ```

2. Navigate to the project directory:

    ```bash
    cd BackgroundTasksDemo
    ```

3. Restore the NuGet packages and run the project:

    ```bash
    dotnet restore
    dotnet run
    ```

## Usage

Send a POST request to `/api/queue/enqueue` to enqueue a background task. For example, using `curl`:

```bash
curl -X POST http://localhost:5000/api/queue/enqueue
````

## Author

Adrián Bailador Panero
[Blog](https://adrianbailador.github.io/)


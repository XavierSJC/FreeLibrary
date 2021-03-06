# FreeLibrary
## A typical library manager software

This is a personal project to study [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)/[React](https://reactjs.org/)/[Docker](https://www.docker.com/)/[Unit Tests](https://docs.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2019)
So if you see anything strange don't worry, I'm learning and your help will be welcome

I hope to start this with a "Hello-World" and maybe turn it into a functional project.

# Docker image


## powersjk/freelibrary-api
The API.

* [`0.0.1`](https://github.com/XavierSJC/FreeLibrary/blob/380f2de0fcb2361550d98ed3f694a3d57a9cdac4/docker/Dockerfile-api), [`latest`](https://github.com/XavierSJC/FreeLibrary/blob/380f2de0fcb2361550d98ed3f694a3d57a9cdac4/docker/Dockerfile-api): CRUD from Book table.

## How execute
This image uses a MySQL database, so to executes the API succcessfully be sure that you has a database available.

Type the following command to run (example):

```
docker network create freeLibrary-network
docker volume create freeLibrary-volume

docker run -d --name mysql -v freeLibrary-volume:/var/lib/mysql -e MYSQL_USER=<user> -e MYSQL_PASSWORD=<user_pwd> -e MYSQL_ROOT_PASSWORD=<root_pwd> --network freeLibrary-network mysql 

docker run -it --name webAPIFreeLibrary -p 80:80 -e DB_SERVER=mysql -e DB_DATABASE=Freelibrary -e DB_USER=root -e DB_USER_PWD=<root_pwd> --network freeLibrary-network powersjk/freelibrary-api:0.0.1
```

or you can use the `docker/docker-compose.yml`:
```
docker-compose up -d
```

## Build image
If you wish to build your custom image from this image you can execute the command:
```
docker build -t <your_tag> -f .\docker\<dockerfile> .
```

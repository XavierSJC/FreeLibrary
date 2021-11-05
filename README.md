# FreeLibrary
## A typical library manager software

This is a personal project to study [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)/[React](https://reactjs.org/)/[Docker](https://www.docker.com/)/[Unit Tests](https://docs.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2019)
So if you see anything strange don't worry, I'm learning and your help will be welcome

I hope to start this with a "Helo-World" and maybe turn it into a functional project.

# Docker image
You can use the image **powersjk/freelibrary**

## Run Application
Type the following command to run:

```
docker run -d --name freelibrary -p 80:80 powersjk/freelibrary:helloworld
````
After the application starts, navigate to `http://localhost` in your web browser.

## Tags Available
* [`helloworld`](): Image running the react code 'Hello world' from dotnet.

This image hasn't the tag `latest` available.

## Build the image
To build this image type these commands:
```
git clone https://github.com/XavierSJC/FreeLibrary.git
cd FreeLibrary
docker build -t freelibrary:helloworld -f .\docker\dockerfile .
```
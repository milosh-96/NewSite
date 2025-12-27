# Hosting Orchard Core on Unix VPS using GitHub actions

Using DotNet Runtime on Unix you can easily host Orchard Core or any ASP.NET project. This process includes several steps but here is the outline of what has to be accomplished. 
1. Setting up proper environment and users
2. GitHub actions setup
3. Configuring directories and a background service using SystemD
5. Allowing specific sudo commands
6. Setting up Nginx server block and reverse proxy
7. Running the site

## Setting up proper environment and users
I won't explain commands here so please look on other resources how to manage users and groups. 

What we need to do is to separate who/which user will deploy our app using GitHub actions and who/which user will run our app. But they should be relatives, thus they should be part of the same user group. So, user who deploys the app will be "deployer" and the one who runs the app will be "service-runner".
While you could just use your SSH login user, who probably has sudo permissions, that would create security concerns so it is not recommended. 
What we can do instead is we can create user group "orchardcore" and you can assign "deployer", "service-runner" and even your sudo user to it.

So now service-runner can execute files since it's in the same group as the deployer.

## GitHub actions setup
You can find the workflow example/template here, but I will go over the must change stuff and explain what those lines actually do.

Lines 32-33, when DotNet builds the project it puts everything in "publish" folder. What we do after that is that we basically take everything from there and then we transfer it to our server, in the temp folder of our project. You just have to create directory for your project and assign it to user group "orchardcore" and "temp" folder will be created automatically.

In the next step we are trying to start/restart our app.




 







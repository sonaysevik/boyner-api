This is a simple app to demonstrate realtime configuration udpates that are saved on MongoDB instance.

Application is getting configuration in original types 

REquirements:
- Config-Library  dll from library repo
- MongoDB driver
- Up and running MongoDB instance with according data


Config Library:
Download source code from following repo and build. Import dll as an assembly dependency.

MongoDB Driver:
Install Nuget package as dependency

MongoDB instance:
Run docker-compose file in this folder with `docker-compose --up` MongoDB instance is running on 23017 port. username is admin password is test

Database name that is being used in source code is admin. The collection that is being used is named as configs.


 

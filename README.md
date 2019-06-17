This is a simple app to demonstrate realtime configuration udpates that are saved on MongoDB instance.

Application is getting configuration in original types 

Requirements:
- Config-Library  dll from library repo
- MongoDB driver
- Up and running MongoDB instance with according data


Config Library:
Download source code from following repo https://github.com/sonaysevik/boyner-library  and build. Import dll as an assembly dependency to api project.

MongoDB Driver:
Install Nuget package as dependency

MongoDB instance:
Run docker-compose file in this folder with `docker-compose up -d` MongoDB instance is running on 27017 port. username is test password is test

Database name that is being used in source code is admin. The collection that is being used is named as configs.

IMPORT DATA TO MONGO:

 1. run `docker cp /Users/sonay.sevik/Documents/Projects/internal/boyner-api/configs.json REPLACE_WITH_CONTAINER_ID:/configs.json `
 2.  run `docker exec -it REPLACE_WITH_CONTAINER_ID bin/bash`
 3.  run ` mongoimport --host=127.0.0.1:27017 --authenticationDatabase=admin  --db=admin --username=test --password=test --collection=configs --file=configs.json`

 
 
# P-CNA371
##P-CNA371 project

run the following commands in your terminal in the directory that contains the Dockerfile

###How to build 
docker build -t project . 

###How to run
docker compose up -d

###how to interact with the container
docker container ls -a 
 - copy <CONTAINER ID> of project:latest IMAGE
docker attach <CONTAINER ID> 

Use docker desktop to view full container output. 



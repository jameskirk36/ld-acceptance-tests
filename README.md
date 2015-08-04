
## Development environment setup

There is a development environment for this provided via a docker container.  This contains all  the tools needed to build, test and run this app.  The source code is linked into the container via a volume (see docker-compose.yml)

*Prerequisites:  You need [docker](https://docs.docker.com/installation/) and [docker-compose](https://docs.docker.com/compose/install/) installed. *

Open a terminal and change directory to the root of this repository.  Now run the following commands to create the environment and log in

Build the docker image:
```
docker build -t docker-acceptance-tests-env .
```

Start the container:
```
docker-compose up -d
```
Now login to the container with a bash shell
```
docker exec -it ldacceptancetests_mimirtests_1 bash
```

Now change directory to the root of this repository.  Your user home directory (~) has been linked as a volume /home/ in the docker container
```
cd /home/
```

Now navigate to this repository

### Build and test
Once the environment has been created (see above) build and test using:

```
./build.sh
```


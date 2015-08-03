FROM nice/ld-docker-build
MAINTAINER James kirk <james.kirk84@gmail.com>
RUN apt-get update -y
RUN apt-get install -y xvfb firefox

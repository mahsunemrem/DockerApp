docker build -t dockerconsoleapp . -> creates image

docker create --name dockerconsoleapp_container dockerconsoleapp -> creates container

docker start dockerconsoleapp_container -> starts container

docker ps -> shows active container

docker ps -a -> shows container with images

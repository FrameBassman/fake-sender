if [[ $TRAVIS_BUILD_NUMBER != "" ]]; then
  docker build --file ./Dockerfile . --tag framebassman/fake-sender:1.1.$TRAVIS_BUILD_NUMBER
  echo "$DOCKER_PASSWORD" | docker login -u "$DOCKER_USERNAME" --password-stdin
  docker push framebassman/fake-sender
fi
FROM docker.bin.sbb.ch/cloud/sbb-base-rhel-java:8-21

EXPOSE 8080
RUN mkdir /deploy

RUN echo $TESTS

# Muss zwingend im Docker file sein, sonst findet OpenShift die Variablen nicht
ARG ARTIFACTORY_USER
ARG ARTIFACTORY_PW

# ADD https://${ARTIFACTORY_USER}:${ARTIFACTORY_PW}@bin.sbb.ch/artifactory/estasch.mvn/ch/sbb/esta/test/test-rze/${VERSION}/test-rze-${VERSION}.jar /deploy/app.jar

# RUN chmod 777 /deploy/app.jar
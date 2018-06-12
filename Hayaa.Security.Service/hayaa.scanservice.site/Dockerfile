FROM ${dockerhos}/java-centos AS base
WORKDIR /app
EXPOSE 10822
COPY . .
ENTRYPOINT ["java", "-jar hayaa.scanservice.site-1.0.0-SNAPSHOT.jar"]
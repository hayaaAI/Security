FROM 192.168.31.59:15000/java-centos AS base
WORKDIR /app
EXPOSE 10822
COPY . .
ENTRYPOINT ["java", "-jar hayaa.scanservice.site-1.0.0-SNAPSHOT.jar"]
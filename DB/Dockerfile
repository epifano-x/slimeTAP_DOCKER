FROM mysql:8.0.33

ENV MYSQL_ROOT_PASSWORD=slime
ENV MYSQL_DATABASE=slime

COPY ./scripts/ /docker-entrypoint-initdb.d/

EXPOSE 3306
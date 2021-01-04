CLI докера
https://habr.com/ru/company/ruvds/blog/440660/

Dockerfile референс
https://tproger.ru/translations/docker-instuction/

########################################################
Билд
docker image build -t ankekatomeky/emptyweb:0.1 .

Запуск
docker container run -d -p 1000:80 ankekatomeky/emptyweb:0.1

Остановка и отчистка
Берем ид контейнера
docker container ls 
Кладем ид контейнера и останавливаем его и удаляем
docker container stop [containerId]
docker container rm [containerId]

Отчистить все остановленые контейнеры
docker container rm $(docker ps -a -q)
########################################################

dotnet add package Microsoft.EntityFrameworkCore     
dotnet add package Microsoft.EntityFrameworkCore.tools      
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
Прога для бд
https://www.beekeeperstudio.io

Установить постгресс
docker pull postgres 

docker run --rm --name pg-docker -e POSTGRES_PASSWORD=docker -d -p 5432:5432 -v ~/Desktop/Postgress:/var/lib/postgresql/data postgres

CREATE DATABASE yourdbname;
CREATE USER youruser WITH ENCRYPTED PASSWORD 'yourpass';
GRANT ALL PRIVILEGES ON DATABASE yourdbname TO youruser;
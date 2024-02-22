# 🔥 Домашнее задание #1

> - Создать веб-сервис, который:
>    - Отвечает на порту 8000
>    - Имеет HTTP-метод `GET http://*:8000/health`, возвращающий `{ "status": "OK" }`
> - Собрать Docker-образ приложения под архитектуру AMD64 и опубликовать его на Docker Hub

### Локальная сборка Docker-образа

> 💡 Выполнение команды осуществляется из [директории](./ContainerizedApplication/src/ContainerizedApplication.Api), включающей `Dockerfile`

```dockerfile
docker build -t riddlocat/otus_hw02:1.0 . --platform linux/amd64
```

### Скачивание Docker-образа из Docker Hub

```powershell
docker pull riddlocat/otus_hw02:1.0
```

### Запуск Docker-контейнера

```dockerfile
docker run -it --rm -p 8000:8000 --name otus_hw02 riddlocat/otus_hw02:1.0
```

### Ссылки

- [Dockerfile](./ContainerizedApplication/src/ContainerizedApplication.Api/Dockerfile)
- [Образ на Docker Hub](https://hub.docker.com/repository/docker/riddlocat/otus_hw02/tags?page=1&ordering=last_updated)
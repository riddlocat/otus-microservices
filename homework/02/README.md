# 🔥 Домашнее задание #1

> - _Создать веб-сервис, который:_
>    - _Отвечает на порту 8000_
>    - _Имеет HTTP-метод `GET http://*:8000/health`, возвращающий `{ "status": "OK" }`_
> - _Собрать Docker-образ приложения под архитектуру AMD64 и опубликовать его на Docker Hub_

### Сборка Docker-образа

> 💡 Выполнение команды осуществляется из [директории](/ContainerizedApplication/src/ContainerizedApplication.Api/), включающей `Dockerfile`

```dockerfile
docker build -t otus_hw02:latest . --platform linux/amd64
```

### Запуск Docker-контейнера

```dockerfile
docker run -it --rm -p 8000:8000 --name otus_hw02 otus_hw02
```

### Публикация Docker-образа на Docker Hub

### Ссылки

- [Dockerfile](/ContainerizedApplication/src/ContainerizedApplication.Api/Dockerfile)
- 
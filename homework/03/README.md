# 🔥 Домашнее задание #3

> - Создать веб-сервис, который:
>    - Отвечает на порту 8000
>    - Имеет HTTP-метод `GET http://*:8000/health`, возвращающий `{ "status": "OK" }`
> - Собрать Docker-образ приложения под архитектуру AMD64 и опубликовать его на Docker Hub
> - Написать манифесты для деплоя веб-сервиса в Kubernetes:
>    - Манифесты должны описывать сущности Deployment, Service, Ingress
>    - В Deployment необходимо указать Liveness, Readiness пробы
>    - Количество реплик должно быть не менее двух
>    - Необходимо использовать образ, загруженный на Docker Hub
>    - Необходимо назначить хост arch.homework в Ingress
>    - После применения манифестов GET-запрос на URL http://arch.homework/health должен возвращать объект `{ "status": "OK" }`
> - В Ingress должно быть правило, перенаправляющее все запросы с `/otusapp/{studentName}/*` на `arch.homework/health` (например, выполнение команды `curl arch.homework/otusapp/akovalev/health` перенаправит запрос на `arch.homework/health`)


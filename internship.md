# Программа стажировки .NET

Во время стажировки происходит знакомство со списком базовых тем. Темы рассматриваются в процессе создания учебного приложения.

## Порядок стажировки

Стажировка длится 3 месяца. Задания рассчитаны на 5-8 часов в день, поэтому стажировку можно пройти и быстрее (либо немного дольше). Если отсутствует доступ к необходимым частям задания или ресурсам компании, просьба обратиться к ментору.

### Этапы стажировки

* В первую неделю обустройство на рабочем месте, прохождение инструктажей
* После первого месяца стажировки по согласованию с ментором предварительный срез знаний
* В последний месяц по возможности введение в рабочий проект, либо выполнение дополнительных заданий по стажировке. Параллельно заполнение пробелов в теории и подготовка к сдаче аттестации на D1
* Сдача [аттестации на D1](https://gitlab.htc-cs.com/standards/dotnet/wikis/d1)

### Условия успешного прохождения стажировки
* Сделанное приложение и положительный отзыв ментора
* Успешно сданная [аттестация на D1](https://gitlab.htc-cs.com/standards/dotnet/wikis/d1)

### Трекинг времени

Все сотрудники отмечают время, в том числе стажеры. Отличие только в том, что стажер может отметить меньше 8 часов за день. Ниже полезные ссылки, которые помогут разобраться, как правильно отмечать время.
* [Как правильно отмечать время в трекере](https://task.htc-cs.com/projects/htcmisc/wiki/%D0%9A%D0%B0%D0%BA_%D0%BF%D1%80%D0%B0%D0%B2%D0%B8%D0%BB%D1%8C%D0%BD%D0%BE_%D0%BE%D1%82%D0%BC%D0%B5%D1%87%D0%B0%D1%82%D1%8C_%D0%B2%D1%80%D0%B5%D0%BC%D1%8F_%D0%B2_%D1%82%D1%80%D0%B5%D0%BA%D0%B5%D1%80%D0%B5)
* [Статусы в Redmine](https://task.htc-cs.com/projects/htcmisc/wiki/%D0%A1%D1%82%D0%B0%D1%82%D1%83%D1%81%D1%8B_%D0%B2_%D1%80%D0%B5%D0%B4%D0%BC%D0%B0%D0%B9%D0%BD%D0%B5)

### Отзыв стажера
После завершения стажировки будет здорово поделиться своими впечатлениями: что было легче и сложнее, что понравилось и не понравилось. Это поможет сделать стажировку лучше для следующих стажеров.

* [Вопросы для отзыва](https://gitlab.htc-cs.com/standards/dotnet/wikis/internship-feedback)

Отзыв нужно отправить RM-у на почту.


## ПО для работы

* Visual Studio 2019
* git
* Git Extentions (необязательно)
* SQL Server 2019 Developer Edition
* SQL Server Management Studio
* IIS
* Любой браузер

Как установить SQL Server:
https://computingforgeeks.com/install-sql-server-developer-edition-on-windows-server/

Как настроить Firewall для SQL Server 
https://docs.microsoft.com/ru-ru/sql/sql-server/install/configure-the-windows-firewall-to-allow-sql-server-access?view=sql-server-ver15

## Задание на стажировку

Приложение для просмотра меню и бронирования еды в буфете.

[Подробное описание задания](https://gitlab.htc-cs.com/standards/dotnet/wikis/internship-task)

Далее примерное разбиение по неделям. Если вы идете быстрее — отлично! Если вы немного выбиваетесь за обозначенные сроки, это не страшно. Напишите потом в отзыве на стажировку, с какими темами это произошло и как на ваш взгляд можно улучшить процесс освоения материала.

### Неделя 1

#### Темы
* Проектирование приложения
* Работа с системами контроля версий на примере Git
* Git Workflow

#### Практическое задание 1
Прочитать задание на стажировку. Определиться с разбиением приложения на подпроекты, нарисовать схему базы данных. Показать ментору и получить его консультацию, при необходимости совместно скорректировать.

#### Практическое задание 2
В солюшене создать проекты по спроектированной схеме.

#### Практическое задание 3
Начать освоение систем контроля версий на примере Git. Установить Git. Создать репозиторий [в гитлабе компании](https://gitlab.htc-cs.com). Добавить в него учебный проект. Дать права на репозиторий ментору. Всю дальнейшую разработку вести в git: для каждого законченного куска изменений создавать комит и пушить его в удаленный репозиторий. Ментор будет проверять выполненную работу по изменениям в репозитории.

#### Практическое заданчие 4
Ознакомиться с Git Workflow — с тем, как можно вести ветки в git (пригодится на будущих проектах).

#### Теория

Онлайн-курсы по git

[Hexlet.io > Основы Git](https://ru.hexlet.io/courses/git_base)

[Devcolibri > Youtube > Уроки Git](https://www.youtube.com/watch?v=en6gms6e54Q&list=PLIU76b8Cjem5B3sufBJ_KFTpKkMEvaTQR)

[Интерактивная обучалка](https://learngitbranching.js.org/)

Дополнительная информация о git

https://git-scm.com/book/ru/v1

https://stackoverflow.com/questions/315911/git-for-beginners-the-definitive-practical-guide

https://onlywei.github.io/explain-git-with-d3/
[Pro Git book](https://git-scm.com/book/ru/v2/)

[Atlassian git tutorials](https://www.atlassian.com/git/tutorials)

[Git: наглядная справка](https://marklodato.github.io/visual-git-guide/index-ru.html)

[Частые комнады Git (htmlacademy)](https://htmlacademy.ru/blog/86-useful-commands-for-working-with-git)

[Частые комнады Git (calculate-linux)](http://www.calculate-linux.org/main/ru/git)

git workflow

[http://technotes.skycover.ru/2013/01/10/git-workflow-dlya-vashego-proekta/](http://technotes.skycover.ru/2013/01/10/git-workflow-dlya-vashego-proekta/)

[http://blog.evercodelab.com/git-workflow/](http://blog.evercodelab.com/git-workflow/)

[https://habrahabr.ru/post/60030/](https://habrahabr.ru/post/60030/)

Про архитектуру
https://habr.com/ru/post/269589/

Поподробнее (хоть и с уклоном во фронтенд) https://habr.com/ru/post/493430/

---

### Неделя 2

#### Темы
* Логирование
* Работа с Management Studio
* Создание базы данных средствами Entity Framework

#### Практическое задание 1
Разобраться с уровнями логирования, грамотным логированием (когда оно нужно и зачем). В MVC приложении (клиенте для API либо в приложении для администратора) создать контроллер, с методом, который принимает строку из простой формы с инпутом. Добавить логирование возвращаемой строки на уровне Info. Проверить наличие файла с логами и информацию, которая была в него записана.

#### Практическое задание 2
Развернуть окружение для работы с БД, Management Studio. Разобраться со способами подключения к БД (Windows Authentication, SQL Server Authentication). Попробовать создать БД средствами Management Studio, отключиться и подключиться к ней. Разобраться с основными составляющими конекшн стринга к SQL Server.

#### Практическое задание 3
Разобраться, что такое ORM и зачем это нужно на примере Entity Framework. В слое данных добавить Entity Framework, создать модели базы данных через Code First, описать их при помощи Data Annotation и Fluent API (некоторые модели одним способом, некоторые другим), создать начальную миграцию (обратить внимание что если в солюшине несколько проектов необходимо выбрать нужный в Package Manager Console) и при помощи Management Studio убедиться, что созданная БД идентична задуманной. Не забудьте добавить ограничения на длину строк, а также проверьте, правильно ли создались связи между таблицами.

#### Теория
Логирование  
https://habrahabr.ru/post/98638/ - зачем логи, и описание библиотек. 
https://codewithmukesh.com/blog/serilog-in-aspnet-core-3-1/ - пример использования Serilog 
https://www.codeproject.com/Articles/140911/log-net-Tutorial - учебник по log4net. 

Что такое ORM  
http://internetka.in.ua/orm-intro/  

Entity Framework Core
https://www.entityframeworktutorial.net/efcore/entity-framework-core-migration.aspx - как создать миграцию и обновить базу на основании модели в коде
https://habr.com/ru/post/547910/ - нюансы при работе с EF миграциями
https://dotnetthoughts.net/using-ef-core-in-a-separate-class-library/ - EF Core и Class Library

### Неделя 3-4

#### Темы
* Работа с базой данных средствами Entity Framework
* Работа с базой данных средствами ADO.NET
* Консольные приложения, запускаемые по расписанию

#### Практическое задание 1
В слое данных необходимо реализовать методы доступа к данным. Идеальный вариант — реализовать интерфейсы репозиториев из слоя бизнес-логики, которые описывают необходимые для работы приложения методы. Один из репозиториев необходимо реализовать средствами ADO.NET.

#### Практическое задание 2
Создать консольную утилиту, которая с использованием репозиториев будет генерировать небольшие отчеты и сохранять их в csv-файлы. csv-файл — это простой текстовый файл с разделителями ячеек и строк. Его можно открыть в блокноте либо Excel. Через интерфейс Management Studio либо Navicat завести тестовые данные и проверить работу утилиты.

Примеры отчетов:
* В какие дни больше всего бронирований;
* Наиболее популярные блюда;
* Предпочитаемые пользователями блюда;
* Блюда, которых обычно не хватает.

На усмотрение ментора и стажера могут быть реализованы не все отчеты либо другие отчеты: зависит от скорости прохождения этого этапа.

#### Практическое задание 3
Настроить периодический запуск утилиты с помощью Task Scheduler. Это стандартный инструмент Windows, который работает с любыми исполняемыми файлами. Его можно запустить, нажав комбинацию Win+R и указав там taskschd.msc, либо просто через поиск по приложениям. Убедиться в том, что утилита периодически отрабатывает и создает новые отчеты.

В реальном проекте отчеты могли бы периодически отправляться владельцу буфета, и он с использованием этой информации мог бы улучшать свой буфет.


#### Теория

Стандартная ORM для .NET - Entity Framework Core 
https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=netcore-cli
https://www.entityframeworktutorial.net/efcore/entity-framework-core.aspx

Работа с СУБД через ADO.NET (запросы напрямую)  
Эндрю Троелсен. Язык программирования C# и платформа .NET. Глава "ADO.NET, часть I: подключенный уровень"  
https://professorweb.ru/my/ADO_NET/base/level1/1_1.php

Язык SQL  
Учебник по языку SQL на примере SQL Server
https://habrahabr.ru/post/256045/ (четвертая часть, в шапке есть ссылки на первые три)

Книжки по SQL  
Ицик Бен-Ган. Microsoft SQL Server. Основы T-SQL (в библиотеке офиса есть бумажная книжка)  
Мартин Грабер. Понимание SQL http://www.sql.ru/docs/sql/u_sql/

Примеры csv-файлов
https://people.sc.fsu.edu/~jburkardt/data/csv/csv.html

Планировщик задач в Windows.
https://docs.microsoft.com/en-us/windows/win32/taskschd/task-scheduler-start-page
https://stackoverflow.com/questions/52946410/how-to-execute-net-core-2-0-console-app-using-windows-task-scheduler


### Неделя 5

#### Темы
* Web: создание простых страничек с выводом данных, работа с формами.
* Работа с ASP.NET контролерами

### Практическое задание 1
Разобраться с принципом внедрения зависимостей (Dependency Injection). Далее применять его в проекте.

#### Практическое задание 2
Реализовать контроллеры, бизнес-логику, верстку для функционала администратора в виде классического веб-приложения с Razor (пока без учета аутентификации).

#### Теория

Web-приложения, Razor
https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-3.1&tabs=visual-studio
https://docs.microsoft.com/en-us/aspnet/web-pages/overview/getting-started/introducing-razor-syntax-c

HTML & CSS  
http://theory.phphtml.net/books/css/  

Верстка  
http://htmlbook.ru/samhtml  
http://htmlbook.ru/samcss  

Javascript  
https://learn.javascript.ru/first-steps  
https://www.site-do.ru/js/js1.php

JQuery  
http://anton.shevchuk.name/javascript/jquery-for-beginners/

XMLHttpRequest  
https://learn.javascript.ru/ajax-xmlhttprequest

Ajax-формы  
https://metanit.com/sharp/mvc/10.4.php


## Неделя 6-7

#### Темы
* Работа с ASP.NET Web API
* Dependency Injection
* Swagger
* Устройство HTTP-протокола

#### Практическое задание 1
Реализовать Web API контроллеры, бизнес-логику для функционала пользователя (пока без авторизации).

#### Практическое задание 2
Потестировать работу методов API с помощью интерфейса Swagger.

#### Практическое задание 3
Изучить содержание HTTP-запросов приложению и ответов от него (3 составные части, методы get/post/put/delete). Для функционала пользователя сделать это через [Postman](https://www.postman.com/downloads/). Для функционала администратора через панель инструментов разработчика в браузере (F12 -> вкладка Network).
* Важно понимать, что http — это текстовый протокол. Любой запрос и ответ — это просто текстовый файл, отформатированный определенным образом
* Обратите внимание, где передаются данные в get-запросе и в post-запросе
* Желательно разобраться в возможных [форматах тела для post-запросов](https://developer.mozilla.org/ru/docs/Web/HTTP/Methods/POST)

#### Теория

Dependency Injection
https://docs.microsoft.com/ru-ru/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-3.1

Swagger  
https://docs.microsoft.com/ru-ru/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-5.0
Включение документирования в Swagger
https://stackoverflow.com/questions/42018857/webapi-controller-summary-is-not-showing-on-swagger-documentation

Кратко про Rest  
https://stackoverflow.com/questions/671118/what-exactly-is-restful-programming?rq=1
https://stackoverflow.com/questions/1619152/how-to-create-rest-urls-without-verbs?rq=1

Длинно про Rest  
https://www.restapitutorial.com/
https://blog.wishtack.com/rest-apis-best-practices-and-security/

HTTP-протокол  
https://habr.com/ru/post/215117/
https://developer.mozilla.org/ru/docs/Web/HTTP/Overview
https://ru.wikipedia.org/wiki/HTTP#%D0%A1%D1%82%D1%80%D1%83%D0%BA%D1%82%D1%83%D1%80%D0%B0_%D0%BF%D1%80%D0%BE%D1%82%D0%BE%D0%BA%D0%BE%D0%BB%D0%B0
https://developer.mozilla.org/ru/docs/Web/HTTP/Methods/POST

Атрибуты Web API 
https://www.dotnetcurry.com/aspnet/1390/aspnet-core-web-api-attributes

### Неделя 8-9

#### Темы
* IIS
* Аутентификация, авторизация
* Обработка ошибок, кастомные страницы с ошибками
* Публикация приложения

#### Практическое задание 1
Развернуть IIS, разобраться в назначении основных компонентов. Развернуть созданные приложение в IIS. Почитать про файл hosts. 

#### Практическое задание 2
В MVC приложении реализовать авторизацию на основе форм. В API добавить использование Asp.Net Identity и реализовать аутентификацию на основе JSON Web Token (JWT), добавить в токен необходимые пользовательские данные используя утверждения (Claims). Реализовать методы доступа к пользовательским данным, реализовать сервис по работе с пользовательскими данными

#### Практическое задание 3
Добавить кастомную страницу с ошибками. Настроить web.config так, чтобы для пользователя выводилась эта страница, а для разработчика выводилась отладочная информация.

#### Практическое задание 4
Разобраться со [средствами публикации в Visual Studio](https://docs.microsoft.com/en-us/visualstudio/deployment/deploying-applications-services-and-components?view=vs-2019).Выполнить публикацию в локальную папку.

#### Практическое задание 5
Подружить Swagger c JWT Authentication

Если будет время и желание, то можно разобраться с Docker, инструкция в [Онбоардинг D1-D2](https://gitlab.htc-cs.com/standards/dotnet/wikis/onboarding-d1-d2). Но можно заняться этим и после стажировки. 

#### Теория

Про IIS
https://habr.com/ru/post/189086/

Публикация приложений в Visual Studio  
https://docs.microsoft.com/en-us/visualstudio/deployment/deploying-applications-services-and-components?view=vs-2019

Разница между аутентификацией и авторизацией   https://www.opennet.ru/docs/BSD/qa/authoriz-vs-authent.html  

Настройка аутентификации в IIS   https://professorweb.ru/my/ASP_NET/security/level2/2_3.php  

Настройка авторизации в IIS   https://professorweb.ru/my/ASP_NET/security/level4/4_4.php  

Примеры https://forums.asp.net/t/1141844.aspx?Asterisk+for+All+users+or+Authenticated+Users+web+config+  

Кастомная формовая аутентификация в веб-приложении   https://www.codeproject.com/Articles/578374/AplusBeginner-splusTutorialplusonplusCustomplusF  

Про куки   https://www.nczonline.net/blog/2009/05/05/http-cookies-explained/  
https://metanit.com/sharp/aspnet5/15.2.php

Про JWT   https://metanit.com/sharp/aspnet5/23.7.php
https://medium.com/@ozgurgul/asp-net-core-2-0-webapi-jwt-authentication-with-identity-mysql-3698eeba6ff8

JWT & Claims    https://www.c-sharpcorner.com/article/jwt-json-web-token-authentication-in-asp-net-core/

Asp.Net Identity & JWT   https://fuse8.ru/articles/using-asp-net-core-identity-and-jwt

Как поставить IIS   https://www.howtogeek.com/112455/how-to-install-iis-8-on-windows-8/  

Как разместить приложение в IIS   https://metanit.com/sharp/mvc/13.2.php  

Swagger & JWT Authentication https://codeburst.io/api-security-in-swagger-f2afff82fb8e

Настройка кастомных страниц в web.config  
http://benfoster.io/blog/aspnet-mvc-custom-error-pages  


### Неделя 10

#### Темы
* Фундаментальные понятия .NET (сборка, CLR/IL, JIT-компиляция)
* Подготовка к сдаче аттестации

#### Практическое задание 1
Разобраться с разделом "Фундаментальные понятия .NET" из [программы аттестации на D1](https://gitlab.htc-cs.com/standards/dotnet/wikis/d1). Информацию об этом можно найти в книжках, предложенных в теории (либо просто нагуглить). Для лучшего практического понимания выполнить следующее задание.

Имеется сборка [StudyLib.dll](https://gitlab.htc-cs.com/standards/dotnet/blob/master/StudyLib.dll). У сборки отсутствует документация. Используя методы сборки, отправить себе на почту письмо. Если все сделано правильно, то письмо будет одобрительное.

#### Практическое задание 2
Изучить [программу аттестации на D1](https://gitlab.htc-cs.com/standards/dotnet/wikis/d1). Подготовиться к сдаче предварительной аттестации.

#### Теория

Про .NET  
Кратко: http://www.intuit.ru/studies/courses/1139/250/lecture/6422?page=1  

Книги  
Эндрю Троелсен. Язык программирования C# и платформа .NET  
Герберт Шилдт. C#: полное руководство.  
Джеффри Рихтер. CLR via C#.  
Джозеф Албахари, Бен Албахари. C#. Справочник. Полное описание языка (C# in a Nutshell)  

Репозиторий с книжками  
https://github.com/micros-uz/csharp/tree/master/Level%201/Books  
.Net   
http://www.realcoding.net/article/view/2873  
.Net & Web  
http://www.intuit.ru/studies/courses/1139/250/lecture/6422?page=1


### Неделя 11 и далее

#### Темы
* Реализация MVC клиента для пользовательского API
* Подготовка к сдаче аттестации

#### Практическое задание 1
Необходимо создать MVC клиента для пользовательского API, которое будет реализовывать вызовы всех методов API. 
Вызовы методов API реализовать используя HttpClient

#### Практическое задание 2
Добавить в API метод принимающий файл и его краткое описание (поле типа string).
В MVC клиенте реализовать форму для отправки файла с описанием и вызов этого метода API 

#### Практическое задание 3
Договоритесь с ментором о подготовке к аттестации на D1. Обсудите с ментором все места, которые не до конца понятны. В оставшийся месяц их нужно разобрать, а затем сдать итоговую аттестацию. На итоговой аттестации будут присутствовать ментор, другой специалист из отдела .NET и RM.

Если есть возможность и проект, может начаться постепенное подключение к будущему боевому проекту.

Поздравляю, вы почти у цели!

#### Теория

HttpClient - https://habr.com/ru/post/424873/

## Куда двигаться после стажировки

* [Онбоардинг D1-D2](https://gitlab.htc-cs.com/standards/dotnet/wikis/onboarding-d1-d2)
* [Аттестация на D2](https://gitlab.htc-cs.com/standards/dotnet/wikis/d2)

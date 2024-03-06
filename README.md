![image](https://github.com/KulnevFedya/-working-with-git-bash/assets/127484484/d9cb5ac3-e2ce-46ab-9868-6cb88a941b4a)#Отчёт по работе с консолью Git Bash

В локальной папке на компьютере открываю консоль Git Bash и прописываю следующиую функцию:
```
git init
```
Это команда позволяет инициализировать новый репозиторий GIT и начинает отслеживание существующего каталога. 
Затем, прописываю команду:
```
git remote add origin https://github.com/KulnevFedya/-working-with-git-bash
```
Эта команда добавляет удаленный репозиторий.
Прописываю две следующие команды, которые позволяют загрузить изменения на удалённый репозиторий:
```
git add .
git commit -m “Моё первое сообщение коммита“
git push origin master
```
![image](https://github.com/KulnevFedya/-working-with-git-bash/assets/127484484/02306c13-64a0-4950-a077-7b067d4ec184)
Чтобы проверить каталог коммитов использую команду:
```
git log
```
Просматриваю все доступные ветки через команду:
```
git branch
```
Создаю две новых ветки: “**feature**” и “**featur**”, затем удаляю одну из веток и снова просматриваю все ветки.
```
git branch feature/new-feature
git branch featur/new-feature
git branch -d featur/new-feature
git branch
```

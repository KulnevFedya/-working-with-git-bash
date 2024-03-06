<h3 align="center">Отчёт по работе с консолью Git Bash</h3>

В локальной папке на компьютере открываю консоль *Git Bash* и прописываю следующиую функцию:
```
git init
```
Это команда позволяет инициализировать новый репозиторий *GitHub* и начинает отслеживание существующего каталога. 
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
Чтобы отменить все изменения в файле 'тестовый блокнот', использую команду:
```
git checkout -- тестовый блокнот
```
Чтобы создать конфликт в *Git Bash*, я изменил один и тот же файл (тестовый блокнот) в одной и той же строке на двух ветках. Создал новую ветку и внес изменения:
```
git checkout -b new-branch
echo "Новая строка" >> тестовый_блокнот.txt
git add тестовый_блокнот.txt
git commit -m "Коммит для новой ветки"
```
вернулся на основную ветку и также внёс изменения в файл:
```
git checkout main
echo "Другая строка" >> тестовый_блокнот.txt
git add тестовый_блокнот.txt
git commit -m "Коммит для основной ветки"
```
Открыл файл с конфликтом в текстовом редакторе и изменил содержимое файла. После того как устранил все конфликты, выполнил команду:
```
git add тестовый_блокнот.txt
```
Затем сделал коммит:
```
git commit -m "Разрешил все конфликты"
```
Чтобы сделать реабзирование текущуей ветки на ветку master использовал слдующую команду:
```
git rebase master
```
*Git* начнет процесс ребазирования (использовать когда возникают конфликты), перенося ваши коммиты на верхушку ветки master.
Чтобы склонировать репозиторий с *Github*, создал новую папку. И прописал следующую команду в новой папке:
```
git clone https://github.com/KulnevFedya/-working-with-git-bash
```

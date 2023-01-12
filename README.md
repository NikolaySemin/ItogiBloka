# Итоги блока. Выбор специализации. IT-специалист

## *Задача*

 Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

    Примеры:
    [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
    [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
    [“Russia”, “Denmark”, “Kazan”] → []
    
***
## *Решение*

Вводим элементы первоначального массива в терминал через пробел.
Задаем переменную `MaxWordLength` отвечающую за длину символов в элементе массива(в данном случае "3").

В методе `GetShortWordsArray` объявляется строчный массив, вводится переменная `length` равная длине массива, строчный массив `result` равный переменной `length` и переменная `count` равная нулю.

Запускается цикл `for` соразмерный длине массива, внутри цикла проверка условия `if` (элемент массива <=`MaxWordLength`), при соблюдении условия в массив `result` записываем проверяемый элемент массива, а к переменной `count` прибавляется "1".

При выходе из цикла `for` возвращаем измененный массив `result` с элементами массива, прошедшими проверку условием `if`, и длиной массива равной переменной `count`.

Далее с помощью метода `PrintArray` выводим наш массив в терминал.

Метод `PrintTask` - использует предыдущие методы для вывода решения задачи в терминал.
***
Ссылки на блок-схемы методов:
* [PrintArray](PrintArray.drawio.png)
* [GetShortWordsArray](method.drawio.png)
* [Программа реализации алгоритма](Task\Program.cs)


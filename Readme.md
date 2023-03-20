# Решение домашнего задания

*Создано 20.03.2023*

**_Написать программу, которая из имеющего массива строк, формирует массив из строк, длина которых меньше либо равна трём символам. Первоначальный массив можно задать с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами._**


**Создание нового массива для вывода найденных элементов**
* Для создания нового массива необходимо определить его размер, соответственно количеству найденных элементов.

* Решаем это перебором элементов вводного массива и вычислением длины (Length) строки каждого элемента, и в случае выполнения условия, прибавляем счётчик размера size.

* По окончании перебора всего вводного массива, создаём новый массив с найденным окончательным размером size.

**Заполнение нового созданного массива элементами согласно условию**

* Для заполнения нового созданного массива элементами, выполняем новый цикл с перебором с тем же условием, чтобы элемент включал три или меньше символов.

**Вывод на печать**
* Для вывода на печать делаем метод для вывода элементов массива в строку с разделителями в виде запятой и пробелом, используя метод Join.
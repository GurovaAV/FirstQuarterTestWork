# Итоговая проверочная работа за первую четверть

## Задача
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Решение
Было решено массив ввести в ручную с клавиатуры, предварительно запросив у пользователя желаемый размер массива.

При решении задачи используются следующие методы:

*string[] CreateArray(int size)* - метод, позволяющий пользователю ввести необходимые элементы в массив заданной длины;

*string[] ArrayElementsSelect(string[] array1)* - метод, выбирающий элементы длиной 3 и менее символов из имеющегося массива и добавляющий их в новый массив.
Это ключевой метод в данной программе. В качестве атрибута используется созданный предыдущим методом массив. Создается счетчик count, изначально равный нулю. Затем цикл проходит по массиву и находит элементы, удовлетворяющие условию, при этом счетчик увеличивается на единицу, а подходящий элемент становится элементом нового массива.

*void ShowArray(string[] array)* - метод, выводящий массив на экран.
Используется дважды: для вывода исходного массива и массива, получившегося после выборки.

**Выполнила Гурова Анастасия.**

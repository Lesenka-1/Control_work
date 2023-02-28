# Итоговая проверочная работа

> _**Задача:** Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами._

**Описание решения:**

1. Задаём массив
2. Высчитываем количество элементов нового массива
    1. Вводим переменную для количества элементов нового массива
    2. Пока индекс меньше количества элементов массива, проверяем условие: 
    3. если количество символов в элементе меньше 4, то увеличиваем на один переменную количества элементов нового массива.
3. Заполняем новый массив 
    1. Вводим новый массив с количеством элементов рассчитанным ранее
    2. Пока индекс меньше длинны изначального массива, проверяем условие:
    3. если количество символов в элементе меньше 4, то это значение присваиваем соответствующему элементу нового массива и увеличиваем на один индекс нового массива.
4. Выводим новый массив.
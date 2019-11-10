# formalLangs
Задание 1.

Написать программу, характеризующую недетерменнированные автоматы.

Реализовать функцию maxString(string str, int startIndex). Функция возвращает пару <bool, int>, где bool отвечает на вопрос: является ли какая-то подстрока, в строке str с символа
startIndex, допускаемой данным автоматом, а int обозначает количество символов в такой подстроке максимальной длины.

Программа получает на вход файл с описанием автомата и файл с текстом, который необходимо проанализировать.

На выход программа выдает файл со всеми словами из текста, которые допускаются заданным автоматом.

Задание 2.

Реализовать лексический анализатор. 

На вход ему подаётся набор автоматов, характеризующих классы лексем(например: идентификатор, ключевое слово и т.п.). 

У каждого автомата есть приоритет. Система приоритетов нужна для решения проблемы пересечения классов лексем, например, лексему while мы можем отнести и к идентификаторам, и к ключевым словам, но так как у автомата, характеризующего класс лексем ключевых слов больше приоритет, то мы относим while именно к классу лексем ключевых слов, а не к классу лексем идентификаторов.

На выходе лексический анализатор должен выдавать пару <название класса лексем, лексема>.

Задание 3.

На вход подается файл с описанием лексики:
<Название класса лексем : приоритет : регулярное выражение>.
Также подается файл с текстом, который нужно проанализировать.

На основании регулярного выражения необходимо программно построить автомат.

На выходе получаем файл с парами <название класса лесем, лексема>, как во втором задании.

You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

Return the merged string.



Example 1:

Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"
Explanation: The merged string will be merged as so:
word1:  a   b   c
word2:    p   q   r
merged: a p b q c r
Example 2:

Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"
Explanation: Notice that as word2 is longer, "rs" is appended to the end.
word1:  a   b
word2:    p   q   r   s
merged: a p b q   r   s
Example 3:

Input: word1 = "abcd", word2 = "pq"
Output: "apbqcd"
Explanation: Notice that as word1 is longer, "cd" is appended to the end.
word1:  a   b   c   d
word2:    p   q
merged: a p b q c   d


Constraints:

1 <= word1.length, word2.length <= 100
word1 and word2 consist of lowercase English letters.

-------------------------------

Вам даны две строки word1 и word2. Объедините строки, добавляя буквы в альтернативном порядке, начиная с word1. Если одна строка длиннее другой, добавьте дополнительные буквы в конец объединенной строки.

Верните объединенную строку.

Пример 1:

Ввод: word1 = "abc", word2 = "pqr"
Вывод: "apbqcr"
Объяснение: Объединенная строка будет выглядеть следующим образом:
word1:  a   b   c
word2:    p   q   r
merged: a p b q c r
Пример 2:

Ввод: word1 = "ab", word2 = "pqrs"
Вывод: "apbqrs"
Объяснение: Обратите внимание, что поскольку word2 длиннее, "rs" добавляется в конец.
word1:  a   b
word2:    p   q   r   s
merged: a p b q   r   s
Пример 3:

Ввод: word1 = "abcd", word2 = "pq"
Вывод: "apbqcd"
Объяснение: Обратите внимание, что поскольку word1 длиннее, "cd" добавляется в конец.
word1:  a   b   c   d
word2:    p   q
merged: a p b q c   d

Ограничения:

1 <= длина word1, длина word2 <= 100
word1 и word2 состоят из строчных английских букв.
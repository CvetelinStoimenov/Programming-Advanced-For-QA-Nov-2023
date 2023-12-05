
# 2. Enter Numbers

Write a method **ReadNumber (int start, int end)** that enters an integer number in a given range 
(**start…end**), **excluding** the numbers **start** and **end**. If an **invalid number** or 
a **non-number** text is entered, the method should **throw an exception**. Using this method 
write a program that enters **10 numbers: a1, a2, … a10, such that 1 \< a1 \< … \< a10 \< 100**. 
If the user enters an invalid number,continue while there are 10 valid numbers entered. 
Print the array elements, separated with **comma and space ","**.

## Hints

- When the entered input holds a non-integer value, print: **"Invalid Number!"**
- When the entered input holds an integer that is out of range, print:

" **Your number is not in range {currentNumber} - 100!**"

## Examples

| **Input** | **Output** |
| --- | --- |
| 2<br>3<br>4<br>5<br>6<br>7<br>8<br>9<br>10<br>11 | 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 |
| 1<br>2<br>1<br>3<br>p<br>4<br>5<br>6<br>7<br>8<br>9<br>10<br>11 | Your number is not in range (1 - 100)<br>Your number is not in range (1 – 100)<br>Invalid Number!<br>2, 3, 4, 5, 6, 7, 8, 9, 10, 11 |

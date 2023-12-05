# 3. Sum of Integers

You will receive a sequence of **elements of different types**, separated by **space**. 
Your task is to calculate the sum of all valid integer numbers in the input. 
Try to add each element of the array to the sum and **write messages **for the possible** exceptions**
while processing the element:

- If you receive an **element**, which is **not in the correct format (FormatException)**:
**"The element '\{element}' is in wrong format!"**
- If you receive an **element**, which is **out of the integer type range (OverflowException)**:
**"The element '\{element}' is out of range!"**

After each processed element add the following message:

**"Element '\{element}' processed - current sum: \{sum}"**

At the end print the total sum of all integers:

**"The total sum of all integers is: \{sum}"**

## Examples

| **Input** | **Output** |
| --- | --- |
| 2147483649 2 3.4 5 invalid 24 -4 | The element '2147483649' is out of range!<br>Element '2147483649' processed - current sum: 0<br>Element '2' processed - current sum: 2<br>The element '3.4' is in wrong format!<br>Element '3.4' processed - current sum: 2<br>Element '5' processed - current sum: 7<br>The element 'invalid' is in wrong format!<br>Element 'invalid' processed - current sum: 7<br>Element '24' processed - current sum: 31<br>Element '-4' processed - current sum: 27<br>The total sum of all integers is: 27 |
| 9876 string 10 -2147483649 -8 3 4.86555 8 | Element '9876' processed - current sum: 9876<br>The element 'string' is in wrong format!<br>Element 'string' processed - current sum: 9876<br>Element '10' processed - current sum: 9886<br>The element '-2147483649' is out of range!<br>Element '-2147483649' processed - current sum: 9886<br>Element '-8' processed - current sum: 9878<br>Element '3' processed - current sum: 9881<br>The element '4.86555' is in wrong format!<br>Element '4.86555' processed - current sum: 9881<br>Element '8' processed - current sum: 9889<br>The total sum of all integers is: 9889 |

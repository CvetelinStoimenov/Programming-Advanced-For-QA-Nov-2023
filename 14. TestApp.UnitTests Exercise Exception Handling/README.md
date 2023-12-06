# Exercises: Unit Testing Exceptions

Tasks for exercise in class and for homework to the course ["Programming Advanced for QA" @ SoftUni](https://softuni.bg/trainings/4257/programming-advanced-for-qa-november-2023).

Submit your solutions here: [https://judge.softuni.org/Contests/4493](https://judge.softuni.org/Contests/4493/Exceptions-and-Error-Handling-Unit-Testing-Exercise)


# 1. Unit Test: Reverse – Argument Null Exception

Look at the **provided skeleton** and examine the **Exceptions.cs** class that you will test:

![image info](pic./Picture1.png)

The class has **multiple methods each showing the use of different exceptions**.

The first method, **ArgumentNullReverse** () , takes in a **string and reverses it**. If the string is **null** an **ArgumentNullException** is thrown:

![image info](pic./Picture2.png)

Then, look at the tests inside the **ExceptionTests.cs** class:

![image info](pic./Picture3.png)

Notice the use of a **setup method **, so each test has a brand new** exception instance** to use.

![image info](pic./Picture4.png)

The two tests are **partially finished**, and your task is to finish them. The tests should run when you're finished:

![image info](pic./Picture5.png)


# 2. Unit Test: Calculate Discount – Argument Exception

The **ArgumentCalculateDiscount () method** takes in a **total price decimal** , and **discount decimal**. It calculates and returns the discounted price. If the discount is **lower than 0 or higher than 100** an **ArgumentException** is thrown:

![image info](pic./Picture6.png)

Now, look at the tests:

![image info](pic./Picture7.png)

You are given **two partially finished** test, the rest are **empty,** and your task is to finish them. The tests should run when you're finished:

![image info](pic./Picture8.png)

# 3. Unit Test: Get Element – Index out of Range Exception

The **IndexOutOfRangeGetElement () method** takes in an **array of integers** , and an **index**. It **retrieves** the element from the **array** at the **given index**. If the index is **lower than 0 or higher / equal** to the **length** an **IndexOutOfRangeException** is thrown:

![image info](pic./Picture9.png)

Now, look at the tests:

![image info](pic./Picture10.png)

You are given **one partially finished** test, the rest are **empty,** and your task is to finish them. The tests should run when you're finished:

![image info](pic./Picture11.png)


# 4. Unit Test: Perform Secure Operation – Invalid Operation
 Exception

The **InvalidOperationPerformSecureOperation () method** takes in a **Boolean indicating if the user is logged in**. If the user is not logged in an **InvalidOperationException** is thrown:

![image info](pic./Picture12.png)

Now, look at the tests:

![image info](pic./Picture13.png)

You are given **two empty** tests, and your task is to finish them. The tests should run when you're finished:

![image info](pic./Picture14.png)


# 5. Unit Test: Parse Int - Format Exception

The **FormatExceptionParseInt () method** takes in a **string as input** and tries to **parse** it into an **integer**. If the string is not a valid number a **FormatException** is thrown:

![image info](pic./Picture15.png)

Now, look at the tests:

![image info](pic./Picture16.png)

You are given **two empty** tests, and your task is to finish them. The tests should run when you're finished:

![image info](pic./Picture17.png)


# 6. Unit Test: Find Value by Key – Key Not Found Exception

The **KeyNotFoundFindValueByKey () method** takes in a **dictionary** , and a **string representing a key from the dictionary**. If the key does not exist in the dictionary a **KeyNotFoundException** is thrown:

![image info](pic./Picture18.png)

Now, look at the tests:

![image info](pic./Picture19.png)

You are given **two empty** tests, and your task is to finish them. The tests should run when you're finished:

![image info](pic./Picture20.png)

# 7. Unit Test: Add Numbers – Overflow Exception

The **OverflowAddNumbers () method** takes in **two numbers to be summed together**. If summing the numbers **overflows the integer type** a **OverflowException** is thrown:

![image info](pic./Picture21.png)

Now, look at the tests:

![image info](pic./Picture22.png)

You are given **three empty** tests, and your task is to finish them. The tests should run when you're finished:

![image info](pic./Picture23.png)

# 8. Unit Test: Divide Numbers – Divide by Zero Exception

The **DivideByZeroDivideNumbers () method** takes in a **two numbers to be divided**. If the **divisor is 0** a **DivideByZeroException** is thrown:

![image info](pic./Picture24.png)

Now, look at the tests:

![image info](pic./Picture25.png)

You are given **two empty** tests, and your task is to finish them. The tests should run when you're finished:

![image info](pic./Picture26.png)

# 9. Unit Test: Sum Collection Elements

The **SumCollectionElements () method** takes in an **array of integers** , and an **index**. If the collection is **null** an **ArgumentNullException** is thrown, or if the **index is out of bounds** an **IndexOutOfRangeException** is thrown:

![image info](pic./Picture27.png)

Now, look at the tests:

![image info](pic./Picture28.png)

You are given **three empty** tests, and your task is to finish them. The tests should run when you're finished:

![image info](pic./Picture29.png)

# 10. Unit Test: Get Element as Number

The **GetElementAsNumber () method** takes in a **dictionary** , and a **string representing a key from the dictionary**. If the key does not exist in the dictionary a **KeyNotFoundException** is thrown, if the value **cannot be converted to integer** a **FormatException** is thrown:

![image info](pic./Picture30.png)

Now, look at the tests:

![image info](pic./Picture31.png)

You are given **two empty** tests, and your task is to finish them. The tests should run when you're finished:

![image info](pic./Picture32.png)

At the end make sure all your tests run:

![image info](pic./Picture33.png)
# Exercises: Unit Testing Exceptions

Tasks for exercise in class and for homework to the course ["Programming Advanced for QA" @ SoftUni](https://softuni.bg/trainings/4257/programming-advanced-for-qa-november-2023).

Submit your solutions here: [https://judge.softuni.org/Contests/4493](https://judge.softuni.org/Contests/4493/Exceptions-and-Error-Handling-Unit-Testing-Exercise)

1.
# Unit Test: Reverse – Argument Null Exception

Look at the **provided skeleton** and examine the **Exceptions.cs** class that you will test:

![Picture 1](RackMultipart20231206-1-oq7oml_html_e703169363f0e150.gif)

The class has **multiple methods each showing the use of different exceptions**.

The first method, **ArgumentNullReverse**** () **, takes in a** string ****and reverses it**. If the string is **null** an **ArgumentNullException** is thrown:

![Picture 1](RackMultipart20231206-1-oq7oml_html_cd3294e79012bf46.gif)

Then, look at the tests inside the **ExceptionTests.cs** class:

![Picture 1](RackMultipart20231206-1-oq7oml_html_1c05519b67460ce1.gif)

Notice the use of a **setup**** method **, so each test has a brand new** exception instance** to use.

![Picture 1](RackMultipart20231206-1-oq7oml_html_66dd8027d5eed217.gif)

The two tests are **partially**** finished**, and your task is to finish them. The tests should run when you're finished:

![Picture 1](RackMultipart20231206-1-oq7oml_html_8ee6ff05276d2b0.gif)

1.
# Unit Test: Calculate Discount – Argument Exception

The **ArgumentCalculateDiscount**** () ****method** takes in a **total price decimal** , and **discount decimal**. It calculates and returns the discounted price. If the discount is **lower than 0 or higher than 100** an **ArgumentException** is thrown:

![Picture 1](RackMultipart20231206-1-oq7oml_html_ea9134cbfe2cdc64.gif)

Now, look at the tests:

![Picture 1](RackMultipart20231206-1-oq7oml_html_3289003072b67681.gif)

You are given **two**** partially ****finished** test, the rest are **empty,** and your task is to finish them. The tests should run when you're finished:

![Picture 1](RackMultipart20231206-1-oq7oml_html_f96da20624d790bc.gif)

1.
# Unit Test: Get Element – Index out of Range Exception

The **IndexOutOfRangeGetElement**** () ****method** takes in an **array of integers** , and an **index**. It **retrieves** the element from the **array** at the **given index**. If the index is **lower than 0 or higher / equal** to the **length** an **IndexOutOfRangeException** is thrown:

![Picture 1](RackMultipart20231206-1-oq7oml_html_7be784d8cf58795c.gif)

Now, look at the tests:

![Picture 1](RackMultipart20231206-1-oq7oml_html_3f3aa20b3ea4b248.gif)

You are given **one**** partially ****finished** test, the rest are **empty,** and your task is to finish them. The tests should run when you're finished:

![Picture 1](RackMultipart20231206-1-oq7oml_html_921c1d30d2f859a8.gif)

1.
# Unit Test: Perform Secure Operation – Invalid Operation
 Exception

The **InvalidOperationPerformSecureOperation**** () ****method** takes in a **Boolean indicating if the user is logged in**. If the user is not logged in an **InvalidOperationException** is thrown:

![Picture 1](RackMultipart20231206-1-oq7oml_html_6e4c6d32750813c6.gif)

Now, look at the tests:

![Picture 1](RackMultipart20231206-1-oq7oml_html_134151c6ee54b16a.gif)

You are given **two**** empty** tests, and your task is to finish them. The tests should run when you're finished:

![Picture 1](RackMultipart20231206-1-oq7oml_html_ce62cb892529fd89.gif)

1.
# Unit Test: Parse Int - Format Exception

The **FormatExceptionParseInt**** () ****method** takes in a **string as input** and tries to **parse** it into an **integer**. If the string is not a valid number a **FormatException** is thrown:

![Picture 1](RackMultipart20231206-1-oq7oml_html_9c178e96e44d1a75.gif)

Now, look at the tests:

![Picture 1](RackMultipart20231206-1-oq7oml_html_25bc2add70d4ffc0.gif)

You are given **two**** empty** tests, and your task is to finish them. The tests should run when you're finished:

![Picture 1](RackMultipart20231206-1-oq7oml_html_91ef3839bc9cbe53.gif)

1.
# Unit Test: Find Value by Key – Key Not Found Exception

The **KeyNotFoundFindValueByKey**** () ****method** takes in a **dictionary** , and a **string representing a key from the dictionary**. If the key does not exist in the dictionary a **KeyNotFoundException** is thrown:

![Picture 1](RackMultipart20231206-1-oq7oml_html_2d003b4f04326180.gif)

Now, look at the tests:

![Picture 1](RackMultipart20231206-1-oq7oml_html_42171771a3a3f90e.gif)

You are given **two**** empty** tests, and your task is to finish them. The tests should run when you're finished:

![Shape1](RackMultipart20231206-1-oq7oml_html_122f63423a0d1851.gif)

1.
# Unit Test: Add Numbers – Overflow Exception

The **OverflowAddNumbers**** () ****method** takes in **two numbers to be summed together**. If summing the numbers **overflows the integer type** a **OverflowException** is thrown:

![Picture 1](RackMultipart20231206-1-oq7oml_html_6f67cb646bd76e48.gif)

Now, look at the tests:

![Picture 1](RackMultipart20231206-1-oq7oml_html_55abf917355cee7b.gif)

You are given **three**** empty** tests, and your task is to finish them. The tests should run when you're finished:

![Picture 1](RackMultipart20231206-1-oq7oml_html_197b92aaf0d68665.gif)

1.
# Unit Test: Divide Numbers – Divide by Zero Exception

The **DivideByZeroDivideNumbers**** () ****method** takes in a **two numbers to be divided**. If the **divisor is 0** a **DivideByZeroException** is thrown:

![Picture 1](RackMultipart20231206-1-oq7oml_html_92fcc2230da1b080.gif)

Now, look at the tests:

![Picture 1](RackMultipart20231206-1-oq7oml_html_11858a2a4c3292f3.gif)

You are given **two**** empty** tests, and your task is to finish them. The tests should run when you're finished:

![Picture 1](RackMultipart20231206-1-oq7oml_html_29d01aa8ab40a62.gif)

1.
# Unit Test: Sum Collection Elements

The **SumCollectionElements**** () ****method** takes in an **array of integers** , and an **index**. If the collection is **null** an **ArgumentNullException** is thrown, or if the **index is out of bounds** an **IndexOutOfRangeException** is thrown:

![Picture 1](RackMultipart20231206-1-oq7oml_html_8c85bfd9cadce8b6.gif)

Now, look at the tests:

![Picture 1](RackMultipart20231206-1-oq7oml_html_b0df350665fbfa0.gif)

You are given **three**** empty** tests, and your task is to finish them. The tests should run when you're finished:

![Picture 1](RackMultipart20231206-1-oq7oml_html_982c755630aced9b.gif)

1.
# Unit Test: Get Element as Number

The **GetElementAsNumber**** () ****method** takes in a **dictionary** , and a **string representing a key from the dictionary**. If the key does not exist in the dictionary a **KeyNotFoundException** is thrown, if the value **cannot be converted to integer** a **FormatException** is thrown:

![Picture 1](RackMultipart20231206-1-oq7oml_html_17d555d960d8ef6.gif)

Now, look at the tests:

![Picture 1](RackMultipart20231206-1-oq7oml_html_a32bc605a13958a5.gif)

You are given **two**** empty** tests, and your task is to finish them. The tests should run when you're finished:

![Picture 1](RackMultipart20231206-1-oq7oml_html_351b56e19078ba63.gif)

At the end make sure all your tests run:

![Picture 1](RackMultipart20231206-1-oq7oml_html_2f355745de02653c.gif)

![Shape2](RackMultipart20231206-1-oq7oml_html_1c4878c41f6f4b07.gif)

© SoftUni – [https://softuni.org](https://softuni.org/). Copyrighted document. Unauthorized copy, reproduction or use is not permitted.

[![](RackMultipart20231206-1-oq7oml_html_9b17934bfedeb713.png)](https://softuni.org/)[![](RackMultipart20231206-1-oq7oml_html_c9db196993f48ff8.png)](https://softuni.bg/)[![Software University @ Facebook](RackMultipart20231206-1-oq7oml_html_94be3df36d913358.png)](https://www.facebook.com/softuni.org)[![](RackMultipart20231206-1-oq7oml_html_7e8e605369b4ad74.png)](https://www.instagram.com/softuni_org)[![Software University @ Twitter](RackMultipart20231206-1-oq7oml_html_ff9c629b0a21eb6b.png)](https://twitter.com/SoftUni1)[![Software University @ YouTube](RackMultipart20231206-1-oq7oml_html_7db86a748da0e575.png)](https://www.youtube.com/channel/UCqvOk8tYzfRS-eDy4vs3UyA)[![](RackMultipart20231206-1-oq7oml_html_95554caa563bbdb3.png)](https://www.linkedin.com/company/softuni/)[![](RackMultipart20231206-1-oq7oml_html_4df51bfadcab813.png)](https://github.com/SoftUni)[![Software University: Email Us](RackMultipart20231206-1-oq7oml_html_d7fa82ab7332f3fa.png)](mailto:info@softuni.org)

Follow us:

Page 4 of 4

[![](RackMultipart20231206-1-oq7oml_html_3aa486326bfa75e9.png)](https://softuni.org/)
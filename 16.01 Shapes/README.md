# Lab: Abstraction and Polymorphism

Tasks for exercise in class and for homework to the course ["Programming Advanced for QA" @ SoftUni](https://softuni.bg/trainings/4257/programming-advanced-for-qa-november-2023).

Test your tasks in the Judge system: [https://judge.softuni.org/Contests/4465/Abstraction-Polymorphism-Lab](https://judge.softuni.org/Contests/4465/Abstraction-Polymorphism-Lab)

# 1. Shapes

Build a **hierarchy** of **interfaces** and **classes** :

![image info](pic./Picture1.png)

You should be able to use the class like this:

| **Program.cs** |
| --- |
| int radius = int.Parse(Console.ReadLine()!);<br>IDrawable circle = newCircle(radius); <br><br>int width = int.Parse(Console.ReadLine()!);<br>int height = int.Parse(Console.ReadLine()!);<br>IDrawable rectangle = newRectangle(width, height); <br><br>circle.Draw();<br>rectangle.Draw(); |

## Examples

| **Input** | **Output** |
| --- | --- |
| 3<br>4<br>5 |&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\*\*\*\*\*\*\*<br>&nbsp;\*\*&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\*\*<br>\*\* &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\*\*<br>\* &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\*<br>&nbsp;\*\*&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; \*\*<br>&nbsp;&nbsp;&nbsp;\*\* &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\*\*<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\*\*\*\*\*\*\*<br><br>\*\*\*\*<br>\*&nbsp;&nbsp;&nbsp;\*<br>\*&nbsp;&nbsp;&nbsp;\*<br>\*&nbsp;&nbsp;&nbsp;\*<br>\*\*\*\* |

## Hints

The algorithm for drawing a circle is:

![image info](pic./Picture2.png)

The algorithm for drawing a rectangle is:

![image info](pic./Picture3.png)

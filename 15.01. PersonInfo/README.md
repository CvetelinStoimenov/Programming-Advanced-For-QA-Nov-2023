# Lab: Encapsulation and Inheritance

Tasks for exercise in class and for homework to the course ["Programming Advanced for QA" @ SoftUni](https://softuni.bg/trainings/4257/programming-advanced-for-qa-november-2023).

Test your tasks in the Judge system: [https://judge.softuni.org/Contests/4461/Encapsulation-Inheritance-Lab](https://judge.softuni.org/Contests/4461/Encapsulation-Inheritance-Lab)

# 1. Person Info

Make sure to use the **provided resources** for the following problems.

Create a class **Person** , which should have **public properties** with **private setters** for:

- **FirstName** : **string**
- **LastName** : **string**
- **Age** : **int**

Each property needs **proper validation**.

- **Name** must be at **least 3 symbols.**
- Age must **not** be **zero or negative.**

If some of the properties are **NOT valid** throw **ArgumentExeption** with the following **messages** :

- " **Age cannot be zero or a negative integer!**"
- " **First name cannot contain fewer than 3 symbols!**"
- " **Last name cannot contain fewer than 3 symbols!**"

Next add a **method** :

**ToString()**: **string** – **override**

Here is an **example** of how the **string** should look like: "Tomas Anderson is 20 years old.".

**Hint** : Because of the **private setters **you will need a** constructor **with** 3 parameters**.

## Examples

| **Input** | **Output** |
| --- | --- |
| 5<br>Brandi Anderson 65<br>Andrew Williams 57<br>Newton Holland 27<br>Andrew Clark 44<br>Brandi Scott 35 | Andrew Clark is 44 years old.<br>Andrew Williams is 57 years old.<br>Brandi Scott is 35 years old.<br>Brandi Anderson is 65 years old.<br>Newton Holland is 27 years old. |

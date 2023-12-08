
# 3. Animals

**NOTE** : You need a **folder** named **Models** to hold the **classes** in.

Create an **abstract** class **Animal** , which holds two fields:

- **name** : **string**
- **favouriteFood** : **string**

An animal has one **virtual method ExplainSelf(): string .**
You should add two new classes - **Cat** and **Dog. Override** the **ExplainSelf()** method by adding **concrete**** animal ****sound** on a new line. (Look at examples below)

You should be able to use the class like this:

| **Program.cs** |
| --- |
| Animal cat = newCat("Peter", "Whiskas");<br>Animal dog = newDog("George", "Meat");<br><br>Console.WriteLine(cat.ExplainSelf());<br>Console.WriteLine(dog.ExplainSelf()); |

## Examples

| **Output** |
| --- |
| I am Peter and my fovourite food is Whiskas<br>MEEOW<br>I am George and my fovourite food is Meat<br>BORK |

# 2. Cars

Build a **hierarchy** of **interfaces** and **classes** :

![image info](pic./Picture1.png)

Your hierarchy must be used with this code:

| **StartUp.cs** |
| --- |
| ICar seat = newSeat("Leon", "Grey");<br>ICar tesla = newTesla("Model 3", "Red", 2);<br><br>Console.WriteLine(seat.ToString());<br>Console.WriteLine(tesla.ToString()); |

## Examples

| **Output** |
| --- |
| Grey Seat Leon<br>Engine start<br>Break!<br>Red Tesla Model 3 with 2 Batteries<br>Engine start<br>Break! |

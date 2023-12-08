
# 3. Players and Monsters

Your task is to create the following game hierarchy:

![image info](pic./Picture1.png)

Create a class Hero. It should contain the following members:

- A constructor, which accepts:
  - **username – string**
  - **level – int**
- The following properties:
  - **Username - string**
  - **Level – int**
- **ToString()** method

Hint: Override **ToString()** of the base class in the following way:

| |
| |
| publicoverridestring ToString()<br>{<br>return$"Type: \{this.GetType().Name} Username: \{this.Username} Level: \{this.Level}";<br>} |

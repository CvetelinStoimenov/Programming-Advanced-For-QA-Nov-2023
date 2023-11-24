# 2.	Match Phone Number
Write a program that:
- Reads a **text** from the console
- Create a **regular expression** to match a **valid phone number** from **Sofia**
- A **valid number** has the following characteristics:
    -   It starts with **"+359"**
    - 	Then, it is followed by the area code (always **2**)
    - 	After that, it's followed by the **number** itself:
    - 	The number consists of **7 digits** (separated into **two groups** of **3** and **4 digits** respectively) 
    - 	The different **parts** are **separated** by **either a space or a hyphen ('-')**
- **Print all valid numbers** on the console, separated by a **comma and a space ", "**

## Examples
|Input|Output|
|---|---|
|+359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222  |  +359 2 222 2222, +359-2-222-2222 |
|+359 2 234 2324, 359-2-111-9876, +359/8/655/5432, +359-2 222 2222, +359 2-222-2222, +359-2-234-345, +359-2-123-45678, +359-2-222-2222, +359 2 654 1234  | +359 2 234 2324, +359-2-222-2222, +359 2 654 1234 |


# 4.SoftUni Parking

SoftUni just got a new **parking lot**. It's so fancy, it even has online **parking validation**. Except the online service doesn't work. It can only receive users' data, but it doesn't know what to do with it. Good thing you're on the dev team and know how to fix it, right?

Write a program, which validates a parking place for an online service. Users can **register** to park and **unregister** to leave.

The program **receives 2 commands** :

- " **register {username} {licensePlateNumber}**":
  - The system only supports **one car per user** at the moment, so if a user tries to register **another license plate** , using the **same username** , the system should print:
" **ERROR: already registered with plate number {licensePlateNumber}**"
  - If the aforementioned checks passes successfully, the plate can be registered, so the system should print:
**"{username} registered {licensePlateNumber} successfully"**
- " **unregister {username}**":
  - If the user is **not present** in the database, the system should print:
" **ERROR: user {username} not found**"
  - If the aforementioned check passes successfully, the system should print:
" **{username} unregistered successfully**"

After you execute all of the commands, **print** all of the currently **registered users** and their **license plates** in the format:

- " **\{username} =\> \{licensePlateNumber}**"

## Input

- First line: **n** - **number of commands** – **integer**.
- Next **n** lines: **commands** in one of the **two** possible formats:
  - Register: " **register \{username} \{licensePlateNumber}**"
  - Unregister: " **unregister \{username}**"

The input will **always** be **valid** and you **do not need** to check it explicitly.

## Examples

| **Input** | **Output** |
| --- | --- |
| 5<br>register John CS1234JS<br>register George JAVA123S<br>register Andy AB4142CD<br>register Jesica VR1223EE<br>unregister Andy | John registered CS1234JS successfully<br>George registered JAVA123S successfully<br>Andy registered AB4142CD successfully<br>Jesica registered VR1223EE successfully<br>Andy unregistered successfully<br>John =\> CS1234JSGeorge =\> JAVA123S<br>Jesica =\> VR1223EE |
| 4<br>register Jony AA4132BB<br>register Jony AA4132BB<br>register Linda AA9999BBun<br>register Jony | Jony registered AA4132BB successfully<br>ERROR: already registered with plate number AA4132BB<br>Linda registered AA9999BB successfully<br>Jony unregistered successfully<br>Linda =\> AA9999BB |
| 6<br>register Jacob MM1111XX<br>register Anthony AB1111XXun<br>register Jacob<br>register Joshua DD1111XX<br>unregister Lilyregister Samantha AA9999BB | Jacob registered MM1111XX successfully<br>Anthony registered AB1111XX successfully<br>Jacob unregistered successfully<br>Joshua registered DD1111XX successfully<br>ERROR: user Lily not found<br>Samantha registered AA9999BB successfully<br>Joshua =\> DD1111XX<br>Anthony =\> AB1111XX<br>Samantha =\> AA9999BB | 
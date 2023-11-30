	# 3. Teamwork Projects

It's time for the teamwork projects and you are responsible for gathering the teams. First, you will receive an integer – the **count** of the **teams** you will have to **register**. You will be given a **user** and a **team** , separated with " **-**". The user is the **creator** of **the team**. For every newly created team you should **print** a message:

" **Team \{teamName} has been created by \{user}!**".

Next, you will receive а user with a team, separated with **" -\> "** , which means that the user wants to **join** that **team**. Upon receiving the command: " **end of assignment**", you should print **every team** , **ordered** by the **count** of its **members** ( **descending** ) and then by **name** ( **ascending** ). For each team, you have to print its members **sorted** by name ( **ascending** ). However, there are several **rules** :

- If а user tries to **create** a team more than once, a message should be displayed:
  - " **Team \{teamName} was already created!**"
- A creator of a team **cannot create** another team – the following message should be thrown:
  - " **\{user} cannot create another team!**"
- If а user tries to **join** a non-existent team, a message should be displayed:
  - " **Team \{teamName} does not exist!** _"_
- A member of a team **cannot join** another team – the following message should be thrown:
  - " **Member \{user} cannot join team \{team Name}!**"
- In the end,teams with **zero** members (with **only a creator** ) should **disband** and you have toprint them **ordered by name in ascending order**.
- Every **valid** team should be printed ordered by **name** (ascending) in the following format:

| **"\{teamName}** <br>- \{creator} **<br>-- \{member}…"** |
| --- |

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 2<br>John-PowerPuffsCoders<br>Tony-Tony is the best<br>Peter-\>PowerPuffsCoders<br>Tony-\>Tony is the best<br>end of assignment | Team PowerPuffsCoders has been created by John!<br>Team Tony is the best has been created by Tony!<br>Member Tony cannot join team Tony is the best!<br>PowerPuffsCoders<br>- John<br>-- Peter<br>Teams to disband:<br>Tony is the best | Tony created a team, which he attempted to join later and this action resulted in throwing a certain message. Since nobody else tried to join his team, the team had to **disband**. |
| 3<br>Tanya-CloneClub<br>Helena-CloneClub<br>Tedy-SoftUni<br>George-\>softUni<br>George-\>SoftUni<br>Tatyana-\>Leda<br>John-\>SoftUni<br>Cossima-\>CloneClub<br>end of assignment | Team CloneClub has been created by Tanya!<br>Team CloneClub was already created!<br>Team SoftUni has been created by Tedy!<br>Team softUni does not exist!<br>Team Leda does not exist!<br>SoftUni<br>- Tedy<br>-- George<br>-- John<br>CloneClub<br>- Tanya<br>-- Cossima<br>Teams to disband: | Note that when a user joins a team, you should first check if the team exists and then check if the user is already in a team: <br><br><br>Tanya has created CloneClub, then she tried to join a non-existent team and the concrete message was displayed. | 
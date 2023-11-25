# 1. Songs

Define a class called **Song** that will hold the following information about some songs:			

 - **Type List** 
 - **Name** 
 - **Time**

## Input / Constraints

 - On the first line, you will receive the **number of songs - N**. 
 - On the next **N** lines, you will be receiving data in the following format:  **"\{typeList}\_\{name}\_\{time}"**.
  - On the last line, you will receive **Type  List** or **"all".**

## Output

- If you receive **Type List** as an input on the last line, print out **only the names of the songs**, which are from that **Type List**.
- If you receive the **"all"** command, print out the names of all **the songs**.

## Examples

| Input	| Output |
|--|--|
| 4<br> favourite_DownTown_3:14 <br>favourite_Kiss_4:16<br>favourite_Smooth Criminal_4:01<br>favourite  | DownTown<br>Kiss<br>Smooth Criminal |
| 4<br>favourite_DownTown_3:14<br>listenLater_Andalouse_3:24<br>favourite_In To The Night_3:58<br>favourite_Live It Up_3:48<br>listenLater	 | Andalouse |
| 2<br>like_Replay_3:15<br>ban_Photoshop_3:48<br>all	 | Replay<br>Photoshop |

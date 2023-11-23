# 1. Songs

Define a class called **Song** that will hold the following information about some songs:			

 - **Type List** 
 - **Name** 
 - **Time**

## Input / Constraints

 - On the first line, you will receive the **number of songs - N**. 
 - On the next **N** lines, you will be receiving data in the following format:  **"{typeList}_{name}_{time}"**.
  - On the last line, you will receive **Type  List** or **"all".**

## Output

- If you receive **Type List** as an input on the last line, print out **only the names of the songs**, which are from that **Type List**.
- If you receive the **"all"** command, print out the names of all **the songs**.

## Examples

| Input	| Output |
|--|--|
| favourite_DownTown_3:14 | DownTown |
| favourite_Kiss_4:16	 | Kiss |
| favourite_Smooth Criminal_4:01	 |  Smooth Criminal|
|favourite	  |  |




| Input | Output |
|--|--|
| 4 |Andalouse  |
|favourite_DownTown_3:14  |  |
| listenLater_Andalouse_3:24 |  |
|favourite_In To The Night_3:58  |  |
|favourite_Live It Up_3:48  |  |
|listenLater  |  |								
			
					
|Input |Output |
|----|-------|
|2|Replay|
|like_Replay_3:15	|Photoshop|
|ban_Photoshop_3:48||
|all	||
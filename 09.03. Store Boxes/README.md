# 3. Store Boxes

Define a class **Item**** , **which contains these properties:** Name **and** Price ****.**

Define a class **Box**** , **which contains these properties:** Serial Number, Item, Item Quantity **and** Price for a Box.**

Until you receive **"end"**** , **you will be receiving data in the following format: "** {Serial Number} {Item Name} {Item Quantity} {itemPrice}**"

The **Price of one box** has to be calculated: **itemQuantity \* itemPrice****.**

Print all the boxes ordered descending by price for a box, in the following format:

**{boxSerialNumber}**

**-- {boxItemName} – ${boxItemPrice}: {boxItemQuantity}**

**-- ${boxPrice}**

The price should be **formatted to the 2**** nd **** digit after the decimal separator**.

## Examples

| **Input** | **Output** |
| --- | --- |
| 19861519 Dove 15 2.50<br>86757035 Butter 7 3.20<br>39393891 Orbit 16 1.60<br>37741865 Samsung 10 1000<br>end | 37741865<br>-- Samsung - $1000.00: 10<br>-- $10000.00<br>19861519<br>-- Dove - $2.50: 15<br>-- $37.50<br>39393891<br>-- Orbit - $1.60: 16<br>-- $25.60<br>86757035<br>-- Butter - $3.20: 7<br>-- $22.40 |
| 48760766 Alcatel 8 100<br>97617240 Intel 2 500<br>83840873 Milka 20 2.75<br>35056501 SneakersXL 15 1.50<br>end | 97617240<br>-- Intel - $500.00: 2<br>-- $1000.00<br>48760766<br>-- Alcatel - $100.00: 8<br>-- $800.00<br>83840873<br>-- Milka - $2.75: 20<br>-- $55.00<br>35056501<br>-- SneakersXL - $1.50: 15<br>-- $22.50 | 
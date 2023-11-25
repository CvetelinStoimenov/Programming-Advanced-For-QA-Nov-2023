# 4. Vehicle Catalogue

Your task is to **create a**  **Vehicle**  **catalog,** which contains only **Trucks** and **Cars**.

Define a class **Truck** with the following properties: **Brand, Model, and Weight**.

Define a class **Car** with the following properties: **Brand, Model, and Horse Power**.

Define a class **Catalog** with the following properties: **Collections of**** Trucks and Cars**.

You must read the input, until you receive the " **end**" command. It will be in following format: " **\{type}/\{brand}/\{model}/\{horse power / weight}**"

In the end, you have **to print all of the vehicles ordered alphabetical by brand,** in the following format:

" **Cars:**

**\{Brand}:** \{Model} ** - ** \{Horse Power}hp**

**Trucks:**

**\{Brand}** : **\{Model}**  **-**  **\{Weight}kg**"

### Examples

| **Input** | **Output** |
| --- | --- |
| Car/Audi/A3/110<br>Car/Maserati/Levante/350<br>Truck/Mercedes/Actros/9019<br>Car/Porsche/Panamera/375<br>end | Cars:<br>Audi: A3 - 110hp<br>Maserati: Levante - 350hp<br>Porsche: Panamera - 375hp<br>Trucks:<br>Mercedes: Actros - 9019kg |
| Car/Subaru/Impreza/152<br>Car/Peugeot/307/109<br>end | Cars:<br>Peugeot: 307 - 109hp<br>Subaru: Impreza - 152hp |


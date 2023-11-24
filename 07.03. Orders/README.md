
# 3.Orders

Create a program that keeps the information about **products** and their prices. Each product has a **name** , a **price** and a **quantity**. If the product **doesn't exist** yet, **add** it with its **starting quantity**.

If you receive a product, which **already exists** , increase its quantity by the input quantity and if its price is different, **replace** the price as well.

You will receive products' names, prices and quantities on new lines. Until you receive the command " **buy**", keep adding items. When you do receive the command " **buy**", print the items with their **names** and the **total price** of all **the products with that name**.

**Input**

- Until you receive " **buy**", the products will be coming in the format: " **{name} {price} {quantity}**".
- The product data is **always** delimited by a **single space**.

**Output**

- Print information about **each**** product** in the following format:
**"\{productName} -\> \{totalPrice}"**
- **Format** the average grade to the **2**** nd **** digit after the decimal separator**.

## Examples

| **Input** | **Output** |
| --- | --- |
| Beer 2.20 100<br>IceTea 1.50 50<br>NukaCola 3.30 80<br>Water 1.00 500<br>buy | Beer -\> 220.00<br>IceTea -\> 75.00<br>NukaCola -\> 264.00<br>Water -\> 500.00 |
| Beer 2.40 350<br>Water 1.25 200<br>IceTea 5.20 100<br>Beer 1.20 200<br>IceTea 0.50 120<br>buy | Beer -\> 660.00<br>Water -\> 250.00<br>IceTea -\> 110.00 |
| CesarSalad 10.20 25<br>SuperEnergy 0.80 400<br>Beer 1.35 350<br>IceCream 1.50 25<br>buy | CesarSalad -\> 255.00<br>SuperEnergy -\> 320.00<br>Beer -\> 472.50<br>IceCream -\> 37.50 | 

1.
## Car Extension

**NOTE** : You need a **StartUp** class with the namespace **CarManufacturer**.

Create a class **Car** (you can use the **class** from **the previous task** ).

The class should have private fields for:

- **make: string**
- **model:**** string**
- **year: int**
- **fuelQuantity: double**
- **fuelConsumption: double**

The class should also have properties for:

- **Make: string**
- **Model:**** string**
- **Year: int**
- **FuelQuantity: double**
- **FuelConsumption: double**

The class should also have methods for:

- **Drive(double distance): void** – This method checks if the car fuel quantity minus the distance multiplied by the car fuel consumption is bigger than zero. If it is removed from the fuel quantity, the result of the multiplication between the distance and the fuel consumption. Otherwise, write on the console the following message:

**"Not enough fuel to perform this trip!"**.

- **WhoAmI(): string –** returns the following message:

**"**** Make ****: {**** this ****.**** Make ****}**

**Model**** : { ****this****. ****Model**** }**

**Year**** : { ****this****. ****Year**** }**

**Fuel**** : { ****this****. ****FuelQuantity**** : ****F**** 2}"**

You should be able to use the class like this:

![](RackMultipart20231127-1-l08e6o_html_2ca5126006ae022b.png)

1.
## Car Constructors

Using the class from the previous problem create one parameterless constructor with default values:

- **Make – VW**
- **Model – Golf**
- **Year – 2025**
- **FuelQuantity – 200**
- **FuelConsumption – 10**

Create a second constructor accepting **make**** , **** model **and** year **upon initialization and call the base constructor with its default values for** fuelQuantity **and** fuelConsumption**.

![](RackMultipart20231127-1-l08e6o_html_c3ba2b10e4dca10e.png)

Create a third constructor accepting **make**** , **** model ****,**  **year**** , **** fuelQuantity **and** fuelConsumption** upon initialization and reuse the second constructor to set the make, model and year values.

![](RackMultipart20231127-1-l08e6o_html_6d4336fc7bbb470b.png)

Go to **StartUp.cs** file and make 3 different instances of the **class**  **Car** , using the **different** overloads of the constructor.

![](RackMultipart20231127-1-l08e6o_html_6e8c2ee4d430fb66.png)

1.
## Car Engine and Tires

Using the Car class, you already created, define another class **Engine**.

The class should have private fields for:

- **horsePower: int**
- **cubicCapacity:**** double**

The class should also have properties for:

- **HorsePower: int**
- **CubicCapacity:**** double**

The class should also have a constructor, which accepts **horsepower** and **cubicCapacity** upon initialization:

![](RackMultipart20231127-1-l08e6o_html_4f3728b0c5312abc.png)

Now create a class **Tire**.

The class should have private fields for:

- **year: int**
- **pressure:**** double**

The class should also have properties for:

- **Year: int**
- **Pressure: double**

The class should also have a constructor, which accepts **year** and **pressure** upon initialization:

![](RackMultipart20231127-1-l08e6o_html_41b17efacdb6ce90.png)

Finally, go to the **Car** class and create **private fields** and **public properties** for **Engine** and**Tire[]**.Create another constructor, which accepts **make**** , **** model ****,**  **year**** , **** fuelQuantity ****,**  **fuelConsumption**** , **** Engine **and** Tire[]** upon initialization:

![](RackMultipart20231127-1-l08e6o_html_8f58059871fd8a67.png)

You should be able to use the classes like this:

![](RackMultipart20231127-1-l08e6o_html_66455c790b3ba839.png)

![Shape3](RackMultipart20231127-1-l08e6o_html_6f222e41d7629786.gif) ![Shape2](RackMultipart20231127-1-l08e6o_html_5f0f2ddacbac70d2.gif) ![Shape1](RackMultipart20231127-1-l08e6o_html_51bd00be29b85496.gif) ![Shape4](RackMultipart20231127-1-l08e6o_html_f746d52952cd7e91.gif)[![](RackMultipart20231127-1-l08e6o_html_3aa486326bfa75e9.png)](https://softuni.org/)

Follow us:

© SoftUni – [about.softuni.bg](https://about.softuni.bg/). Copyrighted document. Unauthorized copy, reproduction or use is not permitted.

[![](RackMultipart20231127-1-l08e6o_html_9b17934bfedeb713.png)](https://softuni.org/)[![](RackMultipart20231127-1-l08e6o_html_c9db196993f48ff8.png)](https://softuni.bg/)[![Software University @ Facebook](RackMultipart20231127-1-l08e6o_html_94be3df36d913358.png)](https://www.facebook.com/softuni.org)[![](RackMultipart20231127-1-l08e6o_html_7e8e605369b4ad74.png)](https://www.instagram.com/softuni_org)[![Software University @ Twitter](RackMultipart20231127-1-l08e6o_html_ff9c629b0a21eb6b.png)](https://twitter.com/SoftUni1)[![Software University @ YouTube](RackMultipart20231127-1-l08e6o_html_7db86a748da0e575.png)](https://www.youtube.com/channel/UCqvOk8tYzfRS-eDy4vs3UyA)[![](RackMultipart20231127-1-l08e6o_html_95554caa563bbdb3.png)](https://www.linkedin.com/company/softuni/)[![](RackMultipart20231127-1-l08e6o_html_4df51bfadcab813.png)](https://github.com/SoftUni)[![Software University: Email Us](RackMultipart20231127-1-l08e6o_html_d7fa82ab7332f3fa.png)](mailto:info@softuni.org)

Page 2 of 2
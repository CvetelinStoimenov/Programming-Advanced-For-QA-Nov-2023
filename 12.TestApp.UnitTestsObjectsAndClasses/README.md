# Exercises: Unit Testing Classes

Tasks for exercise in class and for homework to the course ["Programming Advanced for QA" @ SoftUni](https://softuni.bg/trainings/4257/programming-advanced-for-qa-november-2023).

Submit your solutions here: [https://judge.softuni.org/Contests/4492/Objects-and-Classes-Unit-Testing-Exercise](https://judge.softuni.org/Contests/4492/Objects-and-Classes-Unit-Testing-Exercise)


# 1.Unit Test: Student

Look at the **provided skeleton** and examine the **Student.cs** class that you will test: 

![image info](pic./Picture1.png)

The class has **properties** for **first name ,last name , age,and hometown** :

![image info](pic./Picture2.png)

It also has a **method** that takes in a **string array **representing** students** in the form of:

" **\{first\_name} \{last\_name} \{age} \{hometown}**"

Also, a string representing which **town** the method should **filter** the students by and **return** them as a string:

![image info](pic./Picture3.png)

![image info](pic./Picture4.png)

![image info](pic./Picture5.png)

Then, look at the tests inside the **StudentTests.cs** class:

![image info](pic./Picture6.png)

![image info](pic./Picture7.png)

Notice the use of a **setup method **, so each test has a brand new** student instance** to use.

The first test if **partially finished **so you have a** reference **, the rest are** empty,** and your task is to finish them. The tests should run when you're finished:

![image info](pic./Picture8.png)


# 2.Unit Test: Song

The class **Song.cs** has **properties** for **list type** , **name** , and **time** :

![image info](pic./Picture9.png)

It also has a **method** that takes in a **string array representing songs** in the form of:

" **\{type} \{name} \{time}**"

Also, a string representing which **list** ( **type** ) the method should **retrieve** and **return** each song in it as a string:

![image info](pic./Picture10.png)

![image info](pic./Picture11.png)

Now, look at the tests inside the **SongTests.cs** class:

![image info](pic./Picture12.png)

You are given a **setup method **again as well as one** partially finished** test, the rest are **empty,** and your task is to finish them. The tests should run when you're finished:

![image info](pic./Picture13.png)


# 3.Unit Test: Store

The **folder Store **contains** 3 classes **, in which the** main **one is** Shop.cs**.

The other 2 classes are smaller classes **representing real life objects** only holding **properties**.

**Box.cs** :

![image info](pic./Picture14.png)

**Item.cs** :

![image info](pic./Picture15.png)

**Shop.cs** only has a **method** which takes in a **string**** array **representing** products** in the form of:

" **\{serial\_number} \{name} \{quantity} \{price}**"

For each **product** a new **Item** is created and placed in a new **Box** then the box is **added** to a **list**. Finally, the list of boxes is returned as a **string of information** :

![image info](pic./Picture16.png)

![image info](pic./Picture17.png)
Now, look at the tests inside the **ShopTests.cs** class:

![image info](pic./Picture18.png)

This time write the **setup**** method **on your own. You are given** one partial test **, the rest are** empty,** and your task is to finish them. The tests should run when you're finished:

![image info](pic./Picture19.png)


# 4.Unit Test: Vehicle

The **folder Vehicle **contains** 4 classes **, in which the** main **one is** Vehicles.cs**.

The other 3 classes **represent real life objects** only holding **properties** :

**Car.cs:**

![image info](pic./Picture20.png)

**Catalogue.cs** :

![image info](pic./Picture21.png)

**Truck.cs** :

![image info](pic./Picture22.png)

**Catalogue.cs** only has a **method** which takes in a **string** array **representing vehicles** in the form of:

" **\{type}/\{brand}/\{model}/\{power}**"

First, a new **Catalogue** is created. For each **vehicle** a new **Truck** or **Car** based on the **type** is created and added to the relevant list in the catalogue. Finally, a string is returned based on the catalogue:

![image info](pic./Picture23.png)

![image info](pic./Picture24.png)

![image info](pic./Picture25.png)

Now, look at the tests inside the **VehicleTests.cs** class:

![image info](pic./Picture26.png)

Write the **setup method **on your own. You are given** one partial test **, the rest are** empty,** and your task is to finish them. The tests should run when you're finished:

![image info](pic./Picture27.png)


# 5.Unit Test: Person

The class **Person.cs** has **properties** for **name** , **id** , and **age** :

![image info](pic./Picture28.png)

The first **method** it has, **AddPeople()**, takes in a **string array **representing** people** in the form of:

" **\{name} \{id} \{age}**"

The method adds all people to a **list** and returns it:

![image info](pic./Picture29.png)

![image info](pic./Picture30.png)

The next method, **GetByAgeAscending()**, takes in a **list of peopl** e, **sorts the list by age** , and returns a **string** with **information** :

![image info](pic./Picture31.png)

Now, look at the tests inside the **PersonTests.cs** class:

![image info](pic./Picture32.png)

Write the **setup**** method **on your own. You are given** one partial test **, the rest are** empty,** and your task is to finish them. The tests should run when you're finished:

![image info](pic./Picture33.png)


# 6.Unit Test: Article

The class **Article.cs** has **properties** for **title** , **content** , **author** , and **article list** :

![image info](pic./Picture34.png)

The first **method** it has, **AddArticles()**, takes in a **string**** array **representing** articles** in the form of:

" **\{title} \{content} \{author}**"

The method adds all articles to a **list** and returns it:

![image info](pic./Picture35.png)

The next method, **GetArticleList()**, takes in an **instance of an article** , and a **print criteria**. Based on the criteria it **orders the list,** and returns a **string** with **information** :

![image info](pic./Picture36.png)

![image info](pic./Picture37.png)

Now, look at the tests inside the **ArticleTests.cs** class:

![image info](pic./Picture38.png)

Write the **setup**** method **on your own. You are given** one partial test **, the rest are** empty,** and your task is to finish them. The tests should run when you're finished:

![image info](pic./Picture39.png)

# 7.Unit Test: Planet

The class **Planet.cs** has **properties** for **name** , **diameter** , **sun distance** , and **moon number**. It also has a **private**** field **for** gravitation **and a** constructor**:

![image info](pic./Picture40.png)

The first **method** it has, **CalculateGravity()**, takes in a **number** representing **mass.** The method calculates the **planets gravity** with a calculation:

![image info](pic./Picture41.png)

The next method, **GetPlanetInfo()**, returns a **string with information about the planet** :

![image info](pic./Picture42.png)

Now, look at the tests inside the **PlanetTests.cs** class:

![image info](pic./Picture43.png)

You are given **one partial test** , the rest are **empty,** and your task is to finish them. The tests should run when you're finished:

![image info](pic./Picture44.png)

At the end make sure all tests pass:

![image info](pic./Picture45.png)


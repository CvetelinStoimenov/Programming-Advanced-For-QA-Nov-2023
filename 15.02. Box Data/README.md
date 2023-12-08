
# 2. Box Data

Create a class **Box** , with the following properties:

**Length** – **double** , should **not be zero** or **negative number**.

**Width** – **double** , should **not be zero** or **negative number**.

**Height** – **double** , should **not be zero** or **negative number**.

If one of the properties **IS a zero or negative number** throw an **ArgumentException** with the message:

" **\{propertyName} cannot be zero or negative.**"

All **properties** are **set by the constructor** and when **set** , they **cannot** be **modified**.

Finally implement the **following methods** :

- **double SurfaceArea()**: Calculate and return the **surface area** of the **Box**. (2\*L\*W + 2\*L\*H + 2\*W\*H)
- **double Volume()**:Calculate and return the **volume** of the **Box**. (L\*W\*H)
- **string ToString()**:
  - " **Surface Area –**  **\{area}**"
  - " **Volume –**  **\{volume}**"

## Examples

| **Input** | **Output** |
| --- | --- |
| 2<br>3<br>4 | Surface Area - 52.00<br>Volume - 24.00 |
| 1.3<br>1<br>6 | Surface Area - 30.20<br>Volume - 7.80 |
| 2<br>-3<br>4 | Width cannot be zero or negative. |

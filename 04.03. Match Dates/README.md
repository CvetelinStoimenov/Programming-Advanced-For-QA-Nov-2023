# 3.	Match Dates
Write a program that:
- Reads a **text** from the console
- Create a **regular expression** to match a **valid dates**
- Every **valid** date has the following characteristics:
  - Format: **"dd{separator}MMM{separator}yyyy"**
  - Always starts with **two digits**, followed by a **separator**
  - After that, it has **one uppercase** and two lowercase letters (e.g. **Jan, Mar**)
  - After that, it has a **separator** and **exactly 4 digits** (for the year)
  - The separator could be either of three things: a period (**'.'**), a hyphen (**'-'**) or a forward-slash (**'/'**)
  - The separator needs to be **the same** for the whole date (e.g. 13.03.2016 is valid, 13.03/2016 is **NOT**). Use a **group backreference** to 
        check for this
- Use **named capturing groups** in your regular expression.
- **Print all valid dates** on the console, **separated by a comma and a space ", "**

## Examples

|Input|Output|
|---|---|
| 13/Jul/1928, 10-Nov-1934, 01/Jan-1951,f 25.Dec.1937 23/09/1973,1/Feb/2016 |  Day: 13, Month: Jul, Year: 1928  <br />Day: 10, Month: Nov, Year: 1934<br />Day: 25, Month: Dec, Year: 1937|
|03-Mar-1878, 25/Apr/1915, 31-May-1916, 22/Jun-1941, 25.Dec.1937, 23/09/1973   |Day: 03, Month: Mar, Year: 1878<br />Day: 25, Month: Apr, Year: 1915<br />Day: 31, Month: May, Year: 1916<br />Day: 25, Month: Dec, Year: 1937|        
                                           
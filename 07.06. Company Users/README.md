
# 6.\*Company Users

Create a program that keeps information about companies and their employees.

You will be receiving a **company**** name **and an** employee's id, **until you receive the "** End**" command. Add each employee to the given company. Keep in mind that a company cannot have two employees with the same id.

When you finish reading the data, print the company's name and each employee's id in the following format:

**{companyName}**

**-- \{id1}**

**-- \{id2}**

**-- \{idN}**

**Input / Constraints**

- Until you receive the " **End**" command, you will be receiving input in the format: " **{companyName} -\> {employeeId}**".
- The input always will be valid.

## Examples

| **Input** | **Output** |
| --- | --- |
| SoftUni -\> AA12345<br>SoftUni -\> BB12345<br>Microsoft -\> CC12345HP -\> BB12345End | SoftUni-- AA12345-- BB12345<br>Microsoft-- CC12345HP-- BB12345 |
| SoftUni -\> AA12345<br>SoftUni -\> CC12344<br>Lenovo -\> XX23456<br>SoftUni -\> AA12345<br>Movement -\> DD11111End | SoftUni-- AA12345-- CC12344<br>Lenovo-- XX23456<br>Movement-- DD11111 |

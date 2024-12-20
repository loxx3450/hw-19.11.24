# Aggregation


## Task 1 
To create classes **Deposit** (bank account), **BaseDeposit** (regular deposit), **SpecialDeposit** (special deposit), **LongDeposit** (long-term deposit), **Client** (bank client) with set functionality. 

1. To create abstract class **Deposit** and declare within it: 
 
- Public money property only for reading **Amount** (deposit amount) 
- Public integer property only for reading **Period** (time of deposit in months) 
- Constructor (for calling in class-inheritor) with parameters **depositAmount** and **depositPeriod**, which creates object deposit with specified sum for specified period.  
- Abstract method **Income**, which returns money value – amount of income from deposit. Income is the difference between sum, withdrawn from deposit upon expiration date and deposited sum.  

2. To create classes that are inheritors of the class **Deposit**, which determine different options of deposit interest addition – class **BaseDeposit**, class **SpecialDeposit** and class **LongDeposit**. To implement in each class a constructor with parameters **amount** and **period**, which calls constructor of parent class.   

3. For each inheritor class – to implement own interest addition scheme and accordingly profit margin definitions, overriding abstract method **Income** in each class.   

**BaseDeposit** implies each month 5% of interest from current deposit sum. Each following month of income is calculated from the sum, which was received by adding to current income sum of the previous month and is rounded to hundredth.  

Example: 
Base amount – 1000,00

In a month – 1050,00; income amount – 50,00 

In two months – 1102,50; income amount – 102,50

In three months – 1157,62; income amount – 157,62 

**SpecialDeposit** implies income addition each month, amount of which (in percent) equals to deposit expiration period. If during the first month 1% is added, during the second month – 2% from the sum obtained after first month and so on.   

Example: Base amount – 1000,00 

In a month – 1010,00; income amount – 10,00 

In two months – 1030,20; income amount – 30,20 

**LongDeposit** implies that during first 6 months, no percent is added to client’s deposit, but starting from 7th month, each month percent addition is 15% from current deposit sum, thus encouraging client to make long-term deposits.
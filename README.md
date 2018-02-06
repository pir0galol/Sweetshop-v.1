# Sweetshop-v.1
### This is my very first C# application using .NET (WinForms). 
* **Objective:** Managing your own sweetshop
* **Language of the application:** Romanian
* **IDE:** Visual Studio 2015
* **.NET Framework:** 4.5
* **Database:** PostgreSQL
* **Prerequisites:**
  * PostgreSQL database installed and configured;
  * Visual Studio 2015 or later with .NET Framework 4.5 or later;
  * Npgsql 3.2.5 (data provider for connecting to PostgreSQL);
  * Metroframework UI 1.4.0 (for a fancy look);
  * ReportViewer 11.0 (for generating reports).
* **Modules:**
  * Nomenclatures;
  * Orders;
  * Invoices;
  * Payments;
  * Reports.
#### The main menu of the application which allows to navigate through the modules:

![1](https://user-images.githubusercontent.com/36104236/35874082-3e0e082e-0b74-11e8-859b-4356128fce10.PNG)

**1. Nomenclatures**
<p>This first module is responsible for managing the suppliers, and your customers.</p>

<p>The suppliers – all CRUD operations are available + redirect to their specific Orders;</p>

![2 furn](https://user-images.githubusercontent.com/36104236/35874292-d421a5e6-0b74-11e8-80cd-6af80448e2f9.PNG)

<p>The customers - all CRUD operations are available + redirect to their specific Orders;</p>

![2 customers](https://user-images.githubusercontent.com/36104236/35874349-f19c9a2c-0b74-11e8-8d46-096a0340e412.PNG)

<p>When adding/deleting/modifying a specific supplier/customer, a specific message will pop up (eg: for adding a new customer):</p>

![cust 2](https://user-images.githubusercontent.com/36104236/35874391-0d7d68f2-0b75-11e8-8073-c61feec4ec93.PNG)

**2. Orders**
<p>
Here you can manage the orders for your suppliers/customers. 
Regarding the suppliers, you can create an order for what kind of raw materials (eggs, milk, flour etc) you need to “prepare” your final products (cakes, pies etc) and generate totals. 
Also, redirect to their specific invoice.
</p>

![orders1](https://user-images.githubusercontent.com/36104236/35874517-5cd663c2-0b75-11e8-9b3a-29b1d6a0962b.PNG)

<p>
Regarding the customers, you are able to manage their orders (cakes, pies etc) and generate the total for each order. 
Also, redirect to their specific invoice.
</p>

![orders-cust](https://user-images.githubusercontent.com/36104236/35874542-691e39c0-0b75-11e8-8929-5373e0d8e351.PNG)

**3. Invoices**
<p>
Here you can manage all your invoices regardless of their “target” (supplier/customer). 
If a specific invoice is already made for a certain order, then a message will show up, otherwise the system will allow you to create the invoice for that order.
</p>

<p>An order which has already been registered with an invoice.</p>

![inv1](https://user-images.githubusercontent.com/36104236/35874572-8473947c-0b75-11e8-9ca9-0b8b84571cd9.PNG)

<p>One which has not and it should be.</p>

![inv2](https://user-images.githubusercontent.com/36104236/35874578-8a6dde28-0b75-11e8-825a-e29efe2add37.PNG)

**4. Payments**          
<p>
Afterwards, a payment should be done for a specific invoice. This is why this module exists.
Here if there has already been made a payment for an invoice, then a specific message will show. Otherwise, it will show a message with the value needed to be paid (or the rest to be paid – you are able to make a payment in maximum two tranches).
</p>

![paym1](https://user-images.githubusercontent.com/36104236/35874604-a2af3bf8-0b75-11e8-837c-a3cbc3cfe8ea.PNG)

<p>A payment made once.</p>

![paym2](https://user-images.githubusercontent.com/36104236/35874624-b2041100-0b75-11e8-8a59-5c3f8104323a.PNG)

**5. Reports**
* **The orders** which were delivered successfully or not (for suppliers/customers);

![repo1](https://user-images.githubusercontent.com/36104236/35874667-d41bec36-0b75-11e8-8dac-b6253ff90df7.PNG)

<p>
And here there is a situation of a specific customer’s order:
</p>

![repo2](https://user-images.githubusercontent.com/36104236/35874766-0b090eea-0b76-11e8-8b43-ce4c4a96e1c5.PNG)

* **Current stock items** (what products are/are not available in our stocks);

![repo3](https://user-images.githubusercontent.com/36104236/35874814-2b88f46e-0b76-11e8-9643-8b1e62ed0d50.PNG)

* **Profit or loss** (the names are suggestive, if we sold more items than our maximum costs, we got profit, otherwise a loss)

<p>We can see for a specific month if we got profit or loss. We took the month “September” for the purpose of this example (sadly we got a loss here):</p>

![repo4](https://user-images.githubusercontent.com/36104236/35874871-4e9c764c-0b76-11e8-95fb-2d77fabb5b88.PNG)

### Final considerations
<p>Although this is my first C# project (made in WinForms) it is undoubtedly not perfect. In the future, the project will be revised partially or even totally for improvements. 
This one has included the SQL scripts for creating the desired database tables in order to use the project.</p>

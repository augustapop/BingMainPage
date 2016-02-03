
# BingMainPage 

Requirements: The primary goal of the below tests is to navigate  to BingMainPage, insert a title in the search box and after validate the numbers of items founds

We will use two methods to do this:

1)We use two classes:one for Page Object where we have fields and methods to navigate,search and validate the results,and another one for test BingTests;

2)The classes and objects participating in this pattern are:

- Page Object Element Map – Contains all element properties and their location logic.

- Page Object Validator – Consists of the validations that will be performed on the page.

- Page Object (BingMainPage)- Holds the actions that can be performed on the page like Search and Navigate. Exposes an easy access to the Page Validator through the Validate() method. The best implementations of the pattern hide the usage of the Element Map, wrapping it through all action methods.

- UI Tests (BingTests) – This class contains a group of tests related to the above page; it can hold only a single instance of the page object.(SeacrchTextInBing_Second)

Ready Scenarios:

1)Validate the numbers of items found using two classes:


2)Validate the numbers ot items without using  Selenium WebDriver


Steps:

1)Navigate to  Page

2)Find the text  box where you want to insert the title

3)Write the title

4)Press the button search

5)Validate the number of items found


Run the tests:


1)Tests SearchTextInBing_First

Download Zip and run https://github.com/augustapop/BingMainPage/blob/master/BingMainPage/BingTest.cs

2)Tests SeacrchTextInBing_Second

Download Zip and run https://github.com/augustapop/BingMainPage/blob/master/BingMainPage/BingTest.cs


# BingMainPage 

The classes and objects participating in this pattern are:

Page Object Element Map – Contains all element properties and their location logic.
Page Object Validator – Consists of the validations that will be performed on the page.
Page Object (BingMainPage)- Holds the actions that can be performed on the page like Search and Navigate. 
Exposes an easy access to the Page Validator through the Validate() method. The best implementations of the
pattern hide the usage of the Element Map, wrapping it through all action methods.
UI Tests (BingTests) – This class contains a group of tests related to the above page; it can hold only a single 
instance of the page object.

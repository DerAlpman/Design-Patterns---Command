# Design Patterns - Command

This project is dedicated to the Command Design Pattern and its purpose is to teach it to me (and maybe others) using C#.

Inspired by https://www.philipphauer.de/study/se/design-pattern/command.php

## EmployeesAndPrinters

This solution shows a use case where the command design pattern is reasonable.

Employees are able to print documents on printers. But there a some problems:

* Every employee is restricted to the useage of one printer type (black-and-white, colour, matrix, pdf). What if an employee needs to print a coloured document? Or if another printer type is added?
* If there is need for a new employee class, the designer has to choose which printer it can use.
* Some printers needs different steps to be done prior printing. Every new employee has to undertake these steps.

## PrintCommand

This solutions has applied the command design pattern to the employee/printer scenario.

Every employee can use any printer using a print command. The print command handles all needed steps for a printer type.

A print command queue can be used to handle more than one print command.

The director has a special command to delegate his print orders to his secretary.
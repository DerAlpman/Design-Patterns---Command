# Design Patterns - Command

This project is dedicated to the Command Design Pattern and its purpose is to teach it to me (and maybe others).

Inspired by https://www.philipphauer.de/study/se/design-pattern/command.php

## EmployeesAndPrinters

This solution shows a use case where the command design pattern is reasonable.

Employees are able to print documents on printers. But there a some problems:

* Every Employee is restricted to the useage of one printer type (black-and-white, colour, matrix, pdf). What if an employee needs to print a coloured document? Or if another printer type is added?
* If there is need for a new employee class, the designer has to choose which printer it can use.
* Some printers needs different steps to be done prior printing. Every new employee has to undertake these steps.

## PrintCommand

This solutions has applied the command design pattern to the employee/printer scenario.
# Console Calculator
Matthew Keaton, Professor Keith Williams

# Purpose

The goal of this project was for the calculator to take in two values. These two values could be as simple as 1 and 2, or a list of numbers that need to be added together in one step. This function is designed in order to minimize the amount of entries needed when using the application. In this project multiple design patterns were used to better my understanding of C# as a whole. I also utilized delegates/events, lambda functions, and more. These Object Oriented Design Patterns include, Abstract Factories, Builders, and Dependency Injection. All of this was done while maintaining SOLID coding practices as well. The definition for solid can be found below.

* **Single-responsibility**: "A class should have one, and only one, responsibility."

* **Open-closed Principle**:  "Software should be open for extension, but closed for modification."

* **Liskov Subsitution**:  "If any module is using a Base class then the reference to that Base class can be replaced with a Derived class without affecting the        functionality of the module."

* **Interface Segregation**: "Many client-specific interfaces are better than one general-purpose interface."

* **Dependency Inversion**: "Depend on abstractions not on concrete implementations."
 
# Lambda Expressions
As with many calculators people develop code for there is going to be functions designated for handling all of the different operations. Below are the lambda expressions I used throughout the entire project.

![image](https://github.com/matthewkeaton5/IS421Calc-C-/blob/main/IMGs/Operations.png)
![image](https://github.com/matthewkeaton5/IS421Calc-C-/blob/main/IMGs/ListOperations.png)

# Events
Towards the end of this project we as a class were introduced to events. These were a difficult concept to grasp for me intially and being so far along in the project, I was worried I would not be able to find a way to add them correctly while still maintaining SOLID coding practices. However while it was a challenge I believe with my understanding of events now I have improved as a coder overall, and improved my understanding of the interaction between files and OOP.

### EventArgs
![Image](https://github.com/matthewkeaton5/IS421Calc-C-/blob/main/IMGs/EventArgs.png)

This is the primary file all the information passed from the user is stored. All this information is added here by the publisher and accessed by the subscriber. Both are shown below

### Publisher
![Image](https://github.com/matthewkeaton5/IS421Calc-C-/blob/main/IMGs/Events.png) 

The image above is an example of a publisher. This file takes in all the relevant information necessary from the code running the application and transports the relevant information to the EventArgs. This can be done rather simply by utilizing += to register the event or -= to unregister the event. For example...

```C#
_publisher.UserInputComplete += _subscriber.CompleteCalculation;
_publisher.CreateUserinput(val1, val2, op);
 _publisher.CreateCalculation(_answer);
```

### Subscriber
![Image](https://github.com/matthewkeaton5/IS421Calc-C-/blob/main/IMGs/Subscriber.png)

This is the final stop for our user input once the code arrives at this point the answer to the problem in question is displayed back to the user. This can be further improved on/refactored to take out the ''' Console.Writeline() ''' by sending the data to another event where it would be displayed. With more time this can easily be changed to better follow SOLID.

# Object Oriented Design Patterns
These patterns were the primary focus of this project. As a class we were instructed to use many of them. Below you can find more information on each of them below.

### Dependency Injection
![Image](https://github.com/matthewkeaton5/IS421Calc-C-/blob/main/IMGs/Calculation.png)
![Image](https://github.com/matthewkeaton5/IS421Calc-C-/blob/main/IMGs/BulkCalculation.png)
![Image](https://github.com/matthewkeaton5/IS421Calc-C-/blob/main/IMGs/ICalculation.png)


### Builder Pattern

### Abstract Factory



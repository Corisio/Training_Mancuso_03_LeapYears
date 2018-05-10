# E.3 – Expressing Business Rules
  
## Objective
- Clearly express business rules and domain.
- It’s OK to write a passing test if it express a valid business rule.
 
## Problem description: Leap Year
 
### Here are the rules for identifying a Leap Year:
- Is leap year if divisible by 400
- Is NOT leap year if divisible by 100 but not by 400
- Is leap year if divisible by 4
 
### Extra requirements:
- Tests AND production code should be written in a way that a Product Owner or
Business Analyst could understand the behaviour, even when looking at them
independently.
 
### Considerations:
- Think about the home (class/function) that you will put this behaviour.
What are the pros/cons when it is used by other classes?
- Can we write the code in a way that a whole category of bugs will never appear?
- How can we deal with business rules who might conflict with each other when
analysed in isolation?
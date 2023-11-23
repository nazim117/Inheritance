# Interfaces and Abstraction

# 1. Define an Interface IPerson
Define an interface IPerson with properties for Name and Age. Define a class Citizen that implements IPerson
and hastwo properties string name and an int age. The Citizen should accept name and age upon initialization.

# 2. Multiple Implementation
Using the code from the previous task, define an interface IIdentifiable with a string property Id and an 
interface IBirthable with a string property Birthdate and implement them in the Citizen class. Rewrite the 
Citizen constructor to accept the new parameters.

# 3. Telephony
You have a small business - manufacturing phones and to run your business you need to create phone software. The 
software should support two main phone models with the following functionality:
 Smartphone: 
 Can calling other phones.
 Can browsing in the world wide web.
 Stationary phone:
 Can only call other phones.
You should start the project by implementing two classes:
 The Smartphone can call other phones and browse the world wide web. 
 The StationaryPhone can only call other phones.
You should also implement interfaces for each class with the appropriate methods.
Input
The input comes from the console. It will hold two lines:
 The First line consists of phone numbers: a string, separated by spaces.
 The Second line consists of websites: a string, separated by spaces.
Output
1. First, call all valid numbers in the order of input:
 If there is a character different from a digit in a number, print: "Invalid number!" and continue 
with the next number.
 If the number is 10 digits long, you are making a call from your smartphone and print: "Calling... 
{number}"
 If the number is 7 digits long, you are making a call from your stationary phone and print: " 
Dialing... {number}"
2. Next, browser all valid websites in the order of input:
 If there is a number in the input of the URLs, print: "Invalid URL!" and continue with the next
URLs.
 If the URL is valid, print on the console the website in the format: "Browsing: {site}!"
Constraints
 Each site's URL should consist only of letters and symbols (No digits are allowed in the URL address).
 The phone numbers will always be 7 or 10 digits long.

# 4. Border Control
It’s the future, you’re the ruler of a totalitarian dystopian society inhabited by citizens and robots, since you’re afraid 
of rebellions you decide to implement strict control of who enters your city. Your soldiers check the Ids of everyone 
who enters and leaves.
You will receive an unknown amount of lines from the console until the command "End" is received, on each line, 
there will be a piece of information for either a citizen or a robot who tries to enter your city in the format: "{name} 
{age} {id}" for citizens and "{model} {id}" for robots. After the "End" command on the next line, you will 
receive a single number representing the last digits of fake ids, all citizens or robots whose Id ends with the specified 
digits must be detained.
The output of your program should consist of all detained Ids each on a separate line in the order of input.
Input
The input comes from the console. Every commands’ parameters before the command "End" will be separated by a 
single space

# 5. Birthday Celebrations
It is a well-known fact that people celebrate birthdays, it is also known that some people also celebrate their pets’
birthdays. Extend the program from your last task to add birthdates to citizens and include a class Pet, pets have a 
name and a birthdate. Encompass repeated functionality into interfaces and implement them in your classes. 
You will receive from the console an unknown number of lines. Until the command "End" is received, each line will 
contain information in one of the following formats "Citizen <name> <age> <id> <birthdate>" for Citizen, 
"Robot <model> <id>" for Robot or "Pet <name> <birthdate" for Pet. After the "End" command on the next 
line, you will receive a single number representing a specific year, your task is to print all birthdates (of both Citizen
and Pet) in that year in the format day/month/year in the order of input.

# 6. Food Shortage
Your totalitarian dystopian society suffers a shortage of food, so many rebels appear. Extend the code from your 
previous task with new functionality to solve this task.
Define a class Rebel which has a name, age, and group (string), names are unique - there will never be 
2 Rebels/Citizens or a Rebel and Citizen with the same name. Define an interface IBuyer which defines a 
method BuyFood() and an integer property Food. Implement the IBuyer interface in the Citizen and Rebel class, 
both Rebels and Citizens start with 0 food, when a Rebel buys food his Food increases by 5, when a Citizen buys food 
his Food increases by 10.
On the first line of the input you will receive an integer N - the number of people, on each of the next N lines you will 
receive information in one of the following formats "<name> <age> <id> <birthdate>" for a Citizen or "<name> 
<age><group>" for a Rebel. After the N lines, until the command "End" is received, you will receive names of people 
who bought food, each on a new line. Note that not all names may be valid, in case of an incorrect name - nothing 
should happen.
Output
The output consists of only one line on which you should print the total amount of food purchased.

# Reflection-and-Attributes

# 1. Stealer
You have the information that this hacker is keeping some of his info in private fields. Create a new class named Spy
and add inside a method called - StealFieldInfo, which receives:
 string – the name of the class to investigate
 an array of string - names of the fields to investigate
After finding the fields, you must print on the console:
"Class under investigation: {nameOfTheClass}"
On the next lines, print info about each field in the following format:
"{filedName} = {fieldValue}"
Use StringBuilder to concatenate the answer. Don’t change anything in Hacker class!

# 2. High-Quality Mistakes
You are already an expert on High-Quality Code, so you know what kind of access modifiers must be set to the
members of a class. You should have noticed that our hacker is not familiar with these concepts.
Create a method inside your Spy class called - AnalyzeAccessModifiers(string className). Check all of the
fields and methods access modifiers. Print on the console all of the mistakes in the format:
 Fields
o {fieldName} must be private!
 Getters
o {methodName} have to be public!
 Setters
o {methodName} have to be private!
Use StringBuilder to concatenate the answer. Don’t change anything in Hacker class!

# 3. Mission Private Impossible
It’s time to see what this hacker you are dealing with aims to do. Create a method inside your Spy class called -
RevealPrivateMethods(string className). Print all private methods in the following format:
All Private Methods of Class: {className}
Base Class: {baseClassName}
On the next lines, print found method’s names each on a new line. Use StringBuilder to concatenate the
answer. Don’t change anything in Hacker class!

# 4. Collector
Use reflection to get all Hacker methods. Then prepare an algorithm that will recognize which methods are getters
and setters.
Print to console each getter on a new line in the format:
"{name} will return {Return Type}"
Then print all of the setters in the format:
"{name} will set field of {Parameter Type}"
Use StringBuilder to concatenate the answer. Don’t change anything in Hacker class!

# 5. Create Attribute
Create attribute Author with a string element called name, that:
 Can be used over classes and methods
 Allow multiple attributes of the same type

# 6. Code Tracker
Create a class Tracker with a method:
 void PrintMethodsByAuthor()
The method above should print on the console information about each method that is written by someone. You
should print the information about the method and its creator in the following format: "{methodName} is
written by {authorName}". You should be able to call your method and see the output of it

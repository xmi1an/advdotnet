What is Global.asax file: global.asax allows us to write event handlers that react to global events in web applications.
 
How it gets called:
Global.asax files are never called directly by the user,
rather they are called automatically in response to application events.
 
Point to remember about global.asax:
They do not contain any HTML or ASP.NET tags.
Contain methods with specific predefined names.
They defined methods for a single class, application class.
They are optional, but a web application has no more than one global.asax file.

How to add global.asax file:
Select Website >>Add New Item (or Project)
>> Add New Item if you're using the Visual Studio web project model)
   and choose the Global Application Class template.
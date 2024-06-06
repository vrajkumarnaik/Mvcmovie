Naik Vraj(0851948)

 created on w/ VS2022 .NET 7


Recreated the ASP .NET MVC Core application
Using .Net 7,no authentication


Accessed the URL and the default works :
https://localhost:7132/
Modified the index.cshtml title to MVC MOVIE by replacing the default title WELCOME

Created README.txt for documentation.

confirmed Part1 of the tutorial is completed, Added a new controller as per the part 2


Commented the default index method which is returning to class view()
Then added new index method and changed the content to This is my default helloworld page...
complied the code and confirmed the changes works:
The URL to confirm
https://localhost:7180/Helloworld


Added another method called welcome with the content of "This is my welcome page..."
Ran the program, Confirmed the changes works:
The URL to confirm
https://localhost:7180/HelloWorld/welcome

2024-05-38

add index and adding a title 
open movie name 


Accessed the Program.cs file and checked the routing section.

Welcome method was updated to include 2 parameters String and an integer

Accessed the URL below and was working fine 

https://localhost:7180/helloworld/welcome?name=vraj&numtimes=5



Welcome method was updated again to include 2 parameters with below arguments

 Welcome(string name, int ID = 1)
 
 2024/23/05

Made the changes and accessed the below working URL
https://localhost:7180/helloworld/welcome/852786?name=vraj 

1018
HelloWorld Controller class was edited and replaced the Index code with the code mentioned in the Turorial.

1035
Created a new folder called "HelloWorld" under the Views Folder

1100
A new empty Razer view was created under the Views/HelloWorld folder.
Edited the Index.cshtml and replaced the contents mentioned in the tutorial page.
Accessed the webpage and it was working fine with the changes made.

1118
Navigated to Views/Shared/_Layout.cshtml file to change views and layout pages.
Viewdata section has been modified and below are the details of the modification 
               
1130
2024052318430820240523184308 intialcreate
20240523184308_IntialCreate.cs

https://localhost:7180/movies this is movie link
1200
input all data and show movies name 

1320
ADD THE INDEX file 
add rating try on brwoser iam able to add ratting succfully.





         



      .
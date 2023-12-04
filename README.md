# Web Chat with API service


1. [About](#About)
2. [Dependencies](#Dependencies)
3. [Instructions](#Instructions)
4. [Authors](#Authors)

## About
### We created a web service chat.

The project has a Registration page, a Login page and a Chat page, and also a Rating page screen.\

**The project uses react-router and react-bootstrap packages.**
You can find the modules installed in package.json -> dependencies. When running ```npm install``` installations are made according to this file

### Registeration Page

You must fill in all the fields. The password should be at least 8 characters, and contain both letters and numbers.

![image](https://github.com/morsimantov/Chat-App-Web-API/assets/92635551/858d9c71-f098-4e65-a71a-b487fa915fc6)

### Login Page

Only registered users can login.

![image](https://github.com/morsimantov/Chat-App-Web-API/assets/92635551/16e24095-7c05-4bf3-b781-f6151c0bf62a)

### Chat Page

Adding a new contact:

You need to fill in his username and server. You may choose any nickname you want.

Note: The contact must be a registerd user! 

![image](https://github.com/morsimantov/Chat-App-Web-API/assets/92635551/07dedcc2-3eea-43b2-987d-588cc43e351a)

Start chatting! Any message you send will be sent to your contact and can be viewd by him as well (and vice versa; the message is sent to the contact's server).

![image](https://github.com/morsimantov/Chat-App-Web-API/assets/92635551/9746ad75-2237-4d35-916e-b95db54fd70a)


## Dependencies
* Download Node.js : https://nodejs.org/en/ which includes NPM (a package manager for NODE. Js) and will be installed on your computer when you install Node.js. 
* Clone the repository
* Install dependencies using:
  ```npm install```
* Run using:
  ```npm start```  
* The project uses react-router and react-bootstrap packages.
* Modules installed can be found in package.json -> dependencies
* Our site uses microsoft/signal.
* Web-Api service needs to run as well - **Web API folder name: "WebApplicationChat".**
* Rating page ASP.net needs to run as well - **Rating App folder name: "WebApplicationRatings"**.
* **The React App is at another repository - in the link: https://github.com/ShaiFisher1/Advanced_Programming_ex2_react_app.**
* The domain of the website is set to deafault at "localhost:7170". If the port needs to be changed, then you need to change the variable - "portNumber" in the file "ServerAddress.js" to the wanted port.
* Remove Migration folder from the folder "WebApplicationChat" and "WebApplicationRatings" and and Drop table if exists. Then connect by the following commands:\
first command: Add-Migration Init, second command: Update-Database
* If the domain of the rating page needs to be changed - then you need to change the variable "ratingAppLink" at row 14 in the file "LoginItem.js".


## Instructions
* In order to login, if a user is already registered and found (in the database) you can login, otherwise, register.
* Running the program leads to the Login screen (run by opening the terminal and then ```npm start```)
* By entering a correct registered user (found in the DB) with username and password, you will be able to login.\
  Onced logged in you will be navigated to the Chat screen.
* When in the chat screen, the contacts of current user are shown on the left,\
  and by clicking on any one of them you can see the chat of the current user with the selected contact.
* Sending a new message:
  * Sending a new text message is done by typing and clicking the send button
* Adding a new contact:
  * Adding a new contact is done by pressing the logo with the plus sign, and entering an existing (registered as a user in the DB) contact. you will be required to fill the contact's username, nickname, and server address. 

## Authors
Mor Siman Tov and Shai Fisher

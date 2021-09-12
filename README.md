# Millionaire
_A game based on the famous TV show._
## User Guide
#### Installation
You can manually download the project as ZIP archive: Code -> Download ZIP. Or, if you have git installed, you can use this command:
```git clone https://github.com/Nezorin/Millionaire.git ```

To run the project you can use your IDE or dotnet CLI. If you use Visual Studio: open the solution file, build the solution(Ctrl+B) and run the code(Ctrl+F5), preferably use Kestrel run profile. Or open Command Prompt(Console) and use these commands:
```
cd "PATH TO PROJECT FOLDER" 
dotnet build
dotnet run
```
#### Usage
GIF demonstration:

![giphy](https://user-images.githubusercontent.com/47496652/132994832-81f905fc-2ed0-4f3c-a9fb-3450f58f36f1.gif)
## Architecture
  Program was written using the Service and Repository pattern. Repository sending request to DB using Entity Framework context class, also it seeds some data to database on first run. Service is used to take concrete amount of question from database and of course do it randomly. All the game logic is located in ```MillionaireController.cs```. The controller and the view exchange a game model that contains all the game fields, such as: score, user answer, question queue etc. Fifty-fifty button logic was made using JavaScript in ```site.js```.

Technologies:
 - **C#**
 - **ASP.NET MVC**
 - **Entity Framework Core**
 - **PostgreSQL**
 - **xUnit**
 - **Moq**

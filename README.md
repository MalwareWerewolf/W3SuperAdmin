# W3SuperAdmin

W3SuperAdmin is a Desktop application for Windows, you can manage different settings for Warcraft III without doing it manually. Keep in mind that some features are disabled with some versions, this application is working up to 1.31 patch, it will not work with **Reforged**.

I was inspired by the **Warcraft Assistant tool** if you notice some similarities.

## Installation

+ [Go to this page](https://github.com/Cramenorn/W3SuperAdmin/releases) and download the latest version;
+ Install [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472);
+ Extract the zip content and run the **exe** file (it needs admin privileges).

## Building

To build and run this project you need [Visual Studio 2019](https://visualstudio.microsoft.com/vs/), the [.NET Desktop development](https://visualstudio.microsoft.com/vs/features/net-development/) and [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472).

## Tips

These are just some tips that I want share if you want to fork and use the project: 

+ if you need to reinitialize the **Registry Keys**, you need to delete the Warcraft III folder in the **Registry Key editor** and launch the game. The path is the following **Computer\HKEY_CURRENT_USER\Software\Blizzard Entertainment\Warcraft III** ;
+ in the **Settings form** you should mantain the same name format between all controls;
+ it's better to put the application logic inside the **BLL** from the moment it serves as an intermediary for data exchange with the presentation layer.

## Watch it in action on Youtube
[![youtube](https://i9.ytimg.com/vi/xipiO_RvgyA/mqdefault.jpg?sqp=CMjxo_oF&rs=AOn4CLAAjlORDQ_UHOPQ-kfuLvPA8-ff5g)](https://www.youtube.com/watch?v=xipiO_RvgyA)
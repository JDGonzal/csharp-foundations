<!-- markdownlint-disable MD012 -->
<!-- markdownlint-disable MD029 -->
<!-- markdownlint-disable MD031 -->
<!-- markdownlint-disable MD032 -->

# CURSO DE C# DESDE CERO 2025

## csharp-foundations

Personal journal of your progress, sounds professional, ideal for solid foundations.

This Learning win wi based on this video list: [Curso de programación con C#](https://www.youtube.com/watch?v=CPPxQlKxQEQ&list=PL2Z95CSZ1N4F7mym8Ca16RoTDVAlIOPlT)

## 2. INSTALACION VISUAL STUDIO 2022 video(2)

>[!IMPORTANT]
>
>Visual Studio vs. Visual Studio Code

1. The instructor suggest in this video [INSTALACION VISUAL STUDIO 2022](https://www.youtube.com/watch?v=5FvYlQ6cpqo&list=PL2Z95CSZ1N4F7mym8Ca16RoTDVAlIOPlT&index=2), but I have installed the [Visual Studio Code](https://code.visualstudio.com/download?_exp_download=fb315fc982).
2. To complete the process I follow this video "[como INSTALAR C# en VISUAL STUDIO CODE 😱](https://www.youtube.com/watch?v=W5naqm7XK9Y)".
3. Download the SDK of .NET from this site [Descargar .NET paraWindows](https://dotnet.microsoft.com/es-es/download), the current version is `SDK versión 10.0.400, publicación 11 de agosto de 2026`.
4. I run the the last file: `dotnet-sdk-10.0.400-win-x64.exe` for _Windows_ and wait for the final message: </br> ![Microsoft .NET SDK 10.0.400](images/2026-08-15_171240.png "Microsoft .NET SDK 10.0.400")











5. To check in a `TERMINAL` I run this command: </br> `dotnet --version` </br>The answer must be like: `10.0.400`.
6. The first test inside the my repository with name `csharp-foundations`, using a  `TERMINAL`, I run this command: </br> `dotnet new console -o prueba1`
7. I get inside the directory: </br> `cd prueba1` </br> and open up another `Visual Studio Code` with the command: `code .`
8. That is I get in this new windows: </br> ![First time inside the 'prueba1' project](images/2026-08-16_062930.png "First time inside the 'prueba1' project")













9. I add in VSCode the `C#` extension from [Microsoft](https://www.microsoft.com/), it helps to code completation.
10. Using a `TERMINAL` I run the command: </br> `dotnet run` </br> The answer must be like open a new windows and in the `TERMINAL` this message `Hello, World!`.
11. I can get the _EXE_ file running in the `TERMINAL` the command: </br> `dotnet build` </br> Then I get those files: </br> ![Generated files after 'build'](images/2026-08-16_065314.png "Generated files after 'build'")















12. Another extension to install in VSCode is [`Material Icon Theme`](https://marketplace.visualstudio.com/items?itemName=PKief.material-icon-theme) from [Philipp Kief](https://marketplace.visualstudio.com/publishers/PKief).
13. Close the last `Visual Studio Code`.
14. Check for the **`.gitignore`** file.

---

## 3. CREAR UN PROYECTO EN C# video(3)

1. How the instructor uses the `Visual Studio`, instead of the simple `Visual Studio Code`, in the first one there are option menu to select the creation type.
2. Moust be sure in the repository directory `csharp-foundations`, if is necessary use the `cd ..` to back to this directory.
3. In our system using a `TERMINAL`, we create a project with the command: </br> `dotnet new console -o console-app1`
4. I change to the new directory using in the `TERMINAL`: </br> `cd console-app1` </br> Then the other command `code .`
5. Following the, I select `Run`->`Start Debugging F5`, it askme for the language, then I select `C#` then what file I'll run.
6. Executes this in the `TERMINAL`:
```bash
 *  Executing task: dotnet: build e:\tutorials\c-sharp\csharp-foundations\console-app1\console-app1.csproj 

dotnet build e:\tutorials\c-sharp\csharp-foundations\console-app1\console-app1.csproj /property:GenerateFullPaths=true /p:Configuration=Debug /p:Platform=AnyCPU /consoleloggerparameters:NoSummary 
C# extension build result service is available.
  Determining projects to restore...
  Restored e:\tutorials\c-sharp\csharp-foundations\console-app1\console-app1.csproj (in 81 ms).
  console-app1 -> e:\tutorials\c-sharp\csharp-foundations\console-app1\bin\Debug\net10.0\console-app1.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:01.35
 *  Terminal will be reused by tasks, press any key to close it. 
```
7. Finally in another `TERMINAL` window, it shows:
```bash
 & 'c:\Users\pizah\.vscode\extensions\ms-dotnettools.csharp-2.140.9-win32-x64\.debugger\x86_64\vsdbg.exe' '--interpreter=vscode' '--connection=782dc2d3054a4092964e0240742dd72c' 
Hello, World!
```
8. Close the last VSCode, and back in this `TERMINAL` to the directory of repository: ``.


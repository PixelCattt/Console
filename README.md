<div align="center">
  <h1>Console</h1>

  THE Admin-System for Gorilla Tag Mods!

  <a href="https://github.com/PixelCattt/Console/compare/1962a6d...master">
    <img src="https://img.shields.io/badge/view-changes-lime?style=for-the-badge"</img>
  </a>
</div>

---

## Implementation
1. Drag the ConsoleScripts Folder into your Project
3. Configure Console.cs and ServerData.cs
3. Add this Code into BaseUnityPlugin.Start (Inside your Plugin.cs):

```csharp
Console.LoadConsole();
```

## Usage
To execute Console commands, you can use the `Console.ExecuteCommand()` Method with the Command and its Arguments.
Check inside of `Console.HandleConsoleCommand()` to see all Commands you can use.

# OpenIconPack

**OpenIconPack** is a C# library that provides a curated collection of open‑source SVG icons for .NET projects. The icons are stored as SVG strings and can be rendered, resized, or integrated into UI frameworks (WinForms, WPF, MAUI, Blazor, etc.).

An icon library that allows you to load SVG icons from built-in and external JSON sources, customize them, and use them in .NET applications.

## Features

- ✅ 60+ ready‑to‑use icons (home, settings, files, actions, emotions, etc.)
- ✅ Icons defined as SVG markup in `OpenIconPack_Default.json`
- ✅ Strongly‑named class `OpenIcon` with helper methods (`Set`, `GetIcon`)
- ✅ Configurable default size, stroke, opacity and color
- ✅ MIT license – free for personal and commercial use

## Installation

### NuGet (recommended)

```bash
# If you published the package, install like this:
dotnet add package OpenIconPack
```

### Manual

1. Clone the repository  
   ```bash
   git clone https://github.com/mustafaduran/OpenIconPack.git
   cd OpenIconPack
   ```
2. Build the solution  
   ```bash
   dotnet build OpenIconPack.sln
   ```
3. Reference the `OpenIconPack` project from your own solution, or add the compiled DLL to your project’s references.

## Quick Usage

```csharp
using OpenIconPack;

// Get a bitmap (24 × 24 by default)
var homeIcon = OpenIcon.Set("home");           // returns System.Drawing.Bitmap
var addIcon = OpenIcon.Set(IconName.add);           // returns System.Drawing.Bitmap

// Custom size and styling
var settingsIcon = OpenIcon.Set("settings", size: 48, stroke: 2, stroke_color: Color.Red, opacity: 80);

// Access the raw SVG string
var svg = OpenIcon.GetIcon("bell").Svg;        // => "<svg …>…</svg>"
```

The static `DefaultSize`, `DefaultStroke`, `DefaultOpacity`, and `DefaultStrokeColor` properties can be changed globally before calling `Set`.

## Default Settings
Can set default settings in the Program.cs
```
//Can use .json file in file system
OpenIcon.JsonPath = "C:\\Users\\User\\Documents\\MyIconPack.json";

//Can use .json file in github repo
OpenIcon.JsonUrl = "https://raw.githubusercontent.com/mustafaduran/OpenIconPack_JSON/refs/heads/main/OpenIconPack_Default.json";

//Can set default stroke
OpenIcon.DefaultStroke = 1.8f;

//Can set default stroke color
OpenIcon.DefaultStrokeColor = Color.Gray;

//Can set default size
OpenIcon.DefaultSize = 32;
```
## Available Icons

The pack includes the following icons (name as used in code):

- `main_menu`
- `settings`
- `filter`
- `forward`
- `back`
- `home`
- `left_arrow`
- `right_arrow`
- `up_arrow`
- `down_arrow`
- `refresh`
- `open_folder`
- `save`
- `pdf_file`
- `excel_file`
- `json_file`
- `word_file`
- `database`
- `server`
- `delete`
- `copy`
- `cut`
- `paste`
- `edit`
- `add`
- `terminal`
- `heart`
- `bell`
- `browser`
- `user`
- `users`
- `mail`
- `phone`
- `url`
- `attachment`
- `stop`
- `play`
- `success`
- `error`
- `warning`
- `info`
- `locked`
- `unlock`
- `eye`
- `eye_off`
- `wiFi`
- `star`
- `tag`
- `calendar`
- `clock`

(Full SVG definitions are in `OpenIconPack/json/OpenIconPack_Default.json`.)




## Contributing

1. Fork the repo.
2. Add a new icon entry to `OpenIconPack/json/OpenIconPack_Default.json` (follow the existing pattern) **or** add a constant to `OpenIconPack/OpenIconNames.cs`.
3. Update this `README.md` with a brief description of the new icon.
4. Submit a pull request.

Please respect the MIT license and keep the visual style consistent.

## License

This project is licensed under the **MIT License** – see the `LICENSE` file for details.

## Contact

- GitHub: [https://github.com/mustafaduran/OpenIconPack](https://github.com/mustafaduran/OpenIconPack)
- Issues: [GitHub Issues](https://github.com/mustafaduran/OpenIconPack/issues)

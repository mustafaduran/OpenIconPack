# OpenIconPack

[![NuGet](https://img.shields.io/nuget/v/OpenIconPack.svg)](https://www.nuget.org/packages/OpenIconPack/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/OpenIconPack.svg)](https://www.nuget.org/packages/OpenIconPack/)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)

**OpenIconPack** is a .NET library that provides a curated collection of open-source SVG icons. Load icons from the built-in collection or external JSON sources, customize them, and use them in your .NET applications.

## Features

- 60+ ready-to-use icons for navigation, files, actions, and more
- Icons stored as SVG markup in `OpenIconPack_Default.json`
- `OpenIcon.GetSvg` to retrieve an icon's SVG markup
- `WinFormExtension.GetBitmap` to render an icon as a Windows Forms bitmap
- Configurable icon size, stroke, opacity, and color for bitmap rendering
- MIT licensed for personal and commercial use

## Installation

Install the package from NuGet:

```bash
dotnet add package OpenIconPack
```

Or install it from the [NuGet package page](https://www.nuget.org/packages/OpenIconPack/).

## Quick start

### Get SVG markup

```csharp
using OpenIconPack;

string svg = OpenIcon.GetSvg("home");
```

### Use an icon in Windows Forms

```csharp
using OpenIconPack;

// Assign the rendered icon bitmap to a Windows Forms control
button1.Image = WinFormExtension.GetBitmap(IconName.cut);

// Optional: set shared rendering defaults
OpenIcon.DefaultSize = 32;
OpenIcon.DefaultStroke = 1.8f;
OpenIcon.DefaultOpacity = 100;
WinFormExtension.DefaultStrokeColor = Color.Gray;
```

`WinFormExtension.GetBitmap` also accepts an icon name as a string and optional size and color arguments:

```csharp
var icon = WinFormExtension.GetBitmap("home", size: 32, color: Color.DarkSlateBlue);
```

## Use an external icon JSON source

Configure a local JSON file or a JSON file hosted online before requesting an icon:

```csharp
// Load from a local file
OpenIcon.JsonPath = @"C:\Users\User\Documents\MyIconPack.json";

// Or load from a GitHub-hosted JSON file
OpenIcon.JsonUrl = "https://raw.githubusercontent.com/mustafaduran/OpenIconPack_JSON/refs/heads/main/OpenIconPack_Default.json";
```

## Available icons

Use these names when requesting icons:

`main_menu`, `settings`, `filter`, `forward`, `back`, `home`, `left_arrow`, `right_arrow`, `up_arrow`, `down_arrow`, `refresh`, `open_folder`, `save`, `pdf_file`, `excel_file`, `json_file`, `word_file`, `database`, `server`, `delete`, `copy`, `cut`, `paste`, `edit`, `add`, `terminal`, `heart`, `bell`, `browser`, `user`, `users`, `mail`, `phone`, `url`, `attachment`, `stop`, `play`, `success`, `error`, `warning`, `info`, `locked`, `unlock`, `eye`, `eye_off`, `wiFi`, `star`, `tag`, `calendar`, `clock`.

The full SVG definitions are in `OpenIconPack/json/OpenIconPack_Default.json`.

## Releases

### 1.0.0

The initial NuGet release of OpenIconPack. It includes the built-in icon collection, support for external JSON icon sources, SVG retrieval, and Windows Forms bitmap rendering.

- [Install OpenIconPack 1.0.0 from NuGet](https://www.nuget.org/packages/OpenIconPack/1.0.0)
- [Browse GitHub Releases](https://github.com/mustafaduran/OpenIconPack/releases)

## Contributing

1. Fork the repository.
2. Add an icon to `OpenIconPack/json/OpenIconPack_Default.json` following the existing format, or add its name to `OpenIconPack/OpenIcon.Names.cs`.
3. Update this README if the available icons change.
4. Open a pull request.

Please respect the MIT license and keep the visual style consistent.

## License

This project is licensed under the [MIT License](LICENSE).

## Links

- [NuGet package](https://www.nuget.org/packages/OpenIconPack/)
- [GitHub repository](https://github.com/mustafaduran/OpenIconPack)
- [Issues and bug reports](https://github.com/mustafaduran/OpenIconPack/issues)

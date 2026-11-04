# OpenIconPack

[![NuGet](https://img.shields.io/nuget/v/OpenIconPack.svg)](https://www.nuget.org/packages/OpenIconPack/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/OpenIconPack.svg)](https://www.nuget.org/packages/OpenIconPack/)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)

**OpenIconPack** is a .NET library that provides a curated collection of open-source SVG icons. Load icons from the built-in collection or external JSON sources, customize them, and use them in your .NET applications.

## Features

- 60+ ready-to-use icons for navigation, files, actions, and more
- Icons stored as SVG markup in `OpenIconPack_Default.json`
- `OpenIcon` helper methods for retrieving and customizing icons
- Configurable icon size, stroke, opacity, and color
- MIT licensed for personal and commercial use

## Installation

Install the package from NuGet:

```bash
dotnet add package OpenIconPack
```

Or install it from the [NuGet package page](https://www.nuget.org/packages/OpenIconPack/).

## Quick start

```csharp
using OpenIconPack;
using System.Drawing;

// Get an icon as a bitmap (24 × 24 by default)
var homeIcon = OpenIcon.Set("home");
var addIcon = OpenIcon.Set(IconName.add);

// Set a custom size and style
var settingsIcon = OpenIcon.Set(
    "settings",
    size: 48,
    stroke: 2,
    stroke_color: Color.Red,
    opacity: 80);

// Retrieve the raw SVG string
var svg = OpenIcon.GetIcon("bell").Svg;
```

You can change the defaults globally before calling `Set`:

```csharp
OpenIcon.DefaultStroke = 1.8f;
OpenIcon.DefaultStrokeColor = Color.Gray;
OpenIcon.DefaultSize = 32;
```

## Use an external icon JSON source

Configure a local JSON file or a JSON file hosted online:

```csharp
// Load from a local file
OpenIcon.JsonPath = @"C:\Users\User\Documents\MyIconPack.json";

// Load from a GitHub-hosted JSON file
OpenIcon.JsonUrl = "https://raw.githubusercontent.com/mustafaduran/OpenIconPack_JSON/refs/heads/main/OpenIconPack_Default.json";
```

## Available icons

Use these names when requesting icons:

`main_menu`, `settings`, `filter`, `forward`, `back`, `home`, `left_arrow`, `right_arrow`, `up_arrow`, `down_arrow`, `refresh`, `open_folder`, `save`, `pdf_file`, `excel_file`, `json_file`, `word_file`, `database`, `server`, `delete`, `copy`, `cut`, `paste`, `edit`, `add`, `terminal`, `heart`, `bell`, `browser`, `user`, `users`, `mail`, `phone`, `url`, `attachment`, `stop`, `play`, `success`, `error`, `warning`, `info`, `locked`, `unlock`, `eye`, `eye_off`, `wiFi`, `star`, `tag`, `calendar`, `clock`.

The full SVG definitions are in `OpenIconPack/json/OpenIconPack_Default.json`.

## Releases

### 1.0.0

The initial NuGet release of OpenIconPack. It includes the built-in icon collection, support for external JSON icon sources, and options to customize icon size and appearance.

- [Install OpenIconPack from NuGet](https://www.nuget.org/packages/OpenIconPack/1.0.0)
- [Browse GitHub Releases](https://github.com/mustafaduran/OpenIconPack/releases)

## Contributing

1. Fork the repository.
2. Add an icon to `OpenIconPack/json/OpenIconPack_Default.json` following the existing format, or add its name to `OpenIconPack/OpenIconNames.cs`.
3. Update this README if the available icons change.
4. Open a pull request.

Please respect the MIT license and keep the visual style consistent.

## License

This project is licensed under the [MIT License](LICENSE).

## Links

- [NuGet package](https://www.nuget.org/packages/OpenIconPack/)
- [GitHub repository](https://github.com/mustafaduran/OpenIconPack)
- [Issues and bug reports](https://github.com/mustafaduran/OpenIconPack/issues)

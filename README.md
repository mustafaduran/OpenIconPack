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

# OpenIconPack Default (v1.0.0)

| View | Icon Name | Tags |
| :---: | :--- | :--- |
| ![main_menu](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M3%209l9-7%209%207v11a2%202%200%200%201-2%202H5a2%202%200%200%201-2-2z%22/><polyline%20points=%229%2022%209%2012%2015%2012%2015%2022%22/></svg>) | `main_menu` | home,mainmenu |
| ![settings](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><circle%20cx=%2212%22%20cy=%2212%22%20r=%223%22/><path%20d=%22M19.4%2015a1.65%201.65%200%200%200%20.33%201.82l.06.06a2%202%200%200%201%200%202.83%202%202%200%200%201-2.83%200l-.06-.06a1.65%201.65%200%200%200-1.82-.33%201.65%201.65%200%200%200-1%201.51V21a2%202%200%200%201-2%202%202%202%200%200%201-2-2v-.09A1.65%201.65%200%200%200%209%2019.4a1.65%201.65%200%200%200-1.82.33l-.06.06a2%202%200%200%201-2.83%200%202%202%200%200%201%200-2.83l.06-.06a1.65%201.65%200%200%200%20.33-1.82%201.65%201.65%200%200%200-1.51-1H3a2%202%200%200%201-2-2%202%202%200%200%201%202-2h.09A1.65%201.65%200%200%200%204.6%209a1.65%201.65%200%200%200-.33-1.82l-.06-.06a2%202%200%200%201%200-2.83%202%202%200%200%201%202.83%200l.06.06a1.65%201.65%200%200%200%201.82.33H9a1.65%201.65%200%200%200%201-1.51V3a2%202%200%200%201%202-2%202%202%200%200%201%202%202v.09a1.65%201.65%200%200%200%201%201.51%201.65%201.65%200%200%200%201.82-.33l.06-.06a2%202%200%200%201%202.83%200%202%202%200%200%201%200%202.83l-.06.06a1.65%201.65%200%200%200-.33%201.82V9a1.65%201.65%200%200%200%201.51%201H21a2%202%200%200%201%202%202%202%202%200%200%201-2%202h-.09a1.65%201.65%200%200%200-1.51%201z"/></svg>) | `settings` | ayarlar settings |
| ![filter](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><polygon%20points=%2222%203%202%203%2010%2012.46%2010%2019%2014%2021%2014%2012.46%2022%203%22/></svg>) | `filter` | filter |
| ![forward](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><polyline%20points=%229%2018%2015%2012%209%206%22/></svg>) | `forward` | forward |
| ![back](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><polyline%20points=%2215%2018%209%2012%2015%206%22/></svg>) | `back` | back |
| ![home](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M3%209l9-7%209%207v11a2%202%200%200%201-2%202H5a2%202%200%200%201-2-2z%22/></svg>) | `home` | home |
| ![left_arrow](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><line%20x1=%2219%22%20y1=%2212%22%20x2=%225%22%20y2=%2212%22/><polyline%20points=%2212%2019%205%2012%2012%205%22/></svg>) | `left_arrow` | left arrow |
| ![right_arrow](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><line%20x1=%225%22%20y1=%2212%22%20x2=%2219%22%20y2=%2212%22/><polyline%20points=%2212%205%2019%2012%2012%2019%22/></svg>) | `right_arrow` | right arrow |
| ![up_arrow](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><line%20x1=%2212%22%20y1=%2219%22%20x2=%2212%22%20y2=%225%22/><polyline%20points=%225%2012%2012%205%2019%2012%22/></svg>) | `up_arrow` | up arrow |
| ![down_arrow](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><line%20x1=%2212%22%20y1=%225%22%20x2=%2212%22%20y2=%2219%22/><polyline%20points=%2219%2012%2012%2019%205%2012%22/></svg>) | `down_arrow` | down arrow |
| ![refresh](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><polyline%20points=%2223%204%2023%2010%2017%2010%22/><path%20d=%22M20.49%2015a9%209%200%201%201-2.12-9.36L23%2010%22/></svg>) | `refresh` | refresh,reload |
| ![open_folder](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M22%2019a2%202%200%200%201-2%202H4a2%202%200%200%201-2-2V5a2%202%200%200%201%202-2h5l2%203h9a2%202%200%200%201%202%202z%22/></svg>) | `open_folder` | open folder |
| ![save](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M19%2021H5a2%202%200%200%201-2-2V5a2%202%200%200%201%202-2h11l5%205v11a2%202%200%200%201-2%202z%22/><polyline%20points=%2217%2021%2017%2013%207%2013%207%2021%22/><polyline%20points=%227%203%207%208%2015%208%22/></svg>) | `save` | save |
| ![pdf_file](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M14%202H6a2%202%200%200%200-2%202v16a2%202%200%200%200%202%202h12a2%202%200%200%200%202-2V8z%22/><polyline%20points=%2214%202%2014%208%2020%208%22/><path%20d=%22M9%2015h2a1.5%201.5%200%200%200%200-3H9v6%22/><path%20d=%22M15%2015h1.5a1.5%201.5%200%200%200%200-3H15v6%22/></svg>) | `pdf_file` | pdf file |
| ![excel_file](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M14%202H6a2%202%200%200%200-2%202v16a2%202%200%200%200%202%202h12a2%202%200%200%200%202-2V8z%22/><polyline%20points=%2214%202%2014%208%2020%208%22/><line%20x1=%228%22%20y1=%2213%22%20x2=%2216%22%20y2=%2217%22/><line%20x1=%228%22%20y1=%2217%22%20x2=%2216%22%20y2=%2213%22/></svg>) | `excel_file` | excel |
| ![json_file](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M14%202H6a2%202%200%200%200-2%202v16a2%202%200%200%200%202%202h12a2%202%200%200%200%202-2V8z%22/><polyline%20points=%2214%202%2014%208%2020%208%22/><path%20d=%22M10%2012h1a1%201%200%200%201%201%201v1a1%201%200%200%200%201%201%201%201%200%200%200-1%201v1a1%201%200%200%201-1%201h-1%22/><path%20d=%22M14%2012h1a1%201%200%200%201%201%201v1a1%201%200%200%200%201%201%201%201%200%200%200-1%201v1a1%201%200%200%201-1%201h-1%22/></svg>) | `json_file` | json |
| ![word_file](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M14%202H6a2%202%200%200%200-2%202v16a2%202%200%200%200%202%202h12a2%202%200%200%200%202-2V8z%22/><polyline%20points=%2214%202%2014%208%2020%208%22/><path%20d=%22M8%2013l2%205%202-3%202%203%202-5%22/></svg>) | `word_file` | word |
| ![database](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><ellipse%20cx=%2212%22%20cy=%225%22%20rx=%229%22%20ry=%223%22/><path%20d=%22M21%2012c0%201.66-4%203-9%203s-9-1.34-9-3%22/><path%20d=%22M3%205v14c0%201.66%204%203%209%203s9-1.34%209-3V5%22/></svg>) | `database` | database |
| ![server](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><rect%20x=%222%22%20y=%222%22%20width=%2220%22%20height=%228%22%20rx=%222%22%20ry=%222%22/><rect%20x=%222%22%20y=%2214%22%20width=%2220%22%20height=%228%22%20rx=%222%22%20ry=%222%22/><line%20x1=%226%22%20y1=%226%22%20x2=%226.01%22%20y2=%226%22/><line%20x1=%226%22%20y1=%2218%22%20x2=%226.01%22%20y2=%2218%22/></svg>) | `server` | server |
| ![delete](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><polyline%20points=%223%206%205%206%2021%206%22/><path%20d=%22M19%206v14a2%202%200%200%201-2%202H7a2%202%200%200%201-2-2V6m3%200V4a2%202%200%200%201%202-2h4a2%202%200%200%201%202%202v2%22/><line%20x1=%2210%22%20y1=%2211%22%20x2=%2210%22%20y2=%2217%22/><line%20x1=%2214%22%20y1=%2211%22%20x2=%2214%22%20y2=%2217%22/></svg>) | `delete` | delete trash |
| ![copy](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><rect%20x=%229%22%20y=%229%22%20width=%2213%22%20height=%2213%22%20rx=%222%22%20ry=%222%22/><path%20d=%22M5%2015H4a2%202%200%200%201-2-2V4a2%202%200%200%201%202-2h9a2%202%200%200%201%202%202v1%22/></svg>) | `copy` | copy |
| ![cut](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><circle%20cx=%226%22%20cy=%226%22%20r=%223%22/><circle%20cx=%226%22%20cy=%2218%22%20r=%223%22/><line%20x1=%2220%22%20y1=%224%22%20x2=%228.12%22%20y2=%2215.88%22/><line%20x1=%2214.47%22%20y1=%2214.48%22%20x2=%2220%22%20y2=%2220%22/><line%20x1=%228.12%22%20y1=%228.12%22%20x2=%2212%22%20y2=%2212%22/></svg>) | `cut` | scissors cut |
| ![paste](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M16%204h2a2%202%200%200%201%202%202v14a2%202%200%200%201-2%202H6a2%202%200%200%201-2-2V6a2%202%200%200%201%202-2h2%22/><rect%20x=%228%22%20y=%222%22%20width=%228%22%20height=%224%22%20rx=%221%22%20ry=%221%22/></svg>) | `paste` | paste clipboard |
| ![edit](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M11%204H4a2%202%200%200%200-2%202v14a2%202%200%200%200%202%202h14a2%202%200%200%200%202-2v-7%22/><path%20d=%22M18.5%202.5a2.121%202.121%200%200%201%203%203L12%2015l-4%201%201-4%209.5-9.5z%22/></svg>) | `edit` | edit pencil |
| ![add](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><line%20x1=%2212%22%20y1=%225%22%20x2=%2212%22%20y2=%2219%22/><line%20x1=%225%22%20y1=%2212%22%20x2=%2219%22%20y2=%2212%22/></svg>) | `add` | add plus |
| ![terminal](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><polyline%20points=%224%2017%2010%2011%204%205%22/><line%20x1=%2212%22%20y1=%2219%22%20x2=%2220%22%20y2=%2219%22/></svg>) | `terminal` | terminal code console |
| ![heart](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M20.84%204.61a5.5%205.5%200%200%200-7.78%200L12%205.67l-1.06-1.06a5.5%205.5%200%200%200-7.78%207.78l1.06%201.06L12%2021.23l7.78-7.78%201.06-1.06a5.5%205.5%200%200%200%200-7.78z%22/></svg>) | `heart` | like heart |
| ![bell](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M18%208A6%206%200%200%200%206%208c0%207-3%209-3%209h18s-3-2-3-9%22/><path%20d=%22M13.73%2021a2%202%200%200%201-3.46%200%22/></svg>) | `bell` | notification bell |
| ![browser](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><circle%20cx=%2212%22%20cy=%2212%22%20r=%2210%22/><line%20x1=%222%22%20y1=%2212%22%20x2=%2222%22%20y2=%2212%22/><path%20d=%22M12%202a15.3%2015.3%200%200%201%204%2010%2015.3%2015.3%200%200%201-4%2010%2015.3%2015.3%200%200%201-4-10%2015.3%2015.3%200%200%201%204-10z%22/></svg>) | `browser` | browser globe |
| ![user](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M20%2021v-2a4%204%200%200%200-4-4H8a4%204%200%200%200-4%204v2%22/><circle%20cx=%2212%22%20cy=%227%22%20r=%224%22/></svg>) | `user` | user |
| ![users](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M17%2021v-2a4%204%200%200%200-4-4H5a4%204%200%200%200-4%204v2%22/><circle%20cx=%229%22%20cy=%227%22%20r=%224%22/><path%20d=%22M23%2021v-2a4%204%200%200%200-3-3.87%22/><path%20d=%22M16%203.13a4%204%200%200%201%200%207.75%22/></svg>) | `users` | users team |
| ![mail](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M4%204h16c1.1%200%202%20.9%202%202v12c0%201.1-.9%202-2%202H4c-1.1%200-2-.9-2-2V6c0-1.1.9-2%202-2z%22/><polyline%20points=%2222,6%2012,13%202,6%22/></svg>) | `mail` | mail email envelope |
| ![phone](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M22%2016.92v3a2%202%200%200%201-2.18%202%2019.79%2019.79%200%200%201-8.63-3.07%2019.5%2019.5%200%200%201-6-6%2019.79%2019.79%200%200%201-3.07-8.67A2%202%200%200%201%204.11%202h3a2%202%200%200%201%202%201.72%2012.84%2012.84%200%200%200%20.7%202.81%202%202%200%200%201-.45%202.11L8.09%209.91a16%2016%200%200%200%206%206l1.27-1.27a2%202%200%200%201%202.11-.45%2012.84%2012.84%200%200%200%202.81.7A2%202%200%200%201%2022%2016.92z%22/></svg>) | `phone` | phone call |
| ![url](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M10%2013a5%205%200%200%200%207.54.54l3-3a5%205%200%200%200-7.07-7.07l-1.72%201.71%22/><path%20d=%22M14%2011a5%205%200%200%200-7.54-.54l-3%203a5%205%200%200%200%207.07%207.07l1.71-1.71%22/></svg>) | `url` | link url chain |
| ![attachment](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M21.44%2011.05l-9.19%209.19a6%206%200%200%201-8.49-8.49l9.19-9.19a4%204%200%200%201%205.66%205.66l-9.2%209.19a2%202%200%200%201-2.83-2.83l8.49-8.48%22/></svg>) | `attachment` | attachment paperclip |
| ![stop](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><rect%20x=%226%22%20y=%226%22%20width=%2212%22%20height=%2212%22%20rx=%221%22%20ry=%221%22/></svg>) | `stop` | stop |
| ![play](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><polygon%20points=%225%203%2019%2012%205%2021%205%203%22/></svg>) | `play` | play |
| ![success](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M22%2011.08V12a10%2010%200%201%201-5.93-9.14%22/><polyline%20points=%2222%204%2012%2014.01%209%2011.01%22/></svg>) | `success` | success check |
| ![error](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><circle%20cx=%2212%22%20cy=%2212%22%20r=%2210%22/><line%20x1=%2215%22%20y1=%229%22%20x2=%229%22%20y2=%2215%22/><line%20x1=%229%22%20y1=%229%22%20x2=%2215%22%20y2=%2215%22/></svg>) | `error` | error x |
| ![warning](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M10.29%203.86L1.82%2018a2%202%200%200%200%201.71%203h16.94a2%202%200%200%200%201.71-3L13.71%203.86a2%202%200%200%200-3.42%200z%22/><line%20x1=%2212%22%20y1=%229%22%20x2=%2212%22%20y2=%2213%22/><line%20x1=%2212%22%20y1=%2217%22%20x2=%2212.01%22%20y2=%2217%22/></svg>) | `warning` | warning alert |
| ![info](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><circle%20cx=%2212%22%20cy=%2212%22%20r=%2210%22/><line%20x1=%2212%22%20y1=%2216%22%20x2=%2212%22%20y2=%2212%22/><line%20x1=%2212%22%20y1=%228%22%20x2=%2212.01%22%20y2=%228%22/></svg>) | `info` | info |
| ![lock](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><rect%20x=%223%22%20y=%2211%22%20width=%2218%22%20height=%2211%22%20rx=%222%22%20ry=%222%22/><path%20d=%22M7%2011V7a5%205%200%200%201%2010%200v4%22/></svg>) | `lock` | lock |
| ![unlock](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><rect%20x=%223%22%20y=%2211%22%20width=%2218%22%20height=%2211%22%20rx=%222%22%20ry=%222%22/><path%20d=%22M7%2011V7a5%205%200%200%201%209.9-1%22/></svg>) | `unlock` | unlock |
| ![eye](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M1%2012s4-8%2011-8%2011%208%2011%208-4%208-11%208-11-8-11-8z%22/><circle%20cx=%2212%22%20cy=%2212%22%20r=%223%22/></svg>) | `eye` | eye |
| ![eye_off](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M17.94%2017.94A10.07%2010.07%200%200%201%2012%2020c-7%200-11-8-11-8a18.45%2018.45%200%200%201%205.06-5.94M9.9%204.24A9.12%209.12%200%200%201%2012%204c7%200%2011%208%2011%208a18.5%2018.5%200%200%201-2.16%203.19m-6.72-1.07a3%203%200%201%201-4.24-4.24%22/><line%20x1=%221%22%20y1=%221%22%20x2=%2223%22%20y2=%2223%22/></svg>) | `eye_off` | eye off |
| ![wiFi](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M5%2012.55a11%2011%200%200%201%2014.08%200%22/><path%20d=%22M1.42%209a16%2016%200%200%201%2021.16%200%22/><path%20d=%22M8.53%2016.11a6%206%200%200%201%206.95%200%22/><line%20x1=%2212%22%20y1=%2220%22%20x2=%2212.01%22%20y2=%2220%22/></svg>) | `wiFi` | wifi wireless |
| ![star](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><polygon%20points=%2212%202%2015.09%208.26%2022%209.27%2017%2014.14%2018.18%2021.02%2012%2017.77%205.82%2021.02%207%2014.14%202%209.27%208.91%208.26%2012%202%22/></svg>) | `star` | star |
| ![tag](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><path%20d=%22M20.59%2013.41l-7.17%207.17a2%202%200%200%201-2.83%200L2%2012V2h10l8.59%208.59a2%202%200%200%201%200%202.82z%22/><line%20x1=%227%22%20y1=%227%22%20x2=%227.01%22%20y2=%227%22/></svg>) | `tag` | tag,label |
| ![calendar](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><rect%20x=%223%22%20y=%224%22%20width=%2218%22%20height=%2218%22%20rx=%222%22%20ry=%222%22/><line%20x1=%2216%22%20y1=%222%22%20x2=%2216%22%20y2=%226%22/><line%20x1=%228%22%20y1=%222%22%20x2=%228%22%20y2=%226%22/><line%20x1=%223%22%20y1=%2210%22%20x2=%2221%22%20y2=%2210%22/></svg>) | `calendar` | calendar |
| ![clock](data:image/svg+xml;utf8,<svg%20viewBox=%220%200%2024%2024%22%20width=%2228%22%20height=%2228%22%20fill=%22none%22%20stroke=%22currentColor%22%20stroke-width=%222%22%20stroke-linecap=%22round%22%20stroke-linejoin=%22round%22><circle%20cx=%2212%22%20cy=%2212%22%20r=%2210%22/><polyline%20points=%2212%206%2012%2012%2016%2014%22/></svg>) | `clock` | clock, time |

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

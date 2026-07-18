# SUS Public Demo

Minimal Unity 6 demo for **open-core** SUS: [sus-core](https://github.com/antaresdk/sus-core) + [sus-router](https://github.com/antaresdk/sus-router) only.

Paid packages (`sus-kit`, `sus-game`) are **not** included.

## Requirements

- Unity **6000.3.17f1** (or compatible Unity 6)
- Network access to GitHub (UPM git packages)

## Quick start

1. Clone this repo
2. Open the folder in Unity Hub
3. Wait for package resolve + script compile
4. Open scene `Assets/SusUI/SusApp.unity` (also set as Build Settings start scene)
5. Press **Play**

You should see the Home screen ("Welcome to SUS").

## Project layout

| Path | Role |
|------|------|
| `Assets/SusUI/MyApp.cs` | Entry: `SusApp` bootstrap |
| `Assets/SusUI/HomeScreen.sharq` | First screen (edit this) |
| `Assets/SusUI/Customization/` | Theme / fonts / icons |
| `Packages/manifest.json` | Only core `#v1.0.2` + router `#v1.0.1` from GitHub |

## Next steps

- Uncomment / extend `UseRouter` in `MyApp.cs` for multi-screen navigation (router is already a dependency)
- Edit `HomeScreen.sharq`, then regenerate via **Window → SUS → Sharq** if needed
- Docs: https://sus-ui.dev and package `Docs/` in sus-core

## License

Demo code: MIT (same as open-core packages).

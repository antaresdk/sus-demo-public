# Customization — place for SUS customization in this project

Each file here is a live, editable example of one customization axis.
They are all wired in the starter (`App.cs` next to this folder) — one
`Use*` line per axis. Edit the file → Play → see the change.

| Want to change | Edit file | How it is wired |
|---|---|---|
| Colors, sizes, radii | `Theme/Resources/branding.uss` | `.UseCustomStyles("branding")` |
| Fonts | `Fonts/AppFonts.asset` (Inspector) | `.UseFonts(_fonts)` |
| Icons | `Icons/Resources/SusRuntime/Icons/app/{weight}/*.svg` | `.UseIcons(new ResourcesFolderIconProvider("com.sharq-it.sus.core", "app"))` |
| Custom component | *(requires com.sharq-it.sus.kit)* | after installing the kit, recreate the scaffold or copy the example from sus-kit/docs/13-custom-components.md |

## How it works

- **branding.uss** loads AFTER the full token cascade (core L1–L3 + kit L4/L5)
  onto the root and OverlayHost — overrides only declared variables,
  including popups/tooltips. Layers: `docs/SUS_THEMING_LAYERS_ARCHITECTURE.md`.
- **AppFonts.asset** — assign fonts in the Inspector; applied to the root and
  overlays via `-unity-font-definition`.
- **Icons** — put `.svg` files in `Icons/Resources/SusRuntime/Icons/app/regular/`
  (or `bold/`, `fill/`, …). Usage: `new SusIcon { Name = { Value = "app-logo" } }`
  or `Icon="app-logo"` in kit components. Your icons override built-ins.
- **Custom components** — `.sharq` files anywhere under the UI root compile
  automatically. Guide: `sus-kit/docs/13-custom-components.md`.

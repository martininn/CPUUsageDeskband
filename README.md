# UsageDeskband (WIP)

A functioning deskband only tested on Windows 10, using [SharpShell](https://github.com/dwmkerr/sharpshell).
Currently only for dark mode

![CPU Deskband image](https://kompis.s-ul.eu/jOyr6bLo)

## How to use

Using the SharpShell [ServerRegistrationManager](https://github.com/dwmkerr/sharpshell/blob/main/docs/srm/srm.md):
- Build project (to generate dll)
- Install/Register using `srm`:
```srm install <dllname.dll>```
- Restart explorer to make it pop up under "toolbars"

Uninstall/Unregister:
```srm uninstall <dllname.dll>```
- Restart explorer and clean solution to make changes
- Repeat from the top

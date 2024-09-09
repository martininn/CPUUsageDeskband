# UsageDeskband (WIP)

A functioning deskband only tested on Windows 10, using [SharpShell](https://github.com/dwmkerr/sharpshell).
Currently only best for dark mode

![CPU Deskband image](https://kompis.s-ul.eu/jOyr6bLo)

## How to use

- Go to project properties -> Signing -> Check the "Sign the assembly" box and create a new .snk file

Using the SharpShell [ServerRegistrationManager](https://github.com/dwmkerr/sharpshell/blob/main/docs/srm/srm.md):
- Build project (to generate dll)
- Install/Register using `srm`:
```srm install <dllname.dll>```
- Restart explorer to make it pop up under "toolbars"

Uninstall/Unregister:
```srm uninstall <dllname.dll>```
- Restart explorer and clean solution to make changes
- Repeat from the top

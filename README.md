# How to use
### Mock Values
To mock values for local dev, copy `jam.env` to these paths:

Android - `/data/local/tmp/jam.env`

Linux - `/home/jam/jam.env`

Windows - `C:\jam\jam.env`

Or use the `SetEnvPath() / set_env_path()` function and pass in the string to the path you want to use before calling the lib.  

### Use in Unity
Unity library (bindings) are under `bindings/csharp`, include in your `Assets` folder.

Prebuilt native plugin / shared library builds for Windows (Unity Player) and Android (which are necessary to use the library/bindings) are under `prebuilt`. You can put this next to your library files.
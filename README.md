# How to use
## Mock Values
To mock values for local dev, copy `jam.env` to these paths:

Android - `/data/local/tmp/jam.env`

Linux - `/home/jam/jam.env`

Windows - `C:\jam\jam.env`

Or use the `SetEnvPath() / set_env_path()` function and pass in the string to the path you want to use before calling the lib.  

## Use in Unity
Unity library (bindings) are under `bindings/csharp`, include in your `Assets` folder.

Prebuilt native plugin / shared library builds (which are necessary to use the library/bindings) for Windows (Unity Player / Editor or Desktop builds) and Android are under `prebuilt`. Put these DLL files in your `Assets/Plugins/` folder.

### Settings for Android target
Switch platform to Android.

`File -> Build Settings`

![image](https://user-images.githubusercontent.com/16667416/191871681-e55dd10c-d57f-4fdf-9f7f-a18cb31938f3.png)

Enable IL2CPP to be able to use native plugins. 

`Edit -> Project Settings -> Other Settings`

![image](https://user-images.githubusercontent.com/16667416/191871355-a84f6d81-8382-484f-917c-17e5f5612006.png)

Disable all graphics APIs except for OpenGLES3.

`Edit -> Project Settings -> Other Settings`

![image](https://user-images.githubusercontent.com/16667416/191871257-60ac191b-d322-4651-adfe-43f7219b54f1.png)


# HelloMaui

Minimal .NET MAUI app that displays "Hello World".

This repo is intended to be edited in GitHub Codespaces and built on Codemagic (macOS runners).

What is included
- `HelloMaui.csproj` — MAUI project (Android target)
- `MauiProgram.cs`, `App.xaml`, `App.xaml.cs`, `MainPage.xaml`, `MainPage.xaml.cs` — minimal app code
- `Platforms/Android/MainActivity.cs` — Android entry point
- `codemagic.yaml` — Codemagic workflow to install .NET and MAUI workloads and build an Android APK

Codemagic notes
1. Add this repository to Codemagic and enable the `build-android` workflow (it will be visible automatically).
2. The workflow installs .NET (channel 8.0) using the official dotnet-install script and runs `dotnet workload install maui`.
3. The workflow builds and publishes an APK to `./publish` and exposes `publish/**/*.apk` as artifacts.

Triggering builds
1. Push changes to this repository (for example, push to the `main` branch).
2. In Codemagic, start a new build for the repository (or use the webhook integration to trigger on push).

Local build (if you have a mac or Codespaces image with dotnet and workloads installed)

```bash
# restore
 dotnet restore
# build for Android
 dotnet build ./HelloMaui.csproj -f net8.0-android -c Release
# publish
 dotnet publish ./HelloMaui.csproj -f net8.0-android -c Release -o ./publish
```

If you cannot install .NET MAUI locally (for example, on Linux without workloads), use Codemagic's macOS runners to build.

Troubleshooting
- If Android SDK tools are missing, Codemagic macOS images usually include them. If not, update the workflow to install Android SDK components using `sdkmanager`.
- Adjust `DOTNET_CHANNEL` in `codemagic.yaml` if you prefer a different .NET version (e.g., `7.0`).

License: MIT

# BundleLocalization

Xamarin.iOS binding library for internationalization to support on-the-fly language change.

Binding of [BundleLocalization](https://github.com/cmaftuleac/BundleLocalization) library.

## Development

### 1. Native

XCode 11.4

Build static library from sources:

```sh
cd Native & make
```

### 2. Binding

#### Sharpie

[Sharpie](https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie/get-started#installing-objective-sharpie) 3.5.22-be043142+

Download latest: http://aka.ms/objective-sharpie

Build binding library:

1. `cd Binding & sh bind.sh`
2. Fix `ApiDefinitions.cs`
3. Build release: `msbuild BundleLocalization/BundleLocalization.csproj -p:Configuration=Release`
4. Profit.

#### Related Links

- [Walkthrough: Binding an iOS Objective-C Library](https://docs.microsoft.com/en-us/xamarin/ios/platform/binding-objective-c/walkthrough?tabs=macos)

---

&copy; 2020 Yauheni Pakala | MIT

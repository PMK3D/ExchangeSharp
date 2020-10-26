# ExchangeSharp
C# language binding for HOOPS Exchange

## Description
This is a direct C# language binding for HOOPS Exchange. It should be a considered pre-alpha implementation. Expect that you may need to modify delegate declarations in order to make some functionality accessible.

ExchangeSharp is implemented in the namespace `TS3D.Exchange.Direct`. 

### What do you mean by "Direct"?
ExchangeSharp utilitizes the [P/Invoke](https://docs.microsoft.com/en-us/dotnet/standard/native-interop/pinvoke) approach for providing a cross-platform is binding for the C# language. It does this by declaring all of the data types used by the native Exchange library in a compatible C# form.

"Direct" implies that the C# syntax you will use to access Exchange will closely resemble its C counterpart.

This approach has several advantages.

1. Memory: Data is not copied. It is directly mapped using `struct` objects.
1. Speed: There is no "middle" code. When you call an Exchange function using C#, you are directly invoking the code and nothing between.
1. Familiar: The code you write will look familiar:
```csharp
A3DAsmModelFileData d;
API.Initialize( out d );
if( A3DStatus.A3D_SUCCESS == API.A3DAsmModelFileGet( model_file, ref d ) ) {
    // Use object here

    // Free the object-
    API.A3DAsmModelFileGet( IntPtr.Zero, ref d );
}
```
## Prerequisites
In order to build and use ExchangeSharp, the following software components are required:
* [HOOPS Exchange 2020 SP2](https://developer.techsoft3d.com/hoops/exchange/downloads/latest/) (or binary compatible version)
* [.NET Core](https://dotnet.microsoft.com/download/dotnet-core)
* [CMake](https://cmake.org/download/)
* C/C++ compiler for your platform

## Building
1. Be sure you have Exchange installed and licensed correctly. 
 	1. Unpack the archive.
 	1. Place hoops_license.h _and_ hoops_license.cs in the `include` folder.
	1. Building and running the sample applications contained within.
1. Clone the ExchangeSharp repository.
1. Build the ExchangeCppLayer.
	1. Set the `HOOPS_EXCHANGE_DIR` environment variable to the root folder of the Exchange installation.
	1. Change to the `ExchangeCppLayer` folder.
	1. Create a build folder, such as `build-win64`.
	1. Change to the build folder `cd build-win64`.
	1. Run `cmake ..`.
	1. Run `nmake` or `make` depending on your platform.
	1. Run `nmake install` or `make install` depending on your platform.
1. Build ExchangeSharp
	1. Change to the `ExchangeSharp` folder.
	1. Run the command `dotnet build`.
	1. `ExchangeSharp.dll` can be found in the `bin/Debug/netcoreapp3.1` folder.

## Building and Running the Examples
1. Change to `examples/DriverApp`
1. Copy `hoops_license.cs` to this folder.
1. `dotnet build`
1. `dotnet run --exchange "/path/to/exchange/bin/win64" "/path/to/exchange/samples/data/prc/helloworld.prc"`






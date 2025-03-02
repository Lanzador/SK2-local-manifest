# Lanzador's fork

Reading manifest from a file instead of downloading it.

Ignore this, it's outdated.

# SteamKit2
[![Build Status (CI/CD)](https://github.com/SteamRE/SteamKit/workflows/CI/CD/badge.svg?branch=master&event=push)](https://github.com/SteamRE/SteamKit/actions?query=workflow%3ACI%2FCD)
[![NuGet](https://img.shields.io/nuget/v/SteamKit2.svg)](https://www.nuget.org/packages/SteamKit2/)


SteamKit2 is a .NET library designed to interoperate with Valve's [Steam network](http://store.steampowered.com/about). It aims to provide a simple, yet extensible, interface to perform various actions on the network.


## Getting Binaries


### Visual Studio

Starting with version 1.2.2, SteamKit2 is distributed as a [NuGet package](http://nuget.org/packages/steamkit2).

Simply install SteamKit2 using the package manager in Visual Studio, and NuGet will add all the required dependencies and references to your project.  
  
### Other

We additionally distribute binaries on our [releases page](https://github.com/SteamRE/SteamKit/releases).

For more information on installing SteamKit2, please refer to the [Installation Guide](https://github.com/SteamRE/SteamKit/wiki/Installation) on the wiki.


## Documentation

Documentation consists primarily of XML code documentation provided with the binaries, and our [wiki](https://github.com/SteamRE/SteamKit/wiki).


## License

SteamKit2 is released under the [LGPL-2.1 license](http://www.tldrlegal.com/license/gnu-lesser-general-public-license-v2.1-%28lgpl-2.1%29).


## Dependencies

In order to use SteamKit2 at runtime, the following dependencies are required:

  - A [.NET Standard 2.0](https://github.com/dotnet/standard/blob/master/docs/versions.md)-compatible runtime. At the time of writing, this is:
      - .NET Framework 4.6.1 or higher required, .NET Framework 4.7.2 or higher recommended.
      - .NET Core 2.0 or higher
      - [Mono 5.4](http://mono-project.com) or higher
  - [protobuf-net](http://code.google.com/p/protobuf-net/) ([NuGet package](http://nuget.org/packages/protobuf-net))

Note: If you're using the SteamKit2 NuGet package, the protobuf-net dependency should be resolved for you. See the [Installation Guide](https://github.com/SteamRE/SteamKit/wiki/Installation) for more information.


To compile SteamKit2, the following is required:

  - C# 8.0 compiler &mdash; [.NET Core 3.0 SDK](https://dot.net/) or higher.
  - A C# IDE is optional but recommended:
      - [Visual Studio 2019 (≥16.3)](https://www.visualstudio.com/vs/whatsnew/) (on Windows)
      - [Visual Studio for Mac (≥8.3)](https://www.visualstudio.com/vs/visual-studio-mac/) (on macOS)
      - [Visual Studio Code](https://code.visualstudio.com) with [the C#/OmniSharp extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) (on Windows, macOS, and Linux)


## Contact

IRC: irc.libera.chat / #steamre ([join via webchat](https://web.libera.chat/#steamre))


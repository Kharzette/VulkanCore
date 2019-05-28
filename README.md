# VulkanCore

[![NuGet Pre Release](https://img.shields.io/nuget/vpre/VulkanCore.svg)](https://www.nuget.org/packages/VulkanCore)
[![Vulkan](https://img.shields.io/badge/vulkan-1.0.69-brightgreen.svg)](https://www.khronos.org/vulkan/)
[![.NET Standard](https://img.shields.io/badge/netstandard-1.3-brightgreen.svg)](https://github.com/dotnet/standard/blob/master/docs/versions.md)
[![AppVeyor Build Status](https://img.shields.io/appveyor/ci/discosultan/vulkancore.svg?label=windows)](https://ci.appveyor.com/project/discosultan/vulkancore)
[![Travis Build Status](https://img.shields.io/travis/discosultan/VulkanCore.svg?label=unix)](https://travis-ci.org/discosultan/VulkanCore)

- [Introduction](#introduction)
- [Building](#building)
- [Samples](#samples---)
- [Tests](#tests--)
- [Related Work](#related-work)

## Introduction

VulkanCore is a thin cross-platform object-oriented wrapper around the Vulkan C API. It supports .NET Core, .NET Framework and Mono.

**Why yet another set of bindings?** While most of the alternatives use a generator-based approach, these bindings do not. This means:

Pros:
- Full control over the API including high quality code documentation
- Easier to contribute - no need to understand a generator

Cons:
- Requires manual work to keep up to date with the Vulkan API registry
- Cumbersome to modify the fundamentals - impossible to simply regenerate everything

## Building

[Visual Studio 2017](https://www.visualstudio.com/vs/whatsnew/) or equivalent tooling is required to successfully compile the source. The tooling must support the *new .csproj format* and *C# 7* language features. Latest [Rider](https://www.jetbrains.com/rider/), [Visual Studio Code](https://code.visualstudio.com/) or [MonoDevelop](http://www.monodevelop.com/) should all work but have not been tested.

## Samples <img height="24" src="Assets/Windows64.png"> <img height="24" src="Assets/Android64.png"> <img height="24" src="Assets/MacOS64.png">

Vulkan-capable graphics hardware and drivers are required to run the samples. Win32 samples are based on WinForms (.NET Framework) and Android ones on Xamarin (Mono).


## Related Work

- [VulkanSharp](https://github.com/mono/VulkanSharp)
- [SharpVulkan](https://github.com/jwollen/SharpVulkan)
- [SharpVk](https://github.com/FacticiusVir/SharpVk)
- [vk](https://github.com/mellinoe/vk)

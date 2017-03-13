# is.gd.NET
API Client Library for is.gd and v.gd

[![Build status](https://ci.appveyor.com/api/projects/status/8cm8a4ex2fnmkgpb?svg=true)](https://ci.appveyor.com/project/prajjwaldimri/is-gd-net)
[![NuGet](https://img.shields.io/nuget/v/is.gd.svg?maxAge=2592000?style=flat-square)](https://www.nuget.org/packages/is.gd)
[![GitHub issues](https://img.shields.io/github/issues/prajjwaldimri/Genius.NET.svg?maxAge=2592000?style=flat-square)](https://github.com/prajjwaldimri/is.gd/issues)
[![license](https://img.shields.io/github/license/mashape/apistatus.svg?maxAge=2592000?style=flat-square)](https://github.com/prajjwaldimri/is.gd/blob/master/LICENSE)
[![Contact](https://img.shields.io/badge/contact-@prajjwaldimri-642C90.svg?style=flat-square)](https://twitter.com/prajjwaldimri)

## Installation (Using Nuget)

```Nuget
Install-Package is.gd
```

## Usage

### Shortening URL

```C#
string shortendUrl = @is.gd.Url.GetShortenedUrl("www.example.com");
```

### Looking up shortened URL

```C#
string fullUrl = @is.gd.Url.LookupShortenedUrl("https://is.gd/T5132");
```

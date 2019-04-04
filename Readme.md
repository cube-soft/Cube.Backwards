Cube.Backwards
====

[![NuGet](https://img.shields.io/nuget/v/Cube.Backwards.svg)](https://www.nuget.org/packages/Cube.Backwards/)
[![AppVeyor](https://ci.appveyor.com/api/projects/status/1h6tx4ubhcpnv144?svg=true)](https://ci.appveyor.com/project/clown/cube-backwards)
[![Azure Pipelines](https://dev.azure.com/cube-soft-jp/Cube.Backwards/_apis/build/status/cube-soft.Cube.Backwards?branchName=master)](https://dev.azure.com/cube-soft-jp/Cube.Backwards/_build)

Cube.Backwards is the Library for using the other Cube.* libraries in .NET Framework 3.5.
Note that the library is not needed in .NET Framework 4.5 or higher.

## Installation

You can install using NuGet like this:

    PM> Install-Package Cube.Backwards

Or select it from the NuGet packages UI on Visual Studio.

## Dependencies

* [AsyncBridge](http://omermor.github.io/AsyncBridge/)

## Contributing

1. Fork [Cube.Backwards](https://github.com/cube-soft/Cube.Backwards/fork) repository.
2. Create a feature branch from the master or stable branch (e.g. git checkout -b my-new-feature origin/master). Note that the master branch may refer some pre-released NuGet packages. Try the [rake clean](https://github.com/cube-soft/Cube.Backwards/blob/master/Rakefile) command when build errors occur.
3. Commit your changes.
4. Rebase your local changes against the master or stable branch.
5. Run test suite with the [NUnit](https://nunit.org/) console or the Visual Studio (NUnit 3 test adapter) and confirm that it passes.
6. Create new Pull Request.

## License

Copyright © 2010 [CubeSoft, Inc.](https://www.cube-soft.jp/)
The project is licensed under the [Apache 2.0](https://github.com/cube-soft/Cube.Backwards/blob/master/License.txt).
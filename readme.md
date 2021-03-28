<p align="center">
  <a href="" rel="noopener">
 <img width=200px height=200px src="img/pandora.png" alt="Pandora logo"></a>
</p>

<h3 align="center">Pandora</h3>

<div align="center">

  ![Azure DevOps builds (branch main)](https://img.shields.io/azure-devops/build/pulsewave/Pandora/1/main?label=main%20build%20&logo=main%20build)
  ![Azure DevOps builds (branch develop)](https://img.shields.io/azure-devops/build/pulsewave/Pandora/1/develop?label=develop%20build%20&logo=develop%20build)
  ![GitHub release (latest SemVer including pre-releases)](https://img.shields.io/github/v/release/abeauchamp96/Pandora?color=teal&sort=semver&include_prereleases)
  [![License](https://img.shields.io/badge/license-MIT-blue.svg)](./license.md)

</div>

---

<p align="center"> A box that contains tools, nugets, scripts, templates and snippets.
    <br> 
</p>

## Table of Contents

- [Table of Contents](#table-of-contents)
- [About](#about)
- [Getting Started](#getting-started)
- [Authors](#authors)
- [Acknowledgements](#acknowledgements)

## About

Aims to develop software more easily through tools, nugets, scripts, templates, code snippets, etc.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Installing

This section explain how to use snippets in visual studio. Make sure you already extract the Pandora release.

#### Snippet

On the Tools menu, select Code Snippets manager then Import (Can use the shorcut: Ctrl+k, Ctrl+b). Import all snippets from the extracted folder (it will be in snippets folder). Click Finish then close the manager.

#### Attention

Some snippets need the package installed to be used correctly.

* Moq snippets: [Moq](https://github.com/moq/moq) and [Moq.Contrib.HttpClient](https://github.com/maxkagamine/Moq.Contrib.HttpClient)
* XUnit snippets: [XUnit](https://xunit.net/)
* Blazor snippets: [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)

## Authors

* Alexandre Beauchamp &#8212; main developer (<abeauchamp@pulsewave.dev>)

## Acknowledgements

* Readme is based on this fantastic repository *[The-Documentation-Compendium]* with his templates.
* Changelog is based on https://keepachangelog.com/en/1.0.0/

[The-Documentation-Compendium]: https://github.com/kylelobo/The-Documentation-Compendium/blob/master/en/README_TEMPLATES/Standard.md

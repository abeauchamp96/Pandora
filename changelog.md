# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## Table of Contents
- [0.3.0](#030--2021-04-25)
- [0.2.0](#020--2021-04-04)
- [0.1.0](#010--2021-02-28)

## 0.3.0 &#8212; 2021-04-25

### Added

- added an uptimeRetriever which retrieve an uptime for something
- added an instanceValidator for testing (mostly use with abstractMock)
- added LiteDB data source and base repository

### Changed

- The IDataSource and BaseRepository has been move to Pandora.Utility.Data.Sql namespace

## 0.2.0 &#8212; 2021-04-04

### Added

- ifield snippet: Insert a private field for an interface
- package TestKit
	- ServiceProviderBuilder
	- Logger extensions
	- AbstractMock
- package Utility
  - IDataSource
  - BaseRepository
  - ITransaction

### Changed

- field snippet: Now insert a private field for a class
- mock snippet: Now add a new() at the end of the mock field

## 0.1.0 &#8212; 2021-02-28

### Added

- function snippets to simply insert different method type
  - func: Insert a method
  - afunc: Insert an async method
  - gfunc: Insert a generic method
  - gafunc: Insert a generic async method
  - func1: Insert a method with one parameter
  - afunc1: Insert an async method with one parameter
  - rafunc: Insert an async method which return a result
  - ifunc: Insert a method for an interface
  - aifunc: Insert an async method for an interface
  - lfunc: Insert a local function
  - alfunc: Insert an asynchronous function
- blazor snippets to insert code for a component
  - inject: Insert an injectable property
  - param: Insert a parameter property
  - cparam: Insert a cascading parameter property
  - onafter: Insert the OnAfterRender override
  - aonafter: Insert the OnAfterRenderAsync override
  - oninit: Insert the OnInitialized override
  - aoninit: Insert the OnInitializedAsync override
  - onparam: Insert the OnParametersSet override
  - aonparam: Insert the OnParametersSetAsync override
  - setparam: Insert the SetParametersAsync override
  - shouldrender: Insert the ShouldRender override
- extensions snippets to insert extension method
  - exfunc: Insert an extension method
  - aexfunc: Insert an asynchronous extension method
  - exservices: Insert a service collection extension method
- miscellaneous snippets
  - ter: Insert a ternary condition operator
  - vter: Insert a ternary condition then affect to a variable
  - rter: Insert a ternary condition then return the result
  - vswitch: Insert a switch expression then affect to a variable
  - rswitch: Insert a switch expression then return the result
  - tryp: Insert TryParse method
  - iftryp: Insert TryParse method inside an if statement
  - tertryp: Insert TryParse method with ternary condition
  - field: Insert a private readonly field for a class
  - empty: Insert an empty enumerable
- moq snippets for unit tests
  - mock: Insert a mock
  - setup: Insert a setup for a mock
  - asetup: Insert an asynchronous setup for a mock
  - gsetup: Insert a getter setup for a mock
  - reqsetup: Insert a request setup for a http mock
  - exsetup: Insert an exception setup for a mock
  - callsetup: Insert a callback setup for a mock
  - verify: Insert a verify on a mock
  - verifyexact: Insert a verify exactly on a mock
  - verifytimes: Insert a verify with a times on a mock
  - verifynever: Insert a verify was never called on a mock
  - reqverify: Insert a request verify on a mock
  - reqverifyexact: Insert a request verify exactly on a mock
  - reqverifytimes: Insert a request verify with a times on a mock
  - reqverifynever: Insert a verify was never called on a mock
- xunit snippets for unit tests
  - fact: Insert a fact method
  - afact: Insert an asynchronous fact method
  - theory: Insert a theory fact method
  - atheory: Insert an asynchronous theory fact method
  - xinline: Insert an inline data for theory
  - xmember: Insert a member data for theory
  - xclass: Insert a class data for theory
- templates
  - Added changelog template
  - Added readme template
  - Added MIT license
- packages
  - Added Utility package
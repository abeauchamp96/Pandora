# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## Table of Contents
- [0.1.0](#010--unreleased)

## 0.1.0 &#8212; Unreleased

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
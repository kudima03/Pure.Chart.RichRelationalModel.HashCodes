# Pure.Chart.RichRelationalModel.HashCodes

Deterministic hash code implementations for chart rich relational model entities in the **Pure** ecosystem.

[![.NET build & test](https://github.com/kudima03/Pure.Chart.RichRelationalModel.HashCodes/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Chart.RichRelationalModel.HashCodes/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Chart.RichRelationalModel.HashCodes/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Chart.RichRelationalModel.HashCodes/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Chart.RichRelationalModel.HashCodes)](https://www.nuget.org/packages/Pure.Chart.RichRelationalModel.HashCodes)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Chart.RichRelationalModel.HashCodes` provides deterministic, byte-enumerable hash codes for every type in the chart rich relational model. Each type wraps one of the `Pure.Chart.RichRelationalModel.Abstractions` interfaces and produces a stable byte sequence by prepending a fixed 16-byte type-discriminator prefix before hashing the object's fields. The resulting sequences compose cleanly with `Pure.HashCodes.DeterminedHash`.

## Hash Types

| Type | Wraps | Hashed fields |
|---|---|---|
| `ChartRichRelationalModelHash` | `IChartRichRelationalModel` | Id, Title, Description, TypeId, Type, XAxisId, XAxis, YAxisId, YAxis, Series |
| `ChartTypeRichRelationalModelHash` | `IChartTypeRichRelationalModel` | Id, Name |
| `ChartSeriesRichRelationalModelHash` | `IChartSeriesRichRelationalModel` | Id, ChartId, Legend, XAxisSource, YAxisSource |
| `AxisRichRelationalModelHash` | `IAxisRichRelationalModel` | Id, Legend |

All types are `sealed record` and implement `IDeterminedHash` (which extends `IEnumerable<byte>`).

## Design Principles

- **Deterministic** — identical inputs always produce identical byte sequences across processes and runtimes.
- **Type-safe** — each entity type carries a hard-coded 16-byte prefix, preventing cross-type hash collisions.
- **Composable** — each field may be supplied as a raw primitive or a pre-computed `IDeterminedHash`, enabling partial hash reuse.

## Dependencies

- [`Pure.Chart.RichRelationalModel.Abstractions`](https://github.com/kudima03/Pure.Chart.RichRelationalModel.Abstractions) — rich relational chart model interfaces
- [`Pure.HashCodes`](https://github.com/kudima03/Pure.HashCodes) — deterministic, byte-enumerable hash computation

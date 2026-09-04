# Changelog

All notable changes to Pure.Chart.RichRelationalModel.HashCodes are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.2.0.0] — 2026-04-26

### Changed

- **`AxisRichRelationalModelHash`** no longer includes `ChartId` in its hash —
  only `Id` and `Legend` are hashed now. The constructor overloads that
  accepted a `chartId`/`chartIdHash` parameter were removed, leaving four
  overloads: `(IAxisRichRelationalModel)`, `(IGuid id, IString legend)`,
  `(IDeterminedHash idHash, IString legend)`, `(IGuid id, IDeterminedHash
  legendHash)`, and `(IDeterminedHash idHash, IDeterminedHash legendHash)`.
  Tracks the `Pure.Chart.RichRelationalModel.Abstractions` 4.0.0 update.

## [0.1.0-preview.1.0.0] — 2026-04-20

### Changed

- **`SeriesRichRelationalModelHash`** renamed to
  **`ChartSeriesRichRelationalModelHash`**, tracking the `ISeries` →
  `IChartSeries` rename in `Pure.Chart.RichRelationalModel.Abstractions`
  3.0.0. Hashed fields (`Id`, `ChartId`, `Legend`, `XAxisSource`,
  `YAxisSource`) are unchanged.
- **`ChartRichRelationalModelHash`**'s `series` constructor parameter type
  changed from `IEnumerable<ISeries>` to `IEnumerable<IChartSeries>`.

## [0.1.0-preview.0.2.0] — 2026-04-14

### Added

- Additional public constructors on `ChartRichRelationalModelHash`,
  `ChartTypeRichRelationalModelHash`, `AxisRichRelationalModelHash`, and
  `SeriesRichRelationalModelHash` accepting raw primitive values (`IGuid`,
  `IString`) in any combination with pre-computed `IDeterminedHash`
  instances, alongside the existing model-based constructor — enabling
  partial hash reuse without rebuilding a full model instance.

## [0.1.0-preview.0.1.0] — 2026-04-05

### Added

- Initial release. Deterministic, byte-enumerable hash implementations
  (`IDeterminedHash`) for the chart rich relational model entities, each
  computed by hashing an entity's fields prefixed with a fixed 16-byte
  type-discriminator:
  - **`ChartRichRelationalModelHash`** — wraps `IChartRichRelationalModel`
    (Id, Title, Description, TypeId, Type, XAxisId, XAxis, YAxisId, YAxis,
    Series).
  - **`ChartTypeRichRelationalModelHash`** — wraps
    `IChartTypeRichRelationalModel` (Id, Name).
  - **`AxisRichRelationalModelHash`** — wraps `IAxisRichRelationalModel`
    (Id, ChartId, Legend).
  - **`SeriesRichRelationalModelHash`** — wraps `ISeriesRichRelationalModel`
    (Id, ChartId, Legend, XAxisSource, YAxisSource).

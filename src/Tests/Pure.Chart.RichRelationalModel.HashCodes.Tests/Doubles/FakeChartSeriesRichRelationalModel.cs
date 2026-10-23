using Pure.Chart.RichRelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.RichRelationalModel.HashCodes.Tests.Doubles;

internal sealed record FakeChartSeriesRichRelationalModel(
    IGuid Id,
    IGuid ChartId,
    IString Legend,
    IString XAxisSource,
    IString YAxisSource,
    IString LineType
) : IChartSeriesRichRelationalModel;

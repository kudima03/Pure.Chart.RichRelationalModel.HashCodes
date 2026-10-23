using System.Collections;
using Pure.Chart.RelationalModel.Abstractions;
using Pure.Chart.RichRelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.HashCodes.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.RichRelationalModel.HashCodes;

public sealed record ChartSeriesRichRelationalModelHash : IDeterminedHash
{
    private static readonly byte[] TypePrefix =
    [
        117,
        93,
        157,
        1,
        141,
        123,
        64,
        127,
        167,
        177,
        88,
        45,
        230,
        12,
        33,
        63,
    ];

    private readonly IDeterminedHash _idHash;

    private readonly IDeterminedHash _chartIdHash;

    private readonly IDeterminedHash _legendHash;

    private readonly IDeterminedHash _xAxisSourceHash;

    private readonly IDeterminedHash _yAxisSourceHash;

    private readonly IDeterminedHash _lineTypeHash;

    public ChartSeriesRichRelationalModelHash(IChartSeriesRichRelationalModel model)
        : this(
            model.Id,
            model.ChartId,
            (model as IChartSeriesRelationalModel).Legend,
            (model as IChartSeriesRelationalModel).XAxisSource,
            (model as IChartSeriesRelationalModel).YAxisSource,
            (model as IChartSeriesRelationalModel).LineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IGuid chartId,
        IString legend,
        IString xAxisSource,
        IString yAxisSource,
        IString lineType
    )
        : this(
            new DeterminedHash(id),
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid chartId,
        IString legend,
        IString xAxisSource,
        IString yAxisSource,
        IString lineType
    )
        : this(
            idHash,
            new DeterminedHash(chartId),
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash chartIdHash,
        IString legend,
        IString xAxisSource,
        IString yAxisSource,
        IString lineType
    )
        : this(
            new DeterminedHash(id),
            chartIdHash,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IGuid chartId,
        IString legend,
        IString xAxisSource,
        IDeterminedHash yAxisSourceHash,
        IString lineType
    )
        : this(
            new DeterminedHash(id),
            chartId,
            legend,
            xAxisSource,
            yAxisSourceHash,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IGuid chartId,
        IDeterminedHash legendHash,
        IString xAxisSource,
        IString yAxisSource,
        IString lineType
    )
        : this(
            new DeterminedHash(id),
            chartId,
            legendHash,
            xAxisSource,
            yAxisSource,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IGuid chartId,
        IString legend,
        IDeterminedHash xAxisSourceHash,
        IString yAxisSource,
        IString lineType
    )
        : this(
            new DeterminedHash(id),
            chartId,
            legend,
            xAxisSourceHash,
            yAxisSource,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IGuid chartId,
        IDeterminedHash legendHash,
        IString xAxisSource,
        IDeterminedHash yAxisSourceHash,
        IString lineType
    )
        : this(
            new DeterminedHash(id),
            chartId,
            legendHash,
            xAxisSource,
            yAxisSourceHash,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IGuid chartId,
        IDeterminedHash legendHash,
        IDeterminedHash xAxisSourceHash,
        IString yAxisSource,
        IString lineType
    )
        : this(
            new DeterminedHash(id),
            chartId,
            legendHash,
            xAxisSourceHash,
            yAxisSource,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash chartIdHash,
        IString legend,
        IDeterminedHash xAxisSourceHash,
        IString yAxisSource,
        IString lineType
    )
        : this(
            new DeterminedHash(id),
            chartIdHash,
            legend,
            xAxisSourceHash,
            yAxisSource,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid chartId,
        IString legend,
        IDeterminedHash xAxisSourceHash,
        IString yAxisSource,
        IString lineType
    )
        : this(
            idHash,
            new DeterminedHash(chartId),
            legend,
            xAxisSourceHash,
            yAxisSource,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IGuid chartId,
        IString legend,
        IDeterminedHash xAxisSourceHash,
        IDeterminedHash yAxisSourceHash,
        IString lineType
    )
        : this(
            new DeterminedHash(id),
            chartId,
            legend,
            xAxisSourceHash,
            yAxisSourceHash,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash chartIdHash,
        IDeterminedHash legendHash,
        IString xAxisSource,
        IString yAxisSource,
        IString lineType
    )
        : this(
            new DeterminedHash(id),
            chartIdHash,
            legendHash,
            xAxisSource,
            yAxisSource,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid chartId,
        IDeterminedHash legendHash,
        IString xAxisSource,
        IString yAxisSource,
        IString lineType
    )
        : this(
            idHash,
            new DeterminedHash(chartId),
            legendHash,
            xAxisSource,
            yAxisSource,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash chartIdHash,
        IString legend,
        IString xAxisSource,
        IString yAxisSource,
        IString lineType
    )
        : this(
            idHash,
            chartIdHash,
            new DeterminedHash(legend),
            xAxisSource,
            yAxisSource,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid chartId,
        IString legend,
        IString xAxisSource,
        IDeterminedHash yAxisSourceHash,
        IString lineType
    )
        : this(
            idHash,
            new DeterminedHash(chartId),
            legend,
            xAxisSource,
            yAxisSourceHash,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash chartIdHash,
        IString legend,
        IString xAxisSource,
        IDeterminedHash yAxisSourceHash,
        IString lineType
    )
        : this(
            new DeterminedHash(id),
            chartIdHash,
            legend,
            xAxisSource,
            yAxisSourceHash,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IGuid chartId,
        IDeterminedHash legendHash,
        IDeterminedHash xAxisSourceHash,
        IDeterminedHash yAxisSourceHash,
        IString lineType
    )
        : this(
            new DeterminedHash(id),
            chartId,
            legendHash,
            xAxisSourceHash,
            yAxisSourceHash,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash chartIdHash,
        IDeterminedHash legendHash,
        IString xAxisSource,
        IDeterminedHash yAxisSourceHash,
        IString lineType
    )
        : this(
            new DeterminedHash(id),
            chartIdHash,
            legendHash,
            xAxisSource,
            yAxisSourceHash,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid chartId,
        IDeterminedHash legendHash,
        IString xAxisSource,
        IDeterminedHash yAxisSourceHash,
        IString lineType
    )
        : this(
            idHash,
            new DeterminedHash(chartId),
            legendHash,
            xAxisSource,
            yAxisSourceHash,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid chartId,
        IDeterminedHash legendHash,
        IDeterminedHash xAxisSourceHash,
        IString yAxisSource,
        IString lineType
    )
        : this(
            idHash,
            new DeterminedHash(chartId),
            legendHash,
            xAxisSourceHash,
            yAxisSource,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash chartIdHash,
        IDeterminedHash legendHash,
        IDeterminedHash xAxisSourceHash,
        IString yAxisSource,
        IString lineType
    )
        : this(
            new DeterminedHash(id),
            chartIdHash,
            legendHash,
            xAxisSourceHash,
            yAxisSource,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid chartId,
        IString legend,
        IDeterminedHash xAxisSourceHash,
        IDeterminedHash yAxisSourceHash,
        IString lineType
    )
        : this(
            idHash,
            new DeterminedHash(chartId),
            legend,
            xAxisSourceHash,
            yAxisSourceHash,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash chartIdHash,
        IString legend,
        IDeterminedHash xAxisSourceHash,
        IString yAxisSource,
        IString lineType
    )
        : this(
            idHash,
            chartIdHash,
            new DeterminedHash(legend),
            xAxisSourceHash,
            yAxisSource,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash chartIdHash,
        IDeterminedHash legendHash,
        IString xAxisSource,
        IString yAxisSource,
        IString lineType
    )
        : this(
            idHash,
            chartIdHash,
            legendHash,
            new DeterminedHash(xAxisSource),
            yAxisSource,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash chartIdHash,
        IString legend,
        IString xAxisSource,
        IDeterminedHash yAxisSourceHash,
        IString lineType
    )
        : this(
            idHash,
            chartIdHash,
            new DeterminedHash(legend),
            xAxisSource,
            yAxisSourceHash,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash chartIdHash,
        IString legend,
        IDeterminedHash xAxisSourceHash,
        IDeterminedHash yAxisSourceHash,
        IString lineType
    )
        : this(
            new DeterminedHash(id),
            chartIdHash,
            legend,
            xAxisSourceHash,
            yAxisSourceHash,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid chartId,
        IDeterminedHash legendHash,
        IDeterminedHash xAxisSourceHash,
        IDeterminedHash yAxisSourceHash,
        IString lineType
    )
        : this(
            idHash,
            new DeterminedHash(chartId),
            legendHash,
            xAxisSourceHash,
            yAxisSourceHash,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash chartIdHash,
        IDeterminedHash legendHash,
        IDeterminedHash xAxisSourceHash,
        IString yAxisSource,
        IString lineType
    )
        : this(
            idHash,
            chartIdHash,
            legendHash,
            xAxisSourceHash,
            new DeterminedHash(yAxisSource),
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash chartIdHash,
        IDeterminedHash legendHash,
        IString xAxisSource,
        IDeterminedHash yAxisSourceHash,
        IString lineType
    )
        : this(
            idHash,
            chartIdHash,
            legendHash,
            new DeterminedHash(xAxisSource),
            yAxisSourceHash,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash chartIdHash,
        IDeterminedHash legendHash,
        IDeterminedHash xAxisSourceHash,
        IDeterminedHash yAxisSourceHash,
        IString lineType
    )
        : this(
            new DeterminedHash(id),
            chartIdHash,
            legendHash,
            xAxisSourceHash,
            yAxisSourceHash,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash chartIdHash,
        IString legend,
        IDeterminedHash xAxisSourceHash,
        IDeterminedHash yAxisSourceHash,
        IString lineType
    )
        : this(
            idHash,
            chartIdHash,
            new DeterminedHash(legend),
            xAxisSourceHash,
            yAxisSourceHash,
            lineType
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash chartIdHash,
        IDeterminedHash legendHash,
        IDeterminedHash xAxisSourceHash,
        IDeterminedHash yAxisSourceHash,
        IString lineType
    )
        : this(
            idHash,
            chartIdHash,
            legendHash,
            xAxisSourceHash,
            yAxisSourceHash,
            new DeterminedHash(lineType)
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IGuid chartId,
        IString legend,
        IString xAxisSource,
        IString yAxisSource,
        IDeterminedHash lineTypeHash
    )
        : this(
            new DeterminedHash(id),
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid chartId,
        IString legend,
        IString xAxisSource,
        IString yAxisSource,
        IDeterminedHash lineTypeHash
    )
        : this(
            idHash,
            new DeterminedHash(chartId),
            legend,
            xAxisSource,
            yAxisSource,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash chartIdHash,
        IString legend,
        IString xAxisSource,
        IString yAxisSource,
        IDeterminedHash lineTypeHash
    )
        : this(
            new DeterminedHash(id),
            chartIdHash,
            legend,
            xAxisSource,
            yAxisSource,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IGuid chartId,
        IString legend,
        IString xAxisSource,
        IDeterminedHash yAxisSourceHash,
        IDeterminedHash lineTypeHash
    )
        : this(
            new DeterminedHash(id),
            chartId,
            legend,
            xAxisSource,
            yAxisSourceHash,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IGuid chartId,
        IDeterminedHash legendHash,
        IString xAxisSource,
        IString yAxisSource,
        IDeterminedHash lineTypeHash
    )
        : this(
            new DeterminedHash(id),
            chartId,
            legendHash,
            xAxisSource,
            yAxisSource,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IGuid chartId,
        IString legend,
        IDeterminedHash xAxisSourceHash,
        IString yAxisSource,
        IDeterminedHash lineTypeHash
    )
        : this(
            new DeterminedHash(id),
            chartId,
            legend,
            xAxisSourceHash,
            yAxisSource,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IGuid chartId,
        IDeterminedHash legendHash,
        IString xAxisSource,
        IDeterminedHash yAxisSourceHash,
        IDeterminedHash lineTypeHash
    )
        : this(
            new DeterminedHash(id),
            chartId,
            legendHash,
            xAxisSource,
            yAxisSourceHash,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IGuid chartId,
        IDeterminedHash legendHash,
        IDeterminedHash xAxisSourceHash,
        IString yAxisSource,
        IDeterminedHash lineTypeHash
    )
        : this(
            new DeterminedHash(id),
            chartId,
            legendHash,
            xAxisSourceHash,
            yAxisSource,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash chartIdHash,
        IString legend,
        IDeterminedHash xAxisSourceHash,
        IString yAxisSource,
        IDeterminedHash lineTypeHash
    )
        : this(
            new DeterminedHash(id),
            chartIdHash,
            legend,
            xAxisSourceHash,
            yAxisSource,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid chartId,
        IString legend,
        IDeterminedHash xAxisSourceHash,
        IString yAxisSource,
        IDeterminedHash lineTypeHash
    )
        : this(
            idHash,
            new DeterminedHash(chartId),
            legend,
            xAxisSourceHash,
            yAxisSource,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IGuid chartId,
        IString legend,
        IDeterminedHash xAxisSourceHash,
        IDeterminedHash yAxisSourceHash,
        IDeterminedHash lineTypeHash
    )
        : this(
            new DeterminedHash(id),
            chartId,
            legend,
            xAxisSourceHash,
            yAxisSourceHash,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash chartIdHash,
        IDeterminedHash legendHash,
        IString xAxisSource,
        IString yAxisSource,
        IDeterminedHash lineTypeHash
    )
        : this(
            new DeterminedHash(id),
            chartIdHash,
            legendHash,
            xAxisSource,
            yAxisSource,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid chartId,
        IDeterminedHash legendHash,
        IString xAxisSource,
        IString yAxisSource,
        IDeterminedHash lineTypeHash
    )
        : this(
            idHash,
            new DeterminedHash(chartId),
            legendHash,
            xAxisSource,
            yAxisSource,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash chartIdHash,
        IString legend,
        IString xAxisSource,
        IString yAxisSource,
        IDeterminedHash lineTypeHash
    )
        : this(
            idHash,
            chartIdHash,
            new DeterminedHash(legend),
            xAxisSource,
            yAxisSource,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid chartId,
        IString legend,
        IString xAxisSource,
        IDeterminedHash yAxisSourceHash,
        IDeterminedHash lineTypeHash
    )
        : this(
            idHash,
            new DeterminedHash(chartId),
            legend,
            xAxisSource,
            yAxisSourceHash,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash chartIdHash,
        IString legend,
        IString xAxisSource,
        IDeterminedHash yAxisSourceHash,
        IDeterminedHash lineTypeHash
    )
        : this(
            new DeterminedHash(id),
            chartIdHash,
            legend,
            xAxisSource,
            yAxisSourceHash,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IGuid chartId,
        IDeterminedHash legendHash,
        IDeterminedHash xAxisSourceHash,
        IDeterminedHash yAxisSourceHash,
        IDeterminedHash lineTypeHash
    )
        : this(
            new DeterminedHash(id),
            chartId,
            legendHash,
            xAxisSourceHash,
            yAxisSourceHash,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash chartIdHash,
        IDeterminedHash legendHash,
        IString xAxisSource,
        IDeterminedHash yAxisSourceHash,
        IDeterminedHash lineTypeHash
    )
        : this(
            new DeterminedHash(id),
            chartIdHash,
            legendHash,
            xAxisSource,
            yAxisSourceHash,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid chartId,
        IDeterminedHash legendHash,
        IString xAxisSource,
        IDeterminedHash yAxisSourceHash,
        IDeterminedHash lineTypeHash
    )
        : this(
            idHash,
            new DeterminedHash(chartId),
            legendHash,
            xAxisSource,
            yAxisSourceHash,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid chartId,
        IDeterminedHash legendHash,
        IDeterminedHash xAxisSourceHash,
        IString yAxisSource,
        IDeterminedHash lineTypeHash
    )
        : this(
            idHash,
            new DeterminedHash(chartId),
            legendHash,
            xAxisSourceHash,
            yAxisSource,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash chartIdHash,
        IDeterminedHash legendHash,
        IDeterminedHash xAxisSourceHash,
        IString yAxisSource,
        IDeterminedHash lineTypeHash
    )
        : this(
            new DeterminedHash(id),
            chartIdHash,
            legendHash,
            xAxisSourceHash,
            yAxisSource,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid chartId,
        IString legend,
        IDeterminedHash xAxisSourceHash,
        IDeterminedHash yAxisSourceHash,
        IDeterminedHash lineTypeHash
    )
        : this(
            idHash,
            new DeterminedHash(chartId),
            legend,
            xAxisSourceHash,
            yAxisSourceHash,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash chartIdHash,
        IString legend,
        IDeterminedHash xAxisSourceHash,
        IString yAxisSource,
        IDeterminedHash lineTypeHash
    )
        : this(
            idHash,
            chartIdHash,
            new DeterminedHash(legend),
            xAxisSourceHash,
            yAxisSource,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash chartIdHash,
        IDeterminedHash legendHash,
        IString xAxisSource,
        IString yAxisSource,
        IDeterminedHash lineTypeHash
    )
        : this(
            idHash,
            chartIdHash,
            legendHash,
            new DeterminedHash(xAxisSource),
            yAxisSource,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash chartIdHash,
        IString legend,
        IString xAxisSource,
        IDeterminedHash yAxisSourceHash,
        IDeterminedHash lineTypeHash
    )
        : this(
            idHash,
            chartIdHash,
            new DeterminedHash(legend),
            xAxisSource,
            yAxisSourceHash,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash chartIdHash,
        IString legend,
        IDeterminedHash xAxisSourceHash,
        IDeterminedHash yAxisSourceHash,
        IDeterminedHash lineTypeHash
    )
        : this(
            new DeterminedHash(id),
            chartIdHash,
            legend,
            xAxisSourceHash,
            yAxisSourceHash,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IGuid chartId,
        IDeterminedHash legendHash,
        IDeterminedHash xAxisSourceHash,
        IDeterminedHash yAxisSourceHash,
        IDeterminedHash lineTypeHash
    )
        : this(
            idHash,
            new DeterminedHash(chartId),
            legendHash,
            xAxisSourceHash,
            yAxisSourceHash,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash chartIdHash,
        IDeterminedHash legendHash,
        IDeterminedHash xAxisSourceHash,
        IString yAxisSource,
        IDeterminedHash lineTypeHash
    )
        : this(
            idHash,
            chartIdHash,
            legendHash,
            xAxisSourceHash,
            new DeterminedHash(yAxisSource),
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash chartIdHash,
        IDeterminedHash legendHash,
        IString xAxisSource,
        IDeterminedHash yAxisSourceHash,
        IDeterminedHash lineTypeHash
    )
        : this(
            idHash,
            chartIdHash,
            legendHash,
            new DeterminedHash(xAxisSource),
            yAxisSourceHash,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IGuid id,
        IDeterminedHash chartIdHash,
        IDeterminedHash legendHash,
        IDeterminedHash xAxisSourceHash,
        IDeterminedHash yAxisSourceHash,
        IDeterminedHash lineTypeHash
    )
        : this(
            new DeterminedHash(id),
            chartIdHash,
            legendHash,
            xAxisSourceHash,
            yAxisSourceHash,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash chartIdHash,
        IString legend,
        IDeterminedHash xAxisSourceHash,
        IDeterminedHash yAxisSourceHash,
        IDeterminedHash lineTypeHash
    )
        : this(
            idHash,
            chartIdHash,
            new DeterminedHash(legend),
            xAxisSourceHash,
            yAxisSourceHash,
            lineTypeHash
        )
    { }

    public ChartSeriesRichRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash chartIdHash,
        IDeterminedHash legendHash,
        IDeterminedHash xAxisSourceHash,
        IDeterminedHash yAxisSourceHash,
        IDeterminedHash lineTypeHash
    )
    {
        _idHash = idHash;
        _chartIdHash = chartIdHash;
        _legendHash = legendHash;
        _xAxisSourceHash = xAxisSourceHash;
        _yAxisSourceHash = yAxisSourceHash;
        _lineTypeHash = lineTypeHash;
    }

    public IEnumerator<byte> GetEnumerator()
    {
        return new DeterminedHash(
            TypePrefix
                .Concat(_idHash)
                .Concat(_chartIdHash)
                .Concat(_legendHash)
                .Concat(_xAxisSourceHash)
                .Concat(_yAxisSourceHash)
                .Concat(_lineTypeHash)
        ).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

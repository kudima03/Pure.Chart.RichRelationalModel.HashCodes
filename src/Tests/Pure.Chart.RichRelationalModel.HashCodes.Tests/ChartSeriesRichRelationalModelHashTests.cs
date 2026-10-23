using System.Collections;
using Pure.Chart.RichRelationalModel.Abstractions;
using Pure.Chart.RichRelationalModel.HashCodes.Tests.Doubles;
using Pure.HashCodes;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;
using String = Pure.Primitives.String.String;

namespace Pure.Chart.RichRelationalModel.HashCodes.Tests;

public sealed record ChartSeriesRichRelationalModelHashTests
{
    private readonly byte[] _typePrefix =
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

    [Fact]
    public void ProduceCorrectHashFromModel()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(model);

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromValues()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                chartId,
                legend,
                xAxisSource,
                yAxisSource,
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                chartId,
                legend,
                xAxisSource,
                yAxisSource,
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                new DeterminedHash(chartId),
                legend,
                xAxisSource,
                yAxisSource,
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                new DeterminedHash(chartId),
                legend,
                xAxisSource,
                yAxisSource,
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                chartId,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                xAxisSource,
                yAxisSource,
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                chartId,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                xAxisSource,
                yAxisSource,
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                new DeterminedHash(chartId),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                xAxisSource,
                yAxisSource,
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashLegendHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                new DeterminedHash(chartId),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                xAxisSource,
                yAxisSource,
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                chartId,
                legend,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                yAxisSource,
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                chartId,
                legend,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                yAxisSource,
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                new DeterminedHash(chartId),
                legend,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                yAxisSource,
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                new DeterminedHash(chartId),
                legend,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                yAxisSource,
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                chartId,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                yAxisSource,
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                chartId,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                yAxisSource,
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                new DeterminedHash(chartId),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                yAxisSource,
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashLegendHashXAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                new DeterminedHash(chartId),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                yAxisSource,
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                chartId,
                legend,
                xAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                chartId,
                legend,
                xAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                new DeterminedHash(chartId),
                legend,
                xAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                new DeterminedHash(chartId),
                legend,
                xAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                chartId,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                xAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                chartId,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                xAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                new DeterminedHash(chartId),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                xAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashLegendHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                new DeterminedHash(chartId),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                xAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                chartId,
                legend,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                chartId,
                legend,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                new DeterminedHash(chartId),
                legend,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                new DeterminedHash(chartId),
                legend,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                chartId,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                chartId,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                new DeterminedHash(chartId),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashLegendHashXAxisSourceHashYAxisSourceHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                new DeterminedHash(chartId),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                lineType
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                chartId,
                legend,
                xAxisSource,
                yAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                chartId,
                legend,
                xAxisSource,
                yAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                new DeterminedHash(chartId),
                legend,
                xAxisSource,
                yAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                new DeterminedHash(chartId),
                legend,
                xAxisSource,
                yAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                chartId,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                xAxisSource,
                yAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                chartId,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                xAxisSource,
                yAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                new DeterminedHash(chartId),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                xAxisSource,
                yAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashLegendHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                new DeterminedHash(chartId),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                xAxisSource,
                yAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromXAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                chartId,
                legend,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                yAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashXAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                chartId,
                legend,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                yAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashXAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                new DeterminedHash(chartId),
                legend,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                yAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashXAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                new DeterminedHash(chartId),
                legend,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                yAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHashXAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                chartId,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                yAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHashXAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                chartId,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                yAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHashXAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                new DeterminedHash(chartId),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                yAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashLegendHashXAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                new DeterminedHash(chartId),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                yAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                chartId,
                legend,
                xAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                chartId,
                legend,
                xAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                new DeterminedHash(chartId),
                legend,
                xAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                new DeterminedHash(chartId),
                legend,
                xAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                chartId,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                xAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                chartId,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                xAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                new DeterminedHash(chartId),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                xAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashLegendHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                new DeterminedHash(chartId),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                xAxisSource,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromXAxisSourceHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                chartId,
                legend,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashXAxisSourceHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                chartId,
                legend,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashXAxisSourceHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                new DeterminedHash(chartId),
                legend,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashChartIdHashXAxisSourceHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                new DeterminedHash(chartId),
                legend,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLegendHashXAxisSourceHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                chartId,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLegendHashXAxisSourceHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                chartId,
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromChartIdHashLegendHashXAxisSourceHashYAxisSourceHashLineTypeHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                id,
                new DeterminedHash(chartId),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromHashes()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        IChartSeriesRichRelationalModel model = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            lineType
        );

        ChartSeriesRichRelationalModelHash expected =
            new ChartSeriesRichRelationalModelHash(model);
        ChartSeriesRichRelationalModelHash actual =
            new ChartSeriesRichRelationalModelHash(
                new DeterminedHash(id),
                new DeterminedHash(chartId),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).Legend
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).XAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).YAxisSource
                ),
                new DeterminedHash(
                    (
                        model as RelationalModel.Abstractions.IChartSeriesRelationalModel
                    ).LineType
                )
            );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        ChartSeriesRichRelationalModelHash hash = new ChartSeriesRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource),
            new DeterminedHash(lineType)
        );

        IEnumerable hashEnumerable = hash;
        using IEnumerator<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(id))
                .Concat(new DeterminedHash(chartId))
                .Concat(new DeterminedHash(legend))
                .Concat(new DeterminedHash(xAxisSource))
                .Concat(new DeterminedHash(yAxisSource))
                .Concat(new DeterminedHash(lineType))
        ).GetEnumerator();

        bool equal = true;

        foreach (object item in hashEnumerable)
        {
            _ = expectedHash.MoveNext();
            if ((byte)item != expectedHash.Current)
            {
                equal = false;
                break;
            }
        }

        Assert.True(equal);
    }

    [Fact]
    public void ProducesCorrectHash()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();
        IString lineType = new RandomString();

        ChartSeriesRichRelationalModelHash hash = new ChartSeriesRichRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(chartId),
            new DeterminedHash(legend),
            new DeterminedHash(xAxisSource),
            new DeterminedHash(yAxisSource),
            new DeterminedHash(lineType)
        );

        IEnumerable<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(id))
                .Concat(new DeterminedHash(chartId))
                .Concat(new DeterminedHash(legend))
                .Concat(new DeterminedHash(xAxisSource))
                .Concat(new DeterminedHash(yAxisSource))
                .Concat(new DeterminedHash(lineType))
        );

        Assert.Equal(expectedHash, hash);
    }

    [Fact]
    public void ProduceDifferentHashesForDifferentLineTypes()
    {
        IGuid id = new Guid();
        IGuid chartId = new Guid();
        IString legend = new RandomString();
        IString xAxisSource = new RandomString();
        IString yAxisSource = new RandomString();

        IChartSeriesRichRelationalModel solid = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            new String("solid")
        );

        IChartSeriesRichRelationalModel dashed = new FakeChartSeriesRichRelationalModel(
            id,
            chartId,
            legend,
            xAxisSource,
            yAxisSource,
            new String("dashed")
        );

        Assert.False(
            new ChartSeriesRichRelationalModelHash(solid).SequenceEqual(
                new ChartSeriesRichRelationalModelHash(dashed)
            )
        );
    }
}

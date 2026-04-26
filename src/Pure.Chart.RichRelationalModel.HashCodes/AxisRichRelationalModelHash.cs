using System.Collections;
using Pure.Chart.RelationalModel.Abstractions;
using Pure.Chart.RichRelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.HashCodes.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Chart.RichRelationalModel.HashCodes;

public sealed record AxisRichRelationalModelHash : IDeterminedHash
{
    private static readonly byte[] TypePrefix =
    [
        116,
        93,
        157,
        1,
        112,
        81,
        34,
        125,
        166,
        203,
        161,
        255,
        81,
        169,
        177,
        171,
    ];

    private readonly IDeterminedHash _idHash;

    private readonly IDeterminedHash _legendHash;

    public AxisRichRelationalModelHash(IAxisRichRelationalModel model)
        : this(model.Id, (model as IAxisRelationalModel).Legend) { }

    public AxisRichRelationalModelHash(IGuid id, IString legend)
        : this(new DeterminedHash(id), legend) { }

    public AxisRichRelationalModelHash(IDeterminedHash idHash, IString legend)
        : this(idHash, new DeterminedHash(legend)) { }

    public AxisRichRelationalModelHash(IGuid id, IDeterminedHash legendHash)
        : this(new DeterminedHash(id), legendHash) { }

    public AxisRichRelationalModelHash(IDeterminedHash idHash, IDeterminedHash legendHash)
    {
        _idHash = idHash;
        _legendHash = legendHash;
    }

    public IEnumerator<byte> GetEnumerator()
    {
        return new DeterminedHash(
            TypePrefix.Concat(_idHash).Concat(_legendHash)
        ).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class Threeuple<A, B, C> : IThreeuple<A, B, C>
{
    public Threeuple(A item1, B item2, C item3)
    {
        this.Item1 = item1;
        this.Item2 = item2;
        this.Item3 = item3;
    }

    public A Item1 { get; private set; }

    public B Item2 { get; private set; }

    public C Item3 { get; private set; }

    public override string ToString()
    {
        return $"{this.Item1} -> {this.Item2} -> {this.Item3}";
    }
}

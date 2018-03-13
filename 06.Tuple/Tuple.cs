public class Tuple<A, B> : ITuple<A, B>
{
    public Tuple(A item1, B item2)
    {
        this.Item1 = item1;
        this.Item2 = item2;
    }

    public A Item1 { get; private set; }

    public B Item2 { get; private set; }

    public override string ToString()
    {
        return $"{this.Item1} -> {this.Item2}";
    }
}

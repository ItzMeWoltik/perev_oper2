public class Weight : IComparable<Weight>, IComparer<Weight>
{
    public int Mass { get; set; }
    public ConsoleColor Color { get; set; }
    public int Size { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Weight other = (Weight)obj;
        return Mass == other.Mass && Color == other.Color && Size == other.Size;
    }

    public override int GetHashCode()
    {
        return Mass.GetHashCode() ^ Color.GetHashCode() ^ Size.GetHashCode();
    }

    public static bool operator ==(Weight w1, Weight w2)
    {
        return w1.Equals(w2);
    }

    public static bool operator !=(Weight w1, Weight w2)
    {
        return !w1.Equals(w2);
    }

    public static bool operator >(Weight w1, Weight w2)
    {
        return w1.Mass > w2.Mass;
    }

    public static bool operator <(Weight w1, Weight w2)
    {
        return w1.Mass < w2.Mass;
    }

    public static bool operator >=(Weight w1, Weight w2)
    {
        return w1.Mass >= w2.Mass;
    }

    public static bool operator <=(Weight w1, Weight w2)
    {
        return w1.Mass <= w2.Mass;
    }

    public int CompareTo(Weight other)
    {
        return Mass.CompareTo(other.Mass);
    }

    public int Compare(Weight x, Weight y)
    {
        return x.Mass.CompareTo(y.Mass);
    }
}
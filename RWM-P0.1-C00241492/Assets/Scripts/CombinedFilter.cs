public class CombinedFilter
{
    public static int[] combinedFilter(int[] xs)
    {
        return Diff.diffs(RunningTotal.RunningTotalResults(xs));
    }
}


namespace C__Practice;


// List<T> is-a IEnumerable<T>
// Dictionary<T, U> is-a IEnumerable<T>
public class CompundSequenceAbstractions
{
    public static IEnumerable<int> AddTenIfBigEnough(IEnumerable<int> numbList)
    {
        return numbList.Where(number => number > 3)
                       .Select(number => number + 10);
    }
}
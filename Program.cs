// See https://aka.ms/new-console-template for more information

List<int> a = [1,2,3,4,3,2,1];

Console.WriteLine(Result.lonelyinteger(a));

class Result
{

    /*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int lonelyinteger(List<int> a)
    {
        int result = -1;
        foreach (var uniqElement in a.Distinct())
        {
            if (a.Where(x => x == uniqElement).Count() == 1)
            {
                result = uniqElement;
            }
            
        }
        return result;
    }

}
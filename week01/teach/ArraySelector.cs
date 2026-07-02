public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var work = new int[select.Length];
        Console.WriteLine(work.Length);
        int x = 0;
        int y = 0;
        int z = 0;
        foreach (int i in select)
        {
            if (i == 1)
            {
                work[z] = (list1[x]);
                x++;
                z++;
            }
            else if (i == 2)
            {
                work[z] = (list2[y]);
                y++;
                z++;
            }
        }
        return work;
    }
}
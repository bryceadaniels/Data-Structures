namespace teach_01;

public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}

        var l3 = new[] { 'A', 'A', 'A', 'A', 'A'};
        var l4 = new[] { 'B', 'B', 'B', 'B', 'B'};
        select = new[] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2};
        var charResult = ListSelector(l3, l4, select);
        Console.WriteLine("<char[]>{" + string.Join(", ", charResult) + "}"); // <char[]>{A, B, A, B, A, B, A, B, A, B}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int[] final = new int[select.Length];
        int i = 0;
        int i1 = 0;
        int i2 = 0;
        foreach (int num in select)
        {
            if (num == 1)
            {
                final[i]=list1[i1];
                i1++;
            }
            else if (num == 2)
            {
                final[i]=list2[i2];
                i2++;
            }

            i++;
        }
        return final;
    }

    private static char[] ListSelector(char[] list1, char[] list2, int[] select)
    {
        char[] final = new char[select.Length];
        int i = 0;
        int i1 = 0;
        int i2 = 0;
        foreach (int num in select)
        {
            if (num == 1)
            {
                final[i]=list1[i1];
                i1++;
            }
            else if (num == 2)
            {
                final[i]=list2[i2];
                i2++;
            }

            i++;
        }
        return final;
    }
}
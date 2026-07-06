using System.Diagnostics.Metrics;

public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int indexList1 = 0;
        int indexList2 = 0;
        int indexSelect = 0;
        int[] resultArray = new int[select.Length];
        

        foreach (int i in select)
        {
        
            if (i == 1){
                    int newNumber = list1[indexList1];
                    resultArray[indexSelect] = newNumber;
                    indexList1++;
            } else if (i == 2){
                    int newNumber = list2[indexList2];
                    resultArray[indexSelect] = newNumber;
                    indexList2++;
            } 
        indexSelect++;
        }
        return resultArray;
    }
}
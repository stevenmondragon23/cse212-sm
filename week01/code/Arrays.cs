public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>




    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        double[] multiplesArray = new double[length]; // <--- Array to the multiples

        for(int i = 0; i < length; i++)  //<-- For loop, i will be the index position to the array
        {
          multiplesArray[i] = number * (i+1); //<--- (i+1) - that is beacuse 0 shuldn´t be in the array
        }

        return multiplesArray; // return the array
    }






    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>



    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        

        // The last 'amount' elements are the ones that need to move to the beginning,
        // so this calculates where that section starts.
        
        int startIndex = data.Count - amount; 

        List<int> extractList = data.GetRange(startIndex, amount); //Extract the last 'amount' elements that will be moved to the beginning of the list
        
        data.RemoveRange(startIndex, amount); // Remove the extracted elements from the original list to avoid having them twice.

        data.InsertRange(0, extractList); //I insert the extract list in the 0 position in the list
 
    }
}

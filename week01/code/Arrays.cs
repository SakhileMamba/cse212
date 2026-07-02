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
        /// 1. Create a new array to hold the results. It's capacity must be the length parameter
        /// 2. Create a new for loop to with length parameter number of steps
        /// 3. Inside the for loop, in each step, for each index in the results array you created, as per the value of the loop variable i, insert a value of number parameter multiplied by (i + 1)

        // Create a new array
        var results = new double[length];

        // Loop through the length of the array
        for (int i = 0; i < length; i++)
        {
            // For each index in the array result as per the value of the loop variable i, insert a value of number multiplied by (i + 1)
            results[i] = number * (i + 1);
        }
        return results;
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
        /// 1. Create a new for loop that as number of steps equal to amount parameter which is the number of elements to rotate in the loop. 
        /// 2. Inside the loop, take the last element inside the data list parameter and insert it into the first index of the list by copying it. Use list method "Insert"
        /// 3. Delete the original element at the end of the list. Use list method "RemoveAt"
        /// 4. Repeat until you have rotate amount parameter number of elements in the data list parameter


        for (int i = 0; i < amount; i++)
        {
            data.Insert(0, data[data.Count - 1]);
            data.RemoveAt(data.Count - 1);
        }
    }
}

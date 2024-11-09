using System.ComponentModel.DataAnnotations;

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

        /* 
        - To find the y multiples of a number x, we first create an array of doubles of length y. 
        - Next we iterate through a for loop y times. 
        - In each iteration of the loop: 
        - We multiply x by a factor variable which starts at 1 and increments with each iteration.
        - We store x * factor at each index of our return array with an index variable that starts at 0
        and increments by one with each iteration.
        */

        double[] doubles = new double[length];
        int index = 0;
        int factor = 1;
        for (int i = 0; i < length; i++){
            doubles[index++] = number * factor++;
        }

        return doubles;
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

        /*
        - We first find the actual number of elements to be rotated with amount % data.Count. If the amount is
        longer than the list, this reduces it to a number shorter than it. If the amount is shorter than the list,
        it is just the amount.
        - We then find the index where rotation begins. This is equal to data.Count - the above value.
        - We then create sublists, the indices from the split to the end, and the indices from the beginning to 
        the split.
        We then merge the two together and update data with this list. 
        */

        // Find the amount to be rotated: 
        int rotation = amount % data.Count;

        // If the rotation amount is zero (ie it is a multiple of data.Count) do nothing. 
        if (rotation == 0){
            return;
        }
        
        // Find the index where rotation starts:
        int rotationIndex = data.Count - rotation; 

        // Create a new list for the indices from rotationIndex to the end: 
        List<int> rotatedData = data.GetRange(rotationIndex, rotation);

        // Add the indices from 0 to rotation index in data to the above:
        rotatedData.AddRange(data.GetRange(0, rotationIndex));

        // Update Data with a new list:
        data.Clear(); data.AddRange(rotatedData);
    }
}

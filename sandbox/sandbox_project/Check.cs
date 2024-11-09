void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        /*
        - We will achieve the rotate function by taking two slices of the original list and concatenating 
        them into one list. 
        - Our rotate function moves the last x = amount indexes to the front and then continues the array as before
        - We can use slicing to get the last x = amount indexes with data.GetRange(amount, data.Count - amount)
        - We can then get the remaining indexes by data.GetRange(0, data.Count - amount)
        */

        data = Enumerable.Concat(data.GetRange(amount, data.Count - amount), data.GetRange(0, data.Count - amount)).ToList();
    }
 
 void main(){
    List<int> data = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};

    RotateListRight(data, 4);

    foreach (int i in data){
        Console.WriteLine(i);
    }
}

main();


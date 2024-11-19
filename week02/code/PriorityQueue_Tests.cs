using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enque and deque; Create a queue with the following people and priorities: 
    // God (3), School (2), Girlfriend (1)
    // Dequeue until empty
    // Expected Result: God, School, Girlfriend removed in that order; Error message for empty queue.
    // Defect(s) Found: The dequeue function was not removing the value from the _queue list. 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue(); // Assemble the queue
        priorityQueue.Enqueue("God", 3);
        priorityQueue.Enqueue("School", 2);
        priorityQueue.Enqueue("Girlfriend", 1);

        string value1 = priorityQueue.Dequeue(); // Check for proper Dequeue operation
        string expectedValue1 = "God"; // Check values for proper Queue final state
        Assert.AreEqual(value1, expectedValue1); // Check for final state
        
        string value2 = priorityQueue.Dequeue(); // Check for proper Dequeue operation
        string expectedValue2 = "School"; // Check values for proper Queue final state
        Assert.AreEqual(value2, expectedValue2); // Check for final state
        
        string value3 = priorityQueue.Dequeue(); // Check for proper Dequeue operation
        string expectedValue3 = "Girlfriend"; // Check values for proper Queue final state
        Assert.AreEqual(value3, expectedValue3); // Check for final state

        try{
            string failPlease = priorityQueue.Dequeue();
        }
        catch (InvalidOperationException e) {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        
    }

    [TestMethod]
    // Scenario: Create a list with two items of equal priority and remove the first in line.
    // Queue = Cheese (1), Girlfriend (2), Sandwiches (2)
    // Expected Result: Girlfriend
    // Defect(s) Found: None. It seems that the code will return the fartherst forward equal priorty item.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue(); // Assemble queue
        priorityQueue.Enqueue("Cheese", 1);
        priorityQueue.Enqueue("Girlfriend", 2);
        priorityQueue.Enqueue("Sandwiches", 2);

        string value = priorityQueue.Dequeue();
        string expectedValue = "Girlfriend";

        Assert.AreEqual(value, expectedValue);
    }

}
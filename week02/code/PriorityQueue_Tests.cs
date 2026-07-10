using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add 4 priority items to a queue to a priority queue using enqueue, the dequeue them to ensure they are removed in order of priority.
    // Expected Result: ["item1", "item3", "item2", "item4"];
    // Defect(s) Found: The dequeue function simply returns the item of highest priority but does not remove it from the priority queue. The first item in the priority queue is skipped from dequeueing. Items aren't return in the correct order when they have the same priority
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("item1", 25);
        priorityQueue.Enqueue("item2", 9);
        priorityQueue.Enqueue("item3", 15);
        priorityQueue.Enqueue("item4", 1);
        priorityQueue.Enqueue("item5", 9);

        string[] expected = ["item1", "item3", "item2", "item5", "item4"];


        for (int i = 0; i < expected.Length; i++)
        {

            string dequeuedValue = priorityQueue.Dequeue();

            Assert.AreEqual(expected[i], dequeuedValue);
        }

    }

    [TestMethod]
    // Scenario: Empty queue
    // Expected Result: The queue is empty
    // Defect(s) Found: none
    public void TestPriorityQueue_2()
    {
        //var priorityQueue = new PriorityQueue();
        //Assert.AreEqual<InvalidOperationException>(priorityQueue.Dequeue(), new InvalidOperationException("The queue is empty"));

        try
        {
            var priorityQueue = new PriorityQueue();
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty", e.Message);
        }

        // Add more test cases as needed below.
    }
}
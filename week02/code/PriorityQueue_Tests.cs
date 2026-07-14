using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
// Scenario: Enqueue three elements with different priorities and remove the highest priority element.
// Expected Result: The element with the highest priority ("k") should be returned first.
// Defect(s) Found: None.

public void TestPriorityQueue_1()
{
    var priorityQueue = new PriorityQueue();

    priorityQueue.Enqueue("h", 12);
    priorityQueue.Enqueue("j", 11);
    priorityQueue.Enqueue("k", 15);

    var result1 = priorityQueue.Dequeue();
    var result2 = priorityQueue.Dequeue();
    var result3 = priorityQueue.Dequeue();

    Assert.AreEqual("k", result1);
    Assert.AreEqual("h", result2);
    Assert.AreEqual("j", result3);
}

    [TestMethod]
    // Scenario: Enqueue two elements with the same priority.
    // Expected Result: Dequeue should return the first element added to the queue "A".
    // Defect(s) Found: None.
public void TestPriorityQueue_2()
{
    var priorityQueue = new PriorityQueue();

    priorityQueue.Enqueue("A", 5);
    priorityQueue.Enqueue("B", 5);

    var result = priorityQueue.Dequeue();

    Assert.AreEqual("A", result);
}
}
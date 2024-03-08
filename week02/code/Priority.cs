using System.Collections.Generic;

public static class Priority {
    public static void Test() {
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test 1
        Console.WriteLine("Test 1");
        // Scenario: Enqueue three items with different priorities
        // Expected Result: The items should be added to the queue in the correct order
        priorityQueue.Enqueue("John", 3);
        priorityQueue.Enqueue("Jonathan", 1);
        priorityQueue.Enqueue("Joel", 2);
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: None
        Console.WriteLine("---------");

        // Test 2
        Console.WriteLine("Test 2");
        // Scenario: Dequeue an item from the queue
        // Expected Result: The item with the highest priority should be dequeued
        var dequeuedItem = priorityQueue.Dequeue();
        Console.WriteLine($"Dequeued Item: {dequeuedItem}");
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: None
        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}

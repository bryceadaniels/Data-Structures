namespace prove_04;

/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Add apple (priority 1), Lemon (50), orange (20) , peach (10), watermelon (50)  
        // Expected Result: lemon, Watermelon, Orange, Peach, Apple
        Console.WriteLine("Test 1");
        var items = new PriorityQueue();
        items.Enqueue("apple",1);
        items.Enqueue("Lemon",50);
        items.Enqueue("Orange",20);
        items.Enqueue("Peach", 10);
        items.Enqueue("Watermelon", 50);
        Console.WriteLine(items.Dequeue());
        Console.WriteLine(items.Dequeue());
        Console.WriteLine(items.Dequeue());
        Console.WriteLine(items.Dequeue());


        // Defect(s) Found: In Dequeue, The for loop went from 1 to less than count -1. 
        // Fixed by setting beginning to 0 and making it less than or equal to
        
        // Also never removes from queue. Added _queue.RemoveAt([highPriorityIndex])
        // Also changed the check for highest priority is set for only > now so if 2 have same, first one goes in
        
        Console.WriteLine("---------");

        // Test 2
        // Scenario: Empty queue
        // Expected Result:  Should return an error message
        Console.WriteLine("Test 2");
        var queue = new PriorityQueue();
        queue.Dequeue();
        
        // Defect(s) Found: Displays error message
        
        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}
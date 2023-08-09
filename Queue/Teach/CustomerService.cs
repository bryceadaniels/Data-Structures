namespace teach_04;
/*
 * CSE212 
 * (c) BYU-Idaho
 * 04-Teach - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */

/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: input a,b,c their ids 1,2,3 and problems !,@,# respectively
        // Expected Result: a (1) : ! , b (2) : @, c (3) : #
        Console.WriteLine("Test 1");
        var cs = new CustomerService(3);
        cs.AddNewCustomer();
        cs.AddNewCustomer();
        cs.AddNewCustomer();
        cs.ServeCustomer();
        cs.ServeCustomer();
        cs.ServeCustomer();
        // Defect(s) Found: The Dequeue had the first 2 lines out of order. Swapped them

        Console.WriteLine("=================");

        // Test 2
        // Scenario: Have max 1 and try to put 2 in
        // Expected Result:  Unable to add
        Console.WriteLine("Test 2");
        var customerService = new CustomerService(1);
        
        customerService.AddNewCustomer();
        customerService.AddNewCustomer();
        // Defect(s) Found: When checking the size, it had > but should have had >=

        Console.WriteLine("=================");

        // Add more Test Cases As Needed Below
        Console.WriteLine("=================");

        // Test 3
        // Scenario: Tries to serve when queue is empty
        // Expected Result:  Error message 
        Console.WriteLine("Test 3");
        var cust = new CustomerService(1);
        cust.ServeCustomer();
        // Defect Found: Added if statement to check if it is empty in ServeCustomer
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count >= _maxSize) {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer() {
        if (_queue.Count == 0)
        {
            Console.WriteLine("There queue is empty");
            return;
        }
        var customer = _queue[0];
        _queue.RemoveAt(0);
        Console.WriteLine(customer);
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + String.Join(", ", _queue) + "]";
    }
}
namespace final_project_bryceadaniels.Tree_Solution;

using System.Collections;

public class BinarySearchTree : IEnumerable<int> {
    private Node? _root;

    /// <summary>
    /// Insert a new node at the front (i.e. the head) of the linked list.
    /// </summary>
    public void Insert(int value) {
        // Create new node
        Node newNode = new Node(value);
        // If the list is empty, then point both head and tail to the new node.
        if (_root is null)
            _root = newNode;
        // If the list is not empty, then only head will be affected.
        else
            _root.Insert(value);
    }

    // Check to see if the tree contains a certain value
    public bool Contains(int value) {
        return _root != null && _root.Contains(value);
    }

    //Yields all values in the tree
    IEnumerator IEnumerable.GetEnumerator() {
        // call the generic version of the method
        return GetEnumerator();
    }

    // Iterate forward through the BST
    public IEnumerator<int> GetEnumerator() {
        var numbers = new List<int>();
        TraverseForward(_root, numbers);
        foreach (var number in numbers) {
            yield return number;
        }
    }

    private void TraverseForward(Node? node, List<int> values) {
        if (node is not null) {
            TraverseForward(node.Left, values);
            values.Add(node.Data);
            TraverseForward(node.Right, values);
        }
    }

    //Iterate backward through the Linked List
    public IEnumerable Reverse() {
        var numbers = new List<int>();
        TraverseBackward(_root, numbers);
        foreach (var number in numbers) {
            yield return number;
        }
    }

    private void TraverseBackward(Node? node, List<int> values) {
        if (node is not null) {
            TraverseBackward(node.Right, values);
            values.Add(node.Data);
            TraverseBackward(node.Left, values);
        }
    }

    // Get the height of the tree
    public int GetHeight() {
        if (_root is null)
            return 0;
        return _root.GetHeight();
    }

    public override string ToString() {
        return "<Bst>{" + string.Join(", ", this) + "}";
    }
}
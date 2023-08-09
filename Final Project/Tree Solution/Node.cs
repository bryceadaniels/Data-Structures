namespace final_project_bryceadaniels.Tree_Solution;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        if (Data == value)
            return true;
        if (Left is null)
            return false;
        if (Right is null)
            return false;
        if (Left.Contains(value))
            return true;
        if (Right.Contains(value))
            return true;

        return false;
    }

    public int GetHeight()
    {
        if (Left is null && Right is null)
            return 1;
        else if (Right is null && Left is not null)
            return Left.GetHeight() + 1;
        else if (Left is null && Right is not null)
            return Right.GetHeight() + 1;
        int leftHeight = Left.GetHeight();
        int rightHeight = Right.GetHeight();
        if (leftHeight > rightHeight)
            return leftHeight + 1;
        return rightHeight + 1;


    }
}
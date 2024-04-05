public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < this.Data) {
            // Insert to the left
            if (Left == null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > this.Data){
            // Insert to the right
            if (Right == null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        if (value == this.Data)
        {
            return true;
        }
        else if (value < this.Data && this.Left != null)
        {
            return this.Left.Contains(value);
        }
        else if (value > this.Data && this.Right != null)
        {
            return this.Right.Contains(value);
        }
        else
        {
        // TODO Start Problem 2
        return false;
        }
    }

    public int GetHeight() {
        if (this == null)
            return 0;
            int leftHeight = this.Left?.GetHeight()?? 0;
            int rightHeight = this.Right?.GetHeight()?? 0;

            return 1 + Math.Max(leftHeight, rightHeight);
        // TODO Start Problem 4
         // Replace this line with the correct return statement(s)
    }
}
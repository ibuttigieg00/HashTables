class Node{
    public int Value;
    public Node? nextValue;
    public Node? prevValue;


    public Node(int value) 
    {
        this.Value = value;
        this.prevValue = null;
        this.nextValue = null;
    }
}
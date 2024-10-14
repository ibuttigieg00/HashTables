class Node{
    public string Key { get; set; }
    public int Value { get; set; }    
    public Node? nextValue;
    public Node? prevValue;

    public Node(string Key, int Value) 
    {
        this.Key = Key;
        this.Value = Value;
        this.prevValue = null;
        this.nextValue = null;
    }
}
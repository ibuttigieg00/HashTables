class DoublyLinkedList{
    Node? head;
    Node? tail;

    public DoublyLinkedList(){
        head = null;
        tail = null;
    }

    public void InsertAtHead(string key, int value){
        Node newNode = new Node(key, value);

        if (head == null){
            // then linked list is empty
            head = newNode;
            tail = newNode;
        }
        else {
            newNode.nextValue = head;
            head.prevValue = newNode;
            head = newNode;
        }
    }

    public void InsertAtTail(string key, int value)
    {
        Node newNode = new Node(key, value);

        if(tail == null)
        {
            // then linked list is empty
            head = newNode;
            tail = newNode;
        }
        else {
            newNode.prevValue = tail;
            tail.nextValue = newNode;
            tail = newNode;
        }
    }

    public bool Delete(string key)
    {
        Node? current = head;

        while (current != null)
        {
            if(current.Key == key)
            {
                if(current == head)
                {
                    head = current.nextValue;
                    
                    if(head != null)
                    {
                        head.prevValue = null;
                    }
                    else
                    {
                        tail = null;
                    }
                }
                else if(current == tail)
                {
                    tail = current.prevValue;

                    if(tail != null)
                    {
                        tail.nextValue = null;
                    }
                    else
                    {
                        head = null;
                    }
                }
                else
                {
                    current.prevValue.nextValue = current.nextValue;
                    current.nextValue.prevValue = current.prevValue;
                }
                return true;
            }

            current = current.nextValue;
        }
        return false;  // Key not found in the list
    }

    // Utility function to print the list from head to tail
    public void PrintForward() {
        Node? current = head;
        while (current != null) {
            Console.Write(current.Value + " ");
            current = current.nextValue;
        }
        Console.WriteLine();
    }

    public void PrintBackwards(){
        Node? current = tail;
        while (current != null) {
            Console.Write(current.Value + " ");
            current = current.prevValue;
        }
        Console.WriteLine();
    }

}
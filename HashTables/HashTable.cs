using HashTables;

class HashTable{
    private int Size;
    private DoublyLinkedList [] Table;

    public HashTable(int Size){
        // check if size is a prime number. 
        //if not, get the next available prime number.
        bool bIsPrimeNo = PrimeNumberChecker.IsPrime(Size);

        if(bIsPrimeNo)
        {
            this.Size = Size;
        }
        else{
            this.Size = PrimeNumberChecker.GetNextPrime(Size);
        }
        
        Table = new DoublyLinkedList[Size];

        for (int i = 0; i < Size; i++){
            Table[i] = new DoublyLinkedList();
        }
    }
 
    public void Insert(string key, int value)
    {
        int index = HashFunctions.HashByDivision(key, Size);
        Table[index].InsertAtHead(key, value);
    }

    public void Delete(string key)
    {
        int index = HashFunctions.HashByDivision(key, Size);
        bool result = Table[index].Delete(key);
    }
}
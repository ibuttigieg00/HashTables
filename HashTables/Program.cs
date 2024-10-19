class Program{
    public static void Main(string[] args){
        // Create a hash table with 10 buckets
        HashTable hashTable = new HashTable(10);

        // Insert key-value pairs
        hashTable.Insert("apple", 10);
        hashTable.Insert("cucumber", 15);
        hashTable.Insert("banana", 20);
        hashTable.Insert("orange", 30);

        // Delete
        hashTable.Delete("cucumber");
    }
}
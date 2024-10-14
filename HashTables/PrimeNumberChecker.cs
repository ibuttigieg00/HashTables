/*
    This class is very useful in hashtables because
    the size of the hashtables matters alot. Why? 
    Because it is very important to have a number 
    which is a prime number. A rule of thumb is that
    numbers should not be a power of 2.
*/
static class PrimeNumberChecker{
    // Helper function to check if a number is prime
    public static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num == 2 || num == 3) return true;
        if (num % 2 == 0 || num % 3 == 0) return false;

        for (int i = 5; i * i <= num; i += 6)
        {
            if (num % i == 0 || num % (i + 2) == 0) return false;
        }
        return true;
    }

    // Function to get the next prime number greater 
    //than or equal to a given number
    public static int GetNextPrime(int num)
    {
        while (!IsPrime(num))
        {
            num++;
        }
        return num;
    }

}
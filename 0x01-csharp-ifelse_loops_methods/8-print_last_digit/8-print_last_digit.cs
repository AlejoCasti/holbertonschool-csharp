using System;

class Number {
    public static int PrintLastDigit(int number) {
        int lastNumber = number % 10 >= 0 ? number % 10 : (number * -1) % 10 ;
        Console.Write("{0}", lastNumber);
        return lastNumber;
    }
}

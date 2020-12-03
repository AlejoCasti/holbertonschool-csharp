using System;

class Array {
    public static int[] CreatePrint(int size) {
        if (size < 0) {
            Console.Write("Size cannot be negative");
            return null;
        }
        int[] newArray = new int[size];
        if (size == 0) {
            Console.Write("\n");
            return newArray;
        }
        int i;
        for (i = 0; i < newArray.Length - 1; i++) {
            newArray[i] = i;
            Console.Write("{0} ", i);
        }
        newArray[i] = i;
        Console.Write("{0}\n", i);
        return newArray;
    }
}

using System;
using System.Collections.Generic;

class List {
    public static List<int> CreatePrint(int size) {
        if (size < 0) {
            Console.Write("Size cannot be negative");
            return null;
        }
        List<int> newList = new List<int>();
        if (size == 0) {
            Console.Write("\n");
            return newList;
        }
        int i;
        for (i = 0; i < size - 1; i++) {
            newList.Add(i);
            Console.Write("{0} ", i);
        }
        newList.Add(i);
        Console.Write("{0}\n", i);
        return newList;
    }
}

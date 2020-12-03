using System;

class Array {
    public static int elementAt(int[] array, int index) {
        if (array.Length < index) {
            Console.Write("Index out of range");
            return -1;
        }
        return array[index];
    }
}

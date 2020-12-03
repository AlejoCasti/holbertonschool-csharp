using System;

class Array {
    public static int[] ReplaceElement(int[] array, int index, int n) {
        if (array.Length < index) {
            Console.Write("Index out of range");
            return array;
        }
        array[index] = n;
        return array;
    }
}

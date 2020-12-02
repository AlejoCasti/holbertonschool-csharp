using System;

class Line {
    public static void PrintLine(int length) {
        if (length <= 0) {
            Console.Write("\n");
            return;
        }
        for (int i = 0; i < length - 1; i++) {
            Console.Write("_");
        }
        Console.Write("_\n");
    }
}

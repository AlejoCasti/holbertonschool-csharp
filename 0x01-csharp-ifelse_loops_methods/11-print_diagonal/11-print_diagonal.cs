﻿using System;

class Line {
    public static void PrintDiagonal(int length) {
        if (length <= 0) {
            Console.Write("\n");
            return;
        }

        for (int i = 0; i < length; i++) {
            for (int j = 0; j < i; j++) {
                Console.Write(" ");
            }
            Console.Write("\\\n");
        }
        Console.Write("\n");
    }
}

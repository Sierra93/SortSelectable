using System;

namespace SortSelectable {
    class Program {
        static void Main() {
            int min, temp;
            int[] arr = { 10, 2, 6, 4, 89, 11, 12 };
            for (int i = 0; i < arr.Length; i++) {
                min = i;
                for (int j = i + 1; j < arr.Length; j++) {
                    if (arr[j] < arr[min]) {
                        min = j;
                    }
                }
                temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}

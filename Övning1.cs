using System;
using System.Collections.Generic;

namespace Övning1
{
    class Övning1 {

        //O(N * N) = O(N^2)
        public static bool ContainsDuplicates(int[] arr) 
        {
            for(int i = 0;i < arr.Length;i++) //O(N)
            {
                for(int j = 0; j < arr.Length; j++) { //O(N)
                    if(i != j) {
                        if(arr[i] == arr[j]) 
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        //O(N * N) = O(N^2)
        //N + (N -1) + (N - 2) + (N - 3)... + 1 = N * (N - 1) / 2 = (N^2 - N) / 2 
        public static bool ContainsDuplicates2(int[] arr)
        {
            for(int i = 0;i < arr.Length; i++) //O(N)
            { 
                for(int j = i + 1; j < arr.Length; j++) //O(N - i)
                {
                    if(arr[i] == arr[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static void PaintBoards(string[] boards)
        {
            for(int i = 0; i < boards.Length; i++) 
            {
                paintBoard(boards[i]);
            }
        }
        public static void PaintBoards2(int board1, int board2)
        {
            DateTime startTime = DateTime.Now;
            //Algoritmen
            DateTime stopTime = DateTime.Now;
            TimeSpan elapsed = stopTime - startTime;
            if(board1 == board2) {
                paintBoard(board1);
            }
            else {
                int middleBoard = (board1 + board2) / 2;
                PaintBoards2(board1, middleBoard);
                PaintBoards2(middleBoard + 1, board2);
            }
        }


        private static void paintBoard(int board) {

        }
        private static void paintBoard(string board)
        {

        }
    }
}
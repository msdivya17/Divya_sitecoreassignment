using System;

namespace sitecore{
    public class Ques3{
        class Program {
            static void Main(string[] args) {
                // Define the minefield
                bool[,] minefield = {
                    { true, false, false },
                    { false, false, true },
                    { false, false, true },
                    { false, false, true },
                    { false, true, false }
                };

                // Start at any safe square in the first row
                int currentRow = 0;
                int currentCol = 0;
                MarkDangerousSquares(minefield, currentRow, currentCol);

                // Loop through each row until the last row is reached
                while (currentRow < minefield.GetLength(0) - 1) {
                    // Move to an adjacent safe square in the next row
                    currentRow++;
                    currentCol = FindSafeSquareInRow(minefield, currentRow, currentCol);
                    MarkSafeSquares(minefield, currentRow, currentCol);

                    // Move Ally to the square that Totoshka just left
                    Console.WriteLine($"Totoshka moved to ({currentRow}, {currentCol}).");
                    MoveAlly(currentRow - 1, currentCol);
                }

                // Totoshka and Ally can move freely in the last row
                Console.WriteLine("Totoshka and Ally can move freely in the last row.");
            }

            // Mark all squares adjacent to the current square as dangerous
            static void MarkDangerousSquares(bool[,] minefield, int row, int col) {
                for (int i = row - 1; i <= row + 1; i++) {
                    for (int j = col - 1; j <= col + 1; j++) {
                        if (i >= 0 && i < minefield.GetLength(0) && j >= 0 && j < minefield.GetLength(1) && minefield[i, j]) {
                            Console.WriteLine($"Marking ({i}, {j}) as dangerous.");
                            minefield[i, j] = false;
                        }
                    }
                }
            }

            // Find any safe square in the specified row that is adjacent to the current square
            static int FindSafeSquareInRow(bool[,] minefield, int row, int col) {
                for (int j = col - 1; j <= col + 1; j++) {
                    if (j >= 0 && j < minefield.GetLength(1) && minefield[row, j]) {
                        return j;
                    }
                }
                throw new Exception($"No safe square found in row {row}.");
            }

            // Mark all squares adjacent to the current square as safe
            static void MarkSafeSquares(bool[,] minefield, int row, int col) {
                for (int i = row - 1; i <= row + 1; i++) {
                    for (int j = col - 1; j <= col + 1; j++) {
                        if (i >= 0 && i < minefield.GetLength(0) && j >= 0 && j < minefield.GetLength(1)) {
                            Console.WriteLine($"Marking ({i}, {j}) as safe.");
                            minefield[i, j] = false;
                        }
                    }
                }
            }

            // Move Ally to the specified square
            static void MoveAlly(int row, int col) {
                Console.WriteLine($"Ally moved to ({row}, {col}).");
            }
        }

    }
}
    
QUESTION 3. 

i)  algorithm that Totoshka can use to pass through the minefield:

    1. Start at any safe square in the first row of the minefield.
    2. Move to an adjacent safe square in the next row.
    3. If there are adjacent squares with bombs, mark them as dangerous.
    4. If there are no adjacent squares with bombs, mark all adjacent squares as safe.
    5. Repeat steps 2-4 until you reach the last row of the minefield.

ii) algorithm that Totoshka and Ally can use to pass through the minefield together while avoiding bombs and without
    occupying the same field:

    1. Start at any safe square in the first row of the minefield. Totoshka should start on this square, and Ally
       should stay in the starting position.
    2. Totoshka moves to an adjacent safe square in the next row. Ally moves to the square that Totoshka just left.
    3. If there are adjacent squares with bombs, Totoshka marks them as dangerous. Ally should stay on the same
       square and wait for Totoshka to finish marking.
    4. If there are no adjacent squares with bombs, Totoshka marks all adjacent squares as safe. Ally should move to
       any of these safe squares.
    5. Repeat steps 2-4 until you reach the last row of the minefield.
    6. When Totoshka and Ally reach the last row, they can move to any safe square without following the algorithm.



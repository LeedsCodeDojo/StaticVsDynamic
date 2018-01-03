# Scoring the Solutions

### Process

* Swap with a pair in the other group
* Give a mark for each successful test case passed
* Deduct a mark for each case of a broken rule
    * Any uncertainly, ask a Judge
* Scores will be aggregated

### Test Cases

1. Simple balls

    [1,2] -> 3

2. Lots of simple balls

    [0,0] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [3,2] -> 21

3. Spare

    [5,5] [6,2] -> 24
    
4. Gutter Spare

    [5,5] [0,1] -> 11

5. Lots of Spares

    [5,5] [5,5] [5,5] [5,5] [5,1] -> 66

6. Strike

    [10,-] [6,3] -> 28

7. Gutter Strike

    [10,-] [0, 0] [1, 1] -> 12

8. Lots of Strikes

    [10,-] [10,-] [10,-] [10,-] [1, 1] -> 95

9. Spare at end of game

    [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [8,2] 5 ->  33
    
10. Strike at end of game

    [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [10,-] 8 1 ->  37

11. Super-Strike at end of game

    [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [1,1] [10,-] 10 10 ->  48
 
12. Perfect game

    [10,-] [10,-] [10,-] [10,-] [10,-] [10,-] [10,-] [10,-] [10,-] [10,-] 10 10 -> 300

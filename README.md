# Unexpected Results with Mutable Variables in Recursive F# Function

This repository demonstrates a common error in F# when using mutable variables within recursive functions.  The `loop` function, designed to calculate a sum, produces incorrect results because of how the mutable variables are updated within the recursive calls. The solution shows a corrected approach using immutability.

## How to reproduce

1.  Clone this repository.
2.  Open `bug.fs` in an F# editor or IDE.
3.  Compile and run the code. Observe the unexpected output.
4.  Open `bugSolution.fs` to see the corrected implementation.

## Bug and Solution

The problem lies in the way the `loop` function in `bug.fs` utilizes mutable variables (`x` and `y`).  Each recursive call modifies the same mutable variables in memory, rather than creating new copies. This leads to accumulation of values in an undesired manner.  The solution in `bugSolution.fs` addresses this by removing mutability and utilizing immutable variables and a helper function to achieve the desired result.
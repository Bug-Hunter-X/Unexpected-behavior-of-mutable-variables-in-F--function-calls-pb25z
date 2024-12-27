# F# Mutable Variable Bug

This repository demonstrates an uncommon bug related to the unexpected behavior of mutable variables in F# when used within function calls. The bug arises from the fact that the values passed to the function are copied, not referenced.  Therefore, subsequent changes to the mutable variables outside the function do not affect the function's calculation. 

## How to Reproduce

1. Clone this repository.
2. Open `bug.fs` in a F# editor.
3. Run the code.
4. Observe that `z` remains unchanged even after modifying `x` and `y`.

## Solution

The solution demonstrates the correct way to handle mutable variables to achieve the expected outcome. In this case, either passing the mutable variables by reference (not possible in a direct way in F#) or using a different pattern are required to have the correct behavior.  A better approach is to generally avoid mutable variables and use immutable data structures instead.
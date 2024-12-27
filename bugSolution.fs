let x = ref 10
let y = ref 20

let add x y = !x + !y

let z = add x y

printfn "%d" z

 x := 30
y := 40

printfn "%d" (add x y) // z will now be 70
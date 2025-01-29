let mutable x = 10
let mutable y = 20

let swap (x, y) =
    (y, x)

let (x, y) = swap (x, y)
printfn "%d %d" x y
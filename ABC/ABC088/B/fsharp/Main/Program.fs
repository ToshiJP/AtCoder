let n = stdin.ReadLine() |> int
let ary = stdin.ReadLine().Split() |> Array.map int

let sortedAry = Array.sort ary |> Array.rev

let mutable result = 0
let mutable isAliceTurn = true
for ai in sortedAry do
    if isAliceTurn then
        result <- result + ai
    else
        result <- result - ai
    isAliceTurn <- not isAliceTurn

printfn "%d" result

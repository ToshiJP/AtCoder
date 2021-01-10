let n = stdin.ReadLine() |> int
let a = stdin.ReadLine().Split() |> Array.map int

let count num =
    let rec f i acc = if i % 2 = 1 then acc else f (i / 2) (acc + 1)
    f num 0

Array.map count a
|> Array.min
|> printfn "%d"

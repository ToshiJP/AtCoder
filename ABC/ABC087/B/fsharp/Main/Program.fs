let a = stdin.ReadLine() |> int
let b = stdin.ReadLine() |> int
let c = stdin.ReadLine() |> int
let x = stdin.ReadLine() |> int

let mutable cnt = 0
for i in seq {0..a} do
    for j in seq {0..b} do
        let y = x - 500 * i - 100 * j
        if y % 50 = 0 && y >= 0 && y <= 50 * c then
            cnt <- cnt + 1

printfn "%d" cnt

let [|n; y|] = stdin.ReadLine().Split() |> Array.map int

let mutable result = (-1, -1, -1)
for i in seq {0..n} do
    for j in seq {0..n-i} do
        let k = y / 1000 - 10 * i - 5 * j
        if i + j + k = n then
            result <- (i, j, k)

match result with
| (a, b, c) -> printfn "%d %d %d" a b c

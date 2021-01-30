let n = stdin.ReadLine() |> int
let a = stdin.ReadLine().Split(' ') |> Array.map int

let dp = Array2D.create n n 1000000000
let mutable ans = 0
for i = 0 to n - 1 do
    dp.[i, i] <- a.[i]
    for j = i + 1 to n - 1 do
        dp.[i, j] <- min dp.[i, j - 1] a.[j]

    for j = i to n - 1 do
        ans <- max ans (dp.[i, j] * (j - i + 1))

printfn "%d" ans

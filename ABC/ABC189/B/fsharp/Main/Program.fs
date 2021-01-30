let [|n; x|] = stdin.ReadLine().Split(' ') |> Array.map int
let ary = Array.create n 0
for i = 0 to n - 1 do
    let vp = stdin.ReadLine().Split(' ') |> Array.map int
    ary.[i] <- vp.[0] * vp.[1]

let mutable ans = -1
let mutable sum = 0
let mutable i = 0
while i < n && ans = -1 do
    sum <- sum + ary.[i]
    if sum > x * 100 then ans <- i + 1
    i <- i + 1

printfn "%d" ans

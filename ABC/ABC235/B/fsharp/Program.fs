let n = stdin.ReadLine() |> int
let h = stdin.ReadLine().Split(" ") |> Array.map int
let ans =
    let rec f (i, acc) =
        if i < n then
            if acc < h.[i] then f (i+1, h.[i]) else acc
        else
            acc
    f (1, h.[0])
printfn "%d" ans

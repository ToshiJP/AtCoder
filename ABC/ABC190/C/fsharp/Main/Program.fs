let [|n; m|] = stdin.ReadLine().Split(' ') |> Array.map int
let abs = Array.init m (fun _ -> stdin.ReadLine().Split(' ') |> Array.map int)
let k = stdin.ReadLine() |> int
let cds = Array.init k (fun _ -> stdin.ReadLine().Split(' ') |> Array.map int)

let sara = Array.create (n+1) 0

let rec solve i (sara: int []) =
    if i >= k then
        let mutable cnt = 0
        for j = 0 to m - 1 do
            if sara.[abs.[j].[0]] >= 1 && sara.[abs.[j].[1]] >= 1 then cnt <- cnt + 1
        cnt
    else
        sara.[cds.[i].[0]] <- sara.[cds.[i].[0]] + 1
        let a = solve (i+1) sara
        sara.[cds.[i].[0]] <- sara.[cds.[i].[0]] - 1

        sara.[cds.[i].[1]] <- sara.[cds.[i].[1]] + 1
        let b = solve (i+1) sara
        sara.[cds.[i].[1]] <- sara.[cds.[i].[1]] - 1

        max a b

solve 0 sara
|> printfn "%d"

let [|n; x|] = stdin.ReadLine().Split(" ") |> Array.map int64

let rec solve m ys =
    if m > n then
        List.filter ((=) 1L) ys
        |> List.length
    else
        let a = stdin.ReadLine().Split(" ") |> Array.toList |> List.tail |> List.map int64
        let ys' = List.collect (fun y ->
            List.filter (fun i -> y % i = 0L) a
            |> List.map (fun i -> y / i)) ys
        solve (m + 1L) ys'

printfn "%d" (solve 1L [x])

let [|n; s; d|] = stdin.ReadLine().Split(' ') |> Array.map int
let xys = Array.init n (fun _ -> stdin.ReadLine().Split(' ') |> Array.map int)

if Array.exists (fun (a: int []) -> a.[0] < s && a.[1] > d) xys then
    printfn "Yes"
else
    printfn "No"

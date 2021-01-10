let n = stdin.ReadLine() |> int

Array.init n (fun _ -> stdin.ReadLine())
|> Set.ofArray |> Set.count
|> printfn "%d"

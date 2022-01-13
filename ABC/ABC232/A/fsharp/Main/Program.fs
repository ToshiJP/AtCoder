let s = stdin.ReadLine()
let a = s.[0].ToString() |> int
let b = s.[2].ToString() |> int

printfn "%d" (a * b)

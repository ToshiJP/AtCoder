let cs = stdin.ReadLine()

if cs.[0] = cs.[1] && cs.[1] = cs.[2] then "Won" else "Lost"
|> printfn "%s"

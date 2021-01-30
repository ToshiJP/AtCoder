let n = stdin.ReadLine() |> int
let s = Array.init n (fun _ -> stdin.ReadLine())

// y_n が True になるようなものの個数
let dp = Array.create (n+1) 0L

dp.[0] <- 1L

let mutable prod = 2L
for i = 1 to n do
    if s.[i-1] = "AND" then
        dp.[i] <- dp.[i-1]
    else
        dp.[i] <- dp.[i-1] + prod
    prod <- prod * 2L

printfn "%d" dp.[n]

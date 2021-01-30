
let [|n; c|] = stdin.ReadLine().Split() |> Array.map int
let ary = Array.init n (fun _ -> stdin.ReadLine().Split() |> Array.map int)

let mutable list = []
for i = 0 to n - 1 do
    list <- (ary.[i].[0], ary.[i].[2]) :: (ary.[i].[1] + 1, -ary.[i].[2]) :: list
list <- List.sort list

let mutable pDay = 1
let mutable ans = 0L
let mutable fee = 0L
for (day, money) in list do
    if day <> pDay then
        ans <- ans + min (int64 c) fee * (int64 day - int64 pDay)
        pDay <- day
    fee <- fee + int64 money

printfn "%d" ans

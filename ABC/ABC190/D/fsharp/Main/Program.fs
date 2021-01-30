let n = stdin.ReadLine() |> int64 |> fun a -> a * 2L

let mutable cnt = 0L
let mutable i = 1L
while i * i <= n do
    if n % i = 0L then
        if (i % 2L = 1L) || ((n / i) % 2L = 1L) then cnt <- cnt + 1L
    i <- i + 1L

printfn "%d" (2L * cnt)

let [|n; a; b|] = stdin.ReadLine().Split() |> Array.map int

let sumDigits i = (string i).ToCharArray() |> Array.sumBy (fun c -> int c - int '0')

let mutable result = 0
for i in seq {1..n} do
    let sum = (string i).ToCharArray() |> Array.sumBy (fun c -> int c - int '0')
    if sum >= a && sum <= b then result <- result + i

printfn "%d" result

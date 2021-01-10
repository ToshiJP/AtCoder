let n = stdin.ReadLine() |> int
let ary = Array.create (n + 1) (0, 0, 0)

let mutable ans = "Yes"
for i = 1 to n do
    ary.[i] <- stdin.ReadLine().Split()
               |> fun a -> (int a.[0], int a.[1], int a.[2])
    let (t1, x1, y1) = ary.[i-1]
    let (t2, x2, y2) = ary.[i]
    let (t, x, y) = (t2 - t1, x2 - x1, y2 - y1)
    if t - abs x - abs y < 0 || (t - abs x - abs y) % 2 <> 0 then ans <- "No"

printfn "%s" ans

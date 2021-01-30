let ary = stdin.ReadLine().Split(' ') |> Array.map int

if ary.[2] = 0 then
    printfn (if ary.[0] > ary.[1] then "Takahashi" else "Aoki")
else
    printfn (if ary.[1] > ary.[0] then "Aoki" else "Takahashi")

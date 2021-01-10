let str = stdin.ReadLine()

let mutable sum = 0
for ch in str do
    sum <- sum + int ch - int '0'

printfn "%d" sum

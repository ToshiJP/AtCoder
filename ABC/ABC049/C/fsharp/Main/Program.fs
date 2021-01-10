let s = stdin.ReadLine()

let rec solve (strOpt: string option) =
    match strOpt with
    | Some str ->
        if str.EndsWith("dream") then solve (Some (str.Remove(str.LastIndexOf("dream"))))
        elif str.EndsWith("dreamer") then solve (Some (str.Remove(str.LastIndexOf("dreamer"))))
        elif str.EndsWith("erase") then solve (Some (str.Remove(str.LastIndexOf("erase"))))
        elif str.EndsWith("eraser") then solve (Some (str.Remove(str.LastIndexOf("eraser"))))
        elif str = "" then Some ""
        else None
    | None -> None

match solve (Some s) with
| Some _ -> printfn "YES"
| None -> printfn "NO"

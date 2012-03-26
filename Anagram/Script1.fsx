
let words = ["ole"; "olsen"; "solen"; "kanskje"]

let createKeyValue = (fun (w : string) -> (w.ToCharArray() |> Array.sort, w))
// createKeyValue "ole"

let sortWords list = List.map createKeyValue list
let sortedWords = sortWords words

let groupWords list = Seq.groupBy (fun (k, _) -> k) list
let groupedWords = groupWords sortedWords


let sequence = groupedWords |> Seq.map (fun (x, y) -> Seq.map (fun (a, b) -> b) y);;
    


// C#
let printSequence list = 
    for (i, v) in list do     
        for (c, s) in v do
            printf "%s, " s
        printfn ""

// Linq / Lambda
let printSequence2 list = 
     Seq.iter (fun (i, v) ->
            if Seq.length v  > 1 then
                Seq.iter (fun (c, s) -> 
                    printf "%s, " s) v
            printfn "") list


    
words
|> sortWords
|> groupWords
|> printSequence2





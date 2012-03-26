

let words = ["neppe"; "olsen"; "solen"; "kanskje"]


let createKeyValue (w : string) = w.ToLower().ToCharArray() |> Array.sort, w

let createDictionary word = 
        List.map  createKeyValueUsingPrime words

let createWordGroups dictionary =
    Seq.groupBy (fun (k, v) -> k) dictionary 

let printWordGroups wordgroups = 
    Seq.iter (fun (k, v) ->
        if Seq.length v > 1 then Seq.iter (fun (x, y) -> printf "%s, " y) v  
        printfn "") wordgroups

let findAnagrams wordlist = 
    wordlist
    |> createDictionary
    |> createWordGroups
    |> printWordGroups

createDictionary words
findAnagrams words
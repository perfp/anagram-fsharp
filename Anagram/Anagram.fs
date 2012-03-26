namespace Anagram

module AnagramCompare =      
    let createKeyValue = 
        (fun (w : string) -> (w.ToCharArray() |> Array.sort, w))
    
    let sortWords list = 
        List.map createKeyValue list    
   
    let groupWords list = 
       Seq.groupBy (fun (k, _) -> k) list

    let printWords list = 
        Seq.iter (fun (i, v) ->
            if Seq.length v  > 1 then
                Seq.iter (fun (c, s) -> 
                    printf "%s, " s) v
            printfn "") list

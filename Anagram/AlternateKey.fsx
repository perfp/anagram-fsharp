
let createKeyValue (word : string) : uint64 * string = 
    let primeAlpha = dict ['a', 2UL; 'b',3UL; 'c',5UL; 'd',7UL;'e', 11UL; 'f',13UL; 'g',17UL; 'h',19UL;'i',23UL; 'j',29UL; 'k',31UL; 'l',37UL; 'm',41UL; 'n',43UL; 'o', 47UL; 'p',53UL;'q',59UL; 'r',61UL; 's',67UL; 't',71UL; 'u',73UL; 'v',79UL; 'w',83UL; 'x',89UL; 'y',97UL; 'z',101UL; 'æ', 103UL; 'ø', 107UL; 'å', 109UL;]
       
    let rec loop list acc = 
        match list with 
        | head :: tail -> loop tail (acc * primeAlpha.Item head )
        | [] -> acc
    
    let charlist = Array.toList(word.ToCharArray())
    let key = loop charlist 1UL
    key, word

createKeyValue "høyesterettsjustitiarius"   


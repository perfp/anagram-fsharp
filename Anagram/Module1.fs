// Learn more about F# at http://fsharp.net. See the 'F# Tutorial' project
// for more guidance on F# programming.

namespace Anagram

/// This is a sample module to contain functions and values
module AnagramCompare =      
    
   

    let compareSequence = 
        Seq.compareWith (fun x y -> if x = y then 0 else 1)

    let hasLetters (word:string)  =
         word
         |> Seq.sortBy (fun x -> x) 
         |> Seq.countBy id

    let IsAnagramOf (word:string) (candidate:string) : bool = 
        let wordletters = hasLetters word
        let candidateletters = hasLetters candidate 
        let wordCompare = compareSequence wordletters candidateletters

        if word = candidate then false
        elif word.Length <> candidate.Length then false         
        elif wordCompare  <> 0 then false 
        else true      
         
        
    let  FindAnagrams ( wordlist : string list) : string list= 
        let rec buildList word wordlist acc =
            match wordlist with            
            | head :: tail -> buildList "" tail (head::acc)
            |[] -> List.rev acc
        buildList "" wordlist []


        
            
            
        









/// This is a sample class type
type SampleLibraryClassType(argument1: int, argument2: int) = 
    
    // This computes the maximum element when the object is constructed
    let maximumElement = max argument1 argument2
    
    /// Get the obejct arguments as a list
    member x.GetElements() = [argument1;  argument2]

    /// Get the sum of the two object arguments
    member x.Sum = argument1 + argument2

    /// Get the maximum of the two object arguments
    member x.Maximum = maximumElement

    /// Create an instance of the class type
    static member Create() = SampleLibraryClassType(3, 4)


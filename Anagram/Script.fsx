// This file is a script that can be executed with the F# Interactive.  
// It can be used to explore and test the library project.
// By default script files are not be part of the project build.

// Learn more about F# at http://fsharp.net. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "Module1.fs"
open Anagram
let word = ["ole"; "olsen"; "solen"; "kanskje"]
AnagramCompare.FindAnagrams word

let a = AnagramCompare.hasLetters "ccadbe"
let b = AnagramCompare.hasLetters "abccdd"
let c = AnagramCompare.compareSequence a b
AnagramCompare.IsAnagramOf "not" "wen"

Seq.compareWith (fun x y -> if x=y then 0 else 1) a b

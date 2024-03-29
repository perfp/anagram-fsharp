﻿// This file is a script that can be executed with the F# Interactive.  
// It can be used to explore and test the library project.
// By default script files are not be part of the project build.

// Learn more about F# at http://fsharp.net. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "Anagram.fs"
open Anagram
let words = ["ole"; "olsen"; "solen"; "kanskje"]

words 
|> AnagramCompare.sortWords
|> AnagramCompare.groupWords
|> AnagramCompare.printWords
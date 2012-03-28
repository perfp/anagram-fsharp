open System
open System.IO

Directory.SetCurrentDirectory( "D:\\source\\Anagram\Anagram\\")
Directory.GetCurrentDirectory()

let input = System.IO.File.ReadAllText(System.Environment.CurrentDirectory + "\\wordlist.txt");

let token = [|System.Environment.NewLine|];
let words = input.Split(token, StringSplitOptions.None)


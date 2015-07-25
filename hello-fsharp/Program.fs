// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

(* Let's say hello, with some Fibonacci numbers. =p Because just printing Hello, World
   is boring...
   https://en.wikibooks.org/wiki/F_Sharp_Programming/Basic_Concepts

   We'll just use .NET i/o for now. It's not functional, but it's fine for this purpose *)

open System

let rec fib = function
    | 0 -> 0
    | 1 -> 1
    | n -> fib (n - 1) + fib (n - 2)

[<EntryPoint>]
let main argv = 
    Console.Write("Enter which Fibonacci number you want: ")
    let input = Console.ReadLine()
    let inputParsed : int = int input
    Console.WriteLine("The {0}th Fibonacci number is: {1}", input, (fib inputParsed))
    Console.WriteLine("Press any key to quit...")
    Console.ReadKey() |> ignore
    0 // return an integer exit code

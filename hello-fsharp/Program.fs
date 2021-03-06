﻿// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

(* Let's say hello, with some Fibonacci numbers. =p Because just printing Hello, World
   is boring...
   https://en.wikibooks.org/wiki/F_Sharp_Programming/Basic_Concepts

   We'll just use .NET i/o for now. It's not functional, but it's fine for this purpose *)

open System

let rec fib = function
    | 0L -> 0L
    | 1L -> 1L
    | n -> fib (n - 1L) + fib (n - 2L)

[<EntryPoint>]
let main argv = 
    Console.Write("Enter which Fibonacci number you want: ")

    let input = Console.ReadLine()
    let inputParsed : int64 = int64 input

    Console.WriteLine("The {0}th Fibonacci number is: {1}", input, (fib inputParsed))
    Console.WriteLine("Press any key to quit...")

    Console.ReadKey() |> ignore // wait for a key, but we don't care about it's value, so throw it away
    0 // return an integer exit code

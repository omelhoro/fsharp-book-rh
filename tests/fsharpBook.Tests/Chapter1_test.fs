module Chapter1_test

open Chapter1
open NUnit.Framework
open FsUnit

[<Test>]
let exercise1 () = Chapter1.fact 4 |> should equal 24;;

[<Test>]
let exercise2 () =  Chapter1.g 5 |> should equal 9;;

[<Test>]
let exercise4 () =  Chapter1.ex4 4 |> should equal 10;;

[<Test>]
let exercise5 () =  Chapter1.fibonacci 4 |> should equal 3;;

[<Test>]
let exercise6 () =  Chapter1.ex6 (4, 2) |> should equal 11;;

[<Test>]
let exerciseFizzBuzz () =  Chapter1.fizzBuzz 15 |> should equal "fizzBuzz";;

[<Test>]
let exerciseFizzBuzzArray () =  [1; 2; 3; 4; 5] |> List.map Chapter1.fizzBuzz |> should equal ["1"; "2"; "fizz"; "4"; "Buzz"];;

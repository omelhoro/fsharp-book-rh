module fsharpBook.Tests

open fsharpBook
open NUnit.Framework
open FsUnit

[<Test>]
let ``hello returns 42`` () =
  let result = Library.hello 42
  printfn "%i" result
  Assert.AreEqual(42,result)

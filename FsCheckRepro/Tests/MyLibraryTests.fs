module TestsLib
open MyLibrary
open FsCheck.Xunit

[<Property>]
let ``My first test`` v =
  v = A
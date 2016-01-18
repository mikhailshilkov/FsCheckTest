module TestsLib2
open MyLibrary
open FsCheck.Xunit

[<Property>]
let ``My first test`` v =
  v = A
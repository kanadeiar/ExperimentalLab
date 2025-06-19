module Calculator

open System.Runtime.CompilerServices

[<assembly: InternalsVisibleTo("MyTestProject")>]
do()

type Data = { weight : double; height : double }

let bodyMassIndex (data) =
    data.weight / (data.height * data.height)

let message (index) =
    $"""Индекс массы тела: {index.ToString()}"""

type Calculator =
    val weight : double
    val height : double
    static member Create weight height =
        new Calculator(weight, height)
    new(weight, height) =
        { weight = weight; height = height }
    member t.Calculate() =
        message <| bodyMassIndex { weight = t.weight; height = t.height }

let calc = Calculator.Create 12.1 34.3
printfn "%s" <| calc.Calculate()
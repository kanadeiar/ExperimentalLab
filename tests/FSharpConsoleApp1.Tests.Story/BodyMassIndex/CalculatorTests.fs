module CalculatorTests

open Xunit
open FluentAssertions
open Calculator

let ``Source for test``() : obj[] seq =
    seq {
        yield [| 50.0; 1.7; "Индекс массы тела: 17,301038062283737" |]
    }

[<Theory>]
[<MemberData(nameof(``Source for test``))>]
let ``Test simple`` (weight, height, expected) =
    let sut = Calculator.Create weight height
    let acutal = sut.Calculate()
    acutal.Should().Be expected |> ignore
module SampleTests

open Xunit
open FluentAssertions

[<Fact>]
let ``Test simple`` () =
    true.Should().BeTrue() |> ignore

[<Theory>]
[<InlineData("1")>]
let ``Test with data`` (obj) =
    obj.Should().NotBeNull() |> ignore

[<Theory>]
[<InlineData(1, 2, 3)>]
[<InlineData(3, 2, 5)>]
let ``Test with digitals`` (one:int) (two:int) (three:int) =
    let sum x y = x + y
    (sum one two).Should().Be three |> ignore

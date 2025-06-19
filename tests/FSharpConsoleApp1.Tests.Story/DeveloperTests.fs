module Tests

open Xunit
open FluentAssertions

[<Fact>]
let ``Test of develop`` () =
    true.Should().BeTrue() |> ignore

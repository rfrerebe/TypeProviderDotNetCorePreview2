// Learn more about F# at http://fsharp.org

open System
open FSharp.Data

type NugetStats = HtmlProvider<"https://www.nuget.org/packages/FSharp.Data">


[<EntryPoint>]
let main argv =
    let rawStats = NugetStats().Tables.``Version History``

    rawStats.Rows |> Seq.iter (printfn "row = %A")
    printfn "Hello World from F#!"
    0 // return an integer exit code

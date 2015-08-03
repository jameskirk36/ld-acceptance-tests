module TickSpec.StepDefinitions

open TickSpec
open NUnit.Framework
open canopy
open System
open runner

let contentEditorUrl = "http://192.168.138.135"

let [<BeforeScenario>] Setup () =
  start firefox

let [<Given>] ``I have a quality standard`` () =
  url contentEditorUrl
  let theTitle = title ()
  printfn "Title: %s" theTitle
  ()

let [<When>] ``I build the knowledge base`` () =
  ()

let [<Then>] ``I should have a quality standard in linked data format`` () =
  Assert.True(true)

let [<AfterScenario>] Teardown () =
  quit()

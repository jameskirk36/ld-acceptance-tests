module TickSpec.StepDefinitions

open TickSpec
open NUnit.Framework
open canopy
open System
open runner

let [<BeforeScenario>] Setup () =
  start firefox

let [<Given>] ``I have a markdown quality statement`` () =
  ContentEditorPage.Load
  ()

let [<When>] ``I build the knowledge base`` () =
  ()

let [<Then>] ``that statement should exist in the triple store`` () =
  Assert.AreEqual(ContentEditorPage.Title, "Owldin")

let [<AfterScenario>] Teardown () =
  quit()

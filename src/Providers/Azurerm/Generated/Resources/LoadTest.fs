namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LoadTestState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.LoadTest.LoadTestConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test">azurerm_load_test</a>.
    /// </summary>
    type LoadTestBuilder(logicalId: string) =
        member _.Yield(_: unit) : LoadTestState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LoadTestState<Missing, Missing, Missing>)

        member _.Zero(()) : LoadTestState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LoadTestState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test#location-1">LoadTest#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: LoadTestState<Missing, 'Name, 'ResourceGroupName>, value: string) : LoadTestState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : LoadTestState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test#name-1">LoadTest#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LoadTestState<'Location, Missing, 'ResourceGroupName>, value: string) : LoadTestState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LoadTestState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test#resource_group_name-1">LoadTest#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LoadTestState<'Location, 'Name, Missing>, value: string) : LoadTestState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LoadTestState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test#description-1">LoadTest#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: LoadTestState<'Location, 'Name, 'ResourceGroupName>, value: string) : LoadTestState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : LoadTestState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test#encryption-1">LoadTest#encryption</a>
        /// </summary>
        [<CustomOperation "encryption">]
        member _.Encryption(state: LoadTestState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.LoadTest.LoadTestEncryption) : LoadTestState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Encryption <- value)
            state : LoadTestState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test#id-1">LoadTest#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LoadTestState<'Location, 'Name, 'ResourceGroupName>, value: string) : LoadTestState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LoadTestState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test#identity-1">LoadTest#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: LoadTestState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.LoadTest.LoadTestIdentity) : LoadTestState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : LoadTestState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test#tags-1">LoadTest#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LoadTestState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : LoadTestState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LoadTestState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test#timeouts-1">LoadTest#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LoadTestState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.LoadTest.LoadTestTimeouts) : LoadTestState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LoadTestState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: LoadTestState<Present, Present, Present>) : azurerm.LoadTest.LoadTest =
            let config = azurerm.LoadTest.LoadTestConfig()
            for setter in state.assignments do
                setter config
            azurerm.LoadTest.LoadTest(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.loadTest: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: LoadTestState<_, _, _>) : azurerm.LoadTest.LoadTest =
            Unchecked.defaultof<azurerm.LoadTest.LoadTest>

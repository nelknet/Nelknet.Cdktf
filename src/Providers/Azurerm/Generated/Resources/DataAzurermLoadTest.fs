namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermLoadTestState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermLoadTest.DataAzurermLoadTestConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/load_test">azurerm_load_test</a>.
    /// </summary>
    type DataAzurermLoadTestBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermLoadTestState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLoadTestState<Missing, Missing>)

        member _.Zero(()) : DataAzurermLoadTestState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLoadTestState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/load_test#name-1">DataAzurermLoadTest#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermLoadTestState<Missing, 'ResourceGroupName>, value: string) : DataAzurermLoadTestState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermLoadTestState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/load_test#resource_group_name-1">DataAzurermLoadTest#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermLoadTestState<'Name, Missing>, value: string) : DataAzurermLoadTestState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermLoadTestState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/load_test#id-1">DataAzurermLoadTest#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermLoadTestState<'Name, 'ResourceGroupName>, value: string) : DataAzurermLoadTestState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermLoadTestState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/load_test#timeouts-1">DataAzurermLoadTest#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermLoadTestState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermLoadTest.DataAzurermLoadTestTimeouts) : DataAzurermLoadTestState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermLoadTestState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermLoadTestState<Present, Present>) : azurerm.DataAzurermLoadTest.DataAzurermLoadTest =
            let config = azurerm.DataAzurermLoadTest.DataAzurermLoadTestConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermLoadTest.DataAzurermLoadTest(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermLoadTest: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermLoadTestState<_, _>) : azurerm.DataAzurermLoadTest.DataAzurermLoadTest =
            Unchecked.defaultof<azurerm.DataAzurermLoadTest.DataAzurermLoadTest>

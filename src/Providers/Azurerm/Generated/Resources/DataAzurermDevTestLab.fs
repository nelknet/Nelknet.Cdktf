namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDevTestLabState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermDevTestLab.DataAzurermDevTestLabConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dev_test_lab">azurerm_dev_test_lab</a>.
    /// </summary>
    type DataAzurermDevTestLabBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDevTestLabState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDevTestLabState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDevTestLabState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDevTestLabState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dev_test_lab#name-1">DataAzurermDevTestLab#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDevTestLabState<Missing, 'ResourceGroupName>, value: string) : DataAzurermDevTestLabState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDevTestLabState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dev_test_lab#resource_group_name-1">DataAzurermDevTestLab#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDevTestLabState<'Name, Missing>, value: string) : DataAzurermDevTestLabState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDevTestLabState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dev_test_lab#id-1">DataAzurermDevTestLab#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDevTestLabState<'Name, 'ResourceGroupName>, value: string) : DataAzurermDevTestLabState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDevTestLabState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dev_test_lab#timeouts-1">DataAzurermDevTestLab#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDevTestLabState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermDevTestLab.DataAzurermDevTestLabTimeouts) : DataAzurermDevTestLabState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDevTestLabState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermDevTestLabState<Present, Present>) : azurerm.DataAzurermDevTestLab.DataAzurermDevTestLab =
            let config = azurerm.DataAzurermDevTestLab.DataAzurermDevTestLabConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDevTestLab.DataAzurermDevTestLab(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDevTestLab: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDevTestLabState<_, _>) : azurerm.DataAzurermDevTestLab.DataAzurermDevTestLab =
            Unchecked.defaultof<azurerm.DataAzurermDevTestLab.DataAzurermDevTestLab>

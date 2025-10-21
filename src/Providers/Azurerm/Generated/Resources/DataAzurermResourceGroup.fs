namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermResourceGroupState<'Name> = { assignments: ResizeArray<azurerm.DataAzurermResourceGroup.DataAzurermResourceGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resource_group">azurerm_resource_group</a>.
    /// </summary>
    type DataAzurermResourceGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermResourceGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermResourceGroupState<Missing>)

        member _.Zero(()) : DataAzurermResourceGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermResourceGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resource_group#name-1">DataAzurermResourceGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermResourceGroupState<Missing>, value: string) : DataAzurermResourceGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermResourceGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resource_group#id-1">DataAzurermResourceGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermResourceGroupState<'Name>, value: string) : DataAzurermResourceGroupState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermResourceGroupState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resource_group#timeouts-1">DataAzurermResourceGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermResourceGroupState<'Name>, value: azurerm.DataAzurermResourceGroup.DataAzurermResourceGroupTimeouts) : DataAzurermResourceGroupState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermResourceGroupState<'Name>

        member _.Run(state: DataAzurermResourceGroupState<Present>) : azurerm.DataAzurermResourceGroup.DataAzurermResourceGroup =
            let config = azurerm.DataAzurermResourceGroup.DataAzurermResourceGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermResourceGroup.DataAzurermResourceGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermResourceGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermResourceGroupState<_>) : azurerm.DataAzurermResourceGroup.DataAzurermResourceGroup =
            Unchecked.defaultof<azurerm.DataAzurermResourceGroup.DataAzurermResourceGroup>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSpatialAnchorsAccountState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermSpatialAnchorsAccount.DataAzurermSpatialAnchorsAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/spatial_anchors_account">azurerm_spatial_anchors_account</a>.
    /// </summary>
    type DataAzurermSpatialAnchorsAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSpatialAnchorsAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSpatialAnchorsAccountState<Missing, Missing>)

        member _.Zero(()) : DataAzurermSpatialAnchorsAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSpatialAnchorsAccountState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/spatial_anchors_account#name-1">DataAzurermSpatialAnchorsAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermSpatialAnchorsAccountState<Missing, 'ResourceGroupName>, value: string) : DataAzurermSpatialAnchorsAccountState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermSpatialAnchorsAccountState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/spatial_anchors_account#resource_group_name-1">DataAzurermSpatialAnchorsAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermSpatialAnchorsAccountState<'Name, Missing>, value: string) : DataAzurermSpatialAnchorsAccountState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermSpatialAnchorsAccountState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/spatial_anchors_account#id-1">DataAzurermSpatialAnchorsAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSpatialAnchorsAccountState<'Name, 'ResourceGroupName>, value: string) : DataAzurermSpatialAnchorsAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSpatialAnchorsAccountState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/spatial_anchors_account#timeouts-1">DataAzurermSpatialAnchorsAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSpatialAnchorsAccountState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermSpatialAnchorsAccount.DataAzurermSpatialAnchorsAccountTimeouts) : DataAzurermSpatialAnchorsAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSpatialAnchorsAccountState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermSpatialAnchorsAccountState<Present, Present>) : azurerm.DataAzurermSpatialAnchorsAccount.DataAzurermSpatialAnchorsAccount =
            let config = azurerm.DataAzurermSpatialAnchorsAccount.DataAzurermSpatialAnchorsAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSpatialAnchorsAccount.DataAzurermSpatialAnchorsAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSpatialAnchorsAccount: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSpatialAnchorsAccountState<_, _>) : azurerm.DataAzurermSpatialAnchorsAccount.DataAzurermSpatialAnchorsAccount =
            Unchecked.defaultof<azurerm.DataAzurermSpatialAnchorsAccount.DataAzurermSpatialAnchorsAccount>

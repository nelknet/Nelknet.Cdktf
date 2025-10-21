namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpatialAnchorsAccountState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.SpatialAnchorsAccount.SpatialAnchorsAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spatial_anchors_account">azurerm_spatial_anchors_account</a>.
    /// </summary>
    type SpatialAnchorsAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpatialAnchorsAccountState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpatialAnchorsAccountState<Missing, Missing, Missing>)

        member _.Zero(()) : SpatialAnchorsAccountState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpatialAnchorsAccountState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spatial_anchors_account#location-1">SpatialAnchorsAccount#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SpatialAnchorsAccountState<Missing, 'Name, 'ResourceGroupName>, value: string) : SpatialAnchorsAccountState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SpatialAnchorsAccountState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spatial_anchors_account#name-1">SpatialAnchorsAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpatialAnchorsAccountState<'Location, Missing, 'ResourceGroupName>, value: string) : SpatialAnchorsAccountState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpatialAnchorsAccountState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spatial_anchors_account#resource_group_name-1">SpatialAnchorsAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SpatialAnchorsAccountState<'Location, 'Name, Missing>, value: string) : SpatialAnchorsAccountState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SpatialAnchorsAccountState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spatial_anchors_account#id-1">SpatialAnchorsAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpatialAnchorsAccountState<'Location, 'Name, 'ResourceGroupName>, value: string) : SpatialAnchorsAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpatialAnchorsAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spatial_anchors_account#tags-1">SpatialAnchorsAccount#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SpatialAnchorsAccountState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : SpatialAnchorsAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SpatialAnchorsAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spatial_anchors_account#timeouts-1">SpatialAnchorsAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpatialAnchorsAccountState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.SpatialAnchorsAccount.SpatialAnchorsAccountTimeouts) : SpatialAnchorsAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpatialAnchorsAccountState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: SpatialAnchorsAccountState<Present, Present, Present>) : azurerm.SpatialAnchorsAccount.SpatialAnchorsAccount =
            let config = azurerm.SpatialAnchorsAccount.SpatialAnchorsAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpatialAnchorsAccount.SpatialAnchorsAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.spatialAnchorsAccount: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: SpatialAnchorsAccountState<_, _, _>) : azurerm.SpatialAnchorsAccount.SpatialAnchorsAccount =
            Unchecked.defaultof<azurerm.SpatialAnchorsAccount.SpatialAnchorsAccount>

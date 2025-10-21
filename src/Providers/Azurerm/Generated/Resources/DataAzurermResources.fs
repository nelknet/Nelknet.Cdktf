namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermResourcesState = { assignments: ResizeArray<azurerm.DataAzurermResources.DataAzurermResourcesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resources">azurerm_resources</a>.
    /// </summary>
    type DataAzurermResourcesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermResourcesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAzurermResourcesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resources#id-1">DataAzurermResources#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermResourcesState, value: string) : DataAzurermResourcesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermResourcesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resources#name-1">DataAzurermResources#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermResourcesState, value: string) : DataAzurermResourcesState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAzurermResourcesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resources#required_tags-1">DataAzurermResources#required_tags</a>.
        /// </summary>
        [<CustomOperation "required_tags">]
        member _.RequiredTags(state: DataAzurermResourcesState, value: seq<string * string>) : DataAzurermResourcesState =
            state.assignments.Add(fun config -> config.RequiredTags <- dict value)
            state : DataAzurermResourcesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resources#resource_group_name-1">DataAzurermResources#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermResourcesState, value: string) : DataAzurermResourcesState =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            state : DataAzurermResourcesState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resources#timeouts-1">DataAzurermResources#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermResourcesState, value: azurerm.DataAzurermResources.DataAzurermResourcesTimeouts) : DataAzurermResourcesState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermResourcesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resources#type-1">DataAzurermResources#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DataAzurermResourcesState, value: string) : DataAzurermResourcesState =
            state.assignments.Add(fun config -> config.Type <- value)
            state : DataAzurermResourcesState

        member _.Run(state: DataAzurermResourcesState) : azurerm.DataAzurermResources.DataAzurermResources =
            let config = azurerm.DataAzurermResources.DataAzurermResourcesConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermResources.DataAzurermResources(StackContext.get (), logicalId, config)

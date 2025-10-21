namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ResourceGroupState<'Location, 'Name> = { assignments: ResizeArray<azurerm.ResourceGroup.ResourceGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group">azurerm_resource_group</a>.
    /// </summary>
    type ResourceGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ResourceGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceGroupState<Missing, Missing>)

        member _.Zero(()) : ResourceGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group#location-1">ResourceGroup#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ResourceGroupState<Missing, 'Name>, value: string) : ResourceGroupState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ResourceGroupState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group#name-1">ResourceGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ResourceGroupState<'Location, Missing>, value: string) : ResourceGroupState<'Location, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ResourceGroupState<'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group#id-1">ResourceGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ResourceGroupState<'Location, 'Name>, value: string) : ResourceGroupState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ResourceGroupState<'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group#managed_by-1">ResourceGroup#managed_by</a>.
        /// </summary>
        [<CustomOperation "managed_by">]
        member _.ManagedBy(state: ResourceGroupState<'Location, 'Name>, value: string) : ResourceGroupState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.ManagedBy <- value)
            state : ResourceGroupState<'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group#tags-1">ResourceGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ResourceGroupState<'Location, 'Name>, value: seq<string * string>) : ResourceGroupState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ResourceGroupState<'Location, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group#timeouts-1">ResourceGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ResourceGroupState<'Location, 'Name>, value: azurerm.ResourceGroup.ResourceGroupTimeouts) : ResourceGroupState<'Location, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ResourceGroupState<'Location, 'Name>

        member _.Run(state: ResourceGroupState<Present, Present>) : azurerm.ResourceGroup.ResourceGroup =
            let config = azurerm.ResourceGroup.ResourceGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.ResourceGroup.ResourceGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.resourceGroup: missing required arguments. Must call: location, name.", 9999, IsError = true)>]
        member _.Run(_: ResourceGroupState<_, _>) : azurerm.ResourceGroup.ResourceGroup =
            Unchecked.defaultof<azurerm.ResourceGroup.ResourceGroup>

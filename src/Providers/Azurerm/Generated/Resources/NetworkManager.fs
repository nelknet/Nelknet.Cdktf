namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkManagerState<'Location, 'Name, 'ResourceGroupName, 'Scope, 'ScopeAccesses> = { assignments: ResizeArray<azurerm.NetworkManager.NetworkManagerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager">azurerm_network_manager</a>.
    /// </summary>
    type NetworkManagerBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkManagerState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetworkManagerState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager#location-1">NetworkManager#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetworkManagerState<Missing, 'Name, 'ResourceGroupName, 'Scope, 'ScopeAccesses>, value: string) : NetworkManagerState<Present, 'Name, 'ResourceGroupName, 'Scope, 'ScopeAccesses> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NetworkManagerState<Present, 'Name, 'ResourceGroupName, 'Scope, 'ScopeAccesses>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager#name-1">NetworkManager#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkManagerState<'Location, Missing, 'ResourceGroupName, 'Scope, 'ScopeAccesses>, value: string) : NetworkManagerState<'Location, Present, 'ResourceGroupName, 'Scope, 'ScopeAccesses> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkManagerState<'Location, Present, 'ResourceGroupName, 'Scope, 'ScopeAccesses>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager#resource_group_name-1">NetworkManager#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NetworkManagerState<'Location, 'Name, Missing, 'Scope, 'ScopeAccesses>, value: string) : NetworkManagerState<'Location, 'Name, Present, 'Scope, 'ScopeAccesses> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NetworkManagerState<'Location, 'Name, Present, 'Scope, 'ScopeAccesses>)

        /// <summary>
        /// scope block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager#scope-1">NetworkManager#scope</a>
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: NetworkManagerState<'Location, 'Name, 'ResourceGroupName, Missing, 'ScopeAccesses>, value: azurerm.NetworkManager.NetworkManagerScope) : NetworkManagerState<'Location, 'Name, 'ResourceGroupName, Present, 'ScopeAccesses> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : NetworkManagerState<'Location, 'Name, 'ResourceGroupName, Present, 'ScopeAccesses>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager#scope_accesses-1">NetworkManager#scope_accesses</a>.
        /// </summary>
        [<CustomOperation "scope_accesses">]
        member _.ScopeAccesses(state: NetworkManagerState<'Location, 'Name, 'ResourceGroupName, 'Scope, Missing>, value: seq<string>) : NetworkManagerState<'Location, 'Name, 'ResourceGroupName, 'Scope, Present> =
            state.assignments.Add(fun config -> config.ScopeAccesses <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : NetworkManagerState<'Location, 'Name, 'ResourceGroupName, 'Scope, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager#description-1">NetworkManager#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkManagerState<'Location, 'Name, 'ResourceGroupName, 'Scope, 'ScopeAccesses>, value: string) : NetworkManagerState<'Location, 'Name, 'ResourceGroupName, 'Scope, 'ScopeAccesses> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkManagerState<'Location, 'Name, 'ResourceGroupName, 'Scope, 'ScopeAccesses>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager#id-1">NetworkManager#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkManagerState<'Location, 'Name, 'ResourceGroupName, 'Scope, 'ScopeAccesses>, value: string) : NetworkManagerState<'Location, 'Name, 'ResourceGroupName, 'Scope, 'ScopeAccesses> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkManagerState<'Location, 'Name, 'ResourceGroupName, 'Scope, 'ScopeAccesses>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager#tags-1">NetworkManager#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkManagerState<'Location, 'Name, 'ResourceGroupName, 'Scope, 'ScopeAccesses>, value: seq<string * string>) : NetworkManagerState<'Location, 'Name, 'ResourceGroupName, 'Scope, 'ScopeAccesses> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkManagerState<'Location, 'Name, 'ResourceGroupName, 'Scope, 'ScopeAccesses>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager#timeouts-1">NetworkManager#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkManagerState<'Location, 'Name, 'ResourceGroupName, 'Scope, 'ScopeAccesses>, value: azurerm.NetworkManager.NetworkManagerTimeouts) : NetworkManagerState<'Location, 'Name, 'ResourceGroupName, 'Scope, 'ScopeAccesses> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkManagerState<'Location, 'Name, 'ResourceGroupName, 'Scope, 'ScopeAccesses>

        member _.Run(state: NetworkManagerState<Present, Present, Present, Present, Present>) : azurerm.NetworkManager.NetworkManager =
            let config = azurerm.NetworkManager.NetworkManagerConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkManager.NetworkManager(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkManager: missing required arguments. Must call: location, name, resource_group_name, scope, scope_accesses.", 9999, IsError = true)>]
        member _.Run(_: NetworkManagerState<_, _, _, _, _>) : azurerm.NetworkManager.NetworkManager =
            Unchecked.defaultof<azurerm.NetworkManager.NetworkManager>

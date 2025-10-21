namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkManagerDeploymentState<'ConfigurationIds, 'Location, 'NetworkManagerId, 'ScopeAccess> = { assignments: ResizeArray<azurerm.NetworkManagerDeployment.NetworkManagerDeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_deployment">azurerm_network_manager_deployment</a>.
    /// </summary>
    type NetworkManagerDeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkManagerDeploymentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerDeploymentState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetworkManagerDeploymentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerDeploymentState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_deployment#configuration_ids-1">NetworkManagerDeployment#configuration_ids</a>.
        /// </summary>
        [<CustomOperation "configuration_ids">]
        member _.ConfigurationIds(state: NetworkManagerDeploymentState<Missing, 'Location, 'NetworkManagerId, 'ScopeAccess>, value: seq<string>) : NetworkManagerDeploymentState<Present, 'Location, 'NetworkManagerId, 'ScopeAccess> =
            state.assignments.Add(fun config -> config.ConfigurationIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : NetworkManagerDeploymentState<Present, 'Location, 'NetworkManagerId, 'ScopeAccess>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_deployment#location-1">NetworkManagerDeployment#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetworkManagerDeploymentState<'ConfigurationIds, Missing, 'NetworkManagerId, 'ScopeAccess>, value: string) : NetworkManagerDeploymentState<'ConfigurationIds, Present, 'NetworkManagerId, 'ScopeAccess> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NetworkManagerDeploymentState<'ConfigurationIds, Present, 'NetworkManagerId, 'ScopeAccess>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_deployment#network_manager_id-1">NetworkManagerDeployment#network_manager_id</a>.
        /// </summary>
        [<CustomOperation "network_manager_id">]
        member _.NetworkManagerId(state: NetworkManagerDeploymentState<'ConfigurationIds, 'Location, Missing, 'ScopeAccess>, value: string) : NetworkManagerDeploymentState<'ConfigurationIds, 'Location, Present, 'ScopeAccess> =
            state.assignments.Add(fun config -> config.NetworkManagerId <- value)
            ({ assignments = state.assignments } : NetworkManagerDeploymentState<'ConfigurationIds, 'Location, Present, 'ScopeAccess>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_deployment#scope_access-1">NetworkManagerDeployment#scope_access</a>.
        /// </summary>
        [<CustomOperation "scope_access">]
        member _.ScopeAccess(state: NetworkManagerDeploymentState<'ConfigurationIds, 'Location, 'NetworkManagerId, Missing>, value: string) : NetworkManagerDeploymentState<'ConfigurationIds, 'Location, 'NetworkManagerId, Present> =
            state.assignments.Add(fun config -> config.ScopeAccess <- value)
            ({ assignments = state.assignments } : NetworkManagerDeploymentState<'ConfigurationIds, 'Location, 'NetworkManagerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_deployment#id-1">NetworkManagerDeployment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkManagerDeploymentState<'ConfigurationIds, 'Location, 'NetworkManagerId, 'ScopeAccess>, value: string) : NetworkManagerDeploymentState<'ConfigurationIds, 'Location, 'NetworkManagerId, 'ScopeAccess> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkManagerDeploymentState<'ConfigurationIds, 'Location, 'NetworkManagerId, 'ScopeAccess>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_deployment#timeouts-1">NetworkManagerDeployment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkManagerDeploymentState<'ConfigurationIds, 'Location, 'NetworkManagerId, 'ScopeAccess>, value: azurerm.NetworkManagerDeployment.NetworkManagerDeploymentTimeouts) : NetworkManagerDeploymentState<'ConfigurationIds, 'Location, 'NetworkManagerId, 'ScopeAccess> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkManagerDeploymentState<'ConfigurationIds, 'Location, 'NetworkManagerId, 'ScopeAccess>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_deployment#triggers-1">NetworkManagerDeployment#triggers</a>.
        /// </summary>
        [<CustomOperation "triggers">]
        member _.Triggers(state: NetworkManagerDeploymentState<'ConfigurationIds, 'Location, 'NetworkManagerId, 'ScopeAccess>, value: seq<string * string>) : NetworkManagerDeploymentState<'ConfigurationIds, 'Location, 'NetworkManagerId, 'ScopeAccess> =
            state.assignments.Add(fun config -> config.Triggers <- dict value)
            state : NetworkManagerDeploymentState<'ConfigurationIds, 'Location, 'NetworkManagerId, 'ScopeAccess>

        member _.Run(state: NetworkManagerDeploymentState<Present, Present, Present, Present>) : azurerm.NetworkManagerDeployment.NetworkManagerDeployment =
            let config = azurerm.NetworkManagerDeployment.NetworkManagerDeploymentConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkManagerDeployment.NetworkManagerDeployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkManagerDeployment: missing required arguments. Must call: configuration_ids, location, network_manager_id, scope_access.", 9999, IsError = true)>]
        member _.Run(_: NetworkManagerDeploymentState<_, _, _, _>) : azurerm.NetworkManagerDeployment.NetworkManagerDeployment =
            Unchecked.defaultof<azurerm.NetworkManagerDeployment.NetworkManagerDeployment>

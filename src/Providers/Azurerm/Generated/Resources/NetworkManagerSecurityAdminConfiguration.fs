namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkManagerSecurityAdminConfigurationState<'Name, 'NetworkManagerId> = { assignments: ResizeArray<azurerm.NetworkManagerSecurityAdminConfiguration.NetworkManagerSecurityAdminConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_security_admin_configuration">azurerm_network_manager_security_admin_configuration</a>.
    /// </summary>
    type NetworkManagerSecurityAdminConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkManagerSecurityAdminConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerSecurityAdminConfigurationState<Missing, Missing>)

        member _.Zero(()) : NetworkManagerSecurityAdminConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerSecurityAdminConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_security_admin_configuration#name-1">NetworkManagerSecurityAdminConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkManagerSecurityAdminConfigurationState<Missing, 'NetworkManagerId>, value: string) : NetworkManagerSecurityAdminConfigurationState<Present, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkManagerSecurityAdminConfigurationState<Present, 'NetworkManagerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_security_admin_configuration#network_manager_id-1">NetworkManagerSecurityAdminConfiguration#network_manager_id</a>.
        /// </summary>
        [<CustomOperation "network_manager_id">]
        member _.NetworkManagerId(state: NetworkManagerSecurityAdminConfigurationState<'Name, Missing>, value: string) : NetworkManagerSecurityAdminConfigurationState<'Name, Present> =
            state.assignments.Add(fun config -> config.NetworkManagerId <- value)
            ({ assignments = state.assignments } : NetworkManagerSecurityAdminConfigurationState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_security_admin_configuration#apply_on_network_intent_policy_based_services-1">NetworkManagerSecurityAdminConfiguration#apply_on_network_intent_policy_based_services</a>.
        /// </summary>
        [<CustomOperation "apply_on_network_intent_policy_based_services">]
        member _.ApplyOnNetworkIntentPolicyBasedServices(state: NetworkManagerSecurityAdminConfigurationState<'Name, 'NetworkManagerId>, value: seq<string>) : NetworkManagerSecurityAdminConfigurationState<'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.ApplyOnNetworkIntentPolicyBasedServices <- (value |> Seq.toArray))
            state : NetworkManagerSecurityAdminConfigurationState<'Name, 'NetworkManagerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_security_admin_configuration#description-1">NetworkManagerSecurityAdminConfiguration#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkManagerSecurityAdminConfigurationState<'Name, 'NetworkManagerId>, value: string) : NetworkManagerSecurityAdminConfigurationState<'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkManagerSecurityAdminConfigurationState<'Name, 'NetworkManagerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_security_admin_configuration#id-1">NetworkManagerSecurityAdminConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkManagerSecurityAdminConfigurationState<'Name, 'NetworkManagerId>, value: string) : NetworkManagerSecurityAdminConfigurationState<'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkManagerSecurityAdminConfigurationState<'Name, 'NetworkManagerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_security_admin_configuration#timeouts-1">NetworkManagerSecurityAdminConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkManagerSecurityAdminConfigurationState<'Name, 'NetworkManagerId>, value: azurerm.NetworkManagerSecurityAdminConfiguration.NetworkManagerSecurityAdminConfigurationTimeouts) : NetworkManagerSecurityAdminConfigurationState<'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkManagerSecurityAdminConfigurationState<'Name, 'NetworkManagerId>

        member _.Run(state: NetworkManagerSecurityAdminConfigurationState<Present, Present>) : azurerm.NetworkManagerSecurityAdminConfiguration.NetworkManagerSecurityAdminConfiguration =
            let config = azurerm.NetworkManagerSecurityAdminConfiguration.NetworkManagerSecurityAdminConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkManagerSecurityAdminConfiguration.NetworkManagerSecurityAdminConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkManagerSecurityAdminConfiguration: missing required arguments. Must call: name, network_manager_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkManagerSecurityAdminConfigurationState<_, _>) : azurerm.NetworkManagerSecurityAdminConfiguration.NetworkManagerSecurityAdminConfiguration =
            Unchecked.defaultof<azurerm.NetworkManagerSecurityAdminConfiguration.NetworkManagerSecurityAdminConfiguration>

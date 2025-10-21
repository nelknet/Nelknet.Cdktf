namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpnServerConfigurationPolicyGroupState<'Name, 'Policy, 'VpnServerConfigurationId> = { assignments: ResizeArray<azurerm.VpnServerConfigurationPolicyGroup.VpnServerConfigurationPolicyGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration_policy_group">azurerm_vpn_server_configuration_policy_group</a>.
    /// </summary>
    type VpnServerConfigurationPolicyGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpnServerConfigurationPolicyGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnServerConfigurationPolicyGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : VpnServerConfigurationPolicyGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnServerConfigurationPolicyGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration_policy_group#name-1">VpnServerConfigurationPolicyGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VpnServerConfigurationPolicyGroupState<Missing, 'Policy, 'VpnServerConfigurationId>, value: string) : VpnServerConfigurationPolicyGroupState<Present, 'Policy, 'VpnServerConfigurationId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VpnServerConfigurationPolicyGroupState<Present, 'Policy, 'VpnServerConfigurationId>)

        /// <summary>
        /// policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration_policy_group#policy-1">VpnServerConfigurationPolicyGroup#policy</a> Accepts: azurerm.IResolvable | azurerm.VpnServerConfigurationPolicyGroup.VpnServerConfigurationPolicyGroupPolicy[]
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: VpnServerConfigurationPolicyGroupState<'Name, Missing, 'VpnServerConfigurationId>, value: HashiCorp.Cdktf.IResolvable) : VpnServerConfigurationPolicyGroupState<'Name, Present, 'VpnServerConfigurationId> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : VpnServerConfigurationPolicyGroupState<'Name, Present, 'VpnServerConfigurationId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration_policy_group#vpn_server_configuration_id-1">VpnServerConfigurationPolicyGroup#vpn_server_configuration_id</a>.
        /// </summary>
        [<CustomOperation "vpn_server_configuration_id">]
        member _.VpnServerConfigurationId(state: VpnServerConfigurationPolicyGroupState<'Name, 'Policy, Missing>, value: string) : VpnServerConfigurationPolicyGroupState<'Name, 'Policy, Present> =
            state.assignments.Add(fun config -> config.VpnServerConfigurationId <- value)
            ({ assignments = state.assignments } : VpnServerConfigurationPolicyGroupState<'Name, 'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration_policy_group#id-1">VpnServerConfigurationPolicyGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpnServerConfigurationPolicyGroupState<'Name, 'Policy, 'VpnServerConfigurationId>, value: string) : VpnServerConfigurationPolicyGroupState<'Name, 'Policy, 'VpnServerConfigurationId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpnServerConfigurationPolicyGroupState<'Name, 'Policy, 'VpnServerConfigurationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration_policy_group#is_default-1">VpnServerConfigurationPolicyGroup#is_default</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_default">]
        member _.IsDefault(state: VpnServerConfigurationPolicyGroupState<'Name, 'Policy, 'VpnServerConfigurationId>, value: bool) : VpnServerConfigurationPolicyGroupState<'Name, 'Policy, 'VpnServerConfigurationId> =
            state.assignments.Add(fun config -> config.IsDefault <- value)
            state : VpnServerConfigurationPolicyGroupState<'Name, 'Policy, 'VpnServerConfigurationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration_policy_group#is_default-1">VpnServerConfigurationPolicyGroup#is_default</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_default">]
        member _.IsDefault(state: VpnServerConfigurationPolicyGroupState<'Name, 'Policy, 'VpnServerConfigurationId>, value: HashiCorp.Cdktf.IResolvable) : VpnServerConfigurationPolicyGroupState<'Name, 'Policy, 'VpnServerConfigurationId> =
            state.assignments.Add(fun config -> config.IsDefault <- value)
            state : VpnServerConfigurationPolicyGroupState<'Name, 'Policy, 'VpnServerConfigurationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration_policy_group#priority-1">VpnServerConfigurationPolicyGroup#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: VpnServerConfigurationPolicyGroupState<'Name, 'Policy, 'VpnServerConfigurationId>, value: double) : VpnServerConfigurationPolicyGroupState<'Name, 'Policy, 'VpnServerConfigurationId> =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : VpnServerConfigurationPolicyGroupState<'Name, 'Policy, 'VpnServerConfigurationId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration_policy_group#timeouts-1">VpnServerConfigurationPolicyGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpnServerConfigurationPolicyGroupState<'Name, 'Policy, 'VpnServerConfigurationId>, value: azurerm.VpnServerConfigurationPolicyGroup.VpnServerConfigurationPolicyGroupTimeouts) : VpnServerConfigurationPolicyGroupState<'Name, 'Policy, 'VpnServerConfigurationId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpnServerConfigurationPolicyGroupState<'Name, 'Policy, 'VpnServerConfigurationId>

        member _.Run(state: VpnServerConfigurationPolicyGroupState<Present, Present, Present>) : azurerm.VpnServerConfigurationPolicyGroup.VpnServerConfigurationPolicyGroup =
            let config = azurerm.VpnServerConfigurationPolicyGroup.VpnServerConfigurationPolicyGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.VpnServerConfigurationPolicyGroup.VpnServerConfigurationPolicyGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.vpnServerConfigurationPolicyGroup: missing required arguments. Must call: name, policy, vpn_server_configuration_id.", 9999, IsError = true)>]
        member _.Run(_: VpnServerConfigurationPolicyGroupState<_, _, _>) : azurerm.VpnServerConfigurationPolicyGroup.VpnServerConfigurationPolicyGroup =
            Unchecked.defaultof<azurerm.VpnServerConfigurationPolicyGroup.VpnServerConfigurationPolicyGroup>

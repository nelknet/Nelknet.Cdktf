namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermWebApplicationFirewallPolicyState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermWebApplicationFirewallPolicy.DataAzurermWebApplicationFirewallPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/web_application_firewall_policy">azurerm_web_application_firewall_policy</a>.
    /// </summary>
    type DataAzurermWebApplicationFirewallPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermWebApplicationFirewallPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermWebApplicationFirewallPolicyState<Missing, Missing>)

        member _.Zero(()) : DataAzurermWebApplicationFirewallPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermWebApplicationFirewallPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/web_application_firewall_policy#name-1">DataAzurermWebApplicationFirewallPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermWebApplicationFirewallPolicyState<Missing, 'ResourceGroupName>, value: string) : DataAzurermWebApplicationFirewallPolicyState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermWebApplicationFirewallPolicyState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/web_application_firewall_policy#resource_group_name-1">DataAzurermWebApplicationFirewallPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermWebApplicationFirewallPolicyState<'Name, Missing>, value: string) : DataAzurermWebApplicationFirewallPolicyState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermWebApplicationFirewallPolicyState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/web_application_firewall_policy#id-1">DataAzurermWebApplicationFirewallPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermWebApplicationFirewallPolicyState<'Name, 'ResourceGroupName>, value: string) : DataAzurermWebApplicationFirewallPolicyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermWebApplicationFirewallPolicyState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/web_application_firewall_policy#tags-1">DataAzurermWebApplicationFirewallPolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAzurermWebApplicationFirewallPolicyState<'Name, 'ResourceGroupName>, value: seq<string * string>) : DataAzurermWebApplicationFirewallPolicyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAzurermWebApplicationFirewallPolicyState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/web_application_firewall_policy#timeouts-1">DataAzurermWebApplicationFirewallPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermWebApplicationFirewallPolicyState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermWebApplicationFirewallPolicy.DataAzurermWebApplicationFirewallPolicyTimeouts) : DataAzurermWebApplicationFirewallPolicyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermWebApplicationFirewallPolicyState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermWebApplicationFirewallPolicyState<Present, Present>) : azurerm.DataAzurermWebApplicationFirewallPolicy.DataAzurermWebApplicationFirewallPolicy =
            let config = azurerm.DataAzurermWebApplicationFirewallPolicy.DataAzurermWebApplicationFirewallPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermWebApplicationFirewallPolicy.DataAzurermWebApplicationFirewallPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermWebApplicationFirewallPolicy: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermWebApplicationFirewallPolicyState<_, _>) : azurerm.DataAzurermWebApplicationFirewallPolicy.DataAzurermWebApplicationFirewallPolicy =
            Unchecked.defaultof<azurerm.DataAzurermWebApplicationFirewallPolicy.DataAzurermWebApplicationFirewallPolicy>

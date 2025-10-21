namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPrivateDnsResolverDnsForwardingRulesetState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermPrivateDnsResolverDnsForwardingRuleset.DataAzurermPrivateDnsResolverDnsForwardingRulesetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_dns_forwarding_ruleset">azurerm_private_dns_resolver_dns_forwarding_ruleset</a>.
    /// </summary>
    type DataAzurermPrivateDnsResolverDnsForwardingRulesetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPrivateDnsResolverDnsForwardingRulesetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsResolverDnsForwardingRulesetState<Missing, Missing>)

        member _.Zero(()) : DataAzurermPrivateDnsResolverDnsForwardingRulesetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsResolverDnsForwardingRulesetState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_dns_forwarding_ruleset#name-1">DataAzurermPrivateDnsResolverDnsForwardingRuleset#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPrivateDnsResolverDnsForwardingRulesetState<Missing, 'ResourceGroupName>, value: string) : DataAzurermPrivateDnsResolverDnsForwardingRulesetState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsResolverDnsForwardingRulesetState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_dns_forwarding_ruleset#resource_group_name-1">DataAzurermPrivateDnsResolverDnsForwardingRuleset#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPrivateDnsResolverDnsForwardingRulesetState<'Name, Missing>, value: string) : DataAzurermPrivateDnsResolverDnsForwardingRulesetState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsResolverDnsForwardingRulesetState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_dns_forwarding_ruleset#id-1">DataAzurermPrivateDnsResolverDnsForwardingRuleset#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPrivateDnsResolverDnsForwardingRulesetState<'Name, 'ResourceGroupName>, value: string) : DataAzurermPrivateDnsResolverDnsForwardingRulesetState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPrivateDnsResolverDnsForwardingRulesetState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_dns_forwarding_ruleset#timeouts-1">DataAzurermPrivateDnsResolverDnsForwardingRuleset#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPrivateDnsResolverDnsForwardingRulesetState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermPrivateDnsResolverDnsForwardingRuleset.DataAzurermPrivateDnsResolverDnsForwardingRulesetTimeouts) : DataAzurermPrivateDnsResolverDnsForwardingRulesetState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPrivateDnsResolverDnsForwardingRulesetState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermPrivateDnsResolverDnsForwardingRulesetState<Present, Present>) : azurerm.DataAzurermPrivateDnsResolverDnsForwardingRuleset.DataAzurermPrivateDnsResolverDnsForwardingRuleset =
            let config = azurerm.DataAzurermPrivateDnsResolverDnsForwardingRuleset.DataAzurermPrivateDnsResolverDnsForwardingRulesetConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPrivateDnsResolverDnsForwardingRuleset.DataAzurermPrivateDnsResolverDnsForwardingRuleset(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPrivateDnsResolverDnsForwardingRuleset: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPrivateDnsResolverDnsForwardingRulesetState<_, _>) : azurerm.DataAzurermPrivateDnsResolverDnsForwardingRuleset.DataAzurermPrivateDnsResolverDnsForwardingRuleset =
            Unchecked.defaultof<azurerm.DataAzurermPrivateDnsResolverDnsForwardingRuleset.DataAzurermPrivateDnsResolverDnsForwardingRuleset>

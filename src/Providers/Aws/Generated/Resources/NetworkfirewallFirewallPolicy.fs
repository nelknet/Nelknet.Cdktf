namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkfirewallFirewallPolicyState<'FirewallPolicy, 'Name> = { assignments: ResizeArray<aws.NetworkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall_policy">aws_networkfirewall_firewall_policy</a>.
    /// </summary>
    type NetworkfirewallFirewallPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkfirewallFirewallPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkfirewallFirewallPolicyState<Missing, Missing>)

        member _.Zero(()) : NetworkfirewallFirewallPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkfirewallFirewallPolicyState<Missing, Missing>)

        /// <summary>
        /// firewall_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall_policy#firewall_policy-1">NetworkfirewallFirewallPolicy#firewall_policy</a>
        /// </summary>
        [<CustomOperation "firewall_policy">]
        member _.FirewallPolicy(state: NetworkfirewallFirewallPolicyState<Missing, 'Name>, value: aws.NetworkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicy) : NetworkfirewallFirewallPolicyState<Present, 'Name> =
            state.assignments.Add(fun config -> config.FirewallPolicy <- value)
            ({ assignments = state.assignments } : NetworkfirewallFirewallPolicyState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall_policy#name-1">NetworkfirewallFirewallPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkfirewallFirewallPolicyState<'FirewallPolicy, Missing>, value: string) : NetworkfirewallFirewallPolicyState<'FirewallPolicy, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkfirewallFirewallPolicyState<'FirewallPolicy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall_policy#description-1">NetworkfirewallFirewallPolicy#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkfirewallFirewallPolicyState<'FirewallPolicy, 'Name>, value: string) : NetworkfirewallFirewallPolicyState<'FirewallPolicy, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkfirewallFirewallPolicyState<'FirewallPolicy, 'Name>

        /// <summary>
        /// encryption_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall_policy#encryption_configuration-1">NetworkfirewallFirewallPolicy#encryption_configuration</a>
        /// </summary>
        [<CustomOperation "encryption_configuration">]
        member _.EncryptionConfiguration(state: NetworkfirewallFirewallPolicyState<'FirewallPolicy, 'Name>, value: aws.NetworkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyEncryptionConfiguration) : NetworkfirewallFirewallPolicyState<'FirewallPolicy, 'Name> =
            state.assignments.Add(fun config -> config.EncryptionConfiguration <- value)
            state : NetworkfirewallFirewallPolicyState<'FirewallPolicy, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall_policy#id-1">NetworkfirewallFirewallPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkfirewallFirewallPolicyState<'FirewallPolicy, 'Name>, value: string) : NetworkfirewallFirewallPolicyState<'FirewallPolicy, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkfirewallFirewallPolicyState<'FirewallPolicy, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall_policy#tags-1">NetworkfirewallFirewallPolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkfirewallFirewallPolicyState<'FirewallPolicy, 'Name>, value: seq<string * string>) : NetworkfirewallFirewallPolicyState<'FirewallPolicy, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkfirewallFirewallPolicyState<'FirewallPolicy, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall_policy#tags_all-1">NetworkfirewallFirewallPolicy#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NetworkfirewallFirewallPolicyState<'FirewallPolicy, 'Name>, value: seq<string * string>) : NetworkfirewallFirewallPolicyState<'FirewallPolicy, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NetworkfirewallFirewallPolicyState<'FirewallPolicy, 'Name>

        member _.Run(state: NetworkfirewallFirewallPolicyState<Present, Present>) : aws.NetworkfirewallFirewallPolicy.NetworkfirewallFirewallPolicy =
            let config = aws.NetworkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkfirewallFirewallPolicy.NetworkfirewallFirewallPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkfirewallFirewallPolicy: missing required arguments. Must call: firewall_policy, name.", 9999, IsError = true)>]
        member _.Run(_: NetworkfirewallFirewallPolicyState<_, _>) : aws.NetworkfirewallFirewallPolicy.NetworkfirewallFirewallPolicy =
            Unchecked.defaultof<aws.NetworkfirewallFirewallPolicy.NetworkfirewallFirewallPolicy>

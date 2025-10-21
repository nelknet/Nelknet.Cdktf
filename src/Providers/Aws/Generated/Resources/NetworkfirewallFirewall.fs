namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId> = { assignments: ResizeArray<aws.NetworkfirewallFirewall.NetworkfirewallFirewallConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall">aws_networkfirewall_firewall</a>.
    /// </summary>
    type NetworkfirewallFirewallBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkfirewallFirewallState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkfirewallFirewallState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetworkfirewallFirewallState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkfirewallFirewallState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall#firewall_policy_arn-1">NetworkfirewallFirewall#firewall_policy_arn</a>.
        /// </summary>
        [<CustomOperation "firewall_policy_arn">]
        member _.FirewallPolicyArn(state: NetworkfirewallFirewallState<Missing, 'Name, 'SubnetMapping, 'VpcId>, value: string) : NetworkfirewallFirewallState<Present, 'Name, 'SubnetMapping, 'VpcId> =
            state.assignments.Add(fun config -> config.FirewallPolicyArn <- value)
            ({ assignments = state.assignments } : NetworkfirewallFirewallState<Present, 'Name, 'SubnetMapping, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall#name-1">NetworkfirewallFirewall#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkfirewallFirewallState<'FirewallPolicyArn, Missing, 'SubnetMapping, 'VpcId>, value: string) : NetworkfirewallFirewallState<'FirewallPolicyArn, Present, 'SubnetMapping, 'VpcId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkfirewallFirewallState<'FirewallPolicyArn, Present, 'SubnetMapping, 'VpcId>)

        /// <summary>
        /// subnet_mapping block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall#subnet_mapping-1">NetworkfirewallFirewall#subnet_mapping</a> Accepts: aws.IResolvable | aws.NetworkfirewallFirewall.NetworkfirewallFirewallSubnetMapping[]
        /// </summary>
        [<CustomOperation "subnet_mapping">]
        member _.SubnetMapping(state: NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, Missing, 'VpcId>, value: HashiCorp.Cdktf.IResolvable) : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, Present, 'VpcId> =
            state.assignments.Add(fun config -> config.SubnetMapping <- value)
            ({ assignments = state.assignments } : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, Present, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall#vpc_id-1">NetworkfirewallFirewall#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, Missing>, value: string) : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall#delete_protection-1">NetworkfirewallFirewall#delete_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection(state: NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>, value: bool) : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId> =
            state.assignments.Add(fun config -> config.DeleteProtection <- value)
            state : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall#delete_protection-1">NetworkfirewallFirewall#delete_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection(state: NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>, value: HashiCorp.Cdktf.IResolvable) : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId> =
            state.assignments.Add(fun config -> config.DeleteProtection <- value)
            state : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall#description-1">NetworkfirewallFirewall#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>, value: string) : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall#enabled_analysis_types-1">NetworkfirewallFirewall#enabled_analysis_types</a>.
        /// </summary>
        [<CustomOperation "enabled_analysis_types">]
        member _.EnabledAnalysisTypes(state: NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>, value: seq<string>) : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId> =
            state.assignments.Add(fun config -> config.EnabledAnalysisTypes <- (value |> Seq.toArray))
            state : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>

        /// <summary>
        /// encryption_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall#encryption_configuration-1">NetworkfirewallFirewall#encryption_configuration</a>
        /// </summary>
        [<CustomOperation "encryption_configuration">]
        member _.EncryptionConfiguration(state: NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>, value: aws.NetworkfirewallFirewall.NetworkfirewallFirewallEncryptionConfiguration) : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId> =
            state.assignments.Add(fun config -> config.EncryptionConfiguration <- value)
            state : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall#firewall_policy_change_protection-1">NetworkfirewallFirewall#firewall_policy_change_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "firewall_policy_change_protection">]
        member _.FirewallPolicyChangeProtection(state: NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>, value: bool) : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId> =
            state.assignments.Add(fun config -> config.FirewallPolicyChangeProtection <- value)
            state : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall#firewall_policy_change_protection-1">NetworkfirewallFirewall#firewall_policy_change_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "firewall_policy_change_protection">]
        member _.FirewallPolicyChangeProtection(state: NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>, value: HashiCorp.Cdktf.IResolvable) : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId> =
            state.assignments.Add(fun config -> config.FirewallPolicyChangeProtection <- value)
            state : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall#id-1">NetworkfirewallFirewall#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>, value: string) : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall#subnet_change_protection-1">NetworkfirewallFirewall#subnet_change_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "subnet_change_protection">]
        member _.SubnetChangeProtection(state: NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>, value: bool) : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId> =
            state.assignments.Add(fun config -> config.SubnetChangeProtection <- value)
            state : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall#subnet_change_protection-1">NetworkfirewallFirewall#subnet_change_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "subnet_change_protection">]
        member _.SubnetChangeProtection(state: NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>, value: HashiCorp.Cdktf.IResolvable) : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId> =
            state.assignments.Add(fun config -> config.SubnetChangeProtection <- value)
            state : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall#tags-1">NetworkfirewallFirewall#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>, value: seq<string * string>) : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall#tags_all-1">NetworkfirewallFirewall#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>, value: seq<string * string>) : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall#timeouts-1">NetworkfirewallFirewall#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>, value: aws.NetworkfirewallFirewall.NetworkfirewallFirewallTimeouts) : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkfirewallFirewallState<'FirewallPolicyArn, 'Name, 'SubnetMapping, 'VpcId>

        member _.Run(state: NetworkfirewallFirewallState<Present, Present, Present, Present>) : aws.NetworkfirewallFirewall.NetworkfirewallFirewall =
            let config = aws.NetworkfirewallFirewall.NetworkfirewallFirewallConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkfirewallFirewall.NetworkfirewallFirewall(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkfirewallFirewall: missing required arguments. Must call: firewall_policy_arn, name, subnet_mapping, vpc_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkfirewallFirewallState<_, _, _, _>) : aws.NetworkfirewallFirewall.NetworkfirewallFirewall =
            Unchecked.defaultof<aws.NetworkfirewallFirewall.NetworkfirewallFirewall>

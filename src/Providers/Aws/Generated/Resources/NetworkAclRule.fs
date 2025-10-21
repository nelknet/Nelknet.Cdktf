namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber> = { assignments: ResizeArray<aws.NetworkAclRule.NetworkAclRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl_rule">aws_network_acl_rule</a>.
    /// </summary>
    type NetworkAclRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkAclRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkAclRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetworkAclRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkAclRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl_rule#network_acl_id-1">NetworkAclRule#network_acl_id</a>.
        /// </summary>
        [<CustomOperation "network_acl_id">]
        member _.NetworkAclId(state: NetworkAclRuleState<Missing, 'Protocol, 'RuleAction, 'RuleNumber>, value: string) : NetworkAclRuleState<Present, 'Protocol, 'RuleAction, 'RuleNumber> =
            state.assignments.Add(fun config -> config.NetworkAclId <- value)
            ({ assignments = state.assignments } : NetworkAclRuleState<Present, 'Protocol, 'RuleAction, 'RuleNumber>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl_rule#protocol-1">NetworkAclRule#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: NetworkAclRuleState<'NetworkAclId, Missing, 'RuleAction, 'RuleNumber>, value: string) : NetworkAclRuleState<'NetworkAclId, Present, 'RuleAction, 'RuleNumber> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            ({ assignments = state.assignments } : NetworkAclRuleState<'NetworkAclId, Present, 'RuleAction, 'RuleNumber>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl_rule#rule_action-1">NetworkAclRule#rule_action</a>.
        /// </summary>
        [<CustomOperation "rule_action">]
        member _.RuleAction(state: NetworkAclRuleState<'NetworkAclId, 'Protocol, Missing, 'RuleNumber>, value: string) : NetworkAclRuleState<'NetworkAclId, 'Protocol, Present, 'RuleNumber> =
            state.assignments.Add(fun config -> config.RuleAction <- value)
            ({ assignments = state.assignments } : NetworkAclRuleState<'NetworkAclId, 'Protocol, Present, 'RuleNumber>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl_rule#rule_number-1">NetworkAclRule#rule_number</a>.
        /// </summary>
        [<CustomOperation "rule_number">]
        member _.RuleNumber(state: NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, Missing>, value: double) : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, Present> =
            state.assignments.Add(fun config -> config.RuleNumber <- value)
            ({ assignments = state.assignments } : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl_rule#cidr_block-1">NetworkAclRule#cidr_block</a>.
        /// </summary>
        [<CustomOperation "cidr_block">]
        member _.CidrBlock(state: NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber>, value: string) : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber> =
            state.assignments.Add(fun config -> config.CidrBlock <- value)
            state : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl_rule#egress-1">NetworkAclRule#egress</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "egress">]
        member _.Egress(state: NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber>, value: bool) : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber> =
            state.assignments.Add(fun config -> config.Egress <- value)
            state : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl_rule#egress-1">NetworkAclRule#egress</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "egress">]
        member _.Egress(state: NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber>, value: HashiCorp.Cdktf.IResolvable) : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber> =
            state.assignments.Add(fun config -> config.Egress <- value)
            state : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl_rule#from_port-1">NetworkAclRule#from_port</a>.
        /// </summary>
        [<CustomOperation "from_port">]
        member _.FromPort(state: NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber>, value: double) : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber> =
            state.assignments.Add(fun config -> config.FromPort <- value)
            state : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl_rule#icmp_code-1">NetworkAclRule#icmp_code</a>.
        /// </summary>
        [<CustomOperation "icmp_code">]
        member _.IcmpCode(state: NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber>, value: double) : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber> =
            state.assignments.Add(fun config -> config.IcmpCode <- value)
            state : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl_rule#icmp_type-1">NetworkAclRule#icmp_type</a>.
        /// </summary>
        [<CustomOperation "icmp_type">]
        member _.IcmpType(state: NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber>, value: double) : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber> =
            state.assignments.Add(fun config -> config.IcmpType <- value)
            state : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl_rule#id-1">NetworkAclRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber>, value: string) : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl_rule#ipv6_cidr_block-1">NetworkAclRule#ipv6_cidr_block</a>.
        /// </summary>
        [<CustomOperation "ipv6_cidr_block">]
        member _.Ipv6CidrBlock(state: NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber>, value: string) : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber> =
            state.assignments.Add(fun config -> config.Ipv6CidrBlock <- value)
            state : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl_rule#to_port-1">NetworkAclRule#to_port</a>.
        /// </summary>
        [<CustomOperation "to_port">]
        member _.ToPort(state: NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber>, value: double) : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber> =
            state.assignments.Add(fun config -> config.ToPort <- value)
            state : NetworkAclRuleState<'NetworkAclId, 'Protocol, 'RuleAction, 'RuleNumber>

        member _.Run(state: NetworkAclRuleState<Present, Present, Present, Present>) : aws.NetworkAclRule.NetworkAclRule =
            let config = aws.NetworkAclRule.NetworkAclRuleConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkAclRule.NetworkAclRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkAclRule: missing required arguments. Must call: network_acl_id, protocol, rule_action, rule_number.", 9999, IsError = true)>]
        member _.Run(_: NetworkAclRuleState<_, _, _, _>) : aws.NetworkAclRule.NetworkAclRule =
            Unchecked.defaultof<aws.NetworkAclRule.NetworkAclRule>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId> = { assignments: ResizeArray<aws.VpcSecurityGroupEgressRule.VpcSecurityGroupEgressRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_egress_rule">aws_vpc_security_group_egress_rule</a>.
    /// </summary>
    type VpcSecurityGroupEgressRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcSecurityGroupEgressRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcSecurityGroupEgressRuleState<Missing, Missing>)

        member _.Zero(()) : VpcSecurityGroupEgressRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcSecurityGroupEgressRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_egress_rule#ip_protocol-1">VpcSecurityGroupEgressRule#ip_protocol</a>.
        /// </summary>
        [<CustomOperation "ip_protocol">]
        member _.IpProtocol(state: VpcSecurityGroupEgressRuleState<Missing, 'SecurityGroupId>, value: string) : VpcSecurityGroupEgressRuleState<Present, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.IpProtocol <- value)
            ({ assignments = state.assignments } : VpcSecurityGroupEgressRuleState<Present, 'SecurityGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_egress_rule#security_group_id-1">VpcSecurityGroupEgressRule#security_group_id</a>.
        /// </summary>
        [<CustomOperation "security_group_id">]
        member _.SecurityGroupId(state: VpcSecurityGroupEgressRuleState<'IpProtocol, Missing>, value: string) : VpcSecurityGroupEgressRuleState<'IpProtocol, Present> =
            state.assignments.Add(fun config -> config.SecurityGroupId <- value)
            ({ assignments = state.assignments } : VpcSecurityGroupEgressRuleState<'IpProtocol, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_egress_rule#cidr_ipv4-1">VpcSecurityGroupEgressRule#cidr_ipv4</a>.
        /// </summary>
        [<CustomOperation "cidr_ipv4">]
        member _.CidrIpv4(state: VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId>, value: string) : VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.CidrIpv4 <- value)
            state : VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_egress_rule#cidr_ipv6-1">VpcSecurityGroupEgressRule#cidr_ipv6</a>.
        /// </summary>
        [<CustomOperation "cidr_ipv6">]
        member _.CidrIpv6(state: VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId>, value: string) : VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.CidrIpv6 <- value)
            state : VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_egress_rule#description-1">VpcSecurityGroupEgressRule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId>, value: string) : VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_egress_rule#from_port-1">VpcSecurityGroupEgressRule#from_port</a>.
        /// </summary>
        [<CustomOperation "from_port">]
        member _.FromPort(state: VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId>, value: double) : VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.FromPort <- value)
            state : VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_egress_rule#prefix_list_id-1">VpcSecurityGroupEgressRule#prefix_list_id</a>.
        /// </summary>
        [<CustomOperation "prefix_list_id">]
        member _.PrefixListId(state: VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId>, value: string) : VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.PrefixListId <- value)
            state : VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_egress_rule#referenced_security_group_id-1">VpcSecurityGroupEgressRule#referenced_security_group_id</a>.
        /// </summary>
        [<CustomOperation "referenced_security_group_id">]
        member _.ReferencedSecurityGroupId(state: VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId>, value: string) : VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.ReferencedSecurityGroupId <- value)
            state : VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_egress_rule#tags-1">VpcSecurityGroupEgressRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId>, value: seq<string * string>) : VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_egress_rule#to_port-1">VpcSecurityGroupEgressRule#to_port</a>.
        /// </summary>
        [<CustomOperation "to_port">]
        member _.ToPort(state: VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId>, value: double) : VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.ToPort <- value)
            state : VpcSecurityGroupEgressRuleState<'IpProtocol, 'SecurityGroupId>

        member _.Run(state: VpcSecurityGroupEgressRuleState<Present, Present>) : aws.VpcSecurityGroupEgressRule.VpcSecurityGroupEgressRule =
            let config = aws.VpcSecurityGroupEgressRule.VpcSecurityGroupEgressRuleConfig()
            for setter in state.assignments do
                setter config
            aws.VpcSecurityGroupEgressRule.VpcSecurityGroupEgressRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcSecurityGroupEgressRule: missing required arguments. Must call: ip_protocol, security_group_id.", 9999, IsError = true)>]
        member _.Run(_: VpcSecurityGroupEgressRuleState<_, _>) : aws.VpcSecurityGroupEgressRule.VpcSecurityGroupEgressRule =
            Unchecked.defaultof<aws.VpcSecurityGroupEgressRule.VpcSecurityGroupEgressRule>

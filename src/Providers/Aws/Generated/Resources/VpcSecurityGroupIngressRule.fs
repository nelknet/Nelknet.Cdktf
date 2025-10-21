namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId> = { assignments: ResizeArray<aws.VpcSecurityGroupIngressRule.VpcSecurityGroupIngressRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_ingress_rule">aws_vpc_security_group_ingress_rule</a>.
    /// </summary>
    type VpcSecurityGroupIngressRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcSecurityGroupIngressRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcSecurityGroupIngressRuleState<Missing, Missing>)

        member _.Zero(()) : VpcSecurityGroupIngressRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcSecurityGroupIngressRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_ingress_rule#ip_protocol-1">VpcSecurityGroupIngressRule#ip_protocol</a>.
        /// </summary>
        [<CustomOperation "ip_protocol">]
        member _.IpProtocol(state: VpcSecurityGroupIngressRuleState<Missing, 'SecurityGroupId>, value: string) : VpcSecurityGroupIngressRuleState<Present, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.IpProtocol <- value)
            ({ assignments = state.assignments } : VpcSecurityGroupIngressRuleState<Present, 'SecurityGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_ingress_rule#security_group_id-1">VpcSecurityGroupIngressRule#security_group_id</a>.
        /// </summary>
        [<CustomOperation "security_group_id">]
        member _.SecurityGroupId(state: VpcSecurityGroupIngressRuleState<'IpProtocol, Missing>, value: string) : VpcSecurityGroupIngressRuleState<'IpProtocol, Present> =
            state.assignments.Add(fun config -> config.SecurityGroupId <- value)
            ({ assignments = state.assignments } : VpcSecurityGroupIngressRuleState<'IpProtocol, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_ingress_rule#cidr_ipv4-1">VpcSecurityGroupIngressRule#cidr_ipv4</a>.
        /// </summary>
        [<CustomOperation "cidr_ipv4">]
        member _.CidrIpv4(state: VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId>, value: string) : VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.CidrIpv4 <- value)
            state : VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_ingress_rule#cidr_ipv6-1">VpcSecurityGroupIngressRule#cidr_ipv6</a>.
        /// </summary>
        [<CustomOperation "cidr_ipv6">]
        member _.CidrIpv6(state: VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId>, value: string) : VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.CidrIpv6 <- value)
            state : VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_ingress_rule#description-1">VpcSecurityGroupIngressRule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId>, value: string) : VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_ingress_rule#from_port-1">VpcSecurityGroupIngressRule#from_port</a>.
        /// </summary>
        [<CustomOperation "from_port">]
        member _.FromPort(state: VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId>, value: double) : VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.FromPort <- value)
            state : VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_ingress_rule#prefix_list_id-1">VpcSecurityGroupIngressRule#prefix_list_id</a>.
        /// </summary>
        [<CustomOperation "prefix_list_id">]
        member _.PrefixListId(state: VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId>, value: string) : VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.PrefixListId <- value)
            state : VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_ingress_rule#referenced_security_group_id-1">VpcSecurityGroupIngressRule#referenced_security_group_id</a>.
        /// </summary>
        [<CustomOperation "referenced_security_group_id">]
        member _.ReferencedSecurityGroupId(state: VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId>, value: string) : VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.ReferencedSecurityGroupId <- value)
            state : VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_ingress_rule#tags-1">VpcSecurityGroupIngressRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId>, value: seq<string * string>) : VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_security_group_ingress_rule#to_port-1">VpcSecurityGroupIngressRule#to_port</a>.
        /// </summary>
        [<CustomOperation "to_port">]
        member _.ToPort(state: VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId>, value: double) : VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId> =
            state.assignments.Add(fun config -> config.ToPort <- value)
            state : VpcSecurityGroupIngressRuleState<'IpProtocol, 'SecurityGroupId>

        member _.Run(state: VpcSecurityGroupIngressRuleState<Present, Present>) : aws.VpcSecurityGroupIngressRule.VpcSecurityGroupIngressRule =
            let config = aws.VpcSecurityGroupIngressRule.VpcSecurityGroupIngressRuleConfig()
            for setter in state.assignments do
                setter config
            aws.VpcSecurityGroupIngressRule.VpcSecurityGroupIngressRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcSecurityGroupIngressRule: missing required arguments. Must call: ip_protocol, security_group_id.", 9999, IsError = true)>]
        member _.Run(_: VpcSecurityGroupIngressRuleState<_, _>) : aws.VpcSecurityGroupIngressRule.VpcSecurityGroupIngressRule =
            Unchecked.defaultof<aws.VpcSecurityGroupIngressRule.VpcSecurityGroupIngressRule>

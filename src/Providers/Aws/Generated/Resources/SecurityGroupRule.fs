namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type> = { assignments: ResizeArray<aws.SecurityGroupRule.SecurityGroupRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group_rule">aws_security_group_rule</a>.
    /// </summary>
    type SecurityGroupRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityGroupRuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityGroupRuleState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SecurityGroupRuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityGroupRuleState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group_rule#from_port-1">SecurityGroupRule#from_port</a>.
        /// </summary>
        [<CustomOperation "from_port">]
        member _.FromPort(state: SecurityGroupRuleState<Missing, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>, value: double) : SecurityGroupRuleState<Present, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type> =
            state.assignments.Add(fun config -> config.FromPort <- value)
            ({ assignments = state.assignments } : SecurityGroupRuleState<Present, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group_rule#protocol-1">SecurityGroupRule#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: SecurityGroupRuleState<'FromPort, Missing, 'SecurityGroupId, 'ToPort, 'Type>, value: string) : SecurityGroupRuleState<'FromPort, Present, 'SecurityGroupId, 'ToPort, 'Type> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            ({ assignments = state.assignments } : SecurityGroupRuleState<'FromPort, Present, 'SecurityGroupId, 'ToPort, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group_rule#security_group_id-1">SecurityGroupRule#security_group_id</a>.
        /// </summary>
        [<CustomOperation "security_group_id">]
        member _.SecurityGroupId(state: SecurityGroupRuleState<'FromPort, 'Protocol, Missing, 'ToPort, 'Type>, value: string) : SecurityGroupRuleState<'FromPort, 'Protocol, Present, 'ToPort, 'Type> =
            state.assignments.Add(fun config -> config.SecurityGroupId <- value)
            ({ assignments = state.assignments } : SecurityGroupRuleState<'FromPort, 'Protocol, Present, 'ToPort, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group_rule#to_port-1">SecurityGroupRule#to_port</a>.
        /// </summary>
        [<CustomOperation "to_port">]
        member _.ToPort(state: SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, Missing, 'Type>, value: double) : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, Present, 'Type> =
            state.assignments.Add(fun config -> config.ToPort <- value)
            ({ assignments = state.assignments } : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group_rule#type-1">SecurityGroupRule#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, Missing>, value: string) : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group_rule#cidr_blocks-1">SecurityGroupRule#cidr_blocks</a>.
        /// </summary>
        [<CustomOperation "cidr_blocks">]
        member _.CidrBlocks(state: SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>, value: seq<string>) : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type> =
            state.assignments.Add(fun config -> config.CidrBlocks <- (value |> Seq.toArray))
            state : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group_rule#description-1">SecurityGroupRule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>, value: string) : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group_rule#id-1">SecurityGroupRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>, value: string) : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group_rule#ipv6_cidr_blocks-1">SecurityGroupRule#ipv6_cidr_blocks</a>.
        /// </summary>
        [<CustomOperation "ipv6_cidr_blocks">]
        member _.Ipv6CidrBlocks(state: SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>, value: seq<string>) : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type> =
            state.assignments.Add(fun config -> config.Ipv6CidrBlocks <- (value |> Seq.toArray))
            state : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group_rule#prefix_list_ids-1">SecurityGroupRule#prefix_list_ids</a>.
        /// </summary>
        [<CustomOperation "prefix_list_ids">]
        member _.PrefixListIds(state: SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>, value: seq<string>) : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type> =
            state.assignments.Add(fun config -> config.PrefixListIds <- (value |> Seq.toArray))
            state : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group_rule#self-1">SecurityGroupRule#self</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "self_attribute">]
        member _.SelfAttribute(state: SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>, value: bool) : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type> =
            state.assignments.Add(fun config -> config.SelfAttribute <- value)
            state : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group_rule#self-1">SecurityGroupRule#self</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "self_attribute">]
        member _.SelfAttribute(state: SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>, value: HashiCorp.Cdktf.IResolvable) : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type> =
            state.assignments.Add(fun config -> config.SelfAttribute <- value)
            state : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group_rule#source_security_group_id-1">SecurityGroupRule#source_security_group_id</a>.
        /// </summary>
        [<CustomOperation "source_security_group_id">]
        member _.SourceSecurityGroupId(state: SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>, value: string) : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type> =
            state.assignments.Add(fun config -> config.SourceSecurityGroupId <- value)
            state : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group_rule#timeouts-1">SecurityGroupRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>, value: aws.SecurityGroupRule.SecurityGroupRuleTimeouts) : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SecurityGroupRuleState<'FromPort, 'Protocol, 'SecurityGroupId, 'ToPort, 'Type>

        member _.Run(state: SecurityGroupRuleState<Present, Present, Present, Present, Present>) : aws.SecurityGroupRule.SecurityGroupRule =
            let config = aws.SecurityGroupRule.SecurityGroupRuleConfig()
            for setter in state.assignments do
                setter config
            aws.SecurityGroupRule.SecurityGroupRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.securityGroupRule: missing required arguments. Must call: from_port, protocol, security_group_id, to_port, type.", 9999, IsError = true)>]
        member _.Run(_: SecurityGroupRuleState<_, _, _, _, _>) : aws.SecurityGroupRule.SecurityGroupRule =
            Unchecked.defaultof<aws.SecurityGroupRule.SecurityGroupRule>

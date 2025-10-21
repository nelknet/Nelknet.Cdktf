namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpcSecurityGroupRuleState = { assignments: ResizeArray<aws.DataAwsVpcSecurityGroupRule.DataAwsVpcSecurityGroupRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_security_group_rule">aws_vpc_security_group_rule</a>.
    /// </summary>
    type DataAwsVpcSecurityGroupRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpcSecurityGroupRuleState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsVpcSecurityGroupRuleState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_security_group_rule#filter-1">DataAwsVpcSecurityGroupRule#filter</a> Accepts: aws.IResolvable | aws.DataAwsVpcSecurityGroupRule.DataAwsVpcSecurityGroupRuleFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsVpcSecurityGroupRuleState, value: HashiCorp.Cdktf.IResolvable) : DataAwsVpcSecurityGroupRuleState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsVpcSecurityGroupRuleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_security_group_rule#security_group_rule_id-1">DataAwsVpcSecurityGroupRule#security_group_rule_id</a>.
        /// </summary>
        [<CustomOperation "security_group_rule_id">]
        member _.SecurityGroupRuleId(state: DataAwsVpcSecurityGroupRuleState, value: string) : DataAwsVpcSecurityGroupRuleState =
            state.assignments.Add(fun config -> config.SecurityGroupRuleId <- value)
            state : DataAwsVpcSecurityGroupRuleState

        member _.Run(state: DataAwsVpcSecurityGroupRuleState) : aws.DataAwsVpcSecurityGroupRule.DataAwsVpcSecurityGroupRule =
            let config = aws.DataAwsVpcSecurityGroupRule.DataAwsVpcSecurityGroupRuleConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpcSecurityGroupRule.DataAwsVpcSecurityGroupRule(StackContext.get (), logicalId, config)

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpcSecurityGroupRulesState = { assignments: ResizeArray<aws.DataAwsVpcSecurityGroupRules.DataAwsVpcSecurityGroupRulesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_security_group_rules">aws_vpc_security_group_rules</a>.
    /// </summary>
    type DataAwsVpcSecurityGroupRulesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpcSecurityGroupRulesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsVpcSecurityGroupRulesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_security_group_rules#filter-1">DataAwsVpcSecurityGroupRules#filter</a> Accepts: aws.IResolvable | aws.DataAwsVpcSecurityGroupRules.DataAwsVpcSecurityGroupRulesFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsVpcSecurityGroupRulesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsVpcSecurityGroupRulesState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsVpcSecurityGroupRulesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_security_group_rules#tags-1">DataAwsVpcSecurityGroupRules#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsVpcSecurityGroupRulesState, value: seq<string * string>) : DataAwsVpcSecurityGroupRulesState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsVpcSecurityGroupRulesState

        member _.Run(state: DataAwsVpcSecurityGroupRulesState) : aws.DataAwsVpcSecurityGroupRules.DataAwsVpcSecurityGroupRules =
            let config = aws.DataAwsVpcSecurityGroupRules.DataAwsVpcSecurityGroupRulesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpcSecurityGroupRules.DataAwsVpcSecurityGroupRules(StackContext.get (), logicalId, config)

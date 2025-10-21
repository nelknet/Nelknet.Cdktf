namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DefaultSecurityGroupState = { assignments: ResizeArray<aws.DefaultSecurityGroup.DefaultSecurityGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_security_group">aws_default_security_group</a>.
    /// </summary>
    type DefaultSecurityGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DefaultSecurityGroupState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DefaultSecurityGroupState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_security_group#egress-1">DefaultSecurityGroup#egress</a>. Accepts: aws.IResolvable | aws.DefaultSecurityGroup.DefaultSecurityGroupEgress[]
        /// </summary>
        [<CustomOperation "egress">]
        member _.Egress(state: DefaultSecurityGroupState, value: HashiCorp.Cdktf.IResolvable) : DefaultSecurityGroupState =
            state.assignments.Add(fun config -> config.Egress <- value)
            state : DefaultSecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_security_group#id-1">DefaultSecurityGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DefaultSecurityGroupState, value: string) : DefaultSecurityGroupState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DefaultSecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_security_group#ingress-1">DefaultSecurityGroup#ingress</a>. Accepts: aws.IResolvable | aws.DefaultSecurityGroup.DefaultSecurityGroupIngress[]
        /// </summary>
        [<CustomOperation "ingress">]
        member _.Ingress(state: DefaultSecurityGroupState, value: HashiCorp.Cdktf.IResolvable) : DefaultSecurityGroupState =
            state.assignments.Add(fun config -> config.Ingress <- value)
            state : DefaultSecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_security_group#revoke_rules_on_delete-1">DefaultSecurityGroup#revoke_rules_on_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "revoke_rules_on_delete">]
        member _.RevokeRulesOnDelete(state: DefaultSecurityGroupState, value: bool) : DefaultSecurityGroupState =
            state.assignments.Add(fun config -> config.RevokeRulesOnDelete <- value)
            state : DefaultSecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_security_group#revoke_rules_on_delete-1">DefaultSecurityGroup#revoke_rules_on_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "revoke_rules_on_delete">]
        member _.RevokeRulesOnDelete(state: DefaultSecurityGroupState, value: HashiCorp.Cdktf.IResolvable) : DefaultSecurityGroupState =
            state.assignments.Add(fun config -> config.RevokeRulesOnDelete <- value)
            state : DefaultSecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_security_group#tags-1">DefaultSecurityGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DefaultSecurityGroupState, value: seq<string * string>) : DefaultSecurityGroupState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DefaultSecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_security_group#tags_all-1">DefaultSecurityGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DefaultSecurityGroupState, value: seq<string * string>) : DefaultSecurityGroupState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DefaultSecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_security_group#vpc_id-1">DefaultSecurityGroup#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: DefaultSecurityGroupState, value: string) : DefaultSecurityGroupState =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : DefaultSecurityGroupState

        member _.Run(state: DefaultSecurityGroupState) : aws.DefaultSecurityGroup.DefaultSecurityGroup =
            let config = aws.DefaultSecurityGroup.DefaultSecurityGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DefaultSecurityGroup.DefaultSecurityGroup(StackContext.get (), logicalId, config)

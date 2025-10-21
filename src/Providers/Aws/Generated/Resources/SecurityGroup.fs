namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityGroupState = { assignments: ResizeArray<aws.SecurityGroup.SecurityGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group">aws_security_group</a>.
    /// </summary>
    type SecurityGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityGroupState =
            { assignments = ResizeArray() }

        member _.Zero(()) : SecurityGroupState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group#description-1">SecurityGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SecurityGroupState, value: string) : SecurityGroupState =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group#egress-1">SecurityGroup#egress</a>. Accepts: aws.IResolvable | aws.SecurityGroup.SecurityGroupEgress[]
        /// </summary>
        [<CustomOperation "egress">]
        member _.Egress(state: SecurityGroupState, value: HashiCorp.Cdktf.IResolvable) : SecurityGroupState =
            state.assignments.Add(fun config -> config.Egress <- value)
            state : SecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group#id-1">SecurityGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityGroupState, value: string) : SecurityGroupState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group#ingress-1">SecurityGroup#ingress</a>. Accepts: aws.IResolvable | aws.SecurityGroup.SecurityGroupIngress[]
        /// </summary>
        [<CustomOperation "ingress">]
        member _.Ingress(state: SecurityGroupState, value: HashiCorp.Cdktf.IResolvable) : SecurityGroupState =
            state.assignments.Add(fun config -> config.Ingress <- value)
            state : SecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group#name-1">SecurityGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SecurityGroupState, value: string) : SecurityGroupState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group#name_prefix-1">SecurityGroup#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: SecurityGroupState, value: string) : SecurityGroupState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : SecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group#revoke_rules_on_delete-1">SecurityGroup#revoke_rules_on_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "revoke_rules_on_delete">]
        member _.RevokeRulesOnDelete(state: SecurityGroupState, value: bool) : SecurityGroupState =
            state.assignments.Add(fun config -> config.RevokeRulesOnDelete <- value)
            state : SecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group#revoke_rules_on_delete-1">SecurityGroup#revoke_rules_on_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "revoke_rules_on_delete">]
        member _.RevokeRulesOnDelete(state: SecurityGroupState, value: HashiCorp.Cdktf.IResolvable) : SecurityGroupState =
            state.assignments.Add(fun config -> config.RevokeRulesOnDelete <- value)
            state : SecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group#tags-1">SecurityGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SecurityGroupState, value: seq<string * string>) : SecurityGroupState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group#tags_all-1">SecurityGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SecurityGroupState, value: seq<string * string>) : SecurityGroupState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SecurityGroupState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group#timeouts-1">SecurityGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SecurityGroupState, value: aws.SecurityGroup.SecurityGroupTimeouts) : SecurityGroupState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/security_group#vpc_id-1">SecurityGroup#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: SecurityGroupState, value: string) : SecurityGroupState =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : SecurityGroupState

        member _.Run(state: SecurityGroupState) : aws.SecurityGroup.SecurityGroup =
            let config = aws.SecurityGroup.SecurityGroupConfig()
            for setter in state.assignments do
                setter config
            aws.SecurityGroup.SecurityGroup(StackContext.get (), logicalId, config)

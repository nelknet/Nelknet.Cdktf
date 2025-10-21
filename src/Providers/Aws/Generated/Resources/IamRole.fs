namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamRoleState<'AssumeRolePolicy> = { assignments: ResizeArray<aws.IamRole.IamRoleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role">aws_iam_role</a>.
    /// </summary>
    type IamRoleBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamRoleState<Missing> =
            ({ assignments = ResizeArray() } : IamRoleState<Missing>)

        member _.Zero(()) : IamRoleState<Missing> =
            ({ assignments = ResizeArray() } : IamRoleState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role#assume_role_policy-1">IamRole#assume_role_policy</a>.
        /// </summary>
        [<CustomOperation "assume_role_policy">]
        member _.AssumeRolePolicy(state: IamRoleState<Missing>, value: string) : IamRoleState<Present> =
            state.assignments.Add(fun config -> config.AssumeRolePolicy <- value)
            ({ assignments = state.assignments } : IamRoleState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role#description-1">IamRole#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: IamRoleState<'AssumeRolePolicy>, value: string) : IamRoleState<'AssumeRolePolicy> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : IamRoleState<'AssumeRolePolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role#force_detach_policies-1">IamRole#force_detach_policies</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_detach_policies">]
        member _.ForceDetachPolicies(state: IamRoleState<'AssumeRolePolicy>, value: bool) : IamRoleState<'AssumeRolePolicy> =
            state.assignments.Add(fun config -> config.ForceDetachPolicies <- value)
            state : IamRoleState<'AssumeRolePolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role#force_detach_policies-1">IamRole#force_detach_policies</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_detach_policies">]
        member _.ForceDetachPolicies(state: IamRoleState<'AssumeRolePolicy>, value: HashiCorp.Cdktf.IResolvable) : IamRoleState<'AssumeRolePolicy> =
            state.assignments.Add(fun config -> config.ForceDetachPolicies <- value)
            state : IamRoleState<'AssumeRolePolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role#id-1">IamRole#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamRoleState<'AssumeRolePolicy>, value: string) : IamRoleState<'AssumeRolePolicy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamRoleState<'AssumeRolePolicy>

        /// <summary>
        /// inline_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role#inline_policy-1">IamRole#inline_policy</a> Accepts: aws.IResolvable | aws.IamRole.IamRoleInlinePolicy[]
        /// </summary>
        [<CustomOperation "inline_policy">]
        member _.InlinePolicy(state: IamRoleState<'AssumeRolePolicy>, value: HashiCorp.Cdktf.IResolvable) : IamRoleState<'AssumeRolePolicy> =
            state.assignments.Add(fun config -> config.InlinePolicy <- value)
            state : IamRoleState<'AssumeRolePolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role#managed_policy_arns-1">IamRole#managed_policy_arns</a>.
        /// </summary>
        [<CustomOperation "managed_policy_arns">]
        member _.ManagedPolicyArns(state: IamRoleState<'AssumeRolePolicy>, value: seq<string>) : IamRoleState<'AssumeRolePolicy> =
            state.assignments.Add(fun config -> config.ManagedPolicyArns <- (value |> Seq.toArray))
            state : IamRoleState<'AssumeRolePolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role#max_session_duration-1">IamRole#max_session_duration</a>.
        /// </summary>
        [<CustomOperation "max_session_duration">]
        member _.MaxSessionDuration(state: IamRoleState<'AssumeRolePolicy>, value: double) : IamRoleState<'AssumeRolePolicy> =
            state.assignments.Add(fun config -> config.MaxSessionDuration <- value)
            state : IamRoleState<'AssumeRolePolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role#name-1">IamRole#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IamRoleState<'AssumeRolePolicy>, value: string) : IamRoleState<'AssumeRolePolicy> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : IamRoleState<'AssumeRolePolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role#name_prefix-1">IamRole#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: IamRoleState<'AssumeRolePolicy>, value: string) : IamRoleState<'AssumeRolePolicy> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : IamRoleState<'AssumeRolePolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role#path-1">IamRole#path</a>.
        /// </summary>
        [<CustomOperation "path">]
        member _.Path(state: IamRoleState<'AssumeRolePolicy>, value: string) : IamRoleState<'AssumeRolePolicy> =
            state.assignments.Add(fun config -> config.Path <- value)
            state : IamRoleState<'AssumeRolePolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role#permissions_boundary-1">IamRole#permissions_boundary</a>.
        /// </summary>
        [<CustomOperation "permissions_boundary">]
        member _.PermissionsBoundary(state: IamRoleState<'AssumeRolePolicy>, value: string) : IamRoleState<'AssumeRolePolicy> =
            state.assignments.Add(fun config -> config.PermissionsBoundary <- value)
            state : IamRoleState<'AssumeRolePolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role#tags-1">IamRole#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IamRoleState<'AssumeRolePolicy>, value: seq<string * string>) : IamRoleState<'AssumeRolePolicy> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IamRoleState<'AssumeRolePolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role#tags_all-1">IamRole#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IamRoleState<'AssumeRolePolicy>, value: seq<string * string>) : IamRoleState<'AssumeRolePolicy> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IamRoleState<'AssumeRolePolicy>

        member _.Run(state: IamRoleState<Present>) : aws.IamRole.IamRole =
            let config = aws.IamRole.IamRoleConfig()
            for setter in state.assignments do
                setter config
            aws.IamRole.IamRole(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamRole: missing required arguments. Must call: assume_role_policy.", 9999, IsError = true)>]
        member _.Run(_: IamRoleState<_>) : aws.IamRole.IamRole =
            Unchecked.defaultof<aws.IamRole.IamRole>

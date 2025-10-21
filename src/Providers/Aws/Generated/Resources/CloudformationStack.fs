namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudformationStackState<'Name> = { assignments: ResizeArray<aws.CloudformationStack.CloudformationStackConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack">aws_cloudformation_stack</a>.
    /// </summary>
    type CloudformationStackBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudformationStackState<Missing> =
            ({ assignments = ResizeArray() } : CloudformationStackState<Missing>)

        member _.Zero(()) : CloudformationStackState<Missing> =
            ({ assignments = ResizeArray() } : CloudformationStackState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack#name-1">CloudformationStack#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudformationStackState<Missing>, value: string) : CloudformationStackState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudformationStackState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack#capabilities-1">CloudformationStack#capabilities</a>.
        /// </summary>
        [<CustomOperation "capabilities">]
        member _.Capabilities(state: CloudformationStackState<'Name>, value: seq<string>) : CloudformationStackState<'Name> =
            state.assignments.Add(fun config -> config.Capabilities <- (value |> Seq.toArray))
            state : CloudformationStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack#disable_rollback-1">CloudformationStack#disable_rollback</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_rollback">]
        member _.DisableRollback(state: CloudformationStackState<'Name>, value: bool) : CloudformationStackState<'Name> =
            state.assignments.Add(fun config -> config.DisableRollback <- value)
            state : CloudformationStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack#disable_rollback-1">CloudformationStack#disable_rollback</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_rollback">]
        member _.DisableRollback(state: CloudformationStackState<'Name>, value: HashiCorp.Cdktf.IResolvable) : CloudformationStackState<'Name> =
            state.assignments.Add(fun config -> config.DisableRollback <- value)
            state : CloudformationStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack#iam_role_arn-1">CloudformationStack#iam_role_arn</a>.
        /// </summary>
        [<CustomOperation "iam_role_arn">]
        member _.IamRoleArn(state: CloudformationStackState<'Name>, value: string) : CloudformationStackState<'Name> =
            state.assignments.Add(fun config -> config.IamRoleArn <- value)
            state : CloudformationStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack#id-1">CloudformationStack#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudformationStackState<'Name>, value: string) : CloudformationStackState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudformationStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack#notification_arns-1">CloudformationStack#notification_arns</a>.
        /// </summary>
        [<CustomOperation "notification_arns">]
        member _.NotificationArns(state: CloudformationStackState<'Name>, value: seq<string>) : CloudformationStackState<'Name> =
            state.assignments.Add(fun config -> config.NotificationArns <- (value |> Seq.toArray))
            state : CloudformationStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack#on_failure-1">CloudformationStack#on_failure</a>.
        /// </summary>
        [<CustomOperation "on_failure">]
        member _.OnFailure(state: CloudformationStackState<'Name>, value: string) : CloudformationStackState<'Name> =
            state.assignments.Add(fun config -> config.OnFailure <- value)
            state : CloudformationStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack#parameters-1">CloudformationStack#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: CloudformationStackState<'Name>, value: seq<string * string>) : CloudformationStackState<'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : CloudformationStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack#policy_body-1">CloudformationStack#policy_body</a>.
        /// </summary>
        [<CustomOperation "policy_body">]
        member _.PolicyBody(state: CloudformationStackState<'Name>, value: string) : CloudformationStackState<'Name> =
            state.assignments.Add(fun config -> config.PolicyBody <- value)
            state : CloudformationStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack#policy_url-1">CloudformationStack#policy_url</a>.
        /// </summary>
        [<CustomOperation "policy_url">]
        member _.PolicyUrl(state: CloudformationStackState<'Name>, value: string) : CloudformationStackState<'Name> =
            state.assignments.Add(fun config -> config.PolicyUrl <- value)
            state : CloudformationStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack#tags-1">CloudformationStack#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudformationStackState<'Name>, value: seq<string * string>) : CloudformationStackState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudformationStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack#tags_all-1">CloudformationStack#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CloudformationStackState<'Name>, value: seq<string * string>) : CloudformationStackState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CloudformationStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack#template_body-1">CloudformationStack#template_body</a>.
        /// </summary>
        [<CustomOperation "template_body">]
        member _.TemplateBody(state: CloudformationStackState<'Name>, value: string) : CloudformationStackState<'Name> =
            state.assignments.Add(fun config -> config.TemplateBody <- value)
            state : CloudformationStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack#template_url-1">CloudformationStack#template_url</a>.
        /// </summary>
        [<CustomOperation "template_url">]
        member _.TemplateUrl(state: CloudformationStackState<'Name>, value: string) : CloudformationStackState<'Name> =
            state.assignments.Add(fun config -> config.TemplateUrl <- value)
            state : CloudformationStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack#timeout_in_minutes-1">CloudformationStack#timeout_in_minutes</a>.
        /// </summary>
        [<CustomOperation "timeout_in_minutes">]
        member _.TimeoutInMinutes(state: CloudformationStackState<'Name>, value: double) : CloudformationStackState<'Name> =
            state.assignments.Add(fun config -> config.TimeoutInMinutes <- value)
            state : CloudformationStackState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack#timeouts-1">CloudformationStack#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CloudformationStackState<'Name>, value: aws.CloudformationStack.CloudformationStackTimeouts) : CloudformationStackState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CloudformationStackState<'Name>

        member _.Run(state: CloudformationStackState<Present>) : aws.CloudformationStack.CloudformationStack =
            let config = aws.CloudformationStack.CloudformationStackConfig()
            for setter in state.assignments do
                setter config
            aws.CloudformationStack.CloudformationStack(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudformationStack: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: CloudformationStackState<_>) : aws.CloudformationStack.CloudformationStack =
            Unchecked.defaultof<aws.CloudformationStack.CloudformationStack>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudformationStackSetState<'Name> = { assignments: ResizeArray<aws.CloudformationStackSet.CloudformationStackSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set">aws_cloudformation_stack_set</a>.
    /// </summary>
    type CloudformationStackSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudformationStackSetState<Missing> =
            ({ assignments = ResizeArray() } : CloudformationStackSetState<Missing>)

        member _.Zero(()) : CloudformationStackSetState<Missing> =
            ({ assignments = ResizeArray() } : CloudformationStackSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#name-1">CloudformationStackSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudformationStackSetState<Missing>, value: string) : CloudformationStackSetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudformationStackSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#administration_role_arn-1">CloudformationStackSet#administration_role_arn</a>.
        /// </summary>
        [<CustomOperation "administration_role_arn">]
        member _.AdministrationRoleArn(state: CloudformationStackSetState<'Name>, value: string) : CloudformationStackSetState<'Name> =
            state.assignments.Add(fun config -> config.AdministrationRoleArn <- value)
            state : CloudformationStackSetState<'Name>

        /// <summary>
        /// auto_deployment block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#auto_deployment-1">CloudformationStackSet#auto_deployment</a>
        /// </summary>
        [<CustomOperation "auto_deployment">]
        member _.AutoDeployment(state: CloudformationStackSetState<'Name>, value: aws.CloudformationStackSet.CloudformationStackSetAutoDeployment) : CloudformationStackSetState<'Name> =
            state.assignments.Add(fun config -> config.AutoDeployment <- value)
            state : CloudformationStackSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#call_as-1">CloudformationStackSet#call_as</a>.
        /// </summary>
        [<CustomOperation "call_as">]
        member _.CallAs(state: CloudformationStackSetState<'Name>, value: string) : CloudformationStackSetState<'Name> =
            state.assignments.Add(fun config -> config.CallAs <- value)
            state : CloudformationStackSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#capabilities-1">CloudformationStackSet#capabilities</a>.
        /// </summary>
        [<CustomOperation "capabilities">]
        member _.Capabilities(state: CloudformationStackSetState<'Name>, value: seq<string>) : CloudformationStackSetState<'Name> =
            state.assignments.Add(fun config -> config.Capabilities <- (value |> Seq.toArray))
            state : CloudformationStackSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#description-1">CloudformationStackSet#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: CloudformationStackSetState<'Name>, value: string) : CloudformationStackSetState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : CloudformationStackSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#execution_role_name-1">CloudformationStackSet#execution_role_name</a>.
        /// </summary>
        [<CustomOperation "execution_role_name">]
        member _.ExecutionRoleName(state: CloudformationStackSetState<'Name>, value: string) : CloudformationStackSetState<'Name> =
            state.assignments.Add(fun config -> config.ExecutionRoleName <- value)
            state : CloudformationStackSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#id-1">CloudformationStackSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudformationStackSetState<'Name>, value: string) : CloudformationStackSetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudformationStackSetState<'Name>

        /// <summary>
        /// managed_execution block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#managed_execution-1">CloudformationStackSet#managed_execution</a>
        /// </summary>
        [<CustomOperation "managed_execution">]
        member _.ManagedExecution(state: CloudformationStackSetState<'Name>, value: aws.CloudformationStackSet.CloudformationStackSetManagedExecution) : CloudformationStackSetState<'Name> =
            state.assignments.Add(fun config -> config.ManagedExecution <- value)
            state : CloudformationStackSetState<'Name>

        /// <summary>
        /// operation_preferences block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#operation_preferences-1">CloudformationStackSet#operation_preferences</a>
        /// </summary>
        [<CustomOperation "operation_preferences">]
        member _.OperationPreferences(state: CloudformationStackSetState<'Name>, value: aws.CloudformationStackSet.CloudformationStackSetOperationPreferences) : CloudformationStackSetState<'Name> =
            state.assignments.Add(fun config -> config.OperationPreferences <- value)
            state : CloudformationStackSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#parameters-1">CloudformationStackSet#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: CloudformationStackSetState<'Name>, value: seq<string * string>) : CloudformationStackSetState<'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : CloudformationStackSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#permission_model-1">CloudformationStackSet#permission_model</a>.
        /// </summary>
        [<CustomOperation "permission_model">]
        member _.PermissionModel(state: CloudformationStackSetState<'Name>, value: string) : CloudformationStackSetState<'Name> =
            state.assignments.Add(fun config -> config.PermissionModel <- value)
            state : CloudformationStackSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#tags-1">CloudformationStackSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudformationStackSetState<'Name>, value: seq<string * string>) : CloudformationStackSetState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudformationStackSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#tags_all-1">CloudformationStackSet#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CloudformationStackSetState<'Name>, value: seq<string * string>) : CloudformationStackSetState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CloudformationStackSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#template_body-1">CloudformationStackSet#template_body</a>.
        /// </summary>
        [<CustomOperation "template_body">]
        member _.TemplateBody(state: CloudformationStackSetState<'Name>, value: string) : CloudformationStackSetState<'Name> =
            state.assignments.Add(fun config -> config.TemplateBody <- value)
            state : CloudformationStackSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#template_url-1">CloudformationStackSet#template_url</a>.
        /// </summary>
        [<CustomOperation "template_url">]
        member _.TemplateUrl(state: CloudformationStackSetState<'Name>, value: string) : CloudformationStackSetState<'Name> =
            state.assignments.Add(fun config -> config.TemplateUrl <- value)
            state : CloudformationStackSetState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#timeouts-1">CloudformationStackSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CloudformationStackSetState<'Name>, value: aws.CloudformationStackSet.CloudformationStackSetTimeouts) : CloudformationStackSetState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CloudformationStackSetState<'Name>

        member _.Run(state: CloudformationStackSetState<Present>) : aws.CloudformationStackSet.CloudformationStackSet =
            let config = aws.CloudformationStackSet.CloudformationStackSetConfig()
            for setter in state.assignments do
                setter config
            aws.CloudformationStackSet.CloudformationStackSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudformationStackSet: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: CloudformationStackSetState<_>) : aws.CloudformationStackSet.CloudformationStackSet =
            Unchecked.defaultof<aws.CloudformationStackSet.CloudformationStackSet>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodebuildWebhookState<'ProjectName> = { assignments: ResizeArray<aws.CodebuildWebhook.CodebuildWebhookConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_webhook">aws_codebuild_webhook</a>.
    /// </summary>
    type CodebuildWebhookBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodebuildWebhookState<Missing> =
            ({ assignments = ResizeArray() } : CodebuildWebhookState<Missing>)

        member _.Zero(()) : CodebuildWebhookState<Missing> =
            ({ assignments = ResizeArray() } : CodebuildWebhookState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_webhook#project_name-1">CodebuildWebhook#project_name</a>.
        /// </summary>
        [<CustomOperation "project_name">]
        member _.ProjectName(state: CodebuildWebhookState<Missing>, value: string) : CodebuildWebhookState<Present> =
            state.assignments.Add(fun config -> config.ProjectName <- value)
            ({ assignments = state.assignments } : CodebuildWebhookState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_webhook#branch_filter-1">CodebuildWebhook#branch_filter</a>.
        /// </summary>
        [<CustomOperation "branch_filter">]
        member _.BranchFilter(state: CodebuildWebhookState<'ProjectName>, value: string) : CodebuildWebhookState<'ProjectName> =
            state.assignments.Add(fun config -> config.BranchFilter <- value)
            state : CodebuildWebhookState<'ProjectName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_webhook#build_type-1">CodebuildWebhook#build_type</a>.
        /// </summary>
        [<CustomOperation "build_type">]
        member _.BuildType(state: CodebuildWebhookState<'ProjectName>, value: string) : CodebuildWebhookState<'ProjectName> =
            state.assignments.Add(fun config -> config.BuildType <- value)
            state : CodebuildWebhookState<'ProjectName>

        /// <summary>
        /// filter_group block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_webhook#filter_group-1">CodebuildWebhook#filter_group</a> Accepts: aws.IResolvable | aws.CodebuildWebhook.CodebuildWebhookFilterGroup[]
        /// </summary>
        [<CustomOperation "filter_group">]
        member _.FilterGroup(state: CodebuildWebhookState<'ProjectName>, value: HashiCorp.Cdktf.IResolvable) : CodebuildWebhookState<'ProjectName> =
            state.assignments.Add(fun config -> config.FilterGroup <- value)
            state : CodebuildWebhookState<'ProjectName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_webhook#id-1">CodebuildWebhook#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodebuildWebhookState<'ProjectName>, value: string) : CodebuildWebhookState<'ProjectName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodebuildWebhookState<'ProjectName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_webhook#manual_creation-1">CodebuildWebhook#manual_creation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "manual_creation">]
        member _.ManualCreation(state: CodebuildWebhookState<'ProjectName>, value: bool) : CodebuildWebhookState<'ProjectName> =
            state.assignments.Add(fun config -> config.ManualCreation <- value)
            state : CodebuildWebhookState<'ProjectName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_webhook#manual_creation-1">CodebuildWebhook#manual_creation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "manual_creation">]
        member _.ManualCreation(state: CodebuildWebhookState<'ProjectName>, value: HashiCorp.Cdktf.IResolvable) : CodebuildWebhookState<'ProjectName> =
            state.assignments.Add(fun config -> config.ManualCreation <- value)
            state : CodebuildWebhookState<'ProjectName>

        /// <summary>
        /// scope_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_webhook#scope_configuration-1">CodebuildWebhook#scope_configuration</a>
        /// </summary>
        [<CustomOperation "scope_configuration">]
        member _.ScopeConfiguration(state: CodebuildWebhookState<'ProjectName>, value: aws.CodebuildWebhook.CodebuildWebhookScopeConfiguration) : CodebuildWebhookState<'ProjectName> =
            state.assignments.Add(fun config -> config.ScopeConfiguration <- value)
            state : CodebuildWebhookState<'ProjectName>

        member _.Run(state: CodebuildWebhookState<Present>) : aws.CodebuildWebhook.CodebuildWebhook =
            let config = aws.CodebuildWebhook.CodebuildWebhookConfig()
            for setter in state.assignments do
                setter config
            aws.CodebuildWebhook.CodebuildWebhook(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codebuildWebhook: missing required arguments. Must call: project_name.", 9999, IsError = true)>]
        member _.Run(_: CodebuildWebhookState<_>) : aws.CodebuildWebhook.CodebuildWebhook =
            Unchecked.defaultof<aws.CodebuildWebhook.CodebuildWebhook>

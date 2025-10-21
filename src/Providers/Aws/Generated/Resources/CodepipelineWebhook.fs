namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodepipelineWebhookState<'Authentication, 'Filter, 'Name, 'TargetAction, 'TargetPipeline> = { assignments: ResizeArray<aws.CodepipelineWebhook.CodepipelineWebhookConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook">aws_codepipeline_webhook</a>.
    /// </summary>
    type CodepipelineWebhookBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodepipelineWebhookState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodepipelineWebhookState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CodepipelineWebhookState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodepipelineWebhookState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#authentication-1">CodepipelineWebhook#authentication</a>.
        /// </summary>
        [<CustomOperation "authentication">]
        member _.Authentication(state: CodepipelineWebhookState<Missing, 'Filter, 'Name, 'TargetAction, 'TargetPipeline>, value: string) : CodepipelineWebhookState<Present, 'Filter, 'Name, 'TargetAction, 'TargetPipeline> =
            state.assignments.Add(fun config -> config.Authentication <- value)
            ({ assignments = state.assignments } : CodepipelineWebhookState<Present, 'Filter, 'Name, 'TargetAction, 'TargetPipeline>)

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#filter-1">CodepipelineWebhook#filter</a> Accepts: aws.IResolvable | aws.CodepipelineWebhook.CodepipelineWebhookFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: CodepipelineWebhookState<'Authentication, Missing, 'Name, 'TargetAction, 'TargetPipeline>, value: HashiCorp.Cdktf.IResolvable) : CodepipelineWebhookState<'Authentication, Present, 'Name, 'TargetAction, 'TargetPipeline> =
            state.assignments.Add(fun config -> config.Filter <- value)
            ({ assignments = state.assignments } : CodepipelineWebhookState<'Authentication, Present, 'Name, 'TargetAction, 'TargetPipeline>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#name-1">CodepipelineWebhook#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CodepipelineWebhookState<'Authentication, 'Filter, Missing, 'TargetAction, 'TargetPipeline>, value: string) : CodepipelineWebhookState<'Authentication, 'Filter, Present, 'TargetAction, 'TargetPipeline> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CodepipelineWebhookState<'Authentication, 'Filter, Present, 'TargetAction, 'TargetPipeline>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#target_action-1">CodepipelineWebhook#target_action</a>.
        /// </summary>
        [<CustomOperation "target_action">]
        member _.TargetAction(state: CodepipelineWebhookState<'Authentication, 'Filter, 'Name, Missing, 'TargetPipeline>, value: string) : CodepipelineWebhookState<'Authentication, 'Filter, 'Name, Present, 'TargetPipeline> =
            state.assignments.Add(fun config -> config.TargetAction <- value)
            ({ assignments = state.assignments } : CodepipelineWebhookState<'Authentication, 'Filter, 'Name, Present, 'TargetPipeline>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#target_pipeline-1">CodepipelineWebhook#target_pipeline</a>.
        /// </summary>
        [<CustomOperation "target_pipeline">]
        member _.TargetPipeline(state: CodepipelineWebhookState<'Authentication, 'Filter, 'Name, 'TargetAction, Missing>, value: string) : CodepipelineWebhookState<'Authentication, 'Filter, 'Name, 'TargetAction, Present> =
            state.assignments.Add(fun config -> config.TargetPipeline <- value)
            ({ assignments = state.assignments } : CodepipelineWebhookState<'Authentication, 'Filter, 'Name, 'TargetAction, Present>)

        /// <summary>
        /// authentication_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#authentication_configuration-1">CodepipelineWebhook#authentication_configuration</a>
        /// </summary>
        [<CustomOperation "authentication_configuration">]
        member _.AuthenticationConfiguration(state: CodepipelineWebhookState<'Authentication, 'Filter, 'Name, 'TargetAction, 'TargetPipeline>, value: aws.CodepipelineWebhook.CodepipelineWebhookAuthenticationConfiguration) : CodepipelineWebhookState<'Authentication, 'Filter, 'Name, 'TargetAction, 'TargetPipeline> =
            state.assignments.Add(fun config -> config.AuthenticationConfiguration <- value)
            state : CodepipelineWebhookState<'Authentication, 'Filter, 'Name, 'TargetAction, 'TargetPipeline>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#id-1">CodepipelineWebhook#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodepipelineWebhookState<'Authentication, 'Filter, 'Name, 'TargetAction, 'TargetPipeline>, value: string) : CodepipelineWebhookState<'Authentication, 'Filter, 'Name, 'TargetAction, 'TargetPipeline> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodepipelineWebhookState<'Authentication, 'Filter, 'Name, 'TargetAction, 'TargetPipeline>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#tags-1">CodepipelineWebhook#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CodepipelineWebhookState<'Authentication, 'Filter, 'Name, 'TargetAction, 'TargetPipeline>, value: seq<string * string>) : CodepipelineWebhookState<'Authentication, 'Filter, 'Name, 'TargetAction, 'TargetPipeline> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CodepipelineWebhookState<'Authentication, 'Filter, 'Name, 'TargetAction, 'TargetPipeline>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#tags_all-1">CodepipelineWebhook#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CodepipelineWebhookState<'Authentication, 'Filter, 'Name, 'TargetAction, 'TargetPipeline>, value: seq<string * string>) : CodepipelineWebhookState<'Authentication, 'Filter, 'Name, 'TargetAction, 'TargetPipeline> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CodepipelineWebhookState<'Authentication, 'Filter, 'Name, 'TargetAction, 'TargetPipeline>

        member _.Run(state: CodepipelineWebhookState<Present, Present, Present, Present, Present>) : aws.CodepipelineWebhook.CodepipelineWebhook =
            let config = aws.CodepipelineWebhook.CodepipelineWebhookConfig()
            for setter in state.assignments do
                setter config
            aws.CodepipelineWebhook.CodepipelineWebhook(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codepipelineWebhook: missing required arguments. Must call: authentication, filter, name, target_action, target_pipeline.", 9999, IsError = true)>]
        member _.Run(_: CodepipelineWebhookState<_, _, _, _, _>) : aws.CodepipelineWebhook.CodepipelineWebhook =
            Unchecked.defaultof<aws.CodepipelineWebhook.CodepipelineWebhook>

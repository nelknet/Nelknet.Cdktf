namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SwfDomainState<'WorkflowExecutionRetentionPeriodInDays> = { assignments: ResizeArray<aws.SwfDomain.SwfDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/swf_domain">aws_swf_domain</a>.
    /// </summary>
    type SwfDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : SwfDomainState<Missing> =
            ({ assignments = ResizeArray() } : SwfDomainState<Missing>)

        member _.Zero(()) : SwfDomainState<Missing> =
            ({ assignments = ResizeArray() } : SwfDomainState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/swf_domain#workflow_execution_retention_period_in_days-1">SwfDomain#workflow_execution_retention_period_in_days</a>.
        /// </summary>
        [<CustomOperation "workflow_execution_retention_period_in_days">]
        member _.WorkflowExecutionRetentionPeriodInDays(state: SwfDomainState<Missing>, value: string) : SwfDomainState<Present> =
            state.assignments.Add(fun config -> config.WorkflowExecutionRetentionPeriodInDays <- value)
            ({ assignments = state.assignments } : SwfDomainState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/swf_domain#description-1">SwfDomain#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SwfDomainState<'WorkflowExecutionRetentionPeriodInDays>, value: string) : SwfDomainState<'WorkflowExecutionRetentionPeriodInDays> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SwfDomainState<'WorkflowExecutionRetentionPeriodInDays>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/swf_domain#id-1">SwfDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SwfDomainState<'WorkflowExecutionRetentionPeriodInDays>, value: string) : SwfDomainState<'WorkflowExecutionRetentionPeriodInDays> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SwfDomainState<'WorkflowExecutionRetentionPeriodInDays>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/swf_domain#name-1">SwfDomain#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SwfDomainState<'WorkflowExecutionRetentionPeriodInDays>, value: string) : SwfDomainState<'WorkflowExecutionRetentionPeriodInDays> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SwfDomainState<'WorkflowExecutionRetentionPeriodInDays>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/swf_domain#name_prefix-1">SwfDomain#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: SwfDomainState<'WorkflowExecutionRetentionPeriodInDays>, value: string) : SwfDomainState<'WorkflowExecutionRetentionPeriodInDays> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : SwfDomainState<'WorkflowExecutionRetentionPeriodInDays>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/swf_domain#tags-1">SwfDomain#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SwfDomainState<'WorkflowExecutionRetentionPeriodInDays>, value: seq<string * string>) : SwfDomainState<'WorkflowExecutionRetentionPeriodInDays> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SwfDomainState<'WorkflowExecutionRetentionPeriodInDays>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/swf_domain#tags_all-1">SwfDomain#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SwfDomainState<'WorkflowExecutionRetentionPeriodInDays>, value: seq<string * string>) : SwfDomainState<'WorkflowExecutionRetentionPeriodInDays> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SwfDomainState<'WorkflowExecutionRetentionPeriodInDays>

        member _.Run(state: SwfDomainState<Present>) : aws.SwfDomain.SwfDomain =
            let config = aws.SwfDomain.SwfDomainConfig()
            for setter in state.assignments do
                setter config
            aws.SwfDomain.SwfDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.swfDomain: missing required arguments. Must call: workflow_execution_retention_period_in_days.", 9999, IsError = true)>]
        member _.Run(_: SwfDomainState<_>) : aws.SwfDomain.SwfDomain =
            Unchecked.defaultof<aws.SwfDomain.SwfDomain>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TransferWorkflowState<'Steps> = { assignments: ResizeArray<aws.TransferWorkflow.TransferWorkflowConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow">aws_transfer_workflow</a>.
    /// </summary>
    type TransferWorkflowBuilder(logicalId: string) =
        member _.Yield(_: unit) : TransferWorkflowState<Missing> =
            ({ assignments = ResizeArray() } : TransferWorkflowState<Missing>)

        member _.Zero(()) : TransferWorkflowState<Missing> =
            ({ assignments = ResizeArray() } : TransferWorkflowState<Missing>)

        /// <summary>
        /// steps block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#steps-1">TransferWorkflow#steps</a> Accepts: aws.IResolvable | aws.TransferWorkflow.TransferWorkflowSteps[]
        /// </summary>
        [<CustomOperation "steps">]
        member _.Steps(state: TransferWorkflowState<Missing>, value: HashiCorp.Cdktf.IResolvable) : TransferWorkflowState<Present> =
            state.assignments.Add(fun config -> config.Steps <- value)
            ({ assignments = state.assignments } : TransferWorkflowState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#description-1">TransferWorkflow#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: TransferWorkflowState<'Steps>, value: string) : TransferWorkflowState<'Steps> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : TransferWorkflowState<'Steps>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#id-1">TransferWorkflow#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TransferWorkflowState<'Steps>, value: string) : TransferWorkflowState<'Steps> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TransferWorkflowState<'Steps>

        /// <summary>
        /// on_exception_steps block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#on_exception_steps-1">TransferWorkflow#on_exception_steps</a> Accepts: aws.IResolvable | aws.TransferWorkflow.TransferWorkflowOnExceptionSteps[]
        /// </summary>
        [<CustomOperation "on_exception_steps">]
        member _.OnExceptionSteps(state: TransferWorkflowState<'Steps>, value: HashiCorp.Cdktf.IResolvable) : TransferWorkflowState<'Steps> =
            state.assignments.Add(fun config -> config.OnExceptionSteps <- value)
            state : TransferWorkflowState<'Steps>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#tags-1">TransferWorkflow#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: TransferWorkflowState<'Steps>, value: seq<string * string>) : TransferWorkflowState<'Steps> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : TransferWorkflowState<'Steps>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#tags_all-1">TransferWorkflow#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: TransferWorkflowState<'Steps>, value: seq<string * string>) : TransferWorkflowState<'Steps> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : TransferWorkflowState<'Steps>

        member _.Run(state: TransferWorkflowState<Present>) : aws.TransferWorkflow.TransferWorkflow =
            let config = aws.TransferWorkflow.TransferWorkflowConfig()
            for setter in state.assignments do
                setter config
            aws.TransferWorkflow.TransferWorkflow(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.transferWorkflow: missing required arguments. Must call: steps.", 9999, IsError = true)>]
        member _.Run(_: TransferWorkflowState<_>) : aws.TransferWorkflow.TransferWorkflow =
            Unchecked.defaultof<aws.TransferWorkflow.TransferWorkflow>

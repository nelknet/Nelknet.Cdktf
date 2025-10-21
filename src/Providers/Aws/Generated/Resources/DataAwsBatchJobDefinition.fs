namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsBatchJobDefinitionState = { assignments: ResizeArray<aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/batch_job_definition">aws_batch_job_definition</a>.
    /// </summary>
    type DataAwsBatchJobDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsBatchJobDefinitionState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsBatchJobDefinitionState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/batch_job_definition#arn-1">DataAwsBatchJobDefinition#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsBatchJobDefinitionState, value: string) : DataAwsBatchJobDefinitionState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsBatchJobDefinitionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/batch_job_definition#name-1">DataAwsBatchJobDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsBatchJobDefinitionState, value: string) : DataAwsBatchJobDefinitionState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsBatchJobDefinitionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/batch_job_definition#revision-1">DataAwsBatchJobDefinition#revision</a>.
        /// </summary>
        [<CustomOperation "revision">]
        member _.Revision(state: DataAwsBatchJobDefinitionState, value: double) : DataAwsBatchJobDefinitionState =
            state.assignments.Add(fun config -> config.Revision <- value)
            state : DataAwsBatchJobDefinitionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/batch_job_definition#status-1">DataAwsBatchJobDefinition#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: DataAwsBatchJobDefinitionState, value: string) : DataAwsBatchJobDefinitionState =
            state.assignments.Add(fun config -> config.Status <- value)
            state : DataAwsBatchJobDefinitionState

        member _.Run(state: DataAwsBatchJobDefinitionState) : aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinition =
            let config = aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinition(StackContext.get (), logicalId, config)

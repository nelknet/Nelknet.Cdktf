namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsFisExperimentTemplatesState = { assignments: ResizeArray<aws.DataAwsFisExperimentTemplates.DataAwsFisExperimentTemplatesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fis_experiment_templates">aws_fis_experiment_templates</a>.
    /// </summary>
    type DataAwsFisExperimentTemplatesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsFisExperimentTemplatesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsFisExperimentTemplatesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/fis_experiment_templates#tags-1">DataAwsFisExperimentTemplates#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsFisExperimentTemplatesState, value: seq<string * string>) : DataAwsFisExperimentTemplatesState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsFisExperimentTemplatesState

        member _.Run(state: DataAwsFisExperimentTemplatesState) : aws.DataAwsFisExperimentTemplates.DataAwsFisExperimentTemplates =
            let config = aws.DataAwsFisExperimentTemplates.DataAwsFisExperimentTemplatesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsFisExperimentTemplates.DataAwsFisExperimentTemplates(StackContext.get (), logicalId, config)

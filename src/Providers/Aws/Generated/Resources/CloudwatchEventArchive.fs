namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchEventArchiveState<'EventSourceArn, 'Name> = { assignments: ResizeArray<aws.CloudwatchEventArchive.CloudwatchEventArchiveConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_archive">aws_cloudwatch_event_archive</a>.
    /// </summary>
    type CloudwatchEventArchiveBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchEventArchiveState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchEventArchiveState<Missing, Missing>)

        member _.Zero(()) : CloudwatchEventArchiveState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchEventArchiveState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_archive#event_source_arn-1">CloudwatchEventArchive#event_source_arn</a>.
        /// </summary>
        [<CustomOperation "event_source_arn">]
        member _.EventSourceArn(state: CloudwatchEventArchiveState<Missing, 'Name>, value: string) : CloudwatchEventArchiveState<Present, 'Name> =
            state.assignments.Add(fun config -> config.EventSourceArn <- value)
            ({ assignments = state.assignments } : CloudwatchEventArchiveState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_archive#name-1">CloudwatchEventArchive#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudwatchEventArchiveState<'EventSourceArn, Missing>, value: string) : CloudwatchEventArchiveState<'EventSourceArn, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudwatchEventArchiveState<'EventSourceArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_archive#description-1">CloudwatchEventArchive#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: CloudwatchEventArchiveState<'EventSourceArn, 'Name>, value: string) : CloudwatchEventArchiveState<'EventSourceArn, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : CloudwatchEventArchiveState<'EventSourceArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_archive#event_pattern-1">CloudwatchEventArchive#event_pattern</a>.
        /// </summary>
        [<CustomOperation "event_pattern">]
        member _.EventPattern(state: CloudwatchEventArchiveState<'EventSourceArn, 'Name>, value: string) : CloudwatchEventArchiveState<'EventSourceArn, 'Name> =
            state.assignments.Add(fun config -> config.EventPattern <- value)
            state : CloudwatchEventArchiveState<'EventSourceArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_archive#id-1">CloudwatchEventArchive#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchEventArchiveState<'EventSourceArn, 'Name>, value: string) : CloudwatchEventArchiveState<'EventSourceArn, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchEventArchiveState<'EventSourceArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_archive#retention_days-1">CloudwatchEventArchive#retention_days</a>.
        /// </summary>
        [<CustomOperation "retention_days">]
        member _.RetentionDays(state: CloudwatchEventArchiveState<'EventSourceArn, 'Name>, value: double) : CloudwatchEventArchiveState<'EventSourceArn, 'Name> =
            state.assignments.Add(fun config -> config.RetentionDays <- value)
            state : CloudwatchEventArchiveState<'EventSourceArn, 'Name>

        member _.Run(state: CloudwatchEventArchiveState<Present, Present>) : aws.CloudwatchEventArchive.CloudwatchEventArchive =
            let config = aws.CloudwatchEventArchive.CloudwatchEventArchiveConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchEventArchive.CloudwatchEventArchive(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchEventArchive: missing required arguments. Must call: event_source_arn, name.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchEventArchiveState<_, _>) : aws.CloudwatchEventArchive.CloudwatchEventArchive =
            Unchecked.defaultof<aws.CloudwatchEventArchive.CloudwatchEventArchive>

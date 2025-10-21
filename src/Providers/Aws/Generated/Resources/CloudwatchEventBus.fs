namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchEventBusState<'Name> = { assignments: ResizeArray<aws.CloudwatchEventBus.CloudwatchEventBusConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_bus">aws_cloudwatch_event_bus</a>.
    /// </summary>
    type CloudwatchEventBusBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchEventBusState<Missing> =
            ({ assignments = ResizeArray() } : CloudwatchEventBusState<Missing>)

        member _.Zero(()) : CloudwatchEventBusState<Missing> =
            ({ assignments = ResizeArray() } : CloudwatchEventBusState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_bus#name-1">CloudwatchEventBus#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudwatchEventBusState<Missing>, value: string) : CloudwatchEventBusState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudwatchEventBusState<Present>)

        /// <summary>
        /// dead_letter_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_bus#dead_letter_config-1">CloudwatchEventBus#dead_letter_config</a>
        /// </summary>
        [<CustomOperation "dead_letter_config">]
        member _.DeadLetterConfig(state: CloudwatchEventBusState<'Name>, value: aws.CloudwatchEventBus.CloudwatchEventBusDeadLetterConfig) : CloudwatchEventBusState<'Name> =
            state.assignments.Add(fun config -> config.DeadLetterConfig <- value)
            state : CloudwatchEventBusState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_bus#description-1">CloudwatchEventBus#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: CloudwatchEventBusState<'Name>, value: string) : CloudwatchEventBusState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : CloudwatchEventBusState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_bus#event_source_name-1">CloudwatchEventBus#event_source_name</a>.
        /// </summary>
        [<CustomOperation "event_source_name">]
        member _.EventSourceName(state: CloudwatchEventBusState<'Name>, value: string) : CloudwatchEventBusState<'Name> =
            state.assignments.Add(fun config -> config.EventSourceName <- value)
            state : CloudwatchEventBusState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_bus#id-1">CloudwatchEventBus#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchEventBusState<'Name>, value: string) : CloudwatchEventBusState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchEventBusState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_bus#kms_key_identifier-1">CloudwatchEventBus#kms_key_identifier</a>.
        /// </summary>
        [<CustomOperation "kms_key_identifier">]
        member _.KmsKeyIdentifier(state: CloudwatchEventBusState<'Name>, value: string) : CloudwatchEventBusState<'Name> =
            state.assignments.Add(fun config -> config.KmsKeyIdentifier <- value)
            state : CloudwatchEventBusState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_bus#tags-1">CloudwatchEventBus#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudwatchEventBusState<'Name>, value: seq<string * string>) : CloudwatchEventBusState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudwatchEventBusState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_bus#tags_all-1">CloudwatchEventBus#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CloudwatchEventBusState<'Name>, value: seq<string * string>) : CloudwatchEventBusState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CloudwatchEventBusState<'Name>

        member _.Run(state: CloudwatchEventBusState<Present>) : aws.CloudwatchEventBus.CloudwatchEventBus =
            let config = aws.CloudwatchEventBus.CloudwatchEventBusConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchEventBus.CloudwatchEventBus(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchEventBus: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchEventBusState<_>) : aws.CloudwatchEventBus.CloudwatchEventBus =
            Unchecked.defaultof<aws.CloudwatchEventBus.CloudwatchEventBus>

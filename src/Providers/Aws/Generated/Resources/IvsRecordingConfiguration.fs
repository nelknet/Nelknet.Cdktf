namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IvsRecordingConfigurationState<'DestinationConfiguration> = { assignments: ResizeArray<aws.IvsRecordingConfiguration.IvsRecordingConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration">aws_ivs_recording_configuration</a>.
    /// </summary>
    type IvsRecordingConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : IvsRecordingConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : IvsRecordingConfigurationState<Missing>)

        member _.Zero(()) : IvsRecordingConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : IvsRecordingConfigurationState<Missing>)

        /// <summary>
        /// destination_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#destination_configuration-1">IvsRecordingConfiguration#destination_configuration</a>
        /// </summary>
        [<CustomOperation "destination_configuration">]
        member _.DestinationConfiguration(state: IvsRecordingConfigurationState<Missing>, value: aws.IvsRecordingConfiguration.IvsRecordingConfigurationDestinationConfiguration) : IvsRecordingConfigurationState<Present> =
            state.assignments.Add(fun config -> config.DestinationConfiguration <- value)
            ({ assignments = state.assignments } : IvsRecordingConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#id-1">IvsRecordingConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IvsRecordingConfigurationState<'DestinationConfiguration>, value: string) : IvsRecordingConfigurationState<'DestinationConfiguration> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IvsRecordingConfigurationState<'DestinationConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#name-1">IvsRecordingConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IvsRecordingConfigurationState<'DestinationConfiguration>, value: string) : IvsRecordingConfigurationState<'DestinationConfiguration> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : IvsRecordingConfigurationState<'DestinationConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#recording_reconnect_window_seconds-1">IvsRecordingConfiguration#recording_reconnect_window_seconds</a>.
        /// </summary>
        [<CustomOperation "recording_reconnect_window_seconds">]
        member _.RecordingReconnectWindowSeconds(state: IvsRecordingConfigurationState<'DestinationConfiguration>, value: double) : IvsRecordingConfigurationState<'DestinationConfiguration> =
            state.assignments.Add(fun config -> config.RecordingReconnectWindowSeconds <- value)
            state : IvsRecordingConfigurationState<'DestinationConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#tags-1">IvsRecordingConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IvsRecordingConfigurationState<'DestinationConfiguration>, value: seq<string * string>) : IvsRecordingConfigurationState<'DestinationConfiguration> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IvsRecordingConfigurationState<'DestinationConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#tags_all-1">IvsRecordingConfiguration#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IvsRecordingConfigurationState<'DestinationConfiguration>, value: seq<string * string>) : IvsRecordingConfigurationState<'DestinationConfiguration> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IvsRecordingConfigurationState<'DestinationConfiguration>

        /// <summary>
        /// thumbnail_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#thumbnail_configuration-1">IvsRecordingConfiguration#thumbnail_configuration</a>
        /// </summary>
        [<CustomOperation "thumbnail_configuration">]
        member _.ThumbnailConfiguration(state: IvsRecordingConfigurationState<'DestinationConfiguration>, value: aws.IvsRecordingConfiguration.IvsRecordingConfigurationThumbnailConfiguration) : IvsRecordingConfigurationState<'DestinationConfiguration> =
            state.assignments.Add(fun config -> config.ThumbnailConfiguration <- value)
            state : IvsRecordingConfigurationState<'DestinationConfiguration>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#timeouts-1">IvsRecordingConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IvsRecordingConfigurationState<'DestinationConfiguration>, value: aws.IvsRecordingConfiguration.IvsRecordingConfigurationTimeouts) : IvsRecordingConfigurationState<'DestinationConfiguration> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IvsRecordingConfigurationState<'DestinationConfiguration>

        member _.Run(state: IvsRecordingConfigurationState<Present>) : aws.IvsRecordingConfiguration.IvsRecordingConfiguration =
            let config = aws.IvsRecordingConfiguration.IvsRecordingConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.IvsRecordingConfiguration.IvsRecordingConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ivsRecordingConfiguration: missing required arguments. Must call: destination_configuration.", 9999, IsError = true)>]
        member _.Run(_: IvsRecordingConfigurationState<_>) : aws.IvsRecordingConfiguration.IvsRecordingConfiguration =
            Unchecked.defaultof<aws.IvsRecordingConfiguration.IvsRecordingConfiguration>

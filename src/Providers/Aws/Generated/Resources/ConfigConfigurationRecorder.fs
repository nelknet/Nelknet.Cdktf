namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConfigConfigurationRecorderState<'RoleArn> = { assignments: ResizeArray<aws.ConfigConfigurationRecorder.ConfigConfigurationRecorderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_recorder">aws_config_configuration_recorder</a>.
    /// </summary>
    type ConfigConfigurationRecorderBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConfigConfigurationRecorderState<Missing> =
            ({ assignments = ResizeArray() } : ConfigConfigurationRecorderState<Missing>)

        member _.Zero(()) : ConfigConfigurationRecorderState<Missing> =
            ({ assignments = ResizeArray() } : ConfigConfigurationRecorderState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_recorder#role_arn-1">ConfigConfigurationRecorder#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: ConfigConfigurationRecorderState<Missing>, value: string) : ConfigConfigurationRecorderState<Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : ConfigConfigurationRecorderState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_recorder#id-1">ConfigConfigurationRecorder#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConfigConfigurationRecorderState<'RoleArn>, value: string) : ConfigConfigurationRecorderState<'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConfigConfigurationRecorderState<'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_recorder#name-1">ConfigConfigurationRecorder#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConfigConfigurationRecorderState<'RoleArn>, value: string) : ConfigConfigurationRecorderState<'RoleArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : ConfigConfigurationRecorderState<'RoleArn>

        /// <summary>
        /// recording_group block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_recorder#recording_group-1">ConfigConfigurationRecorder#recording_group</a>
        /// </summary>
        [<CustomOperation "recording_group">]
        member _.RecordingGroup(state: ConfigConfigurationRecorderState<'RoleArn>, value: aws.ConfigConfigurationRecorder.ConfigConfigurationRecorderRecordingGroup) : ConfigConfigurationRecorderState<'RoleArn> =
            state.assignments.Add(fun config -> config.RecordingGroup <- value)
            state : ConfigConfigurationRecorderState<'RoleArn>

        /// <summary>
        /// recording_mode block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_recorder#recording_mode-1">ConfigConfigurationRecorder#recording_mode</a>
        /// </summary>
        [<CustomOperation "recording_mode">]
        member _.RecordingMode(state: ConfigConfigurationRecorderState<'RoleArn>, value: aws.ConfigConfigurationRecorder.ConfigConfigurationRecorderRecordingMode) : ConfigConfigurationRecorderState<'RoleArn> =
            state.assignments.Add(fun config -> config.RecordingMode <- value)
            state : ConfigConfigurationRecorderState<'RoleArn>

        member _.Run(state: ConfigConfigurationRecorderState<Present>) : aws.ConfigConfigurationRecorder.ConfigConfigurationRecorder =
            let config = aws.ConfigConfigurationRecorder.ConfigConfigurationRecorderConfig()
            for setter in state.assignments do
                setter config
            aws.ConfigConfigurationRecorder.ConfigConfigurationRecorder(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.configConfigurationRecorder: missing required arguments. Must call: role_arn.", 9999, IsError = true)>]
        member _.Run(_: ConfigConfigurationRecorderState<_>) : aws.ConfigConfigurationRecorder.ConfigConfigurationRecorder =
            Unchecked.defaultof<aws.ConfigConfigurationRecorder.ConfigConfigurationRecorder>

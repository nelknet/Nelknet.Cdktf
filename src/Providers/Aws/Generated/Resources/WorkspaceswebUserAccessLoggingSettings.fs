namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WorkspaceswebUserAccessLoggingSettingsState<'KinesisStreamArn> = { assignments: ResizeArray<aws.WorkspaceswebUserAccessLoggingSettings.WorkspaceswebUserAccessLoggingSettingsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_access_logging_settings">aws_workspacesweb_user_access_logging_settings</a>.
    /// </summary>
    type WorkspaceswebUserAccessLoggingSettingsBuilder(logicalId: string) =
        member _.Yield(_: unit) : WorkspaceswebUserAccessLoggingSettingsState<Missing> =
            ({ assignments = ResizeArray() } : WorkspaceswebUserAccessLoggingSettingsState<Missing>)

        member _.Zero(()) : WorkspaceswebUserAccessLoggingSettingsState<Missing> =
            ({ assignments = ResizeArray() } : WorkspaceswebUserAccessLoggingSettingsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_access_logging_settings#kinesis_stream_arn-1">WorkspaceswebUserAccessLoggingSettings#kinesis_stream_arn</a>.
        /// </summary>
        [<CustomOperation "kinesis_stream_arn">]
        member _.KinesisStreamArn(state: WorkspaceswebUserAccessLoggingSettingsState<Missing>, value: string) : WorkspaceswebUserAccessLoggingSettingsState<Present> =
            state.assignments.Add(fun config -> config.KinesisStreamArn <- value)
            ({ assignments = state.assignments } : WorkspaceswebUserAccessLoggingSettingsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_access_logging_settings#tags-1">WorkspaceswebUserAccessLoggingSettings#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WorkspaceswebUserAccessLoggingSettingsState<'KinesisStreamArn>, value: seq<string * string>) : WorkspaceswebUserAccessLoggingSettingsState<'KinesisStreamArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WorkspaceswebUserAccessLoggingSettingsState<'KinesisStreamArn>

        member _.Run(state: WorkspaceswebUserAccessLoggingSettingsState<Present>) : aws.WorkspaceswebUserAccessLoggingSettings.WorkspaceswebUserAccessLoggingSettings =
            let config = aws.WorkspaceswebUserAccessLoggingSettings.WorkspaceswebUserAccessLoggingSettingsConfig()
            for setter in state.assignments do
                setter config
            aws.WorkspaceswebUserAccessLoggingSettings.WorkspaceswebUserAccessLoggingSettings(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.workspaceswebUserAccessLoggingSettings: missing required arguments. Must call: kinesis_stream_arn.", 9999, IsError = true)>]
        member _.Run(_: WorkspaceswebUserAccessLoggingSettingsState<_>) : aws.WorkspaceswebUserAccessLoggingSettings.WorkspaceswebUserAccessLoggingSettings =
            Unchecked.defaultof<aws.WorkspaceswebUserAccessLoggingSettings.WorkspaceswebUserAccessLoggingSettings>

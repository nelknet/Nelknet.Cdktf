namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotLoggingOptionsState<'DefaultLogLevel, 'RoleArn> = { assignments: ResizeArray<aws.IotLoggingOptions.IotLoggingOptionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_logging_options">aws_iot_logging_options</a>.
    /// </summary>
    type IotLoggingOptionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotLoggingOptionsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IotLoggingOptionsState<Missing, Missing>)

        member _.Zero(()) : IotLoggingOptionsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IotLoggingOptionsState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_logging_options#default_log_level-1">IotLoggingOptions#default_log_level</a>.
        /// </summary>
        [<CustomOperation "default_log_level">]
        member _.DefaultLogLevel(state: IotLoggingOptionsState<Missing, 'RoleArn>, value: string) : IotLoggingOptionsState<Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.DefaultLogLevel <- value)
            ({ assignments = state.assignments } : IotLoggingOptionsState<Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_logging_options#role_arn-1">IotLoggingOptions#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: IotLoggingOptionsState<'DefaultLogLevel, Missing>, value: string) : IotLoggingOptionsState<'DefaultLogLevel, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : IotLoggingOptionsState<'DefaultLogLevel, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_logging_options#disable_all_logs-1">IotLoggingOptions#disable_all_logs</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_all_logs">]
        member _.DisableAllLogs(state: IotLoggingOptionsState<'DefaultLogLevel, 'RoleArn>, value: bool) : IotLoggingOptionsState<'DefaultLogLevel, 'RoleArn> =
            state.assignments.Add(fun config -> config.DisableAllLogs <- value)
            state : IotLoggingOptionsState<'DefaultLogLevel, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_logging_options#disable_all_logs-1">IotLoggingOptions#disable_all_logs</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_all_logs">]
        member _.DisableAllLogs(state: IotLoggingOptionsState<'DefaultLogLevel, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : IotLoggingOptionsState<'DefaultLogLevel, 'RoleArn> =
            state.assignments.Add(fun config -> config.DisableAllLogs <- value)
            state : IotLoggingOptionsState<'DefaultLogLevel, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_logging_options#id-1">IotLoggingOptions#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotLoggingOptionsState<'DefaultLogLevel, 'RoleArn>, value: string) : IotLoggingOptionsState<'DefaultLogLevel, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotLoggingOptionsState<'DefaultLogLevel, 'RoleArn>

        member _.Run(state: IotLoggingOptionsState<Present, Present>) : aws.IotLoggingOptions.IotLoggingOptions =
            let config = aws.IotLoggingOptions.IotLoggingOptionsConfig()
            for setter in state.assignments do
                setter config
            aws.IotLoggingOptions.IotLoggingOptions(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iotLoggingOptions: missing required arguments. Must call: default_log_level, role_arn.", 9999, IsError = true)>]
        member _.Run(_: IotLoggingOptionsState<_, _>) : aws.IotLoggingOptions.IotLoggingOptions =
            Unchecked.defaultof<aws.IotLoggingOptions.IotLoggingOptions>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VerifiedaccessInstanceLoggingConfigurationState<'AccessLogs, 'VerifiedaccessInstanceId> = { assignments: ResizeArray<aws.VerifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance_logging_configuration">aws_verifiedaccess_instance_logging_configuration</a>.
    /// </summary>
    type VerifiedaccessInstanceLoggingConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VerifiedaccessInstanceLoggingConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VerifiedaccessInstanceLoggingConfigurationState<Missing, Missing>)

        member _.Zero(()) : VerifiedaccessInstanceLoggingConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VerifiedaccessInstanceLoggingConfigurationState<Missing, Missing>)

        /// <summary>
        /// access_logs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance_logging_configuration#access_logs-1">VerifiedaccessInstanceLoggingConfiguration#access_logs</a>
        /// </summary>
        [<CustomOperation "access_logs">]
        member _.AccessLogs(state: VerifiedaccessInstanceLoggingConfigurationState<Missing, 'VerifiedaccessInstanceId>, value: aws.VerifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogs) : VerifiedaccessInstanceLoggingConfigurationState<Present, 'VerifiedaccessInstanceId> =
            state.assignments.Add(fun config -> config.AccessLogs <- value)
            ({ assignments = state.assignments } : VerifiedaccessInstanceLoggingConfigurationState<Present, 'VerifiedaccessInstanceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance_logging_configuration#verifiedaccess_instance_id-1">VerifiedaccessInstanceLoggingConfiguration#verifiedaccess_instance_id</a>.
        /// </summary>
        [<CustomOperation "verifiedaccess_instance_id">]
        member _.VerifiedaccessInstanceId(state: VerifiedaccessInstanceLoggingConfigurationState<'AccessLogs, Missing>, value: string) : VerifiedaccessInstanceLoggingConfigurationState<'AccessLogs, Present> =
            state.assignments.Add(fun config -> config.VerifiedaccessInstanceId <- value)
            ({ assignments = state.assignments } : VerifiedaccessInstanceLoggingConfigurationState<'AccessLogs, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance_logging_configuration#id-1">VerifiedaccessInstanceLoggingConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VerifiedaccessInstanceLoggingConfigurationState<'AccessLogs, 'VerifiedaccessInstanceId>, value: string) : VerifiedaccessInstanceLoggingConfigurationState<'AccessLogs, 'VerifiedaccessInstanceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VerifiedaccessInstanceLoggingConfigurationState<'AccessLogs, 'VerifiedaccessInstanceId>

        member _.Run(state: VerifiedaccessInstanceLoggingConfigurationState<Present, Present>) : aws.VerifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfiguration =
            let config = aws.VerifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.VerifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.verifiedaccessInstanceLoggingConfiguration: missing required arguments. Must call: access_logs, verifiedaccess_instance_id.", 9999, IsError = true)>]
        member _.Run(_: VerifiedaccessInstanceLoggingConfigurationState<_, _>) : aws.VerifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfiguration =
            Unchecked.defaultof<aws.VerifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfiguration>

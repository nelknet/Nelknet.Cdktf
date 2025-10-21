namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EfsReplicationConfigurationState<'Destination, 'SourceFileSystemId> = { assignments: ResizeArray<aws.EfsReplicationConfiguration.EfsReplicationConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_replication_configuration">aws_efs_replication_configuration</a>.
    /// </summary>
    type EfsReplicationConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : EfsReplicationConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EfsReplicationConfigurationState<Missing, Missing>)

        member _.Zero(()) : EfsReplicationConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EfsReplicationConfigurationState<Missing, Missing>)

        /// <summary>
        /// destination block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_replication_configuration#destination-1">EfsReplicationConfiguration#destination</a>
        /// </summary>
        [<CustomOperation "destination">]
        member _.Destination(state: EfsReplicationConfigurationState<Missing, 'SourceFileSystemId>, value: aws.EfsReplicationConfiguration.EfsReplicationConfigurationDestination) : EfsReplicationConfigurationState<Present, 'SourceFileSystemId> =
            state.assignments.Add(fun config -> config.Destination <- value)
            ({ assignments = state.assignments } : EfsReplicationConfigurationState<Present, 'SourceFileSystemId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_replication_configuration#source_file_system_id-1">EfsReplicationConfiguration#source_file_system_id</a>.
        /// </summary>
        [<CustomOperation "source_file_system_id">]
        member _.SourceFileSystemId(state: EfsReplicationConfigurationState<'Destination, Missing>, value: string) : EfsReplicationConfigurationState<'Destination, Present> =
            state.assignments.Add(fun config -> config.SourceFileSystemId <- value)
            ({ assignments = state.assignments } : EfsReplicationConfigurationState<'Destination, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_replication_configuration#id-1">EfsReplicationConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EfsReplicationConfigurationState<'Destination, 'SourceFileSystemId>, value: string) : EfsReplicationConfigurationState<'Destination, 'SourceFileSystemId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EfsReplicationConfigurationState<'Destination, 'SourceFileSystemId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_replication_configuration#timeouts-1">EfsReplicationConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EfsReplicationConfigurationState<'Destination, 'SourceFileSystemId>, value: aws.EfsReplicationConfiguration.EfsReplicationConfigurationTimeouts) : EfsReplicationConfigurationState<'Destination, 'SourceFileSystemId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EfsReplicationConfigurationState<'Destination, 'SourceFileSystemId>

        member _.Run(state: EfsReplicationConfigurationState<Present, Present>) : aws.EfsReplicationConfiguration.EfsReplicationConfiguration =
            let config = aws.EfsReplicationConfiguration.EfsReplicationConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.EfsReplicationConfiguration.EfsReplicationConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.efsReplicationConfiguration: missing required arguments. Must call: destination, source_file_system_id.", 9999, IsError = true)>]
        member _.Run(_: EfsReplicationConfigurationState<_, _>) : aws.EfsReplicationConfiguration.EfsReplicationConfiguration =
            Unchecked.defaultof<aws.EfsReplicationConfiguration.EfsReplicationConfiguration>

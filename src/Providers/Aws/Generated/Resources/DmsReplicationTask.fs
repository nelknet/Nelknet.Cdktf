namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> = { assignments: ResizeArray<aws.DmsReplicationTask.DmsReplicationTaskConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_task">aws_dms_replication_task</a>.
    /// </summary>
    type DmsReplicationTaskBuilder(logicalId: string) =
        member _.Yield(_: unit) : DmsReplicationTaskState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DmsReplicationTaskState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DmsReplicationTaskState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DmsReplicationTaskState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_task#migration_type-1">DmsReplicationTask#migration_type</a>.
        /// </summary>
        [<CustomOperation "migration_type">]
        member _.MigrationType(state: DmsReplicationTaskState<Missing, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: string) : DmsReplicationTaskState<Present, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.MigrationType <- value)
            ({ assignments = state.assignments } : DmsReplicationTaskState<Present, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_task#replication_instance_arn-1">DmsReplicationTask#replication_instance_arn</a>.
        /// </summary>
        [<CustomOperation "replication_instance_arn">]
        member _.ReplicationInstanceArn(state: DmsReplicationTaskState<'MigrationType, Missing, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: string) : DmsReplicationTaskState<'MigrationType, Present, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.ReplicationInstanceArn <- value)
            ({ assignments = state.assignments } : DmsReplicationTaskState<'MigrationType, Present, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_task#replication_task_id-1">DmsReplicationTask#replication_task_id</a>.
        /// </summary>
        [<CustomOperation "replication_task_id">]
        member _.ReplicationTaskId(state: DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, Missing, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: string) : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, Present, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.ReplicationTaskId <- value)
            ({ assignments = state.assignments } : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, Present, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_task#source_endpoint_arn-1">DmsReplicationTask#source_endpoint_arn</a>.
        /// </summary>
        [<CustomOperation "source_endpoint_arn">]
        member _.SourceEndpointArn(state: DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, Missing, 'TableMappings, 'TargetEndpointArn>, value: string) : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, Present, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.SourceEndpointArn <- value)
            ({ assignments = state.assignments } : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, Present, 'TableMappings, 'TargetEndpointArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_task#table_mappings-1">DmsReplicationTask#table_mappings</a>.
        /// </summary>
        [<CustomOperation "table_mappings">]
        member _.TableMappings(state: DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, Missing, 'TargetEndpointArn>, value: string) : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, Present, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.TableMappings <- value)
            ({ assignments = state.assignments } : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, Present, 'TargetEndpointArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_task#target_endpoint_arn-1">DmsReplicationTask#target_endpoint_arn</a>.
        /// </summary>
        [<CustomOperation "target_endpoint_arn">]
        member _.TargetEndpointArn(state: DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, Missing>, value: string) : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, Present> =
            state.assignments.Add(fun config -> config.TargetEndpointArn <- value)
            ({ assignments = state.assignments } : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_task#cdc_start_position-1">DmsReplicationTask#cdc_start_position</a>.
        /// </summary>
        [<CustomOperation "cdc_start_position">]
        member _.CdcStartPosition(state: DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: string) : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.CdcStartPosition <- value)
            state : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_task#cdc_start_time-1">DmsReplicationTask#cdc_start_time</a>.
        /// </summary>
        [<CustomOperation "cdc_start_time">]
        member _.CdcStartTime(state: DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: string) : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.CdcStartTime <- value)
            state : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_task#id-1">DmsReplicationTask#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: string) : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_task#replication_task_settings-1">DmsReplicationTask#replication_task_settings</a>.
        /// </summary>
        [<CustomOperation "replication_task_settings">]
        member _.ReplicationTaskSettings(state: DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: string) : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.ReplicationTaskSettings <- value)
            state : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_task#resource_identifier-1">DmsReplicationTask#resource_identifier</a>.
        /// </summary>
        [<CustomOperation "resource_identifier">]
        member _.ResourceIdentifier(state: DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: string) : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.ResourceIdentifier <- value)
            state : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_task#start_replication_task-1">DmsReplicationTask#start_replication_task</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "start_replication_task">]
        member _.StartReplicationTask(state: DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: bool) : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.StartReplicationTask <- value)
            state : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_task#start_replication_task-1">DmsReplicationTask#start_replication_task</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "start_replication_task">]
        member _.StartReplicationTask(state: DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: HashiCorp.Cdktf.IResolvable) : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.StartReplicationTask <- value)
            state : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_task#tags-1">DmsReplicationTask#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: seq<string * string>) : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_task#tags_all-1">DmsReplicationTask#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: seq<string * string>) : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DmsReplicationTaskState<'MigrationType, 'ReplicationInstanceArn, 'ReplicationTaskId, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>

        member _.Run(state: DmsReplicationTaskState<Present, Present, Present, Present, Present, Present>) : aws.DmsReplicationTask.DmsReplicationTask =
            let config = aws.DmsReplicationTask.DmsReplicationTaskConfig()
            for setter in state.assignments do
                setter config
            aws.DmsReplicationTask.DmsReplicationTask(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dmsReplicationTask: missing required arguments. Must call: migration_type, replication_instance_arn, replication_task_id, source_endpoint_arn, table_mappings, target_endpoint_arn.", 9999, IsError = true)>]
        member _.Run(_: DmsReplicationTaskState<_, _, _, _, _, _>) : aws.DmsReplicationTask.DmsReplicationTask =
            Unchecked.defaultof<aws.DmsReplicationTask.DmsReplicationTask>

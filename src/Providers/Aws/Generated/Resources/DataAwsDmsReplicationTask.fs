namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDmsReplicationTaskState<'ReplicationTaskId> = { assignments: ResizeArray<aws.DataAwsDmsReplicationTask.DataAwsDmsReplicationTaskConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_replication_task">aws_dms_replication_task</a>.
    /// </summary>
    type DataAwsDmsReplicationTaskBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDmsReplicationTaskState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDmsReplicationTaskState<Missing>)

        member _.Zero(()) : DataAwsDmsReplicationTaskState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDmsReplicationTaskState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_replication_task#replication_task_id-1">DataAwsDmsReplicationTask#replication_task_id</a>.
        /// </summary>
        [<CustomOperation "replication_task_id">]
        member _.ReplicationTaskId(state: DataAwsDmsReplicationTaskState<Missing>, value: string) : DataAwsDmsReplicationTaskState<Present> =
            state.assignments.Add(fun config -> config.ReplicationTaskId <- value)
            ({ assignments = state.assignments } : DataAwsDmsReplicationTaskState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_replication_task#id-1">DataAwsDmsReplicationTask#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDmsReplicationTaskState<'ReplicationTaskId>, value: string) : DataAwsDmsReplicationTaskState<'ReplicationTaskId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDmsReplicationTaskState<'ReplicationTaskId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_replication_task#tags-1">DataAwsDmsReplicationTask#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsDmsReplicationTaskState<'ReplicationTaskId>, value: seq<string * string>) : DataAwsDmsReplicationTaskState<'ReplicationTaskId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsDmsReplicationTaskState<'ReplicationTaskId>

        member _.Run(state: DataAwsDmsReplicationTaskState<Present>) : aws.DataAwsDmsReplicationTask.DataAwsDmsReplicationTask =
            let config = aws.DataAwsDmsReplicationTask.DataAwsDmsReplicationTaskConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDmsReplicationTask.DataAwsDmsReplicationTask(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsDmsReplicationTask: missing required arguments. Must call: replication_task_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsDmsReplicationTaskState<_>) : aws.DataAwsDmsReplicationTask.DataAwsDmsReplicationTask =
            Unchecked.defaultof<aws.DataAwsDmsReplicationTask.DataAwsDmsReplicationTask>

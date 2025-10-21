namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDmsReplicationInstanceState<'ReplicationInstanceId> = { assignments: ResizeArray<aws.DataAwsDmsReplicationInstance.DataAwsDmsReplicationInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_replication_instance">aws_dms_replication_instance</a>.
    /// </summary>
    type DataAwsDmsReplicationInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDmsReplicationInstanceState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDmsReplicationInstanceState<Missing>)

        member _.Zero(()) : DataAwsDmsReplicationInstanceState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDmsReplicationInstanceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_replication_instance#replication_instance_id-1">DataAwsDmsReplicationInstance#replication_instance_id</a>.
        /// </summary>
        [<CustomOperation "replication_instance_id">]
        member _.ReplicationInstanceId(state: DataAwsDmsReplicationInstanceState<Missing>, value: string) : DataAwsDmsReplicationInstanceState<Present> =
            state.assignments.Add(fun config -> config.ReplicationInstanceId <- value)
            ({ assignments = state.assignments } : DataAwsDmsReplicationInstanceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_replication_instance#id-1">DataAwsDmsReplicationInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDmsReplicationInstanceState<'ReplicationInstanceId>, value: string) : DataAwsDmsReplicationInstanceState<'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDmsReplicationInstanceState<'ReplicationInstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_replication_instance#tags-1">DataAwsDmsReplicationInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsDmsReplicationInstanceState<'ReplicationInstanceId>, value: seq<string * string>) : DataAwsDmsReplicationInstanceState<'ReplicationInstanceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsDmsReplicationInstanceState<'ReplicationInstanceId>

        member _.Run(state: DataAwsDmsReplicationInstanceState<Present>) : aws.DataAwsDmsReplicationInstance.DataAwsDmsReplicationInstance =
            let config = aws.DataAwsDmsReplicationInstance.DataAwsDmsReplicationInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDmsReplicationInstance.DataAwsDmsReplicationInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsDmsReplicationInstance: missing required arguments. Must call: replication_instance_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsDmsReplicationInstanceState<_>) : aws.DataAwsDmsReplicationInstance.DataAwsDmsReplicationInstance =
            Unchecked.defaultof<aws.DataAwsDmsReplicationInstance.DataAwsDmsReplicationInstance>

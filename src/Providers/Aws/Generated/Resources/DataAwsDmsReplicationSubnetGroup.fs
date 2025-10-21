namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDmsReplicationSubnetGroupState<'ReplicationSubnetGroupId> = { assignments: ResizeArray<aws.DataAwsDmsReplicationSubnetGroup.DataAwsDmsReplicationSubnetGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_replication_subnet_group">aws_dms_replication_subnet_group</a>.
    /// </summary>
    type DataAwsDmsReplicationSubnetGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDmsReplicationSubnetGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDmsReplicationSubnetGroupState<Missing>)

        member _.Zero(()) : DataAwsDmsReplicationSubnetGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDmsReplicationSubnetGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_replication_subnet_group#replication_subnet_group_id-1">DataAwsDmsReplicationSubnetGroup#replication_subnet_group_id</a>.
        /// </summary>
        [<CustomOperation "replication_subnet_group_id">]
        member _.ReplicationSubnetGroupId(state: DataAwsDmsReplicationSubnetGroupState<Missing>, value: string) : DataAwsDmsReplicationSubnetGroupState<Present> =
            state.assignments.Add(fun config -> config.ReplicationSubnetGroupId <- value)
            ({ assignments = state.assignments } : DataAwsDmsReplicationSubnetGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_replication_subnet_group#id-1">DataAwsDmsReplicationSubnetGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDmsReplicationSubnetGroupState<'ReplicationSubnetGroupId>, value: string) : DataAwsDmsReplicationSubnetGroupState<'ReplicationSubnetGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDmsReplicationSubnetGroupState<'ReplicationSubnetGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_replication_subnet_group#tags-1">DataAwsDmsReplicationSubnetGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsDmsReplicationSubnetGroupState<'ReplicationSubnetGroupId>, value: seq<string * string>) : DataAwsDmsReplicationSubnetGroupState<'ReplicationSubnetGroupId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsDmsReplicationSubnetGroupState<'ReplicationSubnetGroupId>

        member _.Run(state: DataAwsDmsReplicationSubnetGroupState<Present>) : aws.DataAwsDmsReplicationSubnetGroup.DataAwsDmsReplicationSubnetGroup =
            let config = aws.DataAwsDmsReplicationSubnetGroup.DataAwsDmsReplicationSubnetGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDmsReplicationSubnetGroup.DataAwsDmsReplicationSubnetGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsDmsReplicationSubnetGroup: missing required arguments. Must call: replication_subnet_group_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsDmsReplicationSubnetGroupState<_>) : aws.DataAwsDmsReplicationSubnetGroup.DataAwsDmsReplicationSubnetGroup =
            Unchecked.defaultof<aws.DataAwsDmsReplicationSubnetGroup.DataAwsDmsReplicationSubnetGroup>

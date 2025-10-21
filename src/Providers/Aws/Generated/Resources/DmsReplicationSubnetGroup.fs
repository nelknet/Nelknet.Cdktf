namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DmsReplicationSubnetGroupState<'ReplicationSubnetGroupDescription, 'ReplicationSubnetGroupId, 'SubnetIds> = { assignments: ResizeArray<aws.DmsReplicationSubnetGroup.DmsReplicationSubnetGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_subnet_group">aws_dms_replication_subnet_group</a>.
    /// </summary>
    type DmsReplicationSubnetGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DmsReplicationSubnetGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DmsReplicationSubnetGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : DmsReplicationSubnetGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DmsReplicationSubnetGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_subnet_group#replication_subnet_group_description-1">DmsReplicationSubnetGroup#replication_subnet_group_description</a>.
        /// </summary>
        [<CustomOperation "replication_subnet_group_description">]
        member _.ReplicationSubnetGroupDescription(state: DmsReplicationSubnetGroupState<Missing, 'ReplicationSubnetGroupId, 'SubnetIds>, value: string) : DmsReplicationSubnetGroupState<Present, 'ReplicationSubnetGroupId, 'SubnetIds> =
            state.assignments.Add(fun config -> config.ReplicationSubnetGroupDescription <- value)
            ({ assignments = state.assignments } : DmsReplicationSubnetGroupState<Present, 'ReplicationSubnetGroupId, 'SubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_subnet_group#replication_subnet_group_id-1">DmsReplicationSubnetGroup#replication_subnet_group_id</a>.
        /// </summary>
        [<CustomOperation "replication_subnet_group_id">]
        member _.ReplicationSubnetGroupId(state: DmsReplicationSubnetGroupState<'ReplicationSubnetGroupDescription, Missing, 'SubnetIds>, value: string) : DmsReplicationSubnetGroupState<'ReplicationSubnetGroupDescription, Present, 'SubnetIds> =
            state.assignments.Add(fun config -> config.ReplicationSubnetGroupId <- value)
            ({ assignments = state.assignments } : DmsReplicationSubnetGroupState<'ReplicationSubnetGroupDescription, Present, 'SubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_subnet_group#subnet_ids-1">DmsReplicationSubnetGroup#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: DmsReplicationSubnetGroupState<'ReplicationSubnetGroupDescription, 'ReplicationSubnetGroupId, Missing>, value: seq<string>) : DmsReplicationSubnetGroupState<'ReplicationSubnetGroupDescription, 'ReplicationSubnetGroupId, Present> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DmsReplicationSubnetGroupState<'ReplicationSubnetGroupDescription, 'ReplicationSubnetGroupId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_subnet_group#id-1">DmsReplicationSubnetGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DmsReplicationSubnetGroupState<'ReplicationSubnetGroupDescription, 'ReplicationSubnetGroupId, 'SubnetIds>, value: string) : DmsReplicationSubnetGroupState<'ReplicationSubnetGroupDescription, 'ReplicationSubnetGroupId, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DmsReplicationSubnetGroupState<'ReplicationSubnetGroupDescription, 'ReplicationSubnetGroupId, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_subnet_group#tags-1">DmsReplicationSubnetGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DmsReplicationSubnetGroupState<'ReplicationSubnetGroupDescription, 'ReplicationSubnetGroupId, 'SubnetIds>, value: seq<string * string>) : DmsReplicationSubnetGroupState<'ReplicationSubnetGroupDescription, 'ReplicationSubnetGroupId, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DmsReplicationSubnetGroupState<'ReplicationSubnetGroupDescription, 'ReplicationSubnetGroupId, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_subnet_group#tags_all-1">DmsReplicationSubnetGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DmsReplicationSubnetGroupState<'ReplicationSubnetGroupDescription, 'ReplicationSubnetGroupId, 'SubnetIds>, value: seq<string * string>) : DmsReplicationSubnetGroupState<'ReplicationSubnetGroupDescription, 'ReplicationSubnetGroupId, 'SubnetIds> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DmsReplicationSubnetGroupState<'ReplicationSubnetGroupDescription, 'ReplicationSubnetGroupId, 'SubnetIds>

        member _.Run(state: DmsReplicationSubnetGroupState<Present, Present, Present>) : aws.DmsReplicationSubnetGroup.DmsReplicationSubnetGroup =
            let config = aws.DmsReplicationSubnetGroup.DmsReplicationSubnetGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DmsReplicationSubnetGroup.DmsReplicationSubnetGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dmsReplicationSubnetGroup: missing required arguments. Must call: replication_subnet_group_description, replication_subnet_group_id, subnet_ids.", 9999, IsError = true)>]
        member _.Run(_: DmsReplicationSubnetGroupState<_, _, _>) : aws.DmsReplicationSubnetGroup.DmsReplicationSubnetGroup =
            Unchecked.defaultof<aws.DmsReplicationSubnetGroup.DmsReplicationSubnetGroup>

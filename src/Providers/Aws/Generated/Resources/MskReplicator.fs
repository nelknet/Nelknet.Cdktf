namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, 'ReplicatorName, 'ServiceExecutionRoleArn> = { assignments: ResizeArray<aws.MskReplicator.MskReplicatorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator">aws_msk_replicator</a>.
    /// </summary>
    type MskReplicatorBuilder(logicalId: string) =
        member _.Yield(_: unit) : MskReplicatorState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MskReplicatorState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MskReplicatorState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MskReplicatorState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// kafka_cluster block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#kafka_cluster-1">MskReplicator#kafka_cluster</a> Accepts: aws.IResolvable | aws.MskReplicator.MskReplicatorKafkaCluster[]
        /// </summary>
        [<CustomOperation "kafka_cluster">]
        member _.KafkaCluster(state: MskReplicatorState<Missing, 'ReplicationInfoList, 'ReplicatorName, 'ServiceExecutionRoleArn>, value: HashiCorp.Cdktf.IResolvable) : MskReplicatorState<Present, 'ReplicationInfoList, 'ReplicatorName, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.KafkaCluster <- value)
            ({ assignments = state.assignments } : MskReplicatorState<Present, 'ReplicationInfoList, 'ReplicatorName, 'ServiceExecutionRoleArn>)

        /// <summary>
        /// replication_info_list block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#replication_info_list-1">MskReplicator#replication_info_list</a>
        /// </summary>
        [<CustomOperation "replication_info_list">]
        member _.ReplicationInfoList(state: MskReplicatorState<'KafkaCluster, Missing, 'ReplicatorName, 'ServiceExecutionRoleArn>, value: aws.MskReplicator.MskReplicatorReplicationInfoListStruct) : MskReplicatorState<'KafkaCluster, Present, 'ReplicatorName, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.ReplicationInfoList <- value)
            ({ assignments = state.assignments } : MskReplicatorState<'KafkaCluster, Present, 'ReplicatorName, 'ServiceExecutionRoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#replicator_name-1">MskReplicator#replicator_name</a>.
        /// </summary>
        [<CustomOperation "replicator_name">]
        member _.ReplicatorName(state: MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, Missing, 'ServiceExecutionRoleArn>, value: string) : MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, Present, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.ReplicatorName <- value)
            ({ assignments = state.assignments } : MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, Present, 'ServiceExecutionRoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#service_execution_role_arn-1">MskReplicator#service_execution_role_arn</a>.
        /// </summary>
        [<CustomOperation "service_execution_role_arn">]
        member _.ServiceExecutionRoleArn(state: MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, 'ReplicatorName, Missing>, value: string) : MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, 'ReplicatorName, Present> =
            state.assignments.Add(fun config -> config.ServiceExecutionRoleArn <- value)
            ({ assignments = state.assignments } : MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, 'ReplicatorName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#description-1">MskReplicator#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, 'ReplicatorName, 'ServiceExecutionRoleArn>, value: string) : MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, 'ReplicatorName, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, 'ReplicatorName, 'ServiceExecutionRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#id-1">MskReplicator#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, 'ReplicatorName, 'ServiceExecutionRoleArn>, value: string) : MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, 'ReplicatorName, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, 'ReplicatorName, 'ServiceExecutionRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#tags-1">MskReplicator#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, 'ReplicatorName, 'ServiceExecutionRoleArn>, value: seq<string * string>) : MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, 'ReplicatorName, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, 'ReplicatorName, 'ServiceExecutionRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#tags_all-1">MskReplicator#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, 'ReplicatorName, 'ServiceExecutionRoleArn>, value: seq<string * string>) : MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, 'ReplicatorName, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, 'ReplicatorName, 'ServiceExecutionRoleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#timeouts-1">MskReplicator#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, 'ReplicatorName, 'ServiceExecutionRoleArn>, value: aws.MskReplicator.MskReplicatorTimeouts) : MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, 'ReplicatorName, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MskReplicatorState<'KafkaCluster, 'ReplicationInfoList, 'ReplicatorName, 'ServiceExecutionRoleArn>

        member _.Run(state: MskReplicatorState<Present, Present, Present, Present>) : aws.MskReplicator.MskReplicator =
            let config = aws.MskReplicator.MskReplicatorConfig()
            for setter in state.assignments do
                setter config
            aws.MskReplicator.MskReplicator(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mskReplicator: missing required arguments. Must call: kafka_cluster, replication_info_list, replicator_name, service_execution_role_arn.", 9999, IsError = true)>]
        member _.Run(_: MskReplicatorState<_, _, _, _>) : aws.MskReplicator.MskReplicator =
            Unchecked.defaultof<aws.MskReplicator.MskReplicator>

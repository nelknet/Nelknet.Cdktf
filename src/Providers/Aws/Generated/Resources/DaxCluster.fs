namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor> = { assignments: ResizeArray<aws.DaxCluster.DaxClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_cluster">aws_dax_cluster</a>.
    /// </summary>
    type DaxClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DaxClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DaxClusterState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DaxClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DaxClusterState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_cluster#cluster_name-1">DaxCluster#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: DaxClusterState<Missing, 'IamRoleArn, 'NodeType, 'ReplicationFactor>, value: string) : DaxClusterState<Present, 'IamRoleArn, 'NodeType, 'ReplicationFactor> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : DaxClusterState<Present, 'IamRoleArn, 'NodeType, 'ReplicationFactor>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_cluster#iam_role_arn-1">DaxCluster#iam_role_arn</a>.
        /// </summary>
        [<CustomOperation "iam_role_arn">]
        member _.IamRoleArn(state: DaxClusterState<'ClusterName, Missing, 'NodeType, 'ReplicationFactor>, value: string) : DaxClusterState<'ClusterName, Present, 'NodeType, 'ReplicationFactor> =
            state.assignments.Add(fun config -> config.IamRoleArn <- value)
            ({ assignments = state.assignments } : DaxClusterState<'ClusterName, Present, 'NodeType, 'ReplicationFactor>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_cluster#node_type-1">DaxCluster#node_type</a>.
        /// </summary>
        [<CustomOperation "node_type">]
        member _.NodeType(state: DaxClusterState<'ClusterName, 'IamRoleArn, Missing, 'ReplicationFactor>, value: string) : DaxClusterState<'ClusterName, 'IamRoleArn, Present, 'ReplicationFactor> =
            state.assignments.Add(fun config -> config.NodeType <- value)
            ({ assignments = state.assignments } : DaxClusterState<'ClusterName, 'IamRoleArn, Present, 'ReplicationFactor>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_cluster#replication_factor-1">DaxCluster#replication_factor</a>.
        /// </summary>
        [<CustomOperation "replication_factor">]
        member _.ReplicationFactor(state: DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, Missing>, value: double) : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, Present> =
            state.assignments.Add(fun config -> config.ReplicationFactor <- value)
            ({ assignments = state.assignments } : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_cluster#availability_zones-1">DaxCluster#availability_zones</a>.
        /// </summary>
        [<CustomOperation "availability_zones">]
        member _.AvailabilityZones(state: DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>, value: seq<string>) : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor> =
            state.assignments.Add(fun config -> config.AvailabilityZones <- (value |> Seq.toArray))
            state : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_cluster#cluster_endpoint_encryption_type-1">DaxCluster#cluster_endpoint_encryption_type</a>.
        /// </summary>
        [<CustomOperation "cluster_endpoint_encryption_type">]
        member _.ClusterEndpointEncryptionType(state: DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>, value: string) : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor> =
            state.assignments.Add(fun config -> config.ClusterEndpointEncryptionType <- value)
            state : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_cluster#description-1">DaxCluster#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>, value: string) : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_cluster#id-1">DaxCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>, value: string) : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_cluster#maintenance_window-1">DaxCluster#maintenance_window</a>.
        /// </summary>
        [<CustomOperation "maintenance_window">]
        member _.MaintenanceWindow(state: DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>, value: string) : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor> =
            state.assignments.Add(fun config -> config.MaintenanceWindow <- value)
            state : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_cluster#notification_topic_arn-1">DaxCluster#notification_topic_arn</a>.
        /// </summary>
        [<CustomOperation "notification_topic_arn">]
        member _.NotificationTopicArn(state: DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>, value: string) : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor> =
            state.assignments.Add(fun config -> config.NotificationTopicArn <- value)
            state : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_cluster#parameter_group_name-1">DaxCluster#parameter_group_name</a>.
        /// </summary>
        [<CustomOperation "parameter_group_name">]
        member _.ParameterGroupName(state: DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>, value: string) : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor> =
            state.assignments.Add(fun config -> config.ParameterGroupName <- value)
            state : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_cluster#security_group_ids-1">DaxCluster#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>, value: seq<string>) : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>

        /// <summary>
        /// server_side_encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_cluster#server_side_encryption-1">DaxCluster#server_side_encryption</a>
        /// </summary>
        [<CustomOperation "server_side_encryption">]
        member _.ServerSideEncryption(state: DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>, value: aws.DaxCluster.DaxClusterServerSideEncryption) : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor> =
            state.assignments.Add(fun config -> config.ServerSideEncryption <- value)
            state : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_cluster#subnet_group_name-1">DaxCluster#subnet_group_name</a>.
        /// </summary>
        [<CustomOperation "subnet_group_name">]
        member _.SubnetGroupName(state: DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>, value: string) : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor> =
            state.assignments.Add(fun config -> config.SubnetGroupName <- value)
            state : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_cluster#tags-1">DaxCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>, value: seq<string * string>) : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_cluster#tags_all-1">DaxCluster#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>, value: seq<string * string>) : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_cluster#timeouts-1">DaxCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>, value: aws.DaxCluster.DaxClusterTimeouts) : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DaxClusterState<'ClusterName, 'IamRoleArn, 'NodeType, 'ReplicationFactor>

        member _.Run(state: DaxClusterState<Present, Present, Present, Present>) : aws.DaxCluster.DaxCluster =
            let config = aws.DaxCluster.DaxClusterConfig()
            for setter in state.assignments do
                setter config
            aws.DaxCluster.DaxCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.daxCluster: missing required arguments. Must call: cluster_name, iam_role_arn, node_type, replication_factor.", 9999, IsError = true)>]
        member _.Run(_: DaxClusterState<_, _, _, _>) : aws.DaxCluster.DaxCluster =
            Unchecked.defaultof<aws.DaxCluster.DaxCluster>

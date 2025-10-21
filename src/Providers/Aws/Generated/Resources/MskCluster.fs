namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes> = { assignments: ResizeArray<aws.MskCluster.MskClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster">aws_msk_cluster</a>.
    /// </summary>
    type MskClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : MskClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MskClusterState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MskClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MskClusterState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// broker_node_group_info block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#broker_node_group_info-1">MskCluster#broker_node_group_info</a>
        /// </summary>
        [<CustomOperation "broker_node_group_info">]
        member _.BrokerNodeGroupInfo(state: MskClusterState<Missing, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>, value: aws.MskCluster.MskClusterBrokerNodeGroupInfo) : MskClusterState<Present, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes> =
            state.assignments.Add(fun config -> config.BrokerNodeGroupInfo <- value)
            ({ assignments = state.assignments } : MskClusterState<Present, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#cluster_name-1">MskCluster#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: MskClusterState<'BrokerNodeGroupInfo, Missing, 'KafkaVersion, 'NumberOfBrokerNodes>, value: string) : MskClusterState<'BrokerNodeGroupInfo, Present, 'KafkaVersion, 'NumberOfBrokerNodes> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : MskClusterState<'BrokerNodeGroupInfo, Present, 'KafkaVersion, 'NumberOfBrokerNodes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#kafka_version-1">MskCluster#kafka_version</a>.
        /// </summary>
        [<CustomOperation "kafka_version">]
        member _.KafkaVersion(state: MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, Missing, 'NumberOfBrokerNodes>, value: string) : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, Present, 'NumberOfBrokerNodes> =
            state.assignments.Add(fun config -> config.KafkaVersion <- value)
            ({ assignments = state.assignments } : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, Present, 'NumberOfBrokerNodes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#number_of_broker_nodes-1">MskCluster#number_of_broker_nodes</a>.
        /// </summary>
        [<CustomOperation "number_of_broker_nodes">]
        member _.NumberOfBrokerNodes(state: MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, Missing>, value: double) : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, Present> =
            state.assignments.Add(fun config -> config.NumberOfBrokerNodes <- value)
            ({ assignments = state.assignments } : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, Present>)

        /// <summary>
        /// client_authentication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#client_authentication-1">MskCluster#client_authentication</a>
        /// </summary>
        [<CustomOperation "client_authentication">]
        member _.ClientAuthentication(state: MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>, value: aws.MskCluster.MskClusterClientAuthentication) : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes> =
            state.assignments.Add(fun config -> config.ClientAuthentication <- value)
            state : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>

        /// <summary>
        /// configuration_info block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#configuration_info-1">MskCluster#configuration_info</a>
        /// </summary>
        [<CustomOperation "configuration_info">]
        member _.ConfigurationInfo(state: MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>, value: aws.MskCluster.MskClusterConfigurationInfo) : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes> =
            state.assignments.Add(fun config -> config.ConfigurationInfo <- value)
            state : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>

        /// <summary>
        /// encryption_info block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#encryption_info-1">MskCluster#encryption_info</a>
        /// </summary>
        [<CustomOperation "encryption_info">]
        member _.EncryptionInfo(state: MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>, value: aws.MskCluster.MskClusterEncryptionInfo) : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes> =
            state.assignments.Add(fun config -> config.EncryptionInfo <- value)
            state : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#enhanced_monitoring-1">MskCluster#enhanced_monitoring</a>.
        /// </summary>
        [<CustomOperation "enhanced_monitoring">]
        member _.EnhancedMonitoring(state: MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>, value: string) : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes> =
            state.assignments.Add(fun config -> config.EnhancedMonitoring <- value)
            state : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#id-1">MskCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>, value: string) : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>

        /// <summary>
        /// logging_info block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#logging_info-1">MskCluster#logging_info</a>
        /// </summary>
        [<CustomOperation "logging_info">]
        member _.LoggingInfo(state: MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>, value: aws.MskCluster.MskClusterLoggingInfo) : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes> =
            state.assignments.Add(fun config -> config.LoggingInfo <- value)
            state : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>

        /// <summary>
        /// open_monitoring block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#open_monitoring-1">MskCluster#open_monitoring</a>
        /// </summary>
        [<CustomOperation "open_monitoring">]
        member _.OpenMonitoring(state: MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>, value: aws.MskCluster.MskClusterOpenMonitoring) : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes> =
            state.assignments.Add(fun config -> config.OpenMonitoring <- value)
            state : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#storage_mode-1">MskCluster#storage_mode</a>.
        /// </summary>
        [<CustomOperation "storage_mode">]
        member _.StorageMode(state: MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>, value: string) : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes> =
            state.assignments.Add(fun config -> config.StorageMode <- value)
            state : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#tags-1">MskCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>, value: seq<string * string>) : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#tags_all-1">MskCluster#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>, value: seq<string * string>) : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#timeouts-1">MskCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>, value: aws.MskCluster.MskClusterTimeouts) : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MskClusterState<'BrokerNodeGroupInfo, 'ClusterName, 'KafkaVersion, 'NumberOfBrokerNodes>

        member _.Run(state: MskClusterState<Present, Present, Present, Present>) : aws.MskCluster.MskCluster =
            let config = aws.MskCluster.MskClusterConfig()
            for setter in state.assignments do
                setter config
            aws.MskCluster.MskCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mskCluster: missing required arguments. Must call: broker_node_group_info, cluster_name, kafka_version, number_of_broker_nodes.", 9999, IsError = true)>]
        member _.Run(_: MskClusterState<_, _, _, _>) : aws.MskCluster.MskCluster =
            Unchecked.defaultof<aws.MskCluster.MskCluster>

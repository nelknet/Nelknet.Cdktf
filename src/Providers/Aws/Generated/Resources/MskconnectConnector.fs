namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn> = { assignments: ResizeArray<aws.MskconnectConnector.MskconnectConnectorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector">aws_mskconnect_connector</a>.
    /// </summary>
    type MskconnectConnectorBuilder(logicalId: string) =
        member _.Yield(_: unit) : MskconnectConnectorState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MskconnectConnectorState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MskconnectConnectorState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MskconnectConnectorState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// capacity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#capacity-1">MskconnectConnector#capacity</a>
        /// </summary>
        [<CustomOperation "capacity">]
        member _.Capacity(state: MskconnectConnectorState<Missing, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>, value: aws.MskconnectConnector.MskconnectConnectorCapacity) : MskconnectConnectorState<Present, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.Capacity <- value)
            ({ assignments = state.assignments } : MskconnectConnectorState<Present, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#connector_configuration-1">MskconnectConnector#connector_configuration</a>.
        /// </summary>
        [<CustomOperation "connector_configuration">]
        member _.ConnectorConfiguration(state: MskconnectConnectorState<'Capacity, Missing, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>, value: seq<string * string>) : MskconnectConnectorState<'Capacity, Present, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.ConnectorConfiguration <- dict value)
            ({ assignments = state.assignments } : MskconnectConnectorState<'Capacity, Present, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>)

        /// <summary>
        /// kafka_cluster block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#kafka_cluster-1">MskconnectConnector#kafka_cluster</a>
        /// </summary>
        [<CustomOperation "kafka_cluster">]
        member _.KafkaCluster(state: MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, Missing, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>, value: aws.MskconnectConnector.MskconnectConnectorKafkaCluster) : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, Present, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.KafkaCluster <- value)
            ({ assignments = state.assignments } : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, Present, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>)

        /// <summary>
        /// kafka_cluster_client_authentication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#kafka_cluster_client_authentication-1">MskconnectConnector#kafka_cluster_client_authentication</a>
        /// </summary>
        [<CustomOperation "kafka_cluster_client_authentication">]
        member _.KafkaClusterClientAuthentication(state: MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, Missing, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>, value: aws.MskconnectConnector.MskconnectConnectorKafkaClusterClientAuthentication) : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, Present, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.KafkaClusterClientAuthentication <- value)
            ({ assignments = state.assignments } : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, Present, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>)

        /// <summary>
        /// kafka_cluster_encryption_in_transit block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#kafka_cluster_encryption_in_transit-1">MskconnectConnector#kafka_cluster_encryption_in_transit</a>
        /// </summary>
        [<CustomOperation "kafka_cluster_encryption_in_transit">]
        member _.KafkaClusterEncryptionInTransit(state: MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, Missing, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>, value: aws.MskconnectConnector.MskconnectConnectorKafkaClusterEncryptionInTransit) : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, Present, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.KafkaClusterEncryptionInTransit <- value)
            ({ assignments = state.assignments } : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, Present, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#kafkaconnect_version-1">MskconnectConnector#kafkaconnect_version</a>.
        /// </summary>
        [<CustomOperation "kafkaconnect_version">]
        member _.KafkaconnectVersion(state: MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, Missing, 'Name, 'Plugin, 'ServiceExecutionRoleArn>, value: string) : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, Present, 'Name, 'Plugin, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.KafkaconnectVersion <- value)
            ({ assignments = state.assignments } : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, Present, 'Name, 'Plugin, 'ServiceExecutionRoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#name-1">MskconnectConnector#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, Missing, 'Plugin, 'ServiceExecutionRoleArn>, value: string) : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, Present, 'Plugin, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, Present, 'Plugin, 'ServiceExecutionRoleArn>)

        /// <summary>
        /// plugin block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#plugin-1">MskconnectConnector#plugin</a> Accepts: aws.IResolvable | aws.MskconnectConnector.MskconnectConnectorPlugin[]
        /// </summary>
        [<CustomOperation "plugin">]
        member _.Plugin(state: MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, Missing, 'ServiceExecutionRoleArn>, value: HashiCorp.Cdktf.IResolvable) : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, Present, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.Plugin <- value)
            ({ assignments = state.assignments } : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, Present, 'ServiceExecutionRoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#service_execution_role_arn-1">MskconnectConnector#service_execution_role_arn</a>.
        /// </summary>
        [<CustomOperation "service_execution_role_arn">]
        member _.ServiceExecutionRoleArn(state: MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, Missing>, value: string) : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, Present> =
            state.assignments.Add(fun config -> config.ServiceExecutionRoleArn <- value)
            ({ assignments = state.assignments } : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#description-1">MskconnectConnector#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>, value: string) : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#id-1">MskconnectConnector#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>, value: string) : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>

        /// <summary>
        /// log_delivery block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#log_delivery-1">MskconnectConnector#log_delivery</a>
        /// </summary>
        [<CustomOperation "log_delivery">]
        member _.LogDelivery(state: MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>, value: aws.MskconnectConnector.MskconnectConnectorLogDelivery) : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.LogDelivery <- value)
            state : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#tags-1">MskconnectConnector#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>, value: seq<string * string>) : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#tags_all-1">MskconnectConnector#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>, value: seq<string * string>) : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#timeouts-1">MskconnectConnector#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>, value: aws.MskconnectConnector.MskconnectConnectorTimeouts) : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>

        /// <summary>
        /// worker_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#worker_configuration-1">MskconnectConnector#worker_configuration</a>
        /// </summary>
        [<CustomOperation "worker_configuration">]
        member _.WorkerConfiguration(state: MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>, value: aws.MskconnectConnector.MskconnectConnectorWorkerConfiguration) : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn> =
            state.assignments.Add(fun config -> config.WorkerConfiguration <- value)
            state : MskconnectConnectorState<'Capacity, 'ConnectorConfiguration, 'KafkaCluster, 'KafkaClusterClientAuthentication, 'KafkaClusterEncryptionInTransit, 'KafkaconnectVersion, 'Name, 'Plugin, 'ServiceExecutionRoleArn>

        member _.Run(state: MskconnectConnectorState<Present, Present, Present, Present, Present, Present, Present, Present, Present>) : aws.MskconnectConnector.MskconnectConnector =
            let config = aws.MskconnectConnector.MskconnectConnectorConfig()
            for setter in state.assignments do
                setter config
            aws.MskconnectConnector.MskconnectConnector(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mskconnectConnector: missing required arguments. Must call: capacity, connector_configuration, kafka_cluster, kafka_cluster_client_authentication, kafka_cluster_encryption_in_transit, kafkaconnect_version, name, plugin, service_execution_role_arn.", 9999, IsError = true)>]
        member _.Run(_: MskconnectConnectorState<_, _, _, _, _, _, _, _, _>) : aws.MskconnectConnector.MskconnectConnector =
            Unchecked.defaultof<aws.MskconnectConnector.MskconnectConnector>

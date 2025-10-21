namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> = { assignments: ResizeArray<aws.MqBroker.MqBrokerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker">aws_mq_broker</a>.
    /// </summary>
    type MqBrokerBuilder(logicalId: string) =
        member _.Yield(_: unit) : MqBrokerState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MqBrokerState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MqBrokerState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MqBrokerState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#broker_name-1">MqBroker#broker_name</a>.
        /// </summary>
        [<CustomOperation "broker_name">]
        member _.BrokerName(state: MqBrokerState<Missing, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: string) : MqBrokerState<Present, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.BrokerName <- value)
            ({ assignments = state.assignments } : MqBrokerState<Present, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#engine_type-1">MqBroker#engine_type</a>.
        /// </summary>
        [<CustomOperation "engine_type">]
        member _.EngineType(state: MqBrokerState<'BrokerName, Missing, 'EngineVersion, 'HostInstanceType, 'User>, value: string) : MqBrokerState<'BrokerName, Present, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.EngineType <- value)
            ({ assignments = state.assignments } : MqBrokerState<'BrokerName, Present, 'EngineVersion, 'HostInstanceType, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#engine_version-1">MqBroker#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: MqBrokerState<'BrokerName, 'EngineType, Missing, 'HostInstanceType, 'User>, value: string) : MqBrokerState<'BrokerName, 'EngineType, Present, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            ({ assignments = state.assignments } : MqBrokerState<'BrokerName, 'EngineType, Present, 'HostInstanceType, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#host_instance_type-1">MqBroker#host_instance_type</a>.
        /// </summary>
        [<CustomOperation "host_instance_type">]
        member _.HostInstanceType(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, Missing, 'User>, value: string) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, Present, 'User> =
            state.assignments.Add(fun config -> config.HostInstanceType <- value)
            ({ assignments = state.assignments } : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, Present, 'User>)

        /// <summary>
        /// user block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#user-1">MqBroker#user</a> Accepts: aws.IResolvable | aws.MqBroker.MqBrokerUser[]
        /// </summary>
        [<CustomOperation "user">]
        member _.User(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, Missing>, value: HashiCorp.Cdktf.IResolvable) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, Present> =
            state.assignments.Add(fun config -> config.User <- value)
            ({ assignments = state.assignments } : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#apply_immediately-1">MqBroker#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: bool) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#apply_immediately-1">MqBroker#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: HashiCorp.Cdktf.IResolvable) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#authentication_strategy-1">MqBroker#authentication_strategy</a>.
        /// </summary>
        [<CustomOperation "authentication_strategy">]
        member _.AuthenticationStrategy(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: string) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.AuthenticationStrategy <- value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#auto_minor_version_upgrade-1">MqBroker#auto_minor_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_minor_version_upgrade">]
        member _.AutoMinorVersionUpgrade(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: bool) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.AutoMinorVersionUpgrade <- value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#auto_minor_version_upgrade-1">MqBroker#auto_minor_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_minor_version_upgrade">]
        member _.AutoMinorVersionUpgrade(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: HashiCorp.Cdktf.IResolvable) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.AutoMinorVersionUpgrade <- value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#configuration-1">MqBroker#configuration</a>
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: aws.MqBroker.MqBrokerConfiguration) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#data_replication_mode-1">MqBroker#data_replication_mode</a>.
        /// </summary>
        [<CustomOperation "data_replication_mode">]
        member _.DataReplicationMode(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: string) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.DataReplicationMode <- value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#data_replication_primary_broker_arn-1">MqBroker#data_replication_primary_broker_arn</a>.
        /// </summary>
        [<CustomOperation "data_replication_primary_broker_arn">]
        member _.DataReplicationPrimaryBrokerArn(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: string) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.DataReplicationPrimaryBrokerArn <- value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#deployment_mode-1">MqBroker#deployment_mode</a>.
        /// </summary>
        [<CustomOperation "deployment_mode">]
        member _.DeploymentMode(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: string) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.DeploymentMode <- value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// encryption_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#encryption_options-1">MqBroker#encryption_options</a>
        /// </summary>
        [<CustomOperation "encryption_options">]
        member _.EncryptionOptions(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: aws.MqBroker.MqBrokerEncryptionOptions) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.EncryptionOptions <- value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#id-1">MqBroker#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: string) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// ldap_server_metadata block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#ldap_server_metadata-1">MqBroker#ldap_server_metadata</a>
        /// </summary>
        [<CustomOperation "ldap_server_metadata">]
        member _.LdapServerMetadata(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: aws.MqBroker.MqBrokerLdapServerMetadata) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.LdapServerMetadata <- value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// logs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#logs-1">MqBroker#logs</a>
        /// </summary>
        [<CustomOperation "logs">]
        member _.Logs(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: aws.MqBroker.MqBrokerLogs) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.Logs <- value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// maintenance_window_start_time block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#maintenance_window_start_time-1">MqBroker#maintenance_window_start_time</a>
        /// </summary>
        [<CustomOperation "maintenance_window_start_time">]
        member _.MaintenanceWindowStartTime(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: aws.MqBroker.MqBrokerMaintenanceWindowStartTime) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.MaintenanceWindowStartTime <- value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#publicly_accessible-1">MqBroker#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: bool) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#publicly_accessible-1">MqBroker#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: HashiCorp.Cdktf.IResolvable) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#security_groups-1">MqBroker#security_groups</a>.
        /// </summary>
        [<CustomOperation "security_groups">]
        member _.SecurityGroups(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: seq<string>) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.SecurityGroups <- (value |> Seq.toArray))
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#storage_type-1">MqBroker#storage_type</a>.
        /// </summary>
        [<CustomOperation "storage_type">]
        member _.StorageType(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: string) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.StorageType <- value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#subnet_ids-1">MqBroker#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: seq<string>) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#tags-1">MqBroker#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: seq<string * string>) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#tags_all-1">MqBroker#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: seq<string * string>) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#timeouts-1">MqBroker#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>, value: aws.MqBroker.MqBrokerTimeouts) : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MqBrokerState<'BrokerName, 'EngineType, 'EngineVersion, 'HostInstanceType, 'User>

        member _.Run(state: MqBrokerState<Present, Present, Present, Present, Present>) : aws.MqBroker.MqBroker =
            let config = aws.MqBroker.MqBrokerConfig()
            for setter in state.assignments do
                setter config
            aws.MqBroker.MqBroker(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mqBroker: missing required arguments. Must call: broker_name, engine_type, engine_version, host_instance_type, user.", 9999, IsError = true)>]
        member _.Run(_: MqBrokerState<_, _, _, _, _>) : aws.MqBroker.MqBroker =
            Unchecked.defaultof<aws.MqBroker.MqBroker>

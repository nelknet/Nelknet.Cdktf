namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> = { assignments: ResizeArray<aws.DmsReplicationConfig.DmsReplicationConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_config">aws_dms_replication_config</a>.
    /// </summary>
    type DmsReplicationConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : DmsReplicationConfigState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DmsReplicationConfigState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DmsReplicationConfigState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DmsReplicationConfigState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// compute_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_config#compute_config-1">DmsReplicationConfig#compute_config</a>
        /// </summary>
        [<CustomOperation "compute_config">]
        member _.ComputeConfig(state: DmsReplicationConfigState<Missing, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: aws.DmsReplicationConfig.DmsReplicationConfigComputeConfig) : DmsReplicationConfigState<Present, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.ComputeConfig <- value)
            ({ assignments = state.assignments } : DmsReplicationConfigState<Present, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_config#replication_config_identifier-1">DmsReplicationConfig#replication_config_identifier</a>.
        /// </summary>
        [<CustomOperation "replication_config_identifier">]
        member _.ReplicationConfigIdentifier(state: DmsReplicationConfigState<'ComputeConfig, Missing, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: string) : DmsReplicationConfigState<'ComputeConfig, Present, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.ReplicationConfigIdentifier <- value)
            ({ assignments = state.assignments } : DmsReplicationConfigState<'ComputeConfig, Present, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_config#replication_type-1">DmsReplicationConfig#replication_type</a>.
        /// </summary>
        [<CustomOperation "replication_type">]
        member _.ReplicationType(state: DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, Missing, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: string) : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, Present, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.ReplicationType <- value)
            ({ assignments = state.assignments } : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, Present, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_config#source_endpoint_arn-1">DmsReplicationConfig#source_endpoint_arn</a>.
        /// </summary>
        [<CustomOperation "source_endpoint_arn">]
        member _.SourceEndpointArn(state: DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, Missing, 'TableMappings, 'TargetEndpointArn>, value: string) : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, Present, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.SourceEndpointArn <- value)
            ({ assignments = state.assignments } : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, Present, 'TableMappings, 'TargetEndpointArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_config#table_mappings-1">DmsReplicationConfig#table_mappings</a>.
        /// </summary>
        [<CustomOperation "table_mappings">]
        member _.TableMappings(state: DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, Missing, 'TargetEndpointArn>, value: string) : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, Present, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.TableMappings <- value)
            ({ assignments = state.assignments } : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, Present, 'TargetEndpointArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_config#target_endpoint_arn-1">DmsReplicationConfig#target_endpoint_arn</a>.
        /// </summary>
        [<CustomOperation "target_endpoint_arn">]
        member _.TargetEndpointArn(state: DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, Missing>, value: string) : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, Present> =
            state.assignments.Add(fun config -> config.TargetEndpointArn <- value)
            ({ assignments = state.assignments } : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_config#id-1">DmsReplicationConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: string) : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_config#replication_settings-1">DmsReplicationConfig#replication_settings</a>.
        /// </summary>
        [<CustomOperation "replication_settings">]
        member _.ReplicationSettings(state: DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: string) : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.ReplicationSettings <- value)
            state : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_config#resource_identifier-1">DmsReplicationConfig#resource_identifier</a>.
        /// </summary>
        [<CustomOperation "resource_identifier">]
        member _.ResourceIdentifier(state: DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: string) : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.ResourceIdentifier <- value)
            state : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_config#start_replication-1">DmsReplicationConfig#start_replication</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "start_replication">]
        member _.StartReplication(state: DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: bool) : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.StartReplication <- value)
            state : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_config#start_replication-1">DmsReplicationConfig#start_replication</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "start_replication">]
        member _.StartReplication(state: DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: HashiCorp.Cdktf.IResolvable) : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.StartReplication <- value)
            state : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_config#supplemental_settings-1">DmsReplicationConfig#supplemental_settings</a>.
        /// </summary>
        [<CustomOperation "supplemental_settings">]
        member _.SupplementalSettings(state: DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: string) : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.SupplementalSettings <- value)
            state : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_config#tags-1">DmsReplicationConfig#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: seq<string * string>) : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_config#tags_all-1">DmsReplicationConfig#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: seq<string * string>) : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_replication_config#timeouts-1">DmsReplicationConfig#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>, value: aws.DmsReplicationConfig.DmsReplicationConfigTimeouts) : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DmsReplicationConfigState<'ComputeConfig, 'ReplicationConfigIdentifier, 'ReplicationType, 'SourceEndpointArn, 'TableMappings, 'TargetEndpointArn>

        member _.Run(state: DmsReplicationConfigState<Present, Present, Present, Present, Present, Present>) : aws.DmsReplicationConfig.DmsReplicationConfig =
            let config = aws.DmsReplicationConfig.DmsReplicationConfigConfig()
            for setter in state.assignments do
                setter config
            aws.DmsReplicationConfig.DmsReplicationConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dmsReplicationConfig: missing required arguments. Must call: compute_config, replication_config_identifier, replication_type, source_endpoint_arn, table_mappings, target_endpoint_arn.", 9999, IsError = true)>]
        member _.Run(_: DmsReplicationConfigState<_, _, _, _, _, _>) : aws.DmsReplicationConfig.DmsReplicationConfig =
            Unchecked.defaultof<aws.DmsReplicationConfig.DmsReplicationConfig>

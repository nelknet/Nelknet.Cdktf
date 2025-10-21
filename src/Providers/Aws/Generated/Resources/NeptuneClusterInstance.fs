namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> = { assignments: ResizeArray<aws.NeptuneClusterInstance.NeptuneClusterInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance">aws_neptune_cluster_instance</a>.
    /// </summary>
    type NeptuneClusterInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : NeptuneClusterInstanceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NeptuneClusterInstanceState<Missing, Missing>)

        member _.Zero(()) : NeptuneClusterInstanceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NeptuneClusterInstanceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#cluster_identifier-1">NeptuneClusterInstance#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: NeptuneClusterInstanceState<Missing, 'InstanceClass>, value: string) : NeptuneClusterInstanceState<Present, 'InstanceClass> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            ({ assignments = state.assignments } : NeptuneClusterInstanceState<Present, 'InstanceClass>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#instance_class-1">NeptuneClusterInstance#instance_class</a>.
        /// </summary>
        [<CustomOperation "instance_class">]
        member _.InstanceClass(state: NeptuneClusterInstanceState<'ClusterIdentifier, Missing>, value: string) : NeptuneClusterInstanceState<'ClusterIdentifier, Present> =
            state.assignments.Add(fun config -> config.InstanceClass <- value)
            ({ assignments = state.assignments } : NeptuneClusterInstanceState<'ClusterIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#apply_immediately-1">NeptuneClusterInstance#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: bool) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#apply_immediately-1">NeptuneClusterInstance#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#auto_minor_version_upgrade-1">NeptuneClusterInstance#auto_minor_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_minor_version_upgrade">]
        member _.AutoMinorVersionUpgrade(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: bool) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.AutoMinorVersionUpgrade <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#auto_minor_version_upgrade-1">NeptuneClusterInstance#auto_minor_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_minor_version_upgrade">]
        member _.AutoMinorVersionUpgrade(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.AutoMinorVersionUpgrade <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#availability_zone-1">NeptuneClusterInstance#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: string) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#engine-1">NeptuneClusterInstance#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: string) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.Engine <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#engine_version-1">NeptuneClusterInstance#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: string) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#id-1">NeptuneClusterInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: string) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#identifier-1">NeptuneClusterInstance#identifier</a>.
        /// </summary>
        [<CustomOperation "identifier">]
        member _.Identifier(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: string) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.Identifier <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#identifier_prefix-1">NeptuneClusterInstance#identifier_prefix</a>.
        /// </summary>
        [<CustomOperation "identifier_prefix">]
        member _.IdentifierPrefix(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: string) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.IdentifierPrefix <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#neptune_parameter_group_name-1">NeptuneClusterInstance#neptune_parameter_group_name</a>.
        /// </summary>
        [<CustomOperation "neptune_parameter_group_name">]
        member _.NeptuneParameterGroupName(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: string) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.NeptuneParameterGroupName <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#neptune_subnet_group_name-1">NeptuneClusterInstance#neptune_subnet_group_name</a>.
        /// </summary>
        [<CustomOperation "neptune_subnet_group_name">]
        member _.NeptuneSubnetGroupName(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: string) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.NeptuneSubnetGroupName <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#port-1">NeptuneClusterInstance#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: double) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.Port <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#preferred_backup_window-1">NeptuneClusterInstance#preferred_backup_window</a>.
        /// </summary>
        [<CustomOperation "preferred_backup_window">]
        member _.PreferredBackupWindow(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: string) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.PreferredBackupWindow <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#preferred_maintenance_window-1">NeptuneClusterInstance#preferred_maintenance_window</a>.
        /// </summary>
        [<CustomOperation "preferred_maintenance_window">]
        member _.PreferredMaintenanceWindow(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: string) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.PreferredMaintenanceWindow <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#promotion_tier-1">NeptuneClusterInstance#promotion_tier</a>.
        /// </summary>
        [<CustomOperation "promotion_tier">]
        member _.PromotionTier(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: double) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.PromotionTier <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#publicly_accessible-1">NeptuneClusterInstance#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: bool) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#publicly_accessible-1">NeptuneClusterInstance#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#skip_final_snapshot-1">NeptuneClusterInstance#skip_final_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_snapshot">]
        member _.SkipFinalSnapshot(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: bool) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.SkipFinalSnapshot <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#skip_final_snapshot-1">NeptuneClusterInstance#skip_final_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_final_snapshot">]
        member _.SkipFinalSnapshot(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.SkipFinalSnapshot <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#tags-1">NeptuneClusterInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: seq<string * string>) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#tags_all-1">NeptuneClusterInstance#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: seq<string * string>) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_instance#timeouts-1">NeptuneClusterInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: aws.NeptuneClusterInstance.NeptuneClusterInstanceTimeouts) : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NeptuneClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        member _.Run(state: NeptuneClusterInstanceState<Present, Present>) : aws.NeptuneClusterInstance.NeptuneClusterInstance =
            let config = aws.NeptuneClusterInstance.NeptuneClusterInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.NeptuneClusterInstance.NeptuneClusterInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.neptuneClusterInstance: missing required arguments. Must call: cluster_identifier, instance_class.", 9999, IsError = true)>]
        member _.Run(_: NeptuneClusterInstanceState<_, _>) : aws.NeptuneClusterInstance.NeptuneClusterInstance =
            Unchecked.defaultof<aws.NeptuneClusterInstance.NeptuneClusterInstance>

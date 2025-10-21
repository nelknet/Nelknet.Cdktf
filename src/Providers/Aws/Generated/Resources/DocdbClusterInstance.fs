namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> = { assignments: ResizeArray<aws.DocdbClusterInstance.DocdbClusterInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance">aws_docdb_cluster_instance</a>.
    /// </summary>
    type DocdbClusterInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DocdbClusterInstanceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DocdbClusterInstanceState<Missing, Missing>)

        member _.Zero(()) : DocdbClusterInstanceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DocdbClusterInstanceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#cluster_identifier-1">DocdbClusterInstance#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: DocdbClusterInstanceState<Missing, 'InstanceClass>, value: string) : DocdbClusterInstanceState<Present, 'InstanceClass> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            ({ assignments = state.assignments } : DocdbClusterInstanceState<Present, 'InstanceClass>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#instance_class-1">DocdbClusterInstance#instance_class</a>.
        /// </summary>
        [<CustomOperation "instance_class">]
        member _.InstanceClass(state: DocdbClusterInstanceState<'ClusterIdentifier, Missing>, value: string) : DocdbClusterInstanceState<'ClusterIdentifier, Present> =
            state.assignments.Add(fun config -> config.InstanceClass <- value)
            ({ assignments = state.assignments } : DocdbClusterInstanceState<'ClusterIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#apply_immediately-1">DocdbClusterInstance#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: bool) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#apply_immediately-1">DocdbClusterInstance#apply_immediately</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_immediately">]
        member _.ApplyImmediately(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.ApplyImmediately <- value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#auto_minor_version_upgrade-1">DocdbClusterInstance#auto_minor_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_minor_version_upgrade">]
        member _.AutoMinorVersionUpgrade(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: bool) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.AutoMinorVersionUpgrade <- value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#auto_minor_version_upgrade-1">DocdbClusterInstance#auto_minor_version_upgrade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_minor_version_upgrade">]
        member _.AutoMinorVersionUpgrade(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.AutoMinorVersionUpgrade <- value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#availability_zone-1">DocdbClusterInstance#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: string) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#ca_cert_identifier-1">DocdbClusterInstance#ca_cert_identifier</a>.
        /// </summary>
        [<CustomOperation "ca_cert_identifier">]
        member _.CaCertIdentifier(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: string) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.CaCertIdentifier <- value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#copy_tags_to_snapshot-1">DocdbClusterInstance#copy_tags_to_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_snapshot">]
        member _.CopyTagsToSnapshot(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: bool) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.CopyTagsToSnapshot <- value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#copy_tags_to_snapshot-1">DocdbClusterInstance#copy_tags_to_snapshot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_snapshot">]
        member _.CopyTagsToSnapshot(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.CopyTagsToSnapshot <- value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#enable_performance_insights-1">DocdbClusterInstance#enable_performance_insights</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_performance_insights">]
        member _.EnablePerformanceInsights(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: bool) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.EnablePerformanceInsights <- value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#enable_performance_insights-1">DocdbClusterInstance#enable_performance_insights</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_performance_insights">]
        member _.EnablePerformanceInsights(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: HashiCorp.Cdktf.IResolvable) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.EnablePerformanceInsights <- value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#engine-1">DocdbClusterInstance#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: string) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.Engine <- value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#id-1">DocdbClusterInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: string) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#identifier-1">DocdbClusterInstance#identifier</a>.
        /// </summary>
        [<CustomOperation "identifier">]
        member _.Identifier(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: string) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.Identifier <- value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#identifier_prefix-1">DocdbClusterInstance#identifier_prefix</a>.
        /// </summary>
        [<CustomOperation "identifier_prefix">]
        member _.IdentifierPrefix(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: string) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.IdentifierPrefix <- value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#performance_insights_kms_key_id-1">DocdbClusterInstance#performance_insights_kms_key_id</a>.
        /// </summary>
        [<CustomOperation "performance_insights_kms_key_id">]
        member _.PerformanceInsightsKmsKeyId(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: string) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.PerformanceInsightsKmsKeyId <- value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#preferred_maintenance_window-1">DocdbClusterInstance#preferred_maintenance_window</a>.
        /// </summary>
        [<CustomOperation "preferred_maintenance_window">]
        member _.PreferredMaintenanceWindow(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: string) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.PreferredMaintenanceWindow <- value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#promotion_tier-1">DocdbClusterInstance#promotion_tier</a>.
        /// </summary>
        [<CustomOperation "promotion_tier">]
        member _.PromotionTier(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: double) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.PromotionTier <- value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#tags-1">DocdbClusterInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: seq<string * string>) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#tags_all-1">DocdbClusterInstance#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: seq<string * string>) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_instance#timeouts-1">DocdbClusterInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>, value: aws.DocdbClusterInstance.DocdbClusterInstanceTimeouts) : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DocdbClusterInstanceState<'ClusterIdentifier, 'InstanceClass>

        member _.Run(state: DocdbClusterInstanceState<Present, Present>) : aws.DocdbClusterInstance.DocdbClusterInstance =
            let config = aws.DocdbClusterInstance.DocdbClusterInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.DocdbClusterInstance.DocdbClusterInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.docdbClusterInstance: missing required arguments. Must call: cluster_identifier, instance_class.", 9999, IsError = true)>]
        member _.Run(_: DocdbClusterInstanceState<_, _>) : aws.DocdbClusterInstance.DocdbClusterInstance =
            Unchecked.defaultof<aws.DocdbClusterInstance.DocdbClusterInstance>

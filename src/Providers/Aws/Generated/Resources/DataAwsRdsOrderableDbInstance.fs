namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRdsOrderableDbInstanceState<'Engine> = { assignments: ResizeArray<aws.DataAwsRdsOrderableDbInstance.DataAwsRdsOrderableDbInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance">aws_rds_orderable_db_instance</a>.
    /// </summary>
    type DataAwsRdsOrderableDbInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRdsOrderableDbInstanceState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRdsOrderableDbInstanceState<Missing>)

        member _.Zero(()) : DataAwsRdsOrderableDbInstanceState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRdsOrderableDbInstanceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#engine-1">DataAwsRdsOrderableDbInstance#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: DataAwsRdsOrderableDbInstanceState<Missing>, value: string) : DataAwsRdsOrderableDbInstanceState<Present> =
            state.assignments.Add(fun config -> config.Engine <- value)
            ({ assignments = state.assignments } : DataAwsRdsOrderableDbInstanceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#availability_zone_group-1">DataAwsRdsOrderableDbInstance#availability_zone_group</a>.
        /// </summary>
        [<CustomOperation "availability_zone_group">]
        member _.AvailabilityZoneGroup(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: string) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.AvailabilityZoneGroup <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#engine_latest_version-1">DataAwsRdsOrderableDbInstance#engine_latest_version</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "engine_latest_version">]
        member _.EngineLatestVersion(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: bool) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.EngineLatestVersion <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#engine_latest_version-1">DataAwsRdsOrderableDbInstance#engine_latest_version</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "engine_latest_version">]
        member _.EngineLatestVersion(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.EngineLatestVersion <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#engine_version-1">DataAwsRdsOrderableDbInstance#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: string) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#id-1">DataAwsRdsOrderableDbInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: string) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#instance_class-1">DataAwsRdsOrderableDbInstance#instance_class</a>.
        /// </summary>
        [<CustomOperation "instance_class">]
        member _.InstanceClass(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: string) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.InstanceClass <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#license_model-1">DataAwsRdsOrderableDbInstance#license_model</a>.
        /// </summary>
        [<CustomOperation "license_model">]
        member _.LicenseModel(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: string) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.LicenseModel <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#preferred_engine_versions-1">DataAwsRdsOrderableDbInstance#preferred_engine_versions</a>.
        /// </summary>
        [<CustomOperation "preferred_engine_versions">]
        member _.PreferredEngineVersions(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: seq<string>) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.PreferredEngineVersions <- (value |> Seq.toArray))
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#preferred_instance_classes-1">DataAwsRdsOrderableDbInstance#preferred_instance_classes</a>.
        /// </summary>
        [<CustomOperation "preferred_instance_classes">]
        member _.PreferredInstanceClasses(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: seq<string>) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.PreferredInstanceClasses <- (value |> Seq.toArray))
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#read_replica_capable-1">DataAwsRdsOrderableDbInstance#read_replica_capable</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "read_replica_capable">]
        member _.ReadReplicaCapable(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: bool) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.ReadReplicaCapable <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#read_replica_capable-1">DataAwsRdsOrderableDbInstance#read_replica_capable</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "read_replica_capable">]
        member _.ReadReplicaCapable(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.ReadReplicaCapable <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#storage_type-1">DataAwsRdsOrderableDbInstance#storage_type</a>.
        /// </summary>
        [<CustomOperation "storage_type">]
        member _.StorageType(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: string) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.StorageType <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supported_engine_modes-1">DataAwsRdsOrderableDbInstance#supported_engine_modes</a>.
        /// </summary>
        [<CustomOperation "supported_engine_modes">]
        member _.SupportedEngineModes(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: seq<string>) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportedEngineModes <- (value |> Seq.toArray))
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supported_network_types-1">DataAwsRdsOrderableDbInstance#supported_network_types</a>.
        /// </summary>
        [<CustomOperation "supported_network_types">]
        member _.SupportedNetworkTypes(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: seq<string>) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportedNetworkTypes <- (value |> Seq.toArray))
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_clusters-1">DataAwsRdsOrderableDbInstance#supports_clusters</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_clusters">]
        member _.SupportsClusters(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: bool) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsClusters <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_clusters-1">DataAwsRdsOrderableDbInstance#supports_clusters</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_clusters">]
        member _.SupportsClusters(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsClusters <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_enhanced_monitoring-1">DataAwsRdsOrderableDbInstance#supports_enhanced_monitoring</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_enhanced_monitoring">]
        member _.SupportsEnhancedMonitoring(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: bool) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsEnhancedMonitoring <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_enhanced_monitoring-1">DataAwsRdsOrderableDbInstance#supports_enhanced_monitoring</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_enhanced_monitoring">]
        member _.SupportsEnhancedMonitoring(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsEnhancedMonitoring <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_global_databases-1">DataAwsRdsOrderableDbInstance#supports_global_databases</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_global_databases">]
        member _.SupportsGlobalDatabases(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: bool) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsGlobalDatabases <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_global_databases-1">DataAwsRdsOrderableDbInstance#supports_global_databases</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_global_databases">]
        member _.SupportsGlobalDatabases(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsGlobalDatabases <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_iam_database_authentication-1">DataAwsRdsOrderableDbInstance#supports_iam_database_authentication</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_iam_database_authentication">]
        member _.SupportsIamDatabaseAuthentication(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: bool) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsIamDatabaseAuthentication <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_iam_database_authentication-1">DataAwsRdsOrderableDbInstance#supports_iam_database_authentication</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_iam_database_authentication">]
        member _.SupportsIamDatabaseAuthentication(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsIamDatabaseAuthentication <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_iops-1">DataAwsRdsOrderableDbInstance#supports_iops</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_iops">]
        member _.SupportsIops(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: bool) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsIops <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_iops-1">DataAwsRdsOrderableDbInstance#supports_iops</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_iops">]
        member _.SupportsIops(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsIops <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_kerberos_authentication-1">DataAwsRdsOrderableDbInstance#supports_kerberos_authentication</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_kerberos_authentication">]
        member _.SupportsKerberosAuthentication(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: bool) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsKerberosAuthentication <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_kerberos_authentication-1">DataAwsRdsOrderableDbInstance#supports_kerberos_authentication</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_kerberos_authentication">]
        member _.SupportsKerberosAuthentication(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsKerberosAuthentication <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_multi_az-1">DataAwsRdsOrderableDbInstance#supports_multi_az</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_multi_az">]
        member _.SupportsMultiAz(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: bool) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsMultiAz <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_multi_az-1">DataAwsRdsOrderableDbInstance#supports_multi_az</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_multi_az">]
        member _.SupportsMultiAz(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsMultiAz <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_performance_insights-1">DataAwsRdsOrderableDbInstance#supports_performance_insights</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_performance_insights">]
        member _.SupportsPerformanceInsights(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: bool) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsPerformanceInsights <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_performance_insights-1">DataAwsRdsOrderableDbInstance#supports_performance_insights</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_performance_insights">]
        member _.SupportsPerformanceInsights(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsPerformanceInsights <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_storage_autoscaling-1">DataAwsRdsOrderableDbInstance#supports_storage_autoscaling</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_storage_autoscaling">]
        member _.SupportsStorageAutoscaling(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: bool) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsStorageAutoscaling <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_storage_autoscaling-1">DataAwsRdsOrderableDbInstance#supports_storage_autoscaling</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_storage_autoscaling">]
        member _.SupportsStorageAutoscaling(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsStorageAutoscaling <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_storage_encryption-1">DataAwsRdsOrderableDbInstance#supports_storage_encryption</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_storage_encryption">]
        member _.SupportsStorageEncryption(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: bool) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsStorageEncryption <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#supports_storage_encryption-1">DataAwsRdsOrderableDbInstance#supports_storage_encryption</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "supports_storage_encryption">]
        member _.SupportsStorageEncryption(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.SupportsStorageEncryption <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#vpc-1">DataAwsRdsOrderableDbInstance#vpc</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "vpc">]
        member _.Vpc(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: bool) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.Vpc <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_orderable_db_instance#vpc-1">DataAwsRdsOrderableDbInstance#vpc</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "vpc">]
        member _.Vpc(state: DataAwsRdsOrderableDbInstanceState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsOrderableDbInstanceState<'Engine> =
            state.assignments.Add(fun config -> config.Vpc <- value)
            state : DataAwsRdsOrderableDbInstanceState<'Engine>

        member _.Run(state: DataAwsRdsOrderableDbInstanceState<Present>) : aws.DataAwsRdsOrderableDbInstance.DataAwsRdsOrderableDbInstance =
            let config = aws.DataAwsRdsOrderableDbInstance.DataAwsRdsOrderableDbInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRdsOrderableDbInstance.DataAwsRdsOrderableDbInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRdsOrderableDbInstance: missing required arguments. Must call: engine.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRdsOrderableDbInstanceState<_>) : aws.DataAwsRdsOrderableDbInstance.DataAwsRdsOrderableDbInstance =
            Unchecked.defaultof<aws.DataAwsRdsOrderableDbInstance.DataAwsRdsOrderableDbInstance>

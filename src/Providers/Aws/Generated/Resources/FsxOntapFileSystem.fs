namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds> = { assignments: ResizeArray<aws.FsxOntapFileSystem.FsxOntapFileSystemConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system">aws_fsx_ontap_file_system</a>.
    /// </summary>
    type FsxOntapFileSystemBuilder(logicalId: string) =
        member _.Yield(_: unit) : FsxOntapFileSystemState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FsxOntapFileSystemState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : FsxOntapFileSystemState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FsxOntapFileSystemState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#deployment_type-1">FsxOntapFileSystem#deployment_type</a>.
        /// </summary>
        [<CustomOperation "deployment_type">]
        member _.DeploymentType(state: FsxOntapFileSystemState<Missing, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>, value: string) : FsxOntapFileSystemState<Present, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.DeploymentType <- value)
            ({ assignments = state.assignments } : FsxOntapFileSystemState<Present, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#preferred_subnet_id-1">FsxOntapFileSystem#preferred_subnet_id</a>.
        /// </summary>
        [<CustomOperation "preferred_subnet_id">]
        member _.PreferredSubnetId(state: FsxOntapFileSystemState<'DeploymentType, Missing, 'StorageCapacity, 'SubnetIds>, value: string) : FsxOntapFileSystemState<'DeploymentType, Present, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.PreferredSubnetId <- value)
            ({ assignments = state.assignments } : FsxOntapFileSystemState<'DeploymentType, Present, 'StorageCapacity, 'SubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#storage_capacity-1">FsxOntapFileSystem#storage_capacity</a>.
        /// </summary>
        [<CustomOperation "storage_capacity">]
        member _.StorageCapacity(state: FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, Missing, 'SubnetIds>, value: double) : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, Present, 'SubnetIds> =
            state.assignments.Add(fun config -> config.StorageCapacity <- value)
            ({ assignments = state.assignments } : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, Present, 'SubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#subnet_ids-1">FsxOntapFileSystem#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, Missing>, value: seq<string>) : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, Present> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#automatic_backup_retention_days-1">FsxOntapFileSystem#automatic_backup_retention_days</a>.
        /// </summary>
        [<CustomOperation "automatic_backup_retention_days">]
        member _.AutomaticBackupRetentionDays(state: FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>, value: double) : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.AutomaticBackupRetentionDays <- value)
            state : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#daily_automatic_backup_start_time-1">FsxOntapFileSystem#daily_automatic_backup_start_time</a>.
        /// </summary>
        [<CustomOperation "daily_automatic_backup_start_time">]
        member _.DailyAutomaticBackupStartTime(state: FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>, value: string) : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.DailyAutomaticBackupStartTime <- value)
            state : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// disk_iops_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#disk_iops_configuration-1">FsxOntapFileSystem#disk_iops_configuration</a>
        /// </summary>
        [<CustomOperation "disk_iops_configuration">]
        member _.DiskIopsConfiguration(state: FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>, value: aws.FsxOntapFileSystem.FsxOntapFileSystemDiskIopsConfiguration) : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.DiskIopsConfiguration <- value)
            state : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#endpoint_ip_address_range-1">FsxOntapFileSystem#endpoint_ip_address_range</a>.
        /// </summary>
        [<CustomOperation "endpoint_ip_address_range">]
        member _.EndpointIpAddressRange(state: FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>, value: string) : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.EndpointIpAddressRange <- value)
            state : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#fsx_admin_password-1">FsxOntapFileSystem#fsx_admin_password</a>.
        /// </summary>
        [<CustomOperation "fsx_admin_password">]
        member _.FsxAdminPassword(state: FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>, value: string) : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.FsxAdminPassword <- value)
            state : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#ha_pairs-1">FsxOntapFileSystem#ha_pairs</a>.
        /// </summary>
        [<CustomOperation "ha_pairs">]
        member _.HaPairs(state: FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>, value: double) : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.HaPairs <- value)
            state : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#id-1">FsxOntapFileSystem#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>, value: string) : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#kms_key_id-1">FsxOntapFileSystem#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>, value: string) : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#route_table_ids-1">FsxOntapFileSystem#route_table_ids</a>.
        /// </summary>
        [<CustomOperation "route_table_ids">]
        member _.RouteTableIds(state: FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>, value: seq<string>) : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.RouteTableIds <- (value |> Seq.toArray))
            state : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#security_group_ids-1">FsxOntapFileSystem#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>, value: seq<string>) : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#storage_type-1">FsxOntapFileSystem#storage_type</a>.
        /// </summary>
        [<CustomOperation "storage_type">]
        member _.StorageType(state: FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>, value: string) : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.StorageType <- value)
            state : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#tags-1">FsxOntapFileSystem#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>, value: seq<string * string>) : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#tags_all-1">FsxOntapFileSystem#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>, value: seq<string * string>) : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#throughput_capacity-1">FsxOntapFileSystem#throughput_capacity</a>.
        /// </summary>
        [<CustomOperation "throughput_capacity">]
        member _.ThroughputCapacity(state: FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>, value: double) : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.ThroughputCapacity <- value)
            state : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#throughput_capacity_per_ha_pair-1">FsxOntapFileSystem#throughput_capacity_per_ha_pair</a>.
        /// </summary>
        [<CustomOperation "throughput_capacity_per_ha_pair">]
        member _.ThroughputCapacityPerHaPair(state: FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>, value: double) : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.ThroughputCapacityPerHaPair <- value)
            state : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#timeouts-1">FsxOntapFileSystem#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>, value: aws.FsxOntapFileSystem.FsxOntapFileSystemTimeouts) : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_ontap_file_system#weekly_maintenance_start_time-1">FsxOntapFileSystem#weekly_maintenance_start_time</a>.
        /// </summary>
        [<CustomOperation "weekly_maintenance_start_time">]
        member _.WeeklyMaintenanceStartTime(state: FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>, value: string) : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.WeeklyMaintenanceStartTime <- value)
            state : FsxOntapFileSystemState<'DeploymentType, 'PreferredSubnetId, 'StorageCapacity, 'SubnetIds>

        member _.Run(state: FsxOntapFileSystemState<Present, Present, Present, Present>) : aws.FsxOntapFileSystem.FsxOntapFileSystem =
            let config = aws.FsxOntapFileSystem.FsxOntapFileSystemConfig()
            for setter in state.assignments do
                setter config
            aws.FsxOntapFileSystem.FsxOntapFileSystem(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.fsxOntapFileSystem: missing required arguments. Must call: deployment_type, preferred_subnet_id, storage_capacity, subnet_ids.", 9999, IsError = true)>]
        member _.Run(_: FsxOntapFileSystemState<_, _, _, _>) : aws.FsxOntapFileSystem.FsxOntapFileSystem =
            Unchecked.defaultof<aws.FsxOntapFileSystem.FsxOntapFileSystem>

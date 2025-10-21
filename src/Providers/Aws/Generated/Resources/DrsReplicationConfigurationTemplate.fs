namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer> = { assignments: ResizeArray<aws.DrsReplicationConfigurationTemplate.DrsReplicationConfigurationTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template">aws_drs_replication_configuration_template</a>.
    /// </summary>
    type DrsReplicationConfigurationTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : DrsReplicationConfigurationTemplateState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DrsReplicationConfigurationTemplateState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DrsReplicationConfigurationTemplateState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DrsReplicationConfigurationTemplateState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#associate_default_security_group-1">DrsReplicationConfigurationTemplate#associate_default_security_group</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "associate_default_security_group">]
        member _.AssociateDefaultSecurityGroup(state: DrsReplicationConfigurationTemplateState<Missing, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>, value: bool) : DrsReplicationConfigurationTemplateState<Present, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer> =
            state.assignments.Add(fun config -> config.AssociateDefaultSecurityGroup <- value)
            ({ assignments = state.assignments } : DrsReplicationConfigurationTemplateState<Present, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#associate_default_security_group-1">DrsReplicationConfigurationTemplate#associate_default_security_group</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "associate_default_security_group">]
        member _.AssociateDefaultSecurityGroup(state: DrsReplicationConfigurationTemplateState<Missing, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>, value: HashiCorp.Cdktf.IResolvable) : DrsReplicationConfigurationTemplateState<Present, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer> =
            state.assignments.Add(fun config -> config.AssociateDefaultSecurityGroup <- value)
            ({ assignments = state.assignments } : DrsReplicationConfigurationTemplateState<Present, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#bandwidth_throttling-1">DrsReplicationConfigurationTemplate#bandwidth_throttling</a>.
        /// </summary>
        [<CustomOperation "bandwidth_throttling">]
        member _.BandwidthThrottling(state: DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, Missing, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>, value: double) : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, Present, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer> =
            state.assignments.Add(fun config -> config.BandwidthThrottling <- value)
            ({ assignments = state.assignments } : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, Present, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#create_public_ip-1">DrsReplicationConfigurationTemplate#create_public_ip</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "create_public_ip">]
        member _.CreatePublicIp(state: DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, Missing, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>, value: bool) : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, Present, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer> =
            state.assignments.Add(fun config -> config.CreatePublicIp <- value)
            ({ assignments = state.assignments } : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, Present, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#create_public_ip-1">DrsReplicationConfigurationTemplate#create_public_ip</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "create_public_ip">]
        member _.CreatePublicIp(state: DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, Missing, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>, value: HashiCorp.Cdktf.IResolvable) : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, Present, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer> =
            state.assignments.Add(fun config -> config.CreatePublicIp <- value)
            ({ assignments = state.assignments } : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, Present, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#data_plane_routing-1">DrsReplicationConfigurationTemplate#data_plane_routing</a>.
        /// </summary>
        [<CustomOperation "data_plane_routing">]
        member _.DataPlaneRouting(state: DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, Missing, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>, value: string) : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, Present, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer> =
            state.assignments.Add(fun config -> config.DataPlaneRouting <- value)
            ({ assignments = state.assignments } : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, Present, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#default_large_staging_disk_type-1">DrsReplicationConfigurationTemplate#default_large_staging_disk_type</a>.
        /// </summary>
        [<CustomOperation "default_large_staging_disk_type">]
        member _.DefaultLargeStagingDiskType(state: DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, Missing, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>, value: string) : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, Present, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer> =
            state.assignments.Add(fun config -> config.DefaultLargeStagingDiskType <- value)
            ({ assignments = state.assignments } : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, Present, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#ebs_encryption-1">DrsReplicationConfigurationTemplate#ebs_encryption</a>.
        /// </summary>
        [<CustomOperation "ebs_encryption">]
        member _.EbsEncryption(state: DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, Missing, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>, value: string) : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, Present, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer> =
            state.assignments.Add(fun config -> config.EbsEncryption <- value)
            ({ assignments = state.assignments } : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, Present, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#replication_server_instance_type-1">DrsReplicationConfigurationTemplate#replication_server_instance_type</a>.
        /// </summary>
        [<CustomOperation "replication_server_instance_type">]
        member _.ReplicationServerInstanceType(state: DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, Missing, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>, value: string) : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, Present, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer> =
            state.assignments.Add(fun config -> config.ReplicationServerInstanceType <- value)
            ({ assignments = state.assignments } : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, Present, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#replication_servers_security_groups_ids-1">DrsReplicationConfigurationTemplate#replication_servers_security_groups_ids</a>.
        /// </summary>
        [<CustomOperation "replication_servers_security_groups_ids">]
        member _.ReplicationServersSecurityGroupsIds(state: DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, Missing, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>, value: seq<string>) : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, Present, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer> =
            state.assignments.Add(fun config -> config.ReplicationServersSecurityGroupsIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, Present, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#staging_area_subnet_id-1">DrsReplicationConfigurationTemplate#staging_area_subnet_id</a>.
        /// </summary>
        [<CustomOperation "staging_area_subnet_id">]
        member _.StagingAreaSubnetId(state: DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, Missing, 'StagingAreaTags, 'UseDedicatedReplicationServer>, value: string) : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, Present, 'StagingAreaTags, 'UseDedicatedReplicationServer> =
            state.assignments.Add(fun config -> config.StagingAreaSubnetId <- value)
            ({ assignments = state.assignments } : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, Present, 'StagingAreaTags, 'UseDedicatedReplicationServer>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#staging_area_tags-1">DrsReplicationConfigurationTemplate#staging_area_tags</a>.
        /// </summary>
        [<CustomOperation "staging_area_tags">]
        member _.StagingAreaTags(state: DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, Missing, 'UseDedicatedReplicationServer>, value: seq<string * string>) : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, Present, 'UseDedicatedReplicationServer> =
            state.assignments.Add(fun config -> config.StagingAreaTags <- dict value)
            ({ assignments = state.assignments } : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, Present, 'UseDedicatedReplicationServer>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#use_dedicated_replication_server-1">DrsReplicationConfigurationTemplate#use_dedicated_replication_server</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_dedicated_replication_server">]
        member _.UseDedicatedReplicationServer(state: DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, Missing>, value: bool) : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, Present> =
            state.assignments.Add(fun config -> config.UseDedicatedReplicationServer <- value)
            ({ assignments = state.assignments } : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#use_dedicated_replication_server-1">DrsReplicationConfigurationTemplate#use_dedicated_replication_server</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_dedicated_replication_server">]
        member _.UseDedicatedReplicationServer(state: DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, Missing>, value: HashiCorp.Cdktf.IResolvable) : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, Present> =
            state.assignments.Add(fun config -> config.UseDedicatedReplicationServer <- value)
            ({ assignments = state.assignments } : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#auto_replicate_new_disks-1">DrsReplicationConfigurationTemplate#auto_replicate_new_disks</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_replicate_new_disks">]
        member _.AutoReplicateNewDisks(state: DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>, value: bool) : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer> =
            state.assignments.Add(fun config -> config.AutoReplicateNewDisks <- value)
            state : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#auto_replicate_new_disks-1">DrsReplicationConfigurationTemplate#auto_replicate_new_disks</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_replicate_new_disks">]
        member _.AutoReplicateNewDisks(state: DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>, value: HashiCorp.Cdktf.IResolvable) : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer> =
            state.assignments.Add(fun config -> config.AutoReplicateNewDisks <- value)
            state : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#ebs_encryption_key_arn-1">DrsReplicationConfigurationTemplate#ebs_encryption_key_arn</a>.
        /// </summary>
        [<CustomOperation "ebs_encryption_key_arn">]
        member _.EbsEncryptionKeyArn(state: DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>, value: string) : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer> =
            state.assignments.Add(fun config -> config.EbsEncryptionKeyArn <- value)
            state : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>

        /// <summary>
        /// pit_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#pit_policy-1">DrsReplicationConfigurationTemplate#pit_policy</a> Accepts: aws.IResolvable | aws.DrsReplicationConfigurationTemplate.DrsReplicationConfigurationTemplatePitPolicy[]
        /// </summary>
        [<CustomOperation "pit_policy">]
        member _.PitPolicy(state: DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>, value: HashiCorp.Cdktf.IResolvable) : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer> =
            state.assignments.Add(fun config -> config.PitPolicy <- value)
            state : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#tags-1">DrsReplicationConfigurationTemplate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>, value: seq<string * string>) : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/drs_replication_configuration_template#timeouts-1">DrsReplicationConfigurationTemplate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>, value: aws.DrsReplicationConfigurationTemplate.DrsReplicationConfigurationTemplateTimeouts) : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DrsReplicationConfigurationTemplateState<'AssociateDefaultSecurityGroup, 'BandwidthThrottling, 'CreatePublicIp, 'DataPlaneRouting, 'DefaultLargeStagingDiskType, 'EbsEncryption, 'ReplicationServerInstanceType, 'ReplicationServersSecurityGroupsIds, 'StagingAreaSubnetId, 'StagingAreaTags, 'UseDedicatedReplicationServer>

        member _.Run(state: DrsReplicationConfigurationTemplateState<Present, Present, Present, Present, Present, Present, Present, Present, Present, Present, Present>) : aws.DrsReplicationConfigurationTemplate.DrsReplicationConfigurationTemplate =
            let config = aws.DrsReplicationConfigurationTemplate.DrsReplicationConfigurationTemplateConfig()
            for setter in state.assignments do
                setter config
            aws.DrsReplicationConfigurationTemplate.DrsReplicationConfigurationTemplate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.drsReplicationConfigurationTemplate: missing required arguments. Must call: associate_default_security_group, bandwidth_throttling, create_public_ip, data_plane_routing, default_large_staging_disk_type, ebs_encryption, replication_server_instance_type, replication_servers_security_groups_ids, staging_area_subnet_id, staging_area_tags, use_dedicated_replication_server.", 9999, IsError = true)>]
        member _.Run(_: DrsReplicationConfigurationTemplateState<_, _, _, _, _, _, _, _, _, _, _>) : aws.DrsReplicationConfigurationTemplate.DrsReplicationConfigurationTemplate =
            Unchecked.defaultof<aws.DrsReplicationConfigurationTemplate.DrsReplicationConfigurationTemplate>

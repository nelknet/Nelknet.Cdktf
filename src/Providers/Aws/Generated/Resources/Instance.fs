namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type InstanceState = { assignments: ResizeArray<aws.Instance.InstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance">aws_instance</a>.
    /// </summary>
    type InstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : InstanceState =
            { assignments = ResizeArray() }

        member _.Zero(()) : InstanceState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#ami-1">Instance#ami</a>.
        /// </summary>
        [<CustomOperation "ami">]
        member _.Ami(state: InstanceState, value: string) : InstanceState =
            state.assignments.Add(fun config -> config.Ami <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#associate_public_ip_address-1">Instance#associate_public_ip_address</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "associate_public_ip_address">]
        member _.AssociatePublicIpAddress(state: InstanceState, value: bool) : InstanceState =
            state.assignments.Add(fun config -> config.AssociatePublicIpAddress <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#associate_public_ip_address-1">Instance#associate_public_ip_address</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "associate_public_ip_address">]
        member _.AssociatePublicIpAddress(state: InstanceState, value: HashiCorp.Cdktf.IResolvable) : InstanceState =
            state.assignments.Add(fun config -> config.AssociatePublicIpAddress <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#availability_zone-1">Instance#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: InstanceState, value: string) : InstanceState =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : InstanceState

        /// <summary>
        /// capacity_reservation_specification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#capacity_reservation_specification-1">Instance#capacity_reservation_specification</a>
        /// </summary>
        [<CustomOperation "capacity_reservation_specification">]
        member _.CapacityReservationSpecification(state: InstanceState, value: aws.Instance.InstanceCapacityReservationSpecification) : InstanceState =
            state.assignments.Add(fun config -> config.CapacityReservationSpecification <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#cpu_core_count-1">Instance#cpu_core_count</a>.
        /// </summary>
        [<CustomOperation "cpu_core_count">]
        member _.CpuCoreCount(state: InstanceState, value: double) : InstanceState =
            state.assignments.Add(fun config -> config.CpuCoreCount <- value)
            state : InstanceState

        /// <summary>
        /// cpu_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#cpu_options-1">Instance#cpu_options</a>
        /// </summary>
        [<CustomOperation "cpu_options">]
        member _.CpuOptions(state: InstanceState, value: aws.Instance.InstanceCpuOptions) : InstanceState =
            state.assignments.Add(fun config -> config.CpuOptions <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#cpu_threads_per_core-1">Instance#cpu_threads_per_core</a>.
        /// </summary>
        [<CustomOperation "cpu_threads_per_core">]
        member _.CpuThreadsPerCore(state: InstanceState, value: double) : InstanceState =
            state.assignments.Add(fun config -> config.CpuThreadsPerCore <- value)
            state : InstanceState

        /// <summary>
        /// credit_specification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#credit_specification-1">Instance#credit_specification</a>
        /// </summary>
        [<CustomOperation "credit_specification">]
        member _.CreditSpecification(state: InstanceState, value: aws.Instance.InstanceCreditSpecification) : InstanceState =
            state.assignments.Add(fun config -> config.CreditSpecification <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#disable_api_stop-1">Instance#disable_api_stop</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_api_stop">]
        member _.DisableApiStop(state: InstanceState, value: bool) : InstanceState =
            state.assignments.Add(fun config -> config.DisableApiStop <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#disable_api_stop-1">Instance#disable_api_stop</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_api_stop">]
        member _.DisableApiStop(state: InstanceState, value: HashiCorp.Cdktf.IResolvable) : InstanceState =
            state.assignments.Add(fun config -> config.DisableApiStop <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#disable_api_termination-1">Instance#disable_api_termination</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_api_termination">]
        member _.DisableApiTermination(state: InstanceState, value: bool) : InstanceState =
            state.assignments.Add(fun config -> config.DisableApiTermination <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#disable_api_termination-1">Instance#disable_api_termination</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_api_termination">]
        member _.DisableApiTermination(state: InstanceState, value: HashiCorp.Cdktf.IResolvable) : InstanceState =
            state.assignments.Add(fun config -> config.DisableApiTermination <- value)
            state : InstanceState

        /// <summary>
        /// ebs_block_device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#ebs_block_device-1">Instance#ebs_block_device</a> Accepts: aws.IResolvable | aws.Instance.InstanceEbsBlockDevice[]
        /// </summary>
        [<CustomOperation "ebs_block_device">]
        member _.EbsBlockDevice(state: InstanceState, value: HashiCorp.Cdktf.IResolvable) : InstanceState =
            state.assignments.Add(fun config -> config.EbsBlockDevice <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#ebs_optimized-1">Instance#ebs_optimized</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ebs_optimized">]
        member _.EbsOptimized(state: InstanceState, value: bool) : InstanceState =
            state.assignments.Add(fun config -> config.EbsOptimized <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#ebs_optimized-1">Instance#ebs_optimized</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ebs_optimized">]
        member _.EbsOptimized(state: InstanceState, value: HashiCorp.Cdktf.IResolvable) : InstanceState =
            state.assignments.Add(fun config -> config.EbsOptimized <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#enable_primary_ipv6-1">Instance#enable_primary_ipv6</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_primary_ipv6">]
        member _.EnablePrimaryIpv6(state: InstanceState, value: bool) : InstanceState =
            state.assignments.Add(fun config -> config.EnablePrimaryIpv6 <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#enable_primary_ipv6-1">Instance#enable_primary_ipv6</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_primary_ipv6">]
        member _.EnablePrimaryIpv6(state: InstanceState, value: HashiCorp.Cdktf.IResolvable) : InstanceState =
            state.assignments.Add(fun config -> config.EnablePrimaryIpv6 <- value)
            state : InstanceState

        /// <summary>
        /// enclave_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#enclave_options-1">Instance#enclave_options</a>
        /// </summary>
        [<CustomOperation "enclave_options">]
        member _.EnclaveOptions(state: InstanceState, value: aws.Instance.InstanceEnclaveOptions) : InstanceState =
            state.assignments.Add(fun config -> config.EnclaveOptions <- value)
            state : InstanceState

        /// <summary>
        /// ephemeral_block_device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#ephemeral_block_device-1">Instance#ephemeral_block_device</a> Accepts: aws.IResolvable | aws.Instance.InstanceEphemeralBlockDevice[]
        /// </summary>
        [<CustomOperation "ephemeral_block_device">]
        member _.EphemeralBlockDevice(state: InstanceState, value: HashiCorp.Cdktf.IResolvable) : InstanceState =
            state.assignments.Add(fun config -> config.EphemeralBlockDevice <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#get_password_data-1">Instance#get_password_data</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fetch_password_data">]
        member _.FetchPasswordData(state: InstanceState, value: bool) : InstanceState =
            state.assignments.Add(fun config -> config.FetchPasswordData <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#get_password_data-1">Instance#get_password_data</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fetch_password_data">]
        member _.FetchPasswordData(state: InstanceState, value: HashiCorp.Cdktf.IResolvable) : InstanceState =
            state.assignments.Add(fun config -> config.FetchPasswordData <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#hibernation-1">Instance#hibernation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "hibernation">]
        member _.Hibernation(state: InstanceState, value: bool) : InstanceState =
            state.assignments.Add(fun config -> config.Hibernation <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#hibernation-1">Instance#hibernation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "hibernation">]
        member _.Hibernation(state: InstanceState, value: HashiCorp.Cdktf.IResolvable) : InstanceState =
            state.assignments.Add(fun config -> config.Hibernation <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#host_id-1">Instance#host_id</a>.
        /// </summary>
        [<CustomOperation "host_id">]
        member _.HostId(state: InstanceState, value: string) : InstanceState =
            state.assignments.Add(fun config -> config.HostId <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#host_resource_group_arn-1">Instance#host_resource_group_arn</a>.
        /// </summary>
        [<CustomOperation "host_resource_group_arn">]
        member _.HostResourceGroupArn(state: InstanceState, value: string) : InstanceState =
            state.assignments.Add(fun config -> config.HostResourceGroupArn <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#iam_instance_profile-1">Instance#iam_instance_profile</a>.
        /// </summary>
        [<CustomOperation "iam_instance_profile">]
        member _.IamInstanceProfile(state: InstanceState, value: string) : InstanceState =
            state.assignments.Add(fun config -> config.IamInstanceProfile <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#id-1">Instance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: InstanceState, value: string) : InstanceState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#instance_initiated_shutdown_behavior-1">Instance#instance_initiated_shutdown_behavior</a>.
        /// </summary>
        [<CustomOperation "instance_initiated_shutdown_behavior">]
        member _.InstanceInitiatedShutdownBehavior(state: InstanceState, value: string) : InstanceState =
            state.assignments.Add(fun config -> config.InstanceInitiatedShutdownBehavior <- value)
            state : InstanceState

        /// <summary>
        /// instance_market_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#instance_market_options-1">Instance#instance_market_options</a>
        /// </summary>
        [<CustomOperation "instance_market_options">]
        member _.InstanceMarketOptions(state: InstanceState, value: aws.Instance.InstanceInstanceMarketOptions) : InstanceState =
            state.assignments.Add(fun config -> config.InstanceMarketOptions <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#instance_type-1">Instance#instance_type</a>.
        /// </summary>
        [<CustomOperation "instance_type">]
        member _.InstanceType(state: InstanceState, value: string) : InstanceState =
            state.assignments.Add(fun config -> config.InstanceType <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#ipv6_address_count-1">Instance#ipv6_address_count</a>.
        /// </summary>
        [<CustomOperation "ipv6_address_count">]
        member _.Ipv6AddressCount(state: InstanceState, value: double) : InstanceState =
            state.assignments.Add(fun config -> config.Ipv6AddressCount <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#ipv6_addresses-1">Instance#ipv6_addresses</a>.
        /// </summary>
        [<CustomOperation "ipv6_addresses">]
        member _.Ipv6Addresses(state: InstanceState, value: seq<string>) : InstanceState =
            state.assignments.Add(fun config -> config.Ipv6Addresses <- (value |> Seq.toArray))
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#key_name-1">Instance#key_name</a>.
        /// </summary>
        [<CustomOperation "key_name">]
        member _.KeyName(state: InstanceState, value: string) : InstanceState =
            state.assignments.Add(fun config -> config.KeyName <- value)
            state : InstanceState

        /// <summary>
        /// launch_template block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#launch_template-1">Instance#launch_template</a>
        /// </summary>
        [<CustomOperation "launch_template">]
        member _.LaunchTemplate(state: InstanceState, value: aws.Instance.InstanceLaunchTemplate) : InstanceState =
            state.assignments.Add(fun config -> config.LaunchTemplate <- value)
            state : InstanceState

        /// <summary>
        /// maintenance_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#maintenance_options-1">Instance#maintenance_options</a>
        /// </summary>
        [<CustomOperation "maintenance_options">]
        member _.MaintenanceOptions(state: InstanceState, value: aws.Instance.InstanceMaintenanceOptions) : InstanceState =
            state.assignments.Add(fun config -> config.MaintenanceOptions <- value)
            state : InstanceState

        /// <summary>
        /// metadata_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#metadata_options-1">Instance#metadata_options</a>
        /// </summary>
        [<CustomOperation "metadata_options">]
        member _.MetadataOptions(state: InstanceState, value: aws.Instance.InstanceMetadataOptions) : InstanceState =
            state.assignments.Add(fun config -> config.MetadataOptions <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#monitoring-1">Instance#monitoring</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "monitoring">]
        member _.Monitoring(state: InstanceState, value: bool) : InstanceState =
            state.assignments.Add(fun config -> config.Monitoring <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#monitoring-1">Instance#monitoring</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "monitoring">]
        member _.Monitoring(state: InstanceState, value: HashiCorp.Cdktf.IResolvable) : InstanceState =
            state.assignments.Add(fun config -> config.Monitoring <- value)
            state : InstanceState

        /// <summary>
        /// network_interface block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#network_interface-1">Instance#network_interface</a> Accepts: aws.IResolvable | aws.Instance.InstanceNetworkInterface[]
        /// </summary>
        [<CustomOperation "network_interface">]
        member _.NetworkInterface(state: InstanceState, value: HashiCorp.Cdktf.IResolvable) : InstanceState =
            state.assignments.Add(fun config -> config.NetworkInterface <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#placement_group-1">Instance#placement_group</a>.
        /// </summary>
        [<CustomOperation "placement_group">]
        member _.PlacementGroup(state: InstanceState, value: string) : InstanceState =
            state.assignments.Add(fun config -> config.PlacementGroup <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#placement_partition_number-1">Instance#placement_partition_number</a>.
        /// </summary>
        [<CustomOperation "placement_partition_number">]
        member _.PlacementPartitionNumber(state: InstanceState, value: double) : InstanceState =
            state.assignments.Add(fun config -> config.PlacementPartitionNumber <- value)
            state : InstanceState

        /// <summary>
        /// private_dns_name_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#private_dns_name_options-1">Instance#private_dns_name_options</a>
        /// </summary>
        [<CustomOperation "private_dns_name_options">]
        member _.PrivateDnsNameOptions(state: InstanceState, value: aws.Instance.InstancePrivateDnsNameOptions) : InstanceState =
            state.assignments.Add(fun config -> config.PrivateDnsNameOptions <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#private_ip-1">Instance#private_ip</a>.
        /// </summary>
        [<CustomOperation "private_ip">]
        member _.PrivateIp(state: InstanceState, value: string) : InstanceState =
            state.assignments.Add(fun config -> config.PrivateIp <- value)
            state : InstanceState

        /// <summary>
        /// root_block_device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#root_block_device-1">Instance#root_block_device</a>
        /// </summary>
        [<CustomOperation "root_block_device">]
        member _.RootBlockDevice(state: InstanceState, value: aws.Instance.InstanceRootBlockDevice) : InstanceState =
            state.assignments.Add(fun config -> config.RootBlockDevice <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#secondary_private_ips-1">Instance#secondary_private_ips</a>.
        /// </summary>
        [<CustomOperation "secondary_private_ips">]
        member _.SecondaryPrivateIps(state: InstanceState, value: seq<string>) : InstanceState =
            state.assignments.Add(fun config -> config.SecondaryPrivateIps <- (value |> Seq.toArray))
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#security_groups-1">Instance#security_groups</a>.
        /// </summary>
        [<CustomOperation "security_groups">]
        member _.SecurityGroups(state: InstanceState, value: seq<string>) : InstanceState =
            state.assignments.Add(fun config -> config.SecurityGroups <- (value |> Seq.toArray))
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#source_dest_check-1">Instance#source_dest_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "source_dest_check">]
        member _.SourceDestCheck(state: InstanceState, value: bool) : InstanceState =
            state.assignments.Add(fun config -> config.SourceDestCheck <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#source_dest_check-1">Instance#source_dest_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "source_dest_check">]
        member _.SourceDestCheck(state: InstanceState, value: HashiCorp.Cdktf.IResolvable) : InstanceState =
            state.assignments.Add(fun config -> config.SourceDestCheck <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#subnet_id-1">Instance#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: InstanceState, value: string) : InstanceState =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#tags-1">Instance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: InstanceState, value: seq<string * string>) : InstanceState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#tags_all-1">Instance#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: InstanceState, value: seq<string * string>) : InstanceState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#tenancy-1">Instance#tenancy</a>.
        /// </summary>
        [<CustomOperation "tenancy">]
        member _.Tenancy(state: InstanceState, value: string) : InstanceState =
            state.assignments.Add(fun config -> config.Tenancy <- value)
            state : InstanceState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#timeouts-1">Instance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: InstanceState, value: aws.Instance.InstanceTimeouts) : InstanceState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#user_data-1">Instance#user_data</a>.
        /// </summary>
        [<CustomOperation "user_data">]
        member _.UserData(state: InstanceState, value: string) : InstanceState =
            state.assignments.Add(fun config -> config.UserData <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#user_data_base64-1">Instance#user_data_base64</a>.
        /// </summary>
        [<CustomOperation "user_data_base64">]
        member _.UserDataBase64(state: InstanceState, value: string) : InstanceState =
            state.assignments.Add(fun config -> config.UserDataBase64 <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#user_data_replace_on_change-1">Instance#user_data_replace_on_change</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "user_data_replace_on_change">]
        member _.UserDataReplaceOnChange(state: InstanceState, value: bool) : InstanceState =
            state.assignments.Add(fun config -> config.UserDataReplaceOnChange <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#user_data_replace_on_change-1">Instance#user_data_replace_on_change</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "user_data_replace_on_change">]
        member _.UserDataReplaceOnChange(state: InstanceState, value: HashiCorp.Cdktf.IResolvable) : InstanceState =
            state.assignments.Add(fun config -> config.UserDataReplaceOnChange <- value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#volume_tags-1">Instance#volume_tags</a>.
        /// </summary>
        [<CustomOperation "volume_tags">]
        member _.VolumeTags(state: InstanceState, value: seq<string * string>) : InstanceState =
            state.assignments.Add(fun config -> config.VolumeTags <- dict value)
            state : InstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#vpc_security_group_ids-1">Instance#vpc_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "vpc_security_group_ids">]
        member _.VpcSecurityGroupIds(state: InstanceState, value: seq<string>) : InstanceState =
            state.assignments.Add(fun config -> config.VpcSecurityGroupIds <- (value |> Seq.toArray))
            state : InstanceState

        member _.Run(state: InstanceState) : aws.Instance.Instance =
            let config = aws.Instance.InstanceConfig()
            for setter in state.assignments do
                setter config
            aws.Instance.Instance(StackContext.get (), logicalId, config)

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpotInstanceRequestState = { assignments: ResizeArray<aws.SpotInstanceRequest.SpotInstanceRequestConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request">aws_spot_instance_request</a>.
    /// </summary>
    type SpotInstanceRequestBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpotInstanceRequestState =
            { assignments = ResizeArray() }

        member _.Zero(()) : SpotInstanceRequestState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#ami-1">SpotInstanceRequest#ami</a>.
        /// </summary>
        [<CustomOperation "ami">]
        member _.Ami(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.Ami <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#associate_public_ip_address-1">SpotInstanceRequest#associate_public_ip_address</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "associate_public_ip_address">]
        member _.AssociatePublicIpAddress(state: SpotInstanceRequestState, value: bool) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.AssociatePublicIpAddress <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#associate_public_ip_address-1">SpotInstanceRequest#associate_public_ip_address</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "associate_public_ip_address">]
        member _.AssociatePublicIpAddress(state: SpotInstanceRequestState, value: HashiCorp.Cdktf.IResolvable) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.AssociatePublicIpAddress <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#availability_zone-1">SpotInstanceRequest#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#block_duration_minutes-1">SpotInstanceRequest#block_duration_minutes</a>.
        /// </summary>
        [<CustomOperation "block_duration_minutes">]
        member _.BlockDurationMinutes(state: SpotInstanceRequestState, value: double) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.BlockDurationMinutes <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// capacity_reservation_specification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#capacity_reservation_specification-1">SpotInstanceRequest#capacity_reservation_specification</a>
        /// </summary>
        [<CustomOperation "capacity_reservation_specification">]
        member _.CapacityReservationSpecification(state: SpotInstanceRequestState, value: aws.SpotInstanceRequest.SpotInstanceRequestCapacityReservationSpecification) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.CapacityReservationSpecification <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#cpu_core_count-1">SpotInstanceRequest#cpu_core_count</a>.
        /// </summary>
        [<CustomOperation "cpu_core_count">]
        member _.CpuCoreCount(state: SpotInstanceRequestState, value: double) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.CpuCoreCount <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// cpu_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#cpu_options-1">SpotInstanceRequest#cpu_options</a>
        /// </summary>
        [<CustomOperation "cpu_options">]
        member _.CpuOptions(state: SpotInstanceRequestState, value: aws.SpotInstanceRequest.SpotInstanceRequestCpuOptions) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.CpuOptions <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#cpu_threads_per_core-1">SpotInstanceRequest#cpu_threads_per_core</a>.
        /// </summary>
        [<CustomOperation "cpu_threads_per_core">]
        member _.CpuThreadsPerCore(state: SpotInstanceRequestState, value: double) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.CpuThreadsPerCore <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// credit_specification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#credit_specification-1">SpotInstanceRequest#credit_specification</a>
        /// </summary>
        [<CustomOperation "credit_specification">]
        member _.CreditSpecification(state: SpotInstanceRequestState, value: aws.SpotInstanceRequest.SpotInstanceRequestCreditSpecification) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.CreditSpecification <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#disable_api_stop-1">SpotInstanceRequest#disable_api_stop</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_api_stop">]
        member _.DisableApiStop(state: SpotInstanceRequestState, value: bool) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.DisableApiStop <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#disable_api_stop-1">SpotInstanceRequest#disable_api_stop</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_api_stop">]
        member _.DisableApiStop(state: SpotInstanceRequestState, value: HashiCorp.Cdktf.IResolvable) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.DisableApiStop <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#disable_api_termination-1">SpotInstanceRequest#disable_api_termination</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_api_termination">]
        member _.DisableApiTermination(state: SpotInstanceRequestState, value: bool) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.DisableApiTermination <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#disable_api_termination-1">SpotInstanceRequest#disable_api_termination</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_api_termination">]
        member _.DisableApiTermination(state: SpotInstanceRequestState, value: HashiCorp.Cdktf.IResolvable) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.DisableApiTermination <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// ebs_block_device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#ebs_block_device-1">SpotInstanceRequest#ebs_block_device</a> Accepts: aws.IResolvable | aws.SpotInstanceRequest.SpotInstanceRequestEbsBlockDevice[]
        /// </summary>
        [<CustomOperation "ebs_block_device">]
        member _.EbsBlockDevice(state: SpotInstanceRequestState, value: HashiCorp.Cdktf.IResolvable) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.EbsBlockDevice <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#ebs_optimized-1">SpotInstanceRequest#ebs_optimized</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ebs_optimized">]
        member _.EbsOptimized(state: SpotInstanceRequestState, value: bool) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.EbsOptimized <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#ebs_optimized-1">SpotInstanceRequest#ebs_optimized</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ebs_optimized">]
        member _.EbsOptimized(state: SpotInstanceRequestState, value: HashiCorp.Cdktf.IResolvable) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.EbsOptimized <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#enable_primary_ipv6-1">SpotInstanceRequest#enable_primary_ipv6</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_primary_ipv6">]
        member _.EnablePrimaryIpv6(state: SpotInstanceRequestState, value: bool) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.EnablePrimaryIpv6 <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#enable_primary_ipv6-1">SpotInstanceRequest#enable_primary_ipv6</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_primary_ipv6">]
        member _.EnablePrimaryIpv6(state: SpotInstanceRequestState, value: HashiCorp.Cdktf.IResolvable) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.EnablePrimaryIpv6 <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// enclave_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#enclave_options-1">SpotInstanceRequest#enclave_options</a>
        /// </summary>
        [<CustomOperation "enclave_options">]
        member _.EnclaveOptions(state: SpotInstanceRequestState, value: aws.SpotInstanceRequest.SpotInstanceRequestEnclaveOptions) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.EnclaveOptions <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// ephemeral_block_device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#ephemeral_block_device-1">SpotInstanceRequest#ephemeral_block_device</a> Accepts: aws.IResolvable | aws.SpotInstanceRequest.SpotInstanceRequestEphemeralBlockDevice[]
        /// </summary>
        [<CustomOperation "ephemeral_block_device">]
        member _.EphemeralBlockDevice(state: SpotInstanceRequestState, value: HashiCorp.Cdktf.IResolvable) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.EphemeralBlockDevice <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#get_password_data-1">SpotInstanceRequest#get_password_data</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fetch_password_data">]
        member _.FetchPasswordData(state: SpotInstanceRequestState, value: bool) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.FetchPasswordData <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#get_password_data-1">SpotInstanceRequest#get_password_data</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fetch_password_data">]
        member _.FetchPasswordData(state: SpotInstanceRequestState, value: HashiCorp.Cdktf.IResolvable) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.FetchPasswordData <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#hibernation-1">SpotInstanceRequest#hibernation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "hibernation">]
        member _.Hibernation(state: SpotInstanceRequestState, value: bool) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.Hibernation <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#hibernation-1">SpotInstanceRequest#hibernation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "hibernation">]
        member _.Hibernation(state: SpotInstanceRequestState, value: HashiCorp.Cdktf.IResolvable) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.Hibernation <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#host_id-1">SpotInstanceRequest#host_id</a>.
        /// </summary>
        [<CustomOperation "host_id">]
        member _.HostId(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.HostId <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#host_resource_group_arn-1">SpotInstanceRequest#host_resource_group_arn</a>.
        /// </summary>
        [<CustomOperation "host_resource_group_arn">]
        member _.HostResourceGroupArn(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.HostResourceGroupArn <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#iam_instance_profile-1">SpotInstanceRequest#iam_instance_profile</a>.
        /// </summary>
        [<CustomOperation "iam_instance_profile">]
        member _.IamInstanceProfile(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.IamInstanceProfile <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#id-1">SpotInstanceRequest#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#instance_initiated_shutdown_behavior-1">SpotInstanceRequest#instance_initiated_shutdown_behavior</a>.
        /// </summary>
        [<CustomOperation "instance_initiated_shutdown_behavior">]
        member _.InstanceInitiatedShutdownBehavior(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.InstanceInitiatedShutdownBehavior <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#instance_interruption_behavior-1">SpotInstanceRequest#instance_interruption_behavior</a>.
        /// </summary>
        [<CustomOperation "instance_interruption_behavior">]
        member _.InstanceInterruptionBehavior(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.InstanceInterruptionBehavior <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#instance_type-1">SpotInstanceRequest#instance_type</a>.
        /// </summary>
        [<CustomOperation "instance_type">]
        member _.InstanceType(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.InstanceType <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#ipv6_address_count-1">SpotInstanceRequest#ipv6_address_count</a>.
        /// </summary>
        [<CustomOperation "ipv6_address_count">]
        member _.Ipv6AddressCount(state: SpotInstanceRequestState, value: double) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.Ipv6AddressCount <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#ipv6_addresses-1">SpotInstanceRequest#ipv6_addresses</a>.
        /// </summary>
        [<CustomOperation "ipv6_addresses">]
        member _.Ipv6Addresses(state: SpotInstanceRequestState, value: seq<string>) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.Ipv6Addresses <- (value |> Seq.toArray))
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#key_name-1">SpotInstanceRequest#key_name</a>.
        /// </summary>
        [<CustomOperation "key_name">]
        member _.KeyName(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.KeyName <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#launch_group-1">SpotInstanceRequest#launch_group</a>.
        /// </summary>
        [<CustomOperation "launch_group">]
        member _.LaunchGroup(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.LaunchGroup <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// launch_template block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#launch_template-1">SpotInstanceRequest#launch_template</a>
        /// </summary>
        [<CustomOperation "launch_template">]
        member _.LaunchTemplate(state: SpotInstanceRequestState, value: aws.SpotInstanceRequest.SpotInstanceRequestLaunchTemplate) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.LaunchTemplate <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// maintenance_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#maintenance_options-1">SpotInstanceRequest#maintenance_options</a>
        /// </summary>
        [<CustomOperation "maintenance_options">]
        member _.MaintenanceOptions(state: SpotInstanceRequestState, value: aws.SpotInstanceRequest.SpotInstanceRequestMaintenanceOptions) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.MaintenanceOptions <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// metadata_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#metadata_options-1">SpotInstanceRequest#metadata_options</a>
        /// </summary>
        [<CustomOperation "metadata_options">]
        member _.MetadataOptions(state: SpotInstanceRequestState, value: aws.SpotInstanceRequest.SpotInstanceRequestMetadataOptions) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.MetadataOptions <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#monitoring-1">SpotInstanceRequest#monitoring</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "monitoring">]
        member _.Monitoring(state: SpotInstanceRequestState, value: bool) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.Monitoring <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#monitoring-1">SpotInstanceRequest#monitoring</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "monitoring">]
        member _.Monitoring(state: SpotInstanceRequestState, value: HashiCorp.Cdktf.IResolvable) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.Monitoring <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// network_interface block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#network_interface-1">SpotInstanceRequest#network_interface</a> Accepts: aws.IResolvable | aws.SpotInstanceRequest.SpotInstanceRequestNetworkInterface[]
        /// </summary>
        [<CustomOperation "network_interface">]
        member _.NetworkInterface(state: SpotInstanceRequestState, value: HashiCorp.Cdktf.IResolvable) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.NetworkInterface <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#placement_group-1">SpotInstanceRequest#placement_group</a>.
        /// </summary>
        [<CustomOperation "placement_group">]
        member _.PlacementGroup(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.PlacementGroup <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#placement_partition_number-1">SpotInstanceRequest#placement_partition_number</a>.
        /// </summary>
        [<CustomOperation "placement_partition_number">]
        member _.PlacementPartitionNumber(state: SpotInstanceRequestState, value: double) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.PlacementPartitionNumber <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// private_dns_name_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#private_dns_name_options-1">SpotInstanceRequest#private_dns_name_options</a>
        /// </summary>
        [<CustomOperation "private_dns_name_options">]
        member _.PrivateDnsNameOptions(state: SpotInstanceRequestState, value: aws.SpotInstanceRequest.SpotInstanceRequestPrivateDnsNameOptions) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.PrivateDnsNameOptions <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#private_ip-1">SpotInstanceRequest#private_ip</a>.
        /// </summary>
        [<CustomOperation "private_ip">]
        member _.PrivateIp(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.PrivateIp <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// root_block_device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#root_block_device-1">SpotInstanceRequest#root_block_device</a>
        /// </summary>
        [<CustomOperation "root_block_device">]
        member _.RootBlockDevice(state: SpotInstanceRequestState, value: aws.SpotInstanceRequest.SpotInstanceRequestRootBlockDevice) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.RootBlockDevice <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#secondary_private_ips-1">SpotInstanceRequest#secondary_private_ips</a>.
        /// </summary>
        [<CustomOperation "secondary_private_ips">]
        member _.SecondaryPrivateIps(state: SpotInstanceRequestState, value: seq<string>) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.SecondaryPrivateIps <- (value |> Seq.toArray))
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#security_groups-1">SpotInstanceRequest#security_groups</a>.
        /// </summary>
        [<CustomOperation "security_groups">]
        member _.SecurityGroups(state: SpotInstanceRequestState, value: seq<string>) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.SecurityGroups <- (value |> Seq.toArray))
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#source_dest_check-1">SpotInstanceRequest#source_dest_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "source_dest_check">]
        member _.SourceDestCheck(state: SpotInstanceRequestState, value: bool) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.SourceDestCheck <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#source_dest_check-1">SpotInstanceRequest#source_dest_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "source_dest_check">]
        member _.SourceDestCheck(state: SpotInstanceRequestState, value: HashiCorp.Cdktf.IResolvable) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.SourceDestCheck <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#spot_price-1">SpotInstanceRequest#spot_price</a>.
        /// </summary>
        [<CustomOperation "spot_price">]
        member _.SpotPrice(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.SpotPrice <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#spot_type-1">SpotInstanceRequest#spot_type</a>.
        /// </summary>
        [<CustomOperation "spot_type">]
        member _.SpotType(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.SpotType <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#subnet_id-1">SpotInstanceRequest#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#tags-1">SpotInstanceRequest#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SpotInstanceRequestState, value: seq<string * string>) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#tags_all-1">SpotInstanceRequest#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SpotInstanceRequestState, value: seq<string * string>) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#tenancy-1">SpotInstanceRequest#tenancy</a>.
        /// </summary>
        [<CustomOperation "tenancy">]
        member _.Tenancy(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.Tenancy <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#timeouts-1">SpotInstanceRequest#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpotInstanceRequestState, value: aws.SpotInstanceRequest.SpotInstanceRequestTimeouts) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#user_data-1">SpotInstanceRequest#user_data</a>.
        /// </summary>
        [<CustomOperation "user_data">]
        member _.UserData(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.UserData <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#user_data_base64-1">SpotInstanceRequest#user_data_base64</a>.
        /// </summary>
        [<CustomOperation "user_data_base64">]
        member _.UserDataBase64(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.UserDataBase64 <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#user_data_replace_on_change-1">SpotInstanceRequest#user_data_replace_on_change</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "user_data_replace_on_change">]
        member _.UserDataReplaceOnChange(state: SpotInstanceRequestState, value: bool) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.UserDataReplaceOnChange <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#user_data_replace_on_change-1">SpotInstanceRequest#user_data_replace_on_change</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "user_data_replace_on_change">]
        member _.UserDataReplaceOnChange(state: SpotInstanceRequestState, value: HashiCorp.Cdktf.IResolvable) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.UserDataReplaceOnChange <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#valid_from-1">SpotInstanceRequest#valid_from</a>.
        /// </summary>
        [<CustomOperation "valid_from">]
        member _.ValidFrom(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.ValidFrom <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#valid_until-1">SpotInstanceRequest#valid_until</a>.
        /// </summary>
        [<CustomOperation "valid_until">]
        member _.ValidUntil(state: SpotInstanceRequestState, value: string) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.ValidUntil <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#volume_tags-1">SpotInstanceRequest#volume_tags</a>.
        /// </summary>
        [<CustomOperation "volume_tags">]
        member _.VolumeTags(state: SpotInstanceRequestState, value: seq<string * string>) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.VolumeTags <- dict value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#vpc_security_group_ids-1">SpotInstanceRequest#vpc_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "vpc_security_group_ids">]
        member _.VpcSecurityGroupIds(state: SpotInstanceRequestState, value: seq<string>) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.VpcSecurityGroupIds <- (value |> Seq.toArray))
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#wait_for_fulfillment-1">SpotInstanceRequest#wait_for_fulfillment</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "wait_for_fulfillment">]
        member _.WaitForFulfillment(state: SpotInstanceRequestState, value: bool) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.WaitForFulfillment <- value)
            state : SpotInstanceRequestState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#wait_for_fulfillment-1">SpotInstanceRequest#wait_for_fulfillment</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "wait_for_fulfillment">]
        member _.WaitForFulfillment(state: SpotInstanceRequestState, value: HashiCorp.Cdktf.IResolvable) : SpotInstanceRequestState =
            state.assignments.Add(fun config -> config.WaitForFulfillment <- value)
            state : SpotInstanceRequestState

        member _.Run(state: SpotInstanceRequestState) : aws.SpotInstanceRequest.SpotInstanceRequest =
            let config = aws.SpotInstanceRequest.SpotInstanceRequestConfig()
            for setter in state.assignments do
                setter config
            aws.SpotInstanceRequest.SpotInstanceRequest(StackContext.get (), logicalId, config)

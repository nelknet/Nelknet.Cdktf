namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LaunchTemplateState = { assignments: ResizeArray<aws.LaunchTemplate.LaunchTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template">aws_launch_template</a>.
    /// </summary>
    type LaunchTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : LaunchTemplateState =
            { assignments = ResizeArray() }

        member _.Zero(()) : LaunchTemplateState =
            { assignments = ResizeArray() }

        /// <summary>
        /// block_device_mappings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#block_device_mappings-1">LaunchTemplate#block_device_mappings</a> Accepts: aws.IResolvable | aws.LaunchTemplate.LaunchTemplateBlockDeviceMappings[]
        /// </summary>
        [<CustomOperation "block_device_mappings">]
        member _.BlockDeviceMappings(state: LaunchTemplateState, value: HashiCorp.Cdktf.IResolvable) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.BlockDeviceMappings <- value)
            state : LaunchTemplateState

        /// <summary>
        /// capacity_reservation_specification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#capacity_reservation_specification-1">LaunchTemplate#capacity_reservation_specification</a>
        /// </summary>
        [<CustomOperation "capacity_reservation_specification">]
        member _.CapacityReservationSpecification(state: LaunchTemplateState, value: aws.LaunchTemplate.LaunchTemplateCapacityReservationSpecification) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.CapacityReservationSpecification <- value)
            state : LaunchTemplateState

        /// <summary>
        /// cpu_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#cpu_options-1">LaunchTemplate#cpu_options</a>
        /// </summary>
        [<CustomOperation "cpu_options">]
        member _.CpuOptions(state: LaunchTemplateState, value: aws.LaunchTemplate.LaunchTemplateCpuOptions) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.CpuOptions <- value)
            state : LaunchTemplateState

        /// <summary>
        /// credit_specification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#credit_specification-1">LaunchTemplate#credit_specification</a>
        /// </summary>
        [<CustomOperation "credit_specification">]
        member _.CreditSpecification(state: LaunchTemplateState, value: aws.LaunchTemplate.LaunchTemplateCreditSpecification) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.CreditSpecification <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#default_version-1">LaunchTemplate#default_version</a>.
        /// </summary>
        [<CustomOperation "default_version">]
        member _.DefaultVersion(state: LaunchTemplateState, value: double) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.DefaultVersion <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#description-1">LaunchTemplate#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: LaunchTemplateState, value: string) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.Description <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#disable_api_stop-1">LaunchTemplate#disable_api_stop</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_api_stop">]
        member _.DisableApiStop(state: LaunchTemplateState, value: bool) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.DisableApiStop <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#disable_api_stop-1">LaunchTemplate#disable_api_stop</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_api_stop">]
        member _.DisableApiStop(state: LaunchTemplateState, value: HashiCorp.Cdktf.IResolvable) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.DisableApiStop <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#disable_api_termination-1">LaunchTemplate#disable_api_termination</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_api_termination">]
        member _.DisableApiTermination(state: LaunchTemplateState, value: bool) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.DisableApiTermination <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#disable_api_termination-1">LaunchTemplate#disable_api_termination</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_api_termination">]
        member _.DisableApiTermination(state: LaunchTemplateState, value: HashiCorp.Cdktf.IResolvable) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.DisableApiTermination <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#ebs_optimized-1">LaunchTemplate#ebs_optimized</a>.
        /// </summary>
        [<CustomOperation "ebs_optimized">]
        member _.EbsOptimized(state: LaunchTemplateState, value: string) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.EbsOptimized <- value)
            state : LaunchTemplateState

        /// <summary>
        /// elastic_gpu_specifications block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#elastic_gpu_specifications-1">LaunchTemplate#elastic_gpu_specifications</a> Accepts: aws.IResolvable | aws.LaunchTemplate.LaunchTemplateElasticGpuSpecifications[]
        /// </summary>
        [<CustomOperation "elastic_gpu_specifications">]
        member _.ElasticGpuSpecifications(state: LaunchTemplateState, value: HashiCorp.Cdktf.IResolvable) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.ElasticGpuSpecifications <- value)
            state : LaunchTemplateState

        /// <summary>
        /// elastic_inference_accelerator block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#elastic_inference_accelerator-1">LaunchTemplate#elastic_inference_accelerator</a>
        /// </summary>
        [<CustomOperation "elastic_inference_accelerator">]
        member _.ElasticInferenceAccelerator(state: LaunchTemplateState, value: aws.LaunchTemplate.LaunchTemplateElasticInferenceAccelerator) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.ElasticInferenceAccelerator <- value)
            state : LaunchTemplateState

        /// <summary>
        /// enclave_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#enclave_options-1">LaunchTemplate#enclave_options</a>
        /// </summary>
        [<CustomOperation "enclave_options">]
        member _.EnclaveOptions(state: LaunchTemplateState, value: aws.LaunchTemplate.LaunchTemplateEnclaveOptions) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.EnclaveOptions <- value)
            state : LaunchTemplateState

        /// <summary>
        /// hibernation_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#hibernation_options-1">LaunchTemplate#hibernation_options</a>
        /// </summary>
        [<CustomOperation "hibernation_options">]
        member _.HibernationOptions(state: LaunchTemplateState, value: aws.LaunchTemplate.LaunchTemplateHibernationOptions) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.HibernationOptions <- value)
            state : LaunchTemplateState

        /// <summary>
        /// iam_instance_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#iam_instance_profile-1">LaunchTemplate#iam_instance_profile</a>
        /// </summary>
        [<CustomOperation "iam_instance_profile">]
        member _.IamInstanceProfile(state: LaunchTemplateState, value: aws.LaunchTemplate.LaunchTemplateIamInstanceProfile) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.IamInstanceProfile <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#id-1">LaunchTemplate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LaunchTemplateState, value: string) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#image_id-1">LaunchTemplate#image_id</a>.
        /// </summary>
        [<CustomOperation "image_id">]
        member _.ImageId(state: LaunchTemplateState, value: string) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.ImageId <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#instance_initiated_shutdown_behavior-1">LaunchTemplate#instance_initiated_shutdown_behavior</a>.
        /// </summary>
        [<CustomOperation "instance_initiated_shutdown_behavior">]
        member _.InstanceInitiatedShutdownBehavior(state: LaunchTemplateState, value: string) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.InstanceInitiatedShutdownBehavior <- value)
            state : LaunchTemplateState

        /// <summary>
        /// instance_market_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#instance_market_options-1">LaunchTemplate#instance_market_options</a>
        /// </summary>
        [<CustomOperation "instance_market_options">]
        member _.InstanceMarketOptions(state: LaunchTemplateState, value: aws.LaunchTemplate.LaunchTemplateInstanceMarketOptions) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.InstanceMarketOptions <- value)
            state : LaunchTemplateState

        /// <summary>
        /// instance_requirements block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#instance_requirements-1">LaunchTemplate#instance_requirements</a>
        /// </summary>
        [<CustomOperation "instance_requirements">]
        member _.InstanceRequirements(state: LaunchTemplateState, value: aws.LaunchTemplate.LaunchTemplateInstanceRequirements) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.InstanceRequirements <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#instance_type-1">LaunchTemplate#instance_type</a>.
        /// </summary>
        [<CustomOperation "instance_type">]
        member _.InstanceType(state: LaunchTemplateState, value: string) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.InstanceType <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#kernel_id-1">LaunchTemplate#kernel_id</a>.
        /// </summary>
        [<CustomOperation "kernel_id">]
        member _.KernelId(state: LaunchTemplateState, value: string) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.KernelId <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#key_name-1">LaunchTemplate#key_name</a>.
        /// </summary>
        [<CustomOperation "key_name">]
        member _.KeyName(state: LaunchTemplateState, value: string) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.KeyName <- value)
            state : LaunchTemplateState

        /// <summary>
        /// license_specification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#license_specification-1">LaunchTemplate#license_specification</a> Accepts: aws.IResolvable | aws.LaunchTemplate.LaunchTemplateLicenseSpecification[]
        /// </summary>
        [<CustomOperation "license_specification">]
        member _.LicenseSpecification(state: LaunchTemplateState, value: HashiCorp.Cdktf.IResolvable) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.LicenseSpecification <- value)
            state : LaunchTemplateState

        /// <summary>
        /// maintenance_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#maintenance_options-1">LaunchTemplate#maintenance_options</a>
        /// </summary>
        [<CustomOperation "maintenance_options">]
        member _.MaintenanceOptions(state: LaunchTemplateState, value: aws.LaunchTemplate.LaunchTemplateMaintenanceOptions) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.MaintenanceOptions <- value)
            state : LaunchTemplateState

        /// <summary>
        /// metadata_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#metadata_options-1">LaunchTemplate#metadata_options</a>
        /// </summary>
        [<CustomOperation "metadata_options">]
        member _.MetadataOptions(state: LaunchTemplateState, value: aws.LaunchTemplate.LaunchTemplateMetadataOptions) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.MetadataOptions <- value)
            state : LaunchTemplateState

        /// <summary>
        /// monitoring block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#monitoring-1">LaunchTemplate#monitoring</a>
        /// </summary>
        [<CustomOperation "monitoring">]
        member _.Monitoring(state: LaunchTemplateState, value: aws.LaunchTemplate.LaunchTemplateMonitoring) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.Monitoring <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#name-1">LaunchTemplate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LaunchTemplateState, value: string) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#name_prefix-1">LaunchTemplate#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: LaunchTemplateState, value: string) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : LaunchTemplateState

        /// <summary>
        /// network_interfaces block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#network_interfaces-1">LaunchTemplate#network_interfaces</a> Accepts: aws.IResolvable | aws.LaunchTemplate.LaunchTemplateNetworkInterfaces[]
        /// </summary>
        [<CustomOperation "network_interfaces">]
        member _.NetworkInterfaces(state: LaunchTemplateState, value: HashiCorp.Cdktf.IResolvable) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.NetworkInterfaces <- value)
            state : LaunchTemplateState

        /// <summary>
        /// placement block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#placement-1">LaunchTemplate#placement</a>
        /// </summary>
        [<CustomOperation "placement">]
        member _.Placement(state: LaunchTemplateState, value: aws.LaunchTemplate.LaunchTemplatePlacement) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.Placement <- value)
            state : LaunchTemplateState

        /// <summary>
        /// private_dns_name_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#private_dns_name_options-1">LaunchTemplate#private_dns_name_options</a>
        /// </summary>
        [<CustomOperation "private_dns_name_options">]
        member _.PrivateDnsNameOptions(state: LaunchTemplateState, value: aws.LaunchTemplate.LaunchTemplatePrivateDnsNameOptions) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.PrivateDnsNameOptions <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#ram_disk_id-1">LaunchTemplate#ram_disk_id</a>.
        /// </summary>
        [<CustomOperation "ram_disk_id">]
        member _.RamDiskId(state: LaunchTemplateState, value: string) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.RamDiskId <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#security_group_names-1">LaunchTemplate#security_group_names</a>.
        /// </summary>
        [<CustomOperation "security_group_names">]
        member _.SecurityGroupNames(state: LaunchTemplateState, value: seq<string>) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.SecurityGroupNames <- (value |> Seq.toArray))
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#tags-1">LaunchTemplate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LaunchTemplateState, value: seq<string * string>) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#tags_all-1">LaunchTemplate#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LaunchTemplateState, value: seq<string * string>) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LaunchTemplateState

        /// <summary>
        /// tag_specifications block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#tag_specifications-1">LaunchTemplate#tag_specifications</a> Accepts: aws.IResolvable | aws.LaunchTemplate.LaunchTemplateTagSpecifications[]
        /// </summary>
        [<CustomOperation "tag_specifications">]
        member _.TagSpecifications(state: LaunchTemplateState, value: HashiCorp.Cdktf.IResolvable) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.TagSpecifications <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#update_default_version-1">LaunchTemplate#update_default_version</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "update_default_version">]
        member _.UpdateDefaultVersion(state: LaunchTemplateState, value: bool) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.UpdateDefaultVersion <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#update_default_version-1">LaunchTemplate#update_default_version</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "update_default_version">]
        member _.UpdateDefaultVersion(state: LaunchTemplateState, value: HashiCorp.Cdktf.IResolvable) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.UpdateDefaultVersion <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#user_data-1">LaunchTemplate#user_data</a>.
        /// </summary>
        [<CustomOperation "user_data">]
        member _.UserData(state: LaunchTemplateState, value: string) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.UserData <- value)
            state : LaunchTemplateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#vpc_security_group_ids-1">LaunchTemplate#vpc_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "vpc_security_group_ids">]
        member _.VpcSecurityGroupIds(state: LaunchTemplateState, value: seq<string>) : LaunchTemplateState =
            state.assignments.Add(fun config -> config.VpcSecurityGroupIds <- (value |> Seq.toArray))
            state : LaunchTemplateState

        member _.Run(state: LaunchTemplateState) : aws.LaunchTemplate.LaunchTemplate =
            let config = aws.LaunchTemplate.LaunchTemplateConfig()
            for setter in state.assignments do
                setter config
            aws.LaunchTemplate.LaunchTemplate(StackContext.get (), logicalId, config)

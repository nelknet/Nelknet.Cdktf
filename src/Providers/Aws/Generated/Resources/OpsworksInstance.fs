namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpsworksInstanceState<'LayerIds, 'StackId> = { assignments: ResizeArray<aws.OpsworksInstance.OpsworksInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance">aws_opsworks_instance</a>.
    /// </summary>
    type OpsworksInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpsworksInstanceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksInstanceState<Missing, Missing>)

        member _.Zero(()) : OpsworksInstanceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksInstanceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#layer_ids-1">OpsworksInstance#layer_ids</a>.
        /// </summary>
        [<CustomOperation "layer_ids">]
        member _.LayerIds(state: OpsworksInstanceState<Missing, 'StackId>, value: seq<string>) : OpsworksInstanceState<Present, 'StackId> =
            state.assignments.Add(fun config -> config.LayerIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : OpsworksInstanceState<Present, 'StackId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#stack_id-1">OpsworksInstance#stack_id</a>.
        /// </summary>
        [<CustomOperation "stack_id">]
        member _.StackId(state: OpsworksInstanceState<'LayerIds, Missing>, value: string) : OpsworksInstanceState<'LayerIds, Present> =
            state.assignments.Add(fun config -> config.StackId <- value)
            ({ assignments = state.assignments } : OpsworksInstanceState<'LayerIds, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#agent_version-1">OpsworksInstance#agent_version</a>.
        /// </summary>
        [<CustomOperation "agent_version">]
        member _.AgentVersion(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.AgentVersion <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#ami_id-1">OpsworksInstance#ami_id</a>.
        /// </summary>
        [<CustomOperation "ami_id">]
        member _.AmiId(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.AmiId <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#architecture-1">OpsworksInstance#architecture</a>.
        /// </summary>
        [<CustomOperation "architecture">]
        member _.Architecture(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.Architecture <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#auto_scaling_type-1">OpsworksInstance#auto_scaling_type</a>.
        /// </summary>
        [<CustomOperation "auto_scaling_type">]
        member _.AutoScalingType(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.AutoScalingType <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#availability_zone-1">OpsworksInstance#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#created_at-1">OpsworksInstance#created_at</a>.
        /// </summary>
        [<CustomOperation "created_at">]
        member _.CreatedAt(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.CreatedAt <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#delete_ebs-1">OpsworksInstance#delete_ebs</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_ebs">]
        member _.DeleteEbs(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: bool) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.DeleteEbs <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#delete_ebs-1">OpsworksInstance#delete_ebs</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_ebs">]
        member _.DeleteEbs(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.DeleteEbs <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#delete_eip-1">OpsworksInstance#delete_eip</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_eip">]
        member _.DeleteEip(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: bool) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.DeleteEip <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#delete_eip-1">OpsworksInstance#delete_eip</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_eip">]
        member _.DeleteEip(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.DeleteEip <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// ebs_block_device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#ebs_block_device-1">OpsworksInstance#ebs_block_device</a> Accepts: aws.IResolvable | aws.OpsworksInstance.OpsworksInstanceEbsBlockDevice[]
        /// </summary>
        [<CustomOperation "ebs_block_device">]
        member _.EbsBlockDevice(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.EbsBlockDevice <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#ebs_optimized-1">OpsworksInstance#ebs_optimized</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ebs_optimized">]
        member _.EbsOptimized(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: bool) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.EbsOptimized <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#ebs_optimized-1">OpsworksInstance#ebs_optimized</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ebs_optimized">]
        member _.EbsOptimized(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.EbsOptimized <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#ecs_cluster_arn-1">OpsworksInstance#ecs_cluster_arn</a>.
        /// </summary>
        [<CustomOperation "ecs_cluster_arn">]
        member _.EcsClusterArn(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.EcsClusterArn <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#elastic_ip-1">OpsworksInstance#elastic_ip</a>.
        /// </summary>
        [<CustomOperation "elastic_ip">]
        member _.ElasticIp(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.ElasticIp <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// ephemeral_block_device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#ephemeral_block_device-1">OpsworksInstance#ephemeral_block_device</a> Accepts: aws.IResolvable | aws.OpsworksInstance.OpsworksInstanceEphemeralBlockDevice[]
        /// </summary>
        [<CustomOperation "ephemeral_block_device">]
        member _.EphemeralBlockDevice(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.EphemeralBlockDevice <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#hostname-1">OpsworksInstance#hostname</a>.
        /// </summary>
        [<CustomOperation "hostname">]
        member _.Hostname(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.Hostname <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#id-1">OpsworksInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#infrastructure_class-1">OpsworksInstance#infrastructure_class</a>.
        /// </summary>
        [<CustomOperation "infrastructure_class">]
        member _.InfrastructureClass(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.InfrastructureClass <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#install_updates_on_boot-1">OpsworksInstance#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: bool) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#install_updates_on_boot-1">OpsworksInstance#install_updates_on_boot</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "install_updates_on_boot">]
        member _.InstallUpdatesOnBoot(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.InstallUpdatesOnBoot <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#instance_profile_arn-1">OpsworksInstance#instance_profile_arn</a>.
        /// </summary>
        [<CustomOperation "instance_profile_arn">]
        member _.InstanceProfileArn(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.InstanceProfileArn <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#instance_type-1">OpsworksInstance#instance_type</a>.
        /// </summary>
        [<CustomOperation "instance_type">]
        member _.InstanceType(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.InstanceType <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#os-1">OpsworksInstance#os</a>.
        /// </summary>
        [<CustomOperation "os">]
        member _.Os(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.Os <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// root_block_device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#root_block_device-1">OpsworksInstance#root_block_device</a> Accepts: aws.IResolvable | aws.OpsworksInstance.OpsworksInstanceRootBlockDevice[]
        /// </summary>
        [<CustomOperation "root_block_device">]
        member _.RootBlockDevice(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: HashiCorp.Cdktf.IResolvable) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.RootBlockDevice <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#root_device_type-1">OpsworksInstance#root_device_type</a>.
        /// </summary>
        [<CustomOperation "root_device_type">]
        member _.RootDeviceType(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.RootDeviceType <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#security_group_ids-1">OpsworksInstance#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: seq<string>) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#ssh_key_name-1">OpsworksInstance#ssh_key_name</a>.
        /// </summary>
        [<CustomOperation "ssh_key_name">]
        member _.SshKeyName(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.SshKeyName <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#state-1">OpsworksInstance#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.State <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#status-1">OpsworksInstance#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#subnet_id-1">OpsworksInstance#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#tenancy-1">OpsworksInstance#tenancy</a>.
        /// </summary>
        [<CustomOperation "tenancy">]
        member _.Tenancy(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.Tenancy <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#timeouts-1">OpsworksInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: aws.OpsworksInstance.OpsworksInstanceTimeouts) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_instance#virtualization_type-1">OpsworksInstance#virtualization_type</a>.
        /// </summary>
        [<CustomOperation "virtualization_type">]
        member _.VirtualizationType(state: OpsworksInstanceState<'LayerIds, 'StackId>, value: string) : OpsworksInstanceState<'LayerIds, 'StackId> =
            state.assignments.Add(fun config -> config.VirtualizationType <- value)
            state : OpsworksInstanceState<'LayerIds, 'StackId>

        member _.Run(state: OpsworksInstanceState<Present, Present>) : aws.OpsworksInstance.OpsworksInstance =
            let config = aws.OpsworksInstance.OpsworksInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.OpsworksInstance.OpsworksInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opsworksInstance: missing required arguments. Must call: layer_ids, stack_id.", 9999, IsError = true)>]
        member _.Run(_: OpsworksInstanceState<_, _>) : aws.OpsworksInstance.OpsworksInstance =
            Unchecked.defaultof<aws.OpsworksInstance.OpsworksInstance>

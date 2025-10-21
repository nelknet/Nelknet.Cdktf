namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> = { assignments: ResizeArray<aws.EksNodeGroup.EksNodeGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group">aws_eks_node_group</a>.
    /// </summary>
    type EksNodeGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : EksNodeGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EksNodeGroupState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : EksNodeGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EksNodeGroupState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#cluster_name-1">EksNodeGroup#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: EksNodeGroupState<Missing, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: string) : EksNodeGroupState<Present, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : EksNodeGroupState<Present, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#node_role_arn-1">EksNodeGroup#node_role_arn</a>.
        /// </summary>
        [<CustomOperation "node_role_arn">]
        member _.NodeRoleArn(state: EksNodeGroupState<'ClusterName, Missing, 'ScalingConfig, 'SubnetIds>, value: string) : EksNodeGroupState<'ClusterName, Present, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.NodeRoleArn <- value)
            ({ assignments = state.assignments } : EksNodeGroupState<'ClusterName, Present, 'ScalingConfig, 'SubnetIds>)

        /// <summary>
        /// scaling_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#scaling_config-1">EksNodeGroup#scaling_config</a>
        /// </summary>
        [<CustomOperation "scaling_config">]
        member _.ScalingConfig(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, Missing, 'SubnetIds>, value: aws.EksNodeGroup.EksNodeGroupScalingConfig) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, Present, 'SubnetIds> =
            state.assignments.Add(fun config -> config.ScalingConfig <- value)
            ({ assignments = state.assignments } : EksNodeGroupState<'ClusterName, 'NodeRoleArn, Present, 'SubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#subnet_ids-1">EksNodeGroup#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, Missing>, value: seq<string>) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, Present> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#ami_type-1">EksNodeGroup#ami_type</a>.
        /// </summary>
        [<CustomOperation "ami_type">]
        member _.AmiType(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: string) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.AmiType <- value)
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#capacity_type-1">EksNodeGroup#capacity_type</a>.
        /// </summary>
        [<CustomOperation "capacity_type">]
        member _.CapacityType(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: string) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.CapacityType <- value)
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#disk_size-1">EksNodeGroup#disk_size</a>.
        /// </summary>
        [<CustomOperation "disk_size">]
        member _.DiskSize(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: double) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.DiskSize <- value)
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#force_update_version-1">EksNodeGroup#force_update_version</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_update_version">]
        member _.ForceUpdateVersion(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: bool) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.ForceUpdateVersion <- value)
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#force_update_version-1">EksNodeGroup#force_update_version</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_update_version">]
        member _.ForceUpdateVersion(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: HashiCorp.Cdktf.IResolvable) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.ForceUpdateVersion <- value)
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#id-1">EksNodeGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: string) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#instance_types-1">EksNodeGroup#instance_types</a>.
        /// </summary>
        [<CustomOperation "instance_types">]
        member _.InstanceTypes(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: seq<string>) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.InstanceTypes <- (value |> Seq.toArray))
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#labels-1">EksNodeGroup#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: seq<string * string>) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        /// <summary>
        /// launch_template block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#launch_template-1">EksNodeGroup#launch_template</a>
        /// </summary>
        [<CustomOperation "launch_template">]
        member _.LaunchTemplate(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: aws.EksNodeGroup.EksNodeGroupLaunchTemplate) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.LaunchTemplate <- value)
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#node_group_name-1">EksNodeGroup#node_group_name</a>.
        /// </summary>
        [<CustomOperation "node_group_name">]
        member _.NodeGroupName(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: string) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.NodeGroupName <- value)
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#node_group_name_prefix-1">EksNodeGroup#node_group_name_prefix</a>.
        /// </summary>
        [<CustomOperation "node_group_name_prefix">]
        member _.NodeGroupNamePrefix(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: string) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.NodeGroupNamePrefix <- value)
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        /// <summary>
        /// node_repair_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#node_repair_config-1">EksNodeGroup#node_repair_config</a>
        /// </summary>
        [<CustomOperation "node_repair_config">]
        member _.NodeRepairConfig(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: aws.EksNodeGroup.EksNodeGroupNodeRepairConfig) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.NodeRepairConfig <- value)
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#release_version-1">EksNodeGroup#release_version</a>.
        /// </summary>
        [<CustomOperation "release_version">]
        member _.ReleaseVersion(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: string) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.ReleaseVersion <- value)
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        /// <summary>
        /// remote_access block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#remote_access-1">EksNodeGroup#remote_access</a>
        /// </summary>
        [<CustomOperation "remote_access">]
        member _.RemoteAccess(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: aws.EksNodeGroup.EksNodeGroupRemoteAccess) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.RemoteAccess <- value)
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#tags-1">EksNodeGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: seq<string * string>) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#tags_all-1">EksNodeGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: seq<string * string>) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        /// <summary>
        /// taint block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#taint-1">EksNodeGroup#taint</a> Accepts: aws.IResolvable | aws.EksNodeGroup.EksNodeGroupTaint[]
        /// </summary>
        [<CustomOperation "taint">]
        member _.Taint(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: HashiCorp.Cdktf.IResolvable) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Taint <- value)
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#timeouts-1">EksNodeGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: aws.EksNodeGroup.EksNodeGroupTimeouts) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        /// <summary>
        /// update_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#update_config-1">EksNodeGroup#update_config</a>
        /// </summary>
        [<CustomOperation "update_config">]
        member _.UpdateConfig(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: aws.EksNodeGroup.EksNodeGroupUpdateConfig) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.UpdateConfig <- value)
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#version-1">EksNodeGroup#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>, value: string) : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : EksNodeGroupState<'ClusterName, 'NodeRoleArn, 'ScalingConfig, 'SubnetIds>

        member _.Run(state: EksNodeGroupState<Present, Present, Present, Present>) : aws.EksNodeGroup.EksNodeGroup =
            let config = aws.EksNodeGroup.EksNodeGroupConfig()
            for setter in state.assignments do
                setter config
            aws.EksNodeGroup.EksNodeGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.eksNodeGroup: missing required arguments. Must call: cluster_name, node_role_arn, scaling_config, subnet_ids.", 9999, IsError = true)>]
        member _.Run(_: EksNodeGroupState<_, _, _, _>) : aws.EksNodeGroup.EksNodeGroup =
            Unchecked.defaultof<aws.EksNodeGroup.EksNodeGroup>

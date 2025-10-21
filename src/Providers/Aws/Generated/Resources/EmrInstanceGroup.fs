namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EmrInstanceGroupState<'ClusterId, 'InstanceType> = { assignments: ResizeArray<aws.EmrInstanceGroup.EmrInstanceGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_group">aws_emr_instance_group</a>.
    /// </summary>
    type EmrInstanceGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : EmrInstanceGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EmrInstanceGroupState<Missing, Missing>)

        member _.Zero(()) : EmrInstanceGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EmrInstanceGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_group#cluster_id-1">EmrInstanceGroup#cluster_id</a>.
        /// </summary>
        [<CustomOperation "cluster_id">]
        member _.ClusterId(state: EmrInstanceGroupState<Missing, 'InstanceType>, value: string) : EmrInstanceGroupState<Present, 'InstanceType> =
            state.assignments.Add(fun config -> config.ClusterId <- value)
            ({ assignments = state.assignments } : EmrInstanceGroupState<Present, 'InstanceType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_group#instance_type-1">EmrInstanceGroup#instance_type</a>.
        /// </summary>
        [<CustomOperation "instance_type">]
        member _.InstanceType(state: EmrInstanceGroupState<'ClusterId, Missing>, value: string) : EmrInstanceGroupState<'ClusterId, Present> =
            state.assignments.Add(fun config -> config.InstanceType <- value)
            ({ assignments = state.assignments } : EmrInstanceGroupState<'ClusterId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_group#autoscaling_policy-1">EmrInstanceGroup#autoscaling_policy</a>.
        /// </summary>
        [<CustomOperation "autoscaling_policy">]
        member _.AutoscalingPolicy(state: EmrInstanceGroupState<'ClusterId, 'InstanceType>, value: string) : EmrInstanceGroupState<'ClusterId, 'InstanceType> =
            state.assignments.Add(fun config -> config.AutoscalingPolicy <- value)
            state : EmrInstanceGroupState<'ClusterId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_group#bid_price-1">EmrInstanceGroup#bid_price</a>.
        /// </summary>
        [<CustomOperation "bid_price">]
        member _.BidPrice(state: EmrInstanceGroupState<'ClusterId, 'InstanceType>, value: string) : EmrInstanceGroupState<'ClusterId, 'InstanceType> =
            state.assignments.Add(fun config -> config.BidPrice <- value)
            state : EmrInstanceGroupState<'ClusterId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_group#configurations_json-1">EmrInstanceGroup#configurations_json</a>.
        /// </summary>
        [<CustomOperation "configurations_json">]
        member _.ConfigurationsJson(state: EmrInstanceGroupState<'ClusterId, 'InstanceType>, value: string) : EmrInstanceGroupState<'ClusterId, 'InstanceType> =
            state.assignments.Add(fun config -> config.ConfigurationsJson <- value)
            state : EmrInstanceGroupState<'ClusterId, 'InstanceType>

        /// <summary>
        /// ebs_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_group#ebs_config-1">EmrInstanceGroup#ebs_config</a> Accepts: aws.IResolvable | aws.EmrInstanceGroup.EmrInstanceGroupEbsConfig[]
        /// </summary>
        [<CustomOperation "ebs_config">]
        member _.EbsConfig(state: EmrInstanceGroupState<'ClusterId, 'InstanceType>, value: HashiCorp.Cdktf.IResolvable) : EmrInstanceGroupState<'ClusterId, 'InstanceType> =
            state.assignments.Add(fun config -> config.EbsConfig <- value)
            state : EmrInstanceGroupState<'ClusterId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_group#ebs_optimized-1">EmrInstanceGroup#ebs_optimized</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ebs_optimized">]
        member _.EbsOptimized(state: EmrInstanceGroupState<'ClusterId, 'InstanceType>, value: bool) : EmrInstanceGroupState<'ClusterId, 'InstanceType> =
            state.assignments.Add(fun config -> config.EbsOptimized <- value)
            state : EmrInstanceGroupState<'ClusterId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_group#ebs_optimized-1">EmrInstanceGroup#ebs_optimized</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ebs_optimized">]
        member _.EbsOptimized(state: EmrInstanceGroupState<'ClusterId, 'InstanceType>, value: HashiCorp.Cdktf.IResolvable) : EmrInstanceGroupState<'ClusterId, 'InstanceType> =
            state.assignments.Add(fun config -> config.EbsOptimized <- value)
            state : EmrInstanceGroupState<'ClusterId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_group#id-1">EmrInstanceGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EmrInstanceGroupState<'ClusterId, 'InstanceType>, value: string) : EmrInstanceGroupState<'ClusterId, 'InstanceType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EmrInstanceGroupState<'ClusterId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_group#instance_count-1">EmrInstanceGroup#instance_count</a>.
        /// </summary>
        [<CustomOperation "instance_count">]
        member _.InstanceCount(state: EmrInstanceGroupState<'ClusterId, 'InstanceType>, value: double) : EmrInstanceGroupState<'ClusterId, 'InstanceType> =
            state.assignments.Add(fun config -> config.InstanceCount <- value)
            state : EmrInstanceGroupState<'ClusterId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_instance_group#name-1">EmrInstanceGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EmrInstanceGroupState<'ClusterId, 'InstanceType>, value: string) : EmrInstanceGroupState<'ClusterId, 'InstanceType> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : EmrInstanceGroupState<'ClusterId, 'InstanceType>

        member _.Run(state: EmrInstanceGroupState<Present, Present>) : aws.EmrInstanceGroup.EmrInstanceGroup =
            let config = aws.EmrInstanceGroup.EmrInstanceGroupConfig()
            for setter in state.assignments do
                setter config
            aws.EmrInstanceGroup.EmrInstanceGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.emrInstanceGroup: missing required arguments. Must call: cluster_id, instance_type.", 9999, IsError = true)>]
        member _.Run(_: EmrInstanceGroupState<_, _>) : aws.EmrInstanceGroup.EmrInstanceGroup =
            Unchecked.defaultof<aws.EmrInstanceGroup.EmrInstanceGroup>

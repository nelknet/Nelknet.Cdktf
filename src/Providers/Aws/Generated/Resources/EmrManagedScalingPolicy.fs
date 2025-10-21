namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EmrManagedScalingPolicyState<'ClusterId, 'ComputeLimits> = { assignments: ResizeArray<aws.EmrManagedScalingPolicy.EmrManagedScalingPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_managed_scaling_policy">aws_emr_managed_scaling_policy</a>.
    /// </summary>
    type EmrManagedScalingPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : EmrManagedScalingPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EmrManagedScalingPolicyState<Missing, Missing>)

        member _.Zero(()) : EmrManagedScalingPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EmrManagedScalingPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_managed_scaling_policy#cluster_id-1">EmrManagedScalingPolicy#cluster_id</a>.
        /// </summary>
        [<CustomOperation "cluster_id">]
        member _.ClusterId(state: EmrManagedScalingPolicyState<Missing, 'ComputeLimits>, value: string) : EmrManagedScalingPolicyState<Present, 'ComputeLimits> =
            state.assignments.Add(fun config -> config.ClusterId <- value)
            ({ assignments = state.assignments } : EmrManagedScalingPolicyState<Present, 'ComputeLimits>)

        /// <summary>
        /// compute_limits block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_managed_scaling_policy#compute_limits-1">EmrManagedScalingPolicy#compute_limits</a> Accepts: aws.IResolvable | aws.EmrManagedScalingPolicy.EmrManagedScalingPolicyComputeLimits[]
        /// </summary>
        [<CustomOperation "compute_limits">]
        member _.ComputeLimits(state: EmrManagedScalingPolicyState<'ClusterId, Missing>, value: HashiCorp.Cdktf.IResolvable) : EmrManagedScalingPolicyState<'ClusterId, Present> =
            state.assignments.Add(fun config -> config.ComputeLimits <- value)
            ({ assignments = state.assignments } : EmrManagedScalingPolicyState<'ClusterId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_managed_scaling_policy#id-1">EmrManagedScalingPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EmrManagedScalingPolicyState<'ClusterId, 'ComputeLimits>, value: string) : EmrManagedScalingPolicyState<'ClusterId, 'ComputeLimits> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EmrManagedScalingPolicyState<'ClusterId, 'ComputeLimits>

        member _.Run(state: EmrManagedScalingPolicyState<Present, Present>) : aws.EmrManagedScalingPolicy.EmrManagedScalingPolicy =
            let config = aws.EmrManagedScalingPolicy.EmrManagedScalingPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.EmrManagedScalingPolicy.EmrManagedScalingPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.emrManagedScalingPolicy: missing required arguments. Must call: cluster_id, compute_limits.", 9999, IsError = true)>]
        member _.Run(_: EmrManagedScalingPolicyState<_, _>) : aws.EmrManagedScalingPolicy.EmrManagedScalingPolicy =
            Unchecked.defaultof<aws.EmrManagedScalingPolicy.EmrManagedScalingPolicy>

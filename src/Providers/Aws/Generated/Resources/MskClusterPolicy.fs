namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MskClusterPolicyState<'ClusterArn, 'Policy> = { assignments: ResizeArray<aws.MskClusterPolicy.MskClusterPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster_policy">aws_msk_cluster_policy</a>.
    /// </summary>
    type MskClusterPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : MskClusterPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MskClusterPolicyState<Missing, Missing>)

        member _.Zero(()) : MskClusterPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MskClusterPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster_policy#cluster_arn-1">MskClusterPolicy#cluster_arn</a>.
        /// </summary>
        [<CustomOperation "cluster_arn">]
        member _.ClusterArn(state: MskClusterPolicyState<Missing, 'Policy>, value: string) : MskClusterPolicyState<Present, 'Policy> =
            state.assignments.Add(fun config -> config.ClusterArn <- value)
            ({ assignments = state.assignments } : MskClusterPolicyState<Present, 'Policy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster_policy#policy-1">MskClusterPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: MskClusterPolicyState<'ClusterArn, Missing>, value: string) : MskClusterPolicyState<'ClusterArn, Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : MskClusterPolicyState<'ClusterArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster_policy#id-1">MskClusterPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MskClusterPolicyState<'ClusterArn, 'Policy>, value: string) : MskClusterPolicyState<'ClusterArn, 'Policy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MskClusterPolicyState<'ClusterArn, 'Policy>

        member _.Run(state: MskClusterPolicyState<Present, Present>) : aws.MskClusterPolicy.MskClusterPolicy =
            let config = aws.MskClusterPolicy.MskClusterPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.MskClusterPolicy.MskClusterPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mskClusterPolicy: missing required arguments. Must call: cluster_arn, policy.", 9999, IsError = true)>]
        member _.Run(_: MskClusterPolicyState<_, _>) : aws.MskClusterPolicy.MskClusterPolicy =
            Unchecked.defaultof<aws.MskClusterPolicy.MskClusterPolicy>

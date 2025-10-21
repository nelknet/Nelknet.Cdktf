namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EksFargateProfileState<'ClusterName, 'FargateProfileName, 'PodExecutionRoleArn, 'Selector> = { assignments: ResizeArray<aws.EksFargateProfile.EksFargateProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_fargate_profile">aws_eks_fargate_profile</a>.
    /// </summary>
    type EksFargateProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : EksFargateProfileState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EksFargateProfileState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : EksFargateProfileState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EksFargateProfileState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_fargate_profile#cluster_name-1">EksFargateProfile#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: EksFargateProfileState<Missing, 'FargateProfileName, 'PodExecutionRoleArn, 'Selector>, value: string) : EksFargateProfileState<Present, 'FargateProfileName, 'PodExecutionRoleArn, 'Selector> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : EksFargateProfileState<Present, 'FargateProfileName, 'PodExecutionRoleArn, 'Selector>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_fargate_profile#fargate_profile_name-1">EksFargateProfile#fargate_profile_name</a>.
        /// </summary>
        [<CustomOperation "fargate_profile_name">]
        member _.FargateProfileName(state: EksFargateProfileState<'ClusterName, Missing, 'PodExecutionRoleArn, 'Selector>, value: string) : EksFargateProfileState<'ClusterName, Present, 'PodExecutionRoleArn, 'Selector> =
            state.assignments.Add(fun config -> config.FargateProfileName <- value)
            ({ assignments = state.assignments } : EksFargateProfileState<'ClusterName, Present, 'PodExecutionRoleArn, 'Selector>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_fargate_profile#pod_execution_role_arn-1">EksFargateProfile#pod_execution_role_arn</a>.
        /// </summary>
        [<CustomOperation "pod_execution_role_arn">]
        member _.PodExecutionRoleArn(state: EksFargateProfileState<'ClusterName, 'FargateProfileName, Missing, 'Selector>, value: string) : EksFargateProfileState<'ClusterName, 'FargateProfileName, Present, 'Selector> =
            state.assignments.Add(fun config -> config.PodExecutionRoleArn <- value)
            ({ assignments = state.assignments } : EksFargateProfileState<'ClusterName, 'FargateProfileName, Present, 'Selector>)

        /// <summary>
        /// selector block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_fargate_profile#selector-1">EksFargateProfile#selector</a> Accepts: aws.IResolvable | aws.EksFargateProfile.EksFargateProfileSelector[]
        /// </summary>
        [<CustomOperation "selector">]
        member _.Selector(state: EksFargateProfileState<'ClusterName, 'FargateProfileName, 'PodExecutionRoleArn, Missing>, value: HashiCorp.Cdktf.IResolvable) : EksFargateProfileState<'ClusterName, 'FargateProfileName, 'PodExecutionRoleArn, Present> =
            state.assignments.Add(fun config -> config.Selector <- value)
            ({ assignments = state.assignments } : EksFargateProfileState<'ClusterName, 'FargateProfileName, 'PodExecutionRoleArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_fargate_profile#id-1">EksFargateProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EksFargateProfileState<'ClusterName, 'FargateProfileName, 'PodExecutionRoleArn, 'Selector>, value: string) : EksFargateProfileState<'ClusterName, 'FargateProfileName, 'PodExecutionRoleArn, 'Selector> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EksFargateProfileState<'ClusterName, 'FargateProfileName, 'PodExecutionRoleArn, 'Selector>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_fargate_profile#subnet_ids-1">EksFargateProfile#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: EksFargateProfileState<'ClusterName, 'FargateProfileName, 'PodExecutionRoleArn, 'Selector>, value: seq<string>) : EksFargateProfileState<'ClusterName, 'FargateProfileName, 'PodExecutionRoleArn, 'Selector> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            state : EksFargateProfileState<'ClusterName, 'FargateProfileName, 'PodExecutionRoleArn, 'Selector>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_fargate_profile#tags-1">EksFargateProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EksFargateProfileState<'ClusterName, 'FargateProfileName, 'PodExecutionRoleArn, 'Selector>, value: seq<string * string>) : EksFargateProfileState<'ClusterName, 'FargateProfileName, 'PodExecutionRoleArn, 'Selector> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EksFargateProfileState<'ClusterName, 'FargateProfileName, 'PodExecutionRoleArn, 'Selector>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_fargate_profile#tags_all-1">EksFargateProfile#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EksFargateProfileState<'ClusterName, 'FargateProfileName, 'PodExecutionRoleArn, 'Selector>, value: seq<string * string>) : EksFargateProfileState<'ClusterName, 'FargateProfileName, 'PodExecutionRoleArn, 'Selector> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EksFargateProfileState<'ClusterName, 'FargateProfileName, 'PodExecutionRoleArn, 'Selector>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_fargate_profile#timeouts-1">EksFargateProfile#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EksFargateProfileState<'ClusterName, 'FargateProfileName, 'PodExecutionRoleArn, 'Selector>, value: aws.EksFargateProfile.EksFargateProfileTimeouts) : EksFargateProfileState<'ClusterName, 'FargateProfileName, 'PodExecutionRoleArn, 'Selector> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EksFargateProfileState<'ClusterName, 'FargateProfileName, 'PodExecutionRoleArn, 'Selector>

        member _.Run(state: EksFargateProfileState<Present, Present, Present, Present>) : aws.EksFargateProfile.EksFargateProfile =
            let config = aws.EksFargateProfile.EksFargateProfileConfig()
            for setter in state.assignments do
                setter config
            aws.EksFargateProfile.EksFargateProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.eksFargateProfile: missing required arguments. Must call: cluster_name, fargate_profile_name, pod_execution_role_arn, selector.", 9999, IsError = true)>]
        member _.Run(_: EksFargateProfileState<_, _, _, _>) : aws.EksFargateProfile.EksFargateProfile =
            Unchecked.defaultof<aws.EksFargateProfile.EksFargateProfile>

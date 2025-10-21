namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EksAddonState<'AddonName, 'ClusterName> = { assignments: ResizeArray<aws.EksAddon.EksAddonConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon">aws_eks_addon</a>.
    /// </summary>
    type EksAddonBuilder(logicalId: string) =
        member _.Yield(_: unit) : EksAddonState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EksAddonState<Missing, Missing>)

        member _.Zero(()) : EksAddonState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EksAddonState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#addon_name-1">EksAddon#addon_name</a>.
        /// </summary>
        [<CustomOperation "addon_name">]
        member _.AddonName(state: EksAddonState<Missing, 'ClusterName>, value: string) : EksAddonState<Present, 'ClusterName> =
            state.assignments.Add(fun config -> config.AddonName <- value)
            ({ assignments = state.assignments } : EksAddonState<Present, 'ClusterName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#cluster_name-1">EksAddon#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: EksAddonState<'AddonName, Missing>, value: string) : EksAddonState<'AddonName, Present> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : EksAddonState<'AddonName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#addon_version-1">EksAddon#addon_version</a>.
        /// </summary>
        [<CustomOperation "addon_version">]
        member _.AddonVersion(state: EksAddonState<'AddonName, 'ClusterName>, value: string) : EksAddonState<'AddonName, 'ClusterName> =
            state.assignments.Add(fun config -> config.AddonVersion <- value)
            state : EksAddonState<'AddonName, 'ClusterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#configuration_values-1">EksAddon#configuration_values</a>.
        /// </summary>
        [<CustomOperation "configuration_values">]
        member _.ConfigurationValues(state: EksAddonState<'AddonName, 'ClusterName>, value: string) : EksAddonState<'AddonName, 'ClusterName> =
            state.assignments.Add(fun config -> config.ConfigurationValues <- value)
            state : EksAddonState<'AddonName, 'ClusterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#id-1">EksAddon#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EksAddonState<'AddonName, 'ClusterName>, value: string) : EksAddonState<'AddonName, 'ClusterName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EksAddonState<'AddonName, 'ClusterName>

        /// <summary>
        /// pod_identity_association block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#pod_identity_association-1">EksAddon#pod_identity_association</a> Accepts: aws.IResolvable | aws.EksAddon.EksAddonPodIdentityAssociation[]
        /// </summary>
        [<CustomOperation "pod_identity_association">]
        member _.PodIdentityAssociation(state: EksAddonState<'AddonName, 'ClusterName>, value: HashiCorp.Cdktf.IResolvable) : EksAddonState<'AddonName, 'ClusterName> =
            state.assignments.Add(fun config -> config.PodIdentityAssociation <- value)
            state : EksAddonState<'AddonName, 'ClusterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#preserve-1">EksAddon#preserve</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "preserve">]
        member _.Preserve(state: EksAddonState<'AddonName, 'ClusterName>, value: bool) : EksAddonState<'AddonName, 'ClusterName> =
            state.assignments.Add(fun config -> config.Preserve <- value)
            state : EksAddonState<'AddonName, 'ClusterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#preserve-1">EksAddon#preserve</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "preserve">]
        member _.Preserve(state: EksAddonState<'AddonName, 'ClusterName>, value: HashiCorp.Cdktf.IResolvable) : EksAddonState<'AddonName, 'ClusterName> =
            state.assignments.Add(fun config -> config.Preserve <- value)
            state : EksAddonState<'AddonName, 'ClusterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#resolve_conflicts-1">EksAddon#resolve_conflicts</a>.
        /// </summary>
        [<CustomOperation "resolve_conflicts">]
        member _.ResolveConflicts(state: EksAddonState<'AddonName, 'ClusterName>, value: string) : EksAddonState<'AddonName, 'ClusterName> =
            state.assignments.Add(fun config -> config.ResolveConflicts <- value)
            state : EksAddonState<'AddonName, 'ClusterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#resolve_conflicts_on_create-1">EksAddon#resolve_conflicts_on_create</a>.
        /// </summary>
        [<CustomOperation "resolve_conflicts_on_create">]
        member _.ResolveConflictsOnCreate(state: EksAddonState<'AddonName, 'ClusterName>, value: string) : EksAddonState<'AddonName, 'ClusterName> =
            state.assignments.Add(fun config -> config.ResolveConflictsOnCreate <- value)
            state : EksAddonState<'AddonName, 'ClusterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#resolve_conflicts_on_update-1">EksAddon#resolve_conflicts_on_update</a>.
        /// </summary>
        [<CustomOperation "resolve_conflicts_on_update">]
        member _.ResolveConflictsOnUpdate(state: EksAddonState<'AddonName, 'ClusterName>, value: string) : EksAddonState<'AddonName, 'ClusterName> =
            state.assignments.Add(fun config -> config.ResolveConflictsOnUpdate <- value)
            state : EksAddonState<'AddonName, 'ClusterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#service_account_role_arn-1">EksAddon#service_account_role_arn</a>.
        /// </summary>
        [<CustomOperation "service_account_role_arn">]
        member _.ServiceAccountRoleArn(state: EksAddonState<'AddonName, 'ClusterName>, value: string) : EksAddonState<'AddonName, 'ClusterName> =
            state.assignments.Add(fun config -> config.ServiceAccountRoleArn <- value)
            state : EksAddonState<'AddonName, 'ClusterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#tags-1">EksAddon#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EksAddonState<'AddonName, 'ClusterName>, value: seq<string * string>) : EksAddonState<'AddonName, 'ClusterName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EksAddonState<'AddonName, 'ClusterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#tags_all-1">EksAddon#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EksAddonState<'AddonName, 'ClusterName>, value: seq<string * string>) : EksAddonState<'AddonName, 'ClusterName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EksAddonState<'AddonName, 'ClusterName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#timeouts-1">EksAddon#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EksAddonState<'AddonName, 'ClusterName>, value: aws.EksAddon.EksAddonTimeouts) : EksAddonState<'AddonName, 'ClusterName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EksAddonState<'AddonName, 'ClusterName>

        member _.Run(state: EksAddonState<Present, Present>) : aws.EksAddon.EksAddon =
            let config = aws.EksAddon.EksAddonConfig()
            for setter in state.assignments do
                setter config
            aws.EksAddon.EksAddon(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.eksAddon: missing required arguments. Must call: addon_name, cluster_name.", 9999, IsError = true)>]
        member _.Run(_: EksAddonState<_, _>) : aws.EksAddon.EksAddon =
            Unchecked.defaultof<aws.EksAddon.EksAddon>

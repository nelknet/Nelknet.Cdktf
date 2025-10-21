namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEksAddonVersionState<'AddonName, 'KubernetesVersion> = { assignments: ResizeArray<aws.DataAwsEksAddonVersion.DataAwsEksAddonVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_addon_version">aws_eks_addon_version</a>.
    /// </summary>
    type DataAwsEksAddonVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEksAddonVersionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsEksAddonVersionState<Missing, Missing>)

        member _.Zero(()) : DataAwsEksAddonVersionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsEksAddonVersionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_addon_version#addon_name-1">DataAwsEksAddonVersion#addon_name</a>.
        /// </summary>
        [<CustomOperation "addon_name">]
        member _.AddonName(state: DataAwsEksAddonVersionState<Missing, 'KubernetesVersion>, value: string) : DataAwsEksAddonVersionState<Present, 'KubernetesVersion> =
            state.assignments.Add(fun config -> config.AddonName <- value)
            ({ assignments = state.assignments } : DataAwsEksAddonVersionState<Present, 'KubernetesVersion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_addon_version#kubernetes_version-1">DataAwsEksAddonVersion#kubernetes_version</a>.
        /// </summary>
        [<CustomOperation "kubernetes_version">]
        member _.KubernetesVersion(state: DataAwsEksAddonVersionState<'AddonName, Missing>, value: string) : DataAwsEksAddonVersionState<'AddonName, Present> =
            state.assignments.Add(fun config -> config.KubernetesVersion <- value)
            ({ assignments = state.assignments } : DataAwsEksAddonVersionState<'AddonName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_addon_version#id-1">DataAwsEksAddonVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEksAddonVersionState<'AddonName, 'KubernetesVersion>, value: string) : DataAwsEksAddonVersionState<'AddonName, 'KubernetesVersion> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEksAddonVersionState<'AddonName, 'KubernetesVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_addon_version#most_recent-1">DataAwsEksAddonVersion#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsEksAddonVersionState<'AddonName, 'KubernetesVersion>, value: bool) : DataAwsEksAddonVersionState<'AddonName, 'KubernetesVersion> =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsEksAddonVersionState<'AddonName, 'KubernetesVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_addon_version#most_recent-1">DataAwsEksAddonVersion#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsEksAddonVersionState<'AddonName, 'KubernetesVersion>, value: HashiCorp.Cdktf.IResolvable) : DataAwsEksAddonVersionState<'AddonName, 'KubernetesVersion> =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsEksAddonVersionState<'AddonName, 'KubernetesVersion>

        member _.Run(state: DataAwsEksAddonVersionState<Present, Present>) : aws.DataAwsEksAddonVersion.DataAwsEksAddonVersion =
            let config = aws.DataAwsEksAddonVersion.DataAwsEksAddonVersionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEksAddonVersion.DataAwsEksAddonVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEksAddonVersion: missing required arguments. Must call: addon_name, kubernetes_version.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEksAddonVersionState<_, _>) : aws.DataAwsEksAddonVersion.DataAwsEksAddonVersion =
            Unchecked.defaultof<aws.DataAwsEksAddonVersion.DataAwsEksAddonVersion>

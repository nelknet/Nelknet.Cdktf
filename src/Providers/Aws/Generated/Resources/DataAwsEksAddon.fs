namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEksAddonState<'AddonName, 'ClusterName> = { assignments: ResizeArray<aws.DataAwsEksAddon.DataAwsEksAddonConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_addon">aws_eks_addon</a>.
    /// </summary>
    type DataAwsEksAddonBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEksAddonState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsEksAddonState<Missing, Missing>)

        member _.Zero(()) : DataAwsEksAddonState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsEksAddonState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_addon#addon_name-1">DataAwsEksAddon#addon_name</a>.
        /// </summary>
        [<CustomOperation "addon_name">]
        member _.AddonName(state: DataAwsEksAddonState<Missing, 'ClusterName>, value: string) : DataAwsEksAddonState<Present, 'ClusterName> =
            state.assignments.Add(fun config -> config.AddonName <- value)
            ({ assignments = state.assignments } : DataAwsEksAddonState<Present, 'ClusterName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_addon#cluster_name-1">DataAwsEksAddon#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: DataAwsEksAddonState<'AddonName, Missing>, value: string) : DataAwsEksAddonState<'AddonName, Present> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : DataAwsEksAddonState<'AddonName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_addon#id-1">DataAwsEksAddon#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEksAddonState<'AddonName, 'ClusterName>, value: string) : DataAwsEksAddonState<'AddonName, 'ClusterName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEksAddonState<'AddonName, 'ClusterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_addon#tags-1">DataAwsEksAddon#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEksAddonState<'AddonName, 'ClusterName>, value: seq<string * string>) : DataAwsEksAddonState<'AddonName, 'ClusterName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEksAddonState<'AddonName, 'ClusterName>

        member _.Run(state: DataAwsEksAddonState<Present, Present>) : aws.DataAwsEksAddon.DataAwsEksAddon =
            let config = aws.DataAwsEksAddon.DataAwsEksAddonConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEksAddon.DataAwsEksAddon(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEksAddon: missing required arguments. Must call: addon_name, cluster_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEksAddonState<_, _>) : aws.DataAwsEksAddon.DataAwsEksAddon =
            Unchecked.defaultof<aws.DataAwsEksAddon.DataAwsEksAddon>

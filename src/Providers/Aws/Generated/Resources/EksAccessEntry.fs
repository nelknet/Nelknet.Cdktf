namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EksAccessEntryState<'ClusterName, 'PrincipalArn> = { assignments: ResizeArray<aws.EksAccessEntry.EksAccessEntryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_entry">aws_eks_access_entry</a>.
    /// </summary>
    type EksAccessEntryBuilder(logicalId: string) =
        member _.Yield(_: unit) : EksAccessEntryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EksAccessEntryState<Missing, Missing>)

        member _.Zero(()) : EksAccessEntryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EksAccessEntryState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_entry#cluster_name-1">EksAccessEntry#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: EksAccessEntryState<Missing, 'PrincipalArn>, value: string) : EksAccessEntryState<Present, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : EksAccessEntryState<Present, 'PrincipalArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_entry#principal_arn-1">EksAccessEntry#principal_arn</a>.
        /// </summary>
        [<CustomOperation "principal_arn">]
        member _.PrincipalArn(state: EksAccessEntryState<'ClusterName, Missing>, value: string) : EksAccessEntryState<'ClusterName, Present> =
            state.assignments.Add(fun config -> config.PrincipalArn <- value)
            ({ assignments = state.assignments } : EksAccessEntryState<'ClusterName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_entry#id-1">EksAccessEntry#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EksAccessEntryState<'ClusterName, 'PrincipalArn>, value: string) : EksAccessEntryState<'ClusterName, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EksAccessEntryState<'ClusterName, 'PrincipalArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_entry#kubernetes_groups-1">EksAccessEntry#kubernetes_groups</a>.
        /// </summary>
        [<CustomOperation "kubernetes_groups">]
        member _.KubernetesGroups(state: EksAccessEntryState<'ClusterName, 'PrincipalArn>, value: seq<string>) : EksAccessEntryState<'ClusterName, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.KubernetesGroups <- (value |> Seq.toArray))
            state : EksAccessEntryState<'ClusterName, 'PrincipalArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_entry#tags-1">EksAccessEntry#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EksAccessEntryState<'ClusterName, 'PrincipalArn>, value: seq<string * string>) : EksAccessEntryState<'ClusterName, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EksAccessEntryState<'ClusterName, 'PrincipalArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_entry#tags_all-1">EksAccessEntry#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EksAccessEntryState<'ClusterName, 'PrincipalArn>, value: seq<string * string>) : EksAccessEntryState<'ClusterName, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EksAccessEntryState<'ClusterName, 'PrincipalArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_entry#timeouts-1">EksAccessEntry#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EksAccessEntryState<'ClusterName, 'PrincipalArn>, value: aws.EksAccessEntry.EksAccessEntryTimeouts) : EksAccessEntryState<'ClusterName, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EksAccessEntryState<'ClusterName, 'PrincipalArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_entry#type-1">EksAccessEntry#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: EksAccessEntryState<'ClusterName, 'PrincipalArn>, value: string) : EksAccessEntryState<'ClusterName, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : EksAccessEntryState<'ClusterName, 'PrincipalArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_entry#user_name-1">EksAccessEntry#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: EksAccessEntryState<'ClusterName, 'PrincipalArn>, value: string) : EksAccessEntryState<'ClusterName, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.UserName <- value)
            state : EksAccessEntryState<'ClusterName, 'PrincipalArn>

        member _.Run(state: EksAccessEntryState<Present, Present>) : aws.EksAccessEntry.EksAccessEntry =
            let config = aws.EksAccessEntry.EksAccessEntryConfig()
            for setter in state.assignments do
                setter config
            aws.EksAccessEntry.EksAccessEntry(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.eksAccessEntry: missing required arguments. Must call: cluster_name, principal_arn.", 9999, IsError = true)>]
        member _.Run(_: EksAccessEntryState<_, _>) : aws.EksAccessEntry.EksAccessEntry =
            Unchecked.defaultof<aws.EksAccessEntry.EksAccessEntry>

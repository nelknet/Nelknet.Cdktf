namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEksAccessEntryState<'ClusterName, 'PrincipalArn> = { assignments: ResizeArray<aws.DataAwsEksAccessEntry.DataAwsEksAccessEntryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_access_entry">aws_eks_access_entry</a>.
    /// </summary>
    type DataAwsEksAccessEntryBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEksAccessEntryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsEksAccessEntryState<Missing, Missing>)

        member _.Zero(()) : DataAwsEksAccessEntryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsEksAccessEntryState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_access_entry#cluster_name-1">DataAwsEksAccessEntry#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: DataAwsEksAccessEntryState<Missing, 'PrincipalArn>, value: string) : DataAwsEksAccessEntryState<Present, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : DataAwsEksAccessEntryState<Present, 'PrincipalArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_access_entry#principal_arn-1">DataAwsEksAccessEntry#principal_arn</a>.
        /// </summary>
        [<CustomOperation "principal_arn">]
        member _.PrincipalArn(state: DataAwsEksAccessEntryState<'ClusterName, Missing>, value: string) : DataAwsEksAccessEntryState<'ClusterName, Present> =
            state.assignments.Add(fun config -> config.PrincipalArn <- value)
            ({ assignments = state.assignments } : DataAwsEksAccessEntryState<'ClusterName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_access_entry#id-1">DataAwsEksAccessEntry#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEksAccessEntryState<'ClusterName, 'PrincipalArn>, value: string) : DataAwsEksAccessEntryState<'ClusterName, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEksAccessEntryState<'ClusterName, 'PrincipalArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_access_entry#tags-1">DataAwsEksAccessEntry#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEksAccessEntryState<'ClusterName, 'PrincipalArn>, value: seq<string * string>) : DataAwsEksAccessEntryState<'ClusterName, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEksAccessEntryState<'ClusterName, 'PrincipalArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_access_entry#tags_all-1">DataAwsEksAccessEntry#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DataAwsEksAccessEntryState<'ClusterName, 'PrincipalArn>, value: seq<string * string>) : DataAwsEksAccessEntryState<'ClusterName, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DataAwsEksAccessEntryState<'ClusterName, 'PrincipalArn>

        member _.Run(state: DataAwsEksAccessEntryState<Present, Present>) : aws.DataAwsEksAccessEntry.DataAwsEksAccessEntry =
            let config = aws.DataAwsEksAccessEntry.DataAwsEksAccessEntryConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEksAccessEntry.DataAwsEksAccessEntry(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEksAccessEntry: missing required arguments. Must call: cluster_name, principal_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEksAccessEntryState<_, _>) : aws.DataAwsEksAccessEntry.DataAwsEksAccessEntry =
            Unchecked.defaultof<aws.DataAwsEksAccessEntry.DataAwsEksAccessEntry>

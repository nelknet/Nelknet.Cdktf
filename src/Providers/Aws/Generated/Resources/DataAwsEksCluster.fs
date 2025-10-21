namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEksClusterState<'Name> = { assignments: ResizeArray<aws.DataAwsEksCluster.DataAwsEksClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_cluster">aws_eks_cluster</a>.
    /// </summary>
    type DataAwsEksClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEksClusterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEksClusterState<Missing>)

        member _.Zero(()) : DataAwsEksClusterState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEksClusterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_cluster#name-1">DataAwsEksCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsEksClusterState<Missing>, value: string) : DataAwsEksClusterState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsEksClusterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_cluster#id-1">DataAwsEksCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEksClusterState<'Name>, value: string) : DataAwsEksClusterState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEksClusterState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_cluster#tags-1">DataAwsEksCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEksClusterState<'Name>, value: seq<string * string>) : DataAwsEksClusterState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEksClusterState<'Name>

        member _.Run(state: DataAwsEksClusterState<Present>) : aws.DataAwsEksCluster.DataAwsEksCluster =
            let config = aws.DataAwsEksCluster.DataAwsEksClusterConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEksCluster.DataAwsEksCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEksCluster: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEksClusterState<_>) : aws.DataAwsEksCluster.DataAwsEksCluster =
            Unchecked.defaultof<aws.DataAwsEksCluster.DataAwsEksCluster>

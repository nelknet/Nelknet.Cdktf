namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEksClustersState = { assignments: ResizeArray<aws.DataAwsEksClusters.DataAwsEksClustersConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_clusters">aws_eks_clusters</a>.
    /// </summary>
    type DataAwsEksClustersBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEksClustersState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEksClustersState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_clusters#id-1">DataAwsEksClusters#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEksClustersState, value: string) : DataAwsEksClustersState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEksClustersState

        member _.Run(state: DataAwsEksClustersState) : aws.DataAwsEksClusters.DataAwsEksClusters =
            let config = aws.DataAwsEksClusters.DataAwsEksClustersConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEksClusters.DataAwsEksClusters(StackContext.get (), logicalId, config)

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRdsClustersState = { assignments: ResizeArray<aws.DataAwsRdsClusters.DataAwsRdsClustersConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_clusters">aws_rds_clusters</a>.
    /// </summary>
    type DataAwsRdsClustersBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRdsClustersState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsRdsClustersState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_clusters#filter-1">DataAwsRdsClusters#filter</a> Accepts: aws.IResolvable | aws.DataAwsRdsClusters.DataAwsRdsClustersFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsRdsClustersState, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsClustersState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsRdsClustersState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_clusters#id-1">DataAwsRdsClusters#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRdsClustersState, value: string) : DataAwsRdsClustersState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRdsClustersState

        member _.Run(state: DataAwsRdsClustersState) : aws.DataAwsRdsClusters.DataAwsRdsClusters =
            let config = aws.DataAwsRdsClusters.DataAwsRdsClustersConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRdsClusters.DataAwsRdsClusters(StackContext.get (), logicalId, config)

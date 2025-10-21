namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEcsClustersState = { assignments: ResizeArray<aws.DataAwsEcsClusters.DataAwsEcsClustersConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_clusters">aws_ecs_clusters</a>.
    /// </summary>
    type DataAwsEcsClustersBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEcsClustersState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEcsClustersState =
            { assignments = ResizeArray() }



        member _.Run(state: DataAwsEcsClustersState) : aws.DataAwsEcsClusters.DataAwsEcsClusters =
            let config = aws.DataAwsEcsClusters.DataAwsEcsClustersConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEcsClusters.DataAwsEcsClusters(StackContext.get (), logicalId, config)

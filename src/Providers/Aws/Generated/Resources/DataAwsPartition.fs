namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsPartitionState = { assignments: ResizeArray<aws.DataAwsPartition.DataAwsPartitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/partition">aws_partition</a>.
    /// </summary>
    type DataAwsPartitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsPartitionState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsPartitionState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/partition#id-1">DataAwsPartition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsPartitionState, value: string) : DataAwsPartitionState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsPartitionState

        member _.Run(state: DataAwsPartitionState) : aws.DataAwsPartition.DataAwsPartition =
            let config = aws.DataAwsPartition.DataAwsPartitionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsPartition.DataAwsPartition(StackContext.get (), logicalId, config)

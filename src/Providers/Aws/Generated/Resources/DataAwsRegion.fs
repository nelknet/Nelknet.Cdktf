namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRegionState = { assignments: ResizeArray<aws.DataAwsRegion.DataAwsRegionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/region">aws_region</a>.
    /// </summary>
    type DataAwsRegionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRegionState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsRegionState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/region#endpoint-1">DataAwsRegion#endpoint</a>.
        /// </summary>
        [<CustomOperation "endpoint">]
        member _.Endpoint(state: DataAwsRegionState, value: string) : DataAwsRegionState =
            state.assignments.Add(fun config -> config.Endpoint <- value)
            state : DataAwsRegionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/region#id-1">DataAwsRegion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRegionState, value: string) : DataAwsRegionState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRegionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/region#name-1">DataAwsRegion#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsRegionState, value: string) : DataAwsRegionState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsRegionState

        member _.Run(state: DataAwsRegionState) : aws.DataAwsRegion.DataAwsRegion =
            let config = aws.DataAwsRegion.DataAwsRegionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRegion.DataAwsRegion(StackContext.get (), logicalId, config)

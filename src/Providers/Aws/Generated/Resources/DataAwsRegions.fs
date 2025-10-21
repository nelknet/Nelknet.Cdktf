namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRegionsState = { assignments: ResizeArray<aws.DataAwsRegions.DataAwsRegionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/regions">aws_regions</a>.
    /// </summary>
    type DataAwsRegionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRegionsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsRegionsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/regions#all_regions-1">DataAwsRegions#all_regions</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "all_regions">]
        member _.AllRegions(state: DataAwsRegionsState, value: bool) : DataAwsRegionsState =
            state.assignments.Add(fun config -> config.AllRegions <- value)
            state : DataAwsRegionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/regions#all_regions-1">DataAwsRegions#all_regions</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "all_regions">]
        member _.AllRegions(state: DataAwsRegionsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsRegionsState =
            state.assignments.Add(fun config -> config.AllRegions <- value)
            state : DataAwsRegionsState

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/regions#filter-1">DataAwsRegions#filter</a> Accepts: aws.IResolvable | aws.DataAwsRegions.DataAwsRegionsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsRegionsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsRegionsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsRegionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/regions#id-1">DataAwsRegions#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRegionsState, value: string) : DataAwsRegionsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRegionsState

        member _.Run(state: DataAwsRegionsState) : aws.DataAwsRegions.DataAwsRegions =
            let config = aws.DataAwsRegions.DataAwsRegionsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRegions.DataAwsRegions(StackContext.get (), logicalId, config)

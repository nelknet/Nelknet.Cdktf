namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEipsState = { assignments: ResizeArray<aws.DataAwsEips.DataAwsEipsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eips">aws_eips</a>.
    /// </summary>
    type DataAwsEipsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEipsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEipsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eips#filter-1">DataAwsEips#filter</a> Accepts: aws.IResolvable | aws.DataAwsEips.DataAwsEipsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEipsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEipsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEipsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eips#id-1">DataAwsEips#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEipsState, value: string) : DataAwsEipsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEipsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eips#tags-1">DataAwsEips#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEipsState, value: seq<string * string>) : DataAwsEipsState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEipsState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eips#timeouts-1">DataAwsEips#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEipsState, value: aws.DataAwsEips.DataAwsEipsTimeouts) : DataAwsEipsState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEipsState

        member _.Run(state: DataAwsEipsState) : aws.DataAwsEips.DataAwsEips =
            let config = aws.DataAwsEips.DataAwsEipsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEips.DataAwsEips(StackContext.get (), logicalId, config)

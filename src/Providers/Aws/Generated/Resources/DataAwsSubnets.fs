namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSubnetsState = { assignments: ResizeArray<aws.DataAwsSubnets.DataAwsSubnetsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnets">aws_subnets</a>.
    /// </summary>
    type DataAwsSubnetsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSubnetsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsSubnetsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnets#filter-1">DataAwsSubnets#filter</a> Accepts: aws.IResolvable | aws.DataAwsSubnets.DataAwsSubnetsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsSubnetsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsSubnetsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsSubnetsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnets#id-1">DataAwsSubnets#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSubnetsState, value: string) : DataAwsSubnetsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSubnetsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnets#tags-1">DataAwsSubnets#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsSubnetsState, value: seq<string * string>) : DataAwsSubnetsState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsSubnetsState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnets#timeouts-1">DataAwsSubnets#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsSubnetsState, value: aws.DataAwsSubnets.DataAwsSubnetsTimeouts) : DataAwsSubnetsState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsSubnetsState

        member _.Run(state: DataAwsSubnetsState) : aws.DataAwsSubnets.DataAwsSubnets =
            let config = aws.DataAwsSubnets.DataAwsSubnetsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSubnets.DataAwsSubnets(StackContext.get (), logicalId, config)

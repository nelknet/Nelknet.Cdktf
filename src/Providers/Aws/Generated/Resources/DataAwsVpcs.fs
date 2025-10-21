namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpcsState = { assignments: ResizeArray<aws.DataAwsVpcs.DataAwsVpcsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpcs">aws_vpcs</a>.
    /// </summary>
    type DataAwsVpcsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpcsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsVpcsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpcs#filter-1">DataAwsVpcs#filter</a> Accepts: aws.IResolvable | aws.DataAwsVpcs.DataAwsVpcsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsVpcsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsVpcsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsVpcsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpcs#id-1">DataAwsVpcs#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsVpcsState, value: string) : DataAwsVpcsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsVpcsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpcs#tags-1">DataAwsVpcs#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsVpcsState, value: seq<string * string>) : DataAwsVpcsState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsVpcsState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpcs#timeouts-1">DataAwsVpcs#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsVpcsState, value: aws.DataAwsVpcs.DataAwsVpcsTimeouts) : DataAwsVpcsState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsVpcsState

        member _.Run(state: DataAwsVpcsState) : aws.DataAwsVpcs.DataAwsVpcs =
            let config = aws.DataAwsVpcs.DataAwsVpcsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpcs.DataAwsVpcs(StackContext.get (), logicalId, config)

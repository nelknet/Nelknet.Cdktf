namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEipState = { assignments: ResizeArray<aws.DataAwsEip.DataAwsEipConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eip">aws_eip</a>.
    /// </summary>
    type DataAwsEipBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEipState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEipState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eip#filter-1">DataAwsEip#filter</a> Accepts: aws.IResolvable | aws.DataAwsEip.DataAwsEipFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEipState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEipState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEipState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eip#id-1">DataAwsEip#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEipState, value: string) : DataAwsEipState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEipState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eip#public_ip-1">DataAwsEip#public_ip</a>.
        /// </summary>
        [<CustomOperation "public_ip">]
        member _.PublicIp(state: DataAwsEipState, value: string) : DataAwsEipState =
            state.assignments.Add(fun config -> config.PublicIp <- value)
            state : DataAwsEipState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eip#tags-1">DataAwsEip#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEipState, value: seq<string * string>) : DataAwsEipState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEipState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eip#timeouts-1">DataAwsEip#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEipState, value: aws.DataAwsEip.DataAwsEipTimeouts) : DataAwsEipState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEipState

        member _.Run(state: DataAwsEipState) : aws.DataAwsEip.DataAwsEip =
            let config = aws.DataAwsEip.DataAwsEipConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEip.DataAwsEip(StackContext.get (), logicalId, config)

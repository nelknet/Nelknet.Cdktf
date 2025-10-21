namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOutpostsOutpostState = { assignments: ResizeArray<aws.DataAwsOutpostsOutpost.DataAwsOutpostsOutpostConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outpost">aws_outposts_outpost</a>.
    /// </summary>
    type DataAwsOutpostsOutpostBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOutpostsOutpostState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsOutpostsOutpostState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outpost#arn-1">DataAwsOutpostsOutpost#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsOutpostsOutpostState, value: string) : DataAwsOutpostsOutpostState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsOutpostsOutpostState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outpost#id-1">DataAwsOutpostsOutpost#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOutpostsOutpostState, value: string) : DataAwsOutpostsOutpostState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOutpostsOutpostState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outpost#name-1">DataAwsOutpostsOutpost#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsOutpostsOutpostState, value: string) : DataAwsOutpostsOutpostState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsOutpostsOutpostState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outpost#owner_id-1">DataAwsOutpostsOutpost#owner_id</a>.
        /// </summary>
        [<CustomOperation "owner_id">]
        member _.OwnerId(state: DataAwsOutpostsOutpostState, value: string) : DataAwsOutpostsOutpostState =
            state.assignments.Add(fun config -> config.OwnerId <- value)
            state : DataAwsOutpostsOutpostState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outpost#tags-1">DataAwsOutpostsOutpost#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsOutpostsOutpostState, value: seq<string * string>) : DataAwsOutpostsOutpostState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsOutpostsOutpostState

        member _.Run(state: DataAwsOutpostsOutpostState) : aws.DataAwsOutpostsOutpost.DataAwsOutpostsOutpost =
            let config = aws.DataAwsOutpostsOutpost.DataAwsOutpostsOutpostConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOutpostsOutpost.DataAwsOutpostsOutpost(StackContext.get (), logicalId, config)

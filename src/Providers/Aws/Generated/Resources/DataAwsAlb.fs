namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAlbState = { assignments: ResizeArray<aws.DataAwsAlb.DataAwsAlbConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb">aws_alb</a>.
    /// </summary>
    type DataAwsAlbBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAlbState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsAlbState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb#arn-1">DataAwsAlb#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsAlbState, value: string) : DataAwsAlbState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsAlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb#id-1">DataAwsAlb#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAlbState, value: string) : DataAwsAlbState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb#name-1">DataAwsAlb#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsAlbState, value: string) : DataAwsAlbState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsAlbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb#tags-1">DataAwsAlb#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsAlbState, value: seq<string * string>) : DataAwsAlbState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsAlbState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb#timeouts-1">DataAwsAlb#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsAlbState, value: aws.DataAwsAlb.DataAwsAlbTimeouts) : DataAwsAlbState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsAlbState

        member _.Run(state: DataAwsAlbState) : aws.DataAwsAlb.DataAwsAlb =
            let config = aws.DataAwsAlb.DataAwsAlbConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAlb.DataAwsAlb(StackContext.get (), logicalId, config)

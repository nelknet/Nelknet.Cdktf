namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCodebuildFleetState<'Name> = { assignments: ResizeArray<aws.DataAwsCodebuildFleet.DataAwsCodebuildFleetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codebuild_fleet">aws_codebuild_fleet</a>.
    /// </summary>
    type DataAwsCodebuildFleetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCodebuildFleetState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCodebuildFleetState<Missing>)

        member _.Zero(()) : DataAwsCodebuildFleetState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCodebuildFleetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codebuild_fleet#name-1">DataAwsCodebuildFleet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsCodebuildFleetState<Missing>, value: string) : DataAwsCodebuildFleetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsCodebuildFleetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codebuild_fleet#tags-1">DataAwsCodebuildFleet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsCodebuildFleetState<'Name>, value: seq<string * string>) : DataAwsCodebuildFleetState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsCodebuildFleetState<'Name>

        member _.Run(state: DataAwsCodebuildFleetState<Present>) : aws.DataAwsCodebuildFleet.DataAwsCodebuildFleet =
            let config = aws.DataAwsCodebuildFleet.DataAwsCodebuildFleetConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCodebuildFleet.DataAwsCodebuildFleet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCodebuildFleet: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCodebuildFleetState<_>) : aws.DataAwsCodebuildFleet.DataAwsCodebuildFleet =
            Unchecked.defaultof<aws.DataAwsCodebuildFleet.DataAwsCodebuildFleet>

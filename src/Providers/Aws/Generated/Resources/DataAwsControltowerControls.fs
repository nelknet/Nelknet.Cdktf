namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsControltowerControlsState<'TargetIdentifier> = { assignments: ResizeArray<aws.DataAwsControltowerControls.DataAwsControltowerControlsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/controltower_controls">aws_controltower_controls</a>.
    /// </summary>
    type DataAwsControltowerControlsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsControltowerControlsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsControltowerControlsState<Missing>)

        member _.Zero(()) : DataAwsControltowerControlsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsControltowerControlsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/controltower_controls#target_identifier-1">DataAwsControltowerControls#target_identifier</a>.
        /// </summary>
        [<CustomOperation "target_identifier">]
        member _.TargetIdentifier(state: DataAwsControltowerControlsState<Missing>, value: string) : DataAwsControltowerControlsState<Present> =
            state.assignments.Add(fun config -> config.TargetIdentifier <- value)
            ({ assignments = state.assignments } : DataAwsControltowerControlsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/controltower_controls#id-1">DataAwsControltowerControls#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsControltowerControlsState<'TargetIdentifier>, value: string) : DataAwsControltowerControlsState<'TargetIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsControltowerControlsState<'TargetIdentifier>

        member _.Run(state: DataAwsControltowerControlsState<Present>) : aws.DataAwsControltowerControls.DataAwsControltowerControls =
            let config = aws.DataAwsControltowerControls.DataAwsControltowerControlsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsControltowerControls.DataAwsControltowerControls(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsControltowerControls: missing required arguments. Must call: target_identifier.", 9999, IsError = true)>]
        member _.Run(_: DataAwsControltowerControlsState<_>) : aws.DataAwsControltowerControls.DataAwsControltowerControls =
            Unchecked.defaultof<aws.DataAwsControltowerControls.DataAwsControltowerControls>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMedialiveInputState<'Id> = { assignments: ResizeArray<aws.DataAwsMedialiveInput.DataAwsMedialiveInputConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/medialive_input">aws_medialive_input</a>.
    /// </summary>
    type DataAwsMedialiveInputBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMedialiveInputState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMedialiveInputState<Missing>)

        member _.Zero(()) : DataAwsMedialiveInputState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMedialiveInputState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/medialive_input#id-1">DataAwsMedialiveInput#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMedialiveInputState<Missing>, value: string) : DataAwsMedialiveInputState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsMedialiveInputState<Present>)

        member _.Run(state: DataAwsMedialiveInputState<Present>) : aws.DataAwsMedialiveInput.DataAwsMedialiveInput =
            let config = aws.DataAwsMedialiveInput.DataAwsMedialiveInputConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMedialiveInput.DataAwsMedialiveInput(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsMedialiveInput: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsMedialiveInputState<_>) : aws.DataAwsMedialiveInput.DataAwsMedialiveInput =
            Unchecked.defaultof<aws.DataAwsMedialiveInput.DataAwsMedialiveInput>

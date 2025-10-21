namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDxLocationState<'LocationCode> = { assignments: ResizeArray<aws.DataAwsDxLocation.DataAwsDxLocationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dx_location">aws_dx_location</a>.
    /// </summary>
    type DataAwsDxLocationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDxLocationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDxLocationState<Missing>)

        member _.Zero(()) : DataAwsDxLocationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDxLocationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dx_location#location_code-1">DataAwsDxLocation#location_code</a>.
        /// </summary>
        [<CustomOperation "location_code">]
        member _.LocationCode(state: DataAwsDxLocationState<Missing>, value: string) : DataAwsDxLocationState<Present> =
            state.assignments.Add(fun config -> config.LocationCode <- value)
            ({ assignments = state.assignments } : DataAwsDxLocationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dx_location#id-1">DataAwsDxLocation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDxLocationState<'LocationCode>, value: string) : DataAwsDxLocationState<'LocationCode> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDxLocationState<'LocationCode>

        member _.Run(state: DataAwsDxLocationState<Present>) : aws.DataAwsDxLocation.DataAwsDxLocation =
            let config = aws.DataAwsDxLocation.DataAwsDxLocationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDxLocation.DataAwsDxLocation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsDxLocation: missing required arguments. Must call: location_code.", 9999, IsError = true)>]
        member _.Run(_: DataAwsDxLocationState<_>) : aws.DataAwsDxLocation.DataAwsDxLocation =
            Unchecked.defaultof<aws.DataAwsDxLocation.DataAwsDxLocation>

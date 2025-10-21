namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLocationRouteCalculatorState<'CalculatorName> = { assignments: ResizeArray<aws.DataAwsLocationRouteCalculator.DataAwsLocationRouteCalculatorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_route_calculator">aws_location_route_calculator</a>.
    /// </summary>
    type DataAwsLocationRouteCalculatorBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLocationRouteCalculatorState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLocationRouteCalculatorState<Missing>)

        member _.Zero(()) : DataAwsLocationRouteCalculatorState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLocationRouteCalculatorState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_route_calculator#calculator_name-1">DataAwsLocationRouteCalculator#calculator_name</a>.
        /// </summary>
        [<CustomOperation "calculator_name">]
        member _.CalculatorName(state: DataAwsLocationRouteCalculatorState<Missing>, value: string) : DataAwsLocationRouteCalculatorState<Present> =
            state.assignments.Add(fun config -> config.CalculatorName <- value)
            ({ assignments = state.assignments } : DataAwsLocationRouteCalculatorState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_route_calculator#id-1">DataAwsLocationRouteCalculator#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLocationRouteCalculatorState<'CalculatorName>, value: string) : DataAwsLocationRouteCalculatorState<'CalculatorName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLocationRouteCalculatorState<'CalculatorName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_route_calculator#tags-1">DataAwsLocationRouteCalculator#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsLocationRouteCalculatorState<'CalculatorName>, value: seq<string * string>) : DataAwsLocationRouteCalculatorState<'CalculatorName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsLocationRouteCalculatorState<'CalculatorName>

        member _.Run(state: DataAwsLocationRouteCalculatorState<Present>) : aws.DataAwsLocationRouteCalculator.DataAwsLocationRouteCalculator =
            let config = aws.DataAwsLocationRouteCalculator.DataAwsLocationRouteCalculatorConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLocationRouteCalculator.DataAwsLocationRouteCalculator(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLocationRouteCalculator: missing required arguments. Must call: calculator_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLocationRouteCalculatorState<_>) : aws.DataAwsLocationRouteCalculator.DataAwsLocationRouteCalculator =
            Unchecked.defaultof<aws.DataAwsLocationRouteCalculator.DataAwsLocationRouteCalculator>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LocationRouteCalculatorState<'CalculatorName, 'DataSource> = { assignments: ResizeArray<aws.LocationRouteCalculator.LocationRouteCalculatorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_route_calculator">aws_location_route_calculator</a>.
    /// </summary>
    type LocationRouteCalculatorBuilder(logicalId: string) =
        member _.Yield(_: unit) : LocationRouteCalculatorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LocationRouteCalculatorState<Missing, Missing>)

        member _.Zero(()) : LocationRouteCalculatorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LocationRouteCalculatorState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_route_calculator#calculator_name-1">LocationRouteCalculator#calculator_name</a>.
        /// </summary>
        [<CustomOperation "calculator_name">]
        member _.CalculatorName(state: LocationRouteCalculatorState<Missing, 'DataSource>, value: string) : LocationRouteCalculatorState<Present, 'DataSource> =
            state.assignments.Add(fun config -> config.CalculatorName <- value)
            ({ assignments = state.assignments } : LocationRouteCalculatorState<Present, 'DataSource>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_route_calculator#data_source-1">LocationRouteCalculator#data_source</a>.
        /// </summary>
        [<CustomOperation "data_source">]
        member _.DataSource(state: LocationRouteCalculatorState<'CalculatorName, Missing>, value: string) : LocationRouteCalculatorState<'CalculatorName, Present> =
            state.assignments.Add(fun config -> config.DataSource <- value)
            ({ assignments = state.assignments } : LocationRouteCalculatorState<'CalculatorName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_route_calculator#description-1">LocationRouteCalculator#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: LocationRouteCalculatorState<'CalculatorName, 'DataSource>, value: string) : LocationRouteCalculatorState<'CalculatorName, 'DataSource> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : LocationRouteCalculatorState<'CalculatorName, 'DataSource>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_route_calculator#id-1">LocationRouteCalculator#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LocationRouteCalculatorState<'CalculatorName, 'DataSource>, value: string) : LocationRouteCalculatorState<'CalculatorName, 'DataSource> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LocationRouteCalculatorState<'CalculatorName, 'DataSource>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_route_calculator#tags-1">LocationRouteCalculator#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LocationRouteCalculatorState<'CalculatorName, 'DataSource>, value: seq<string * string>) : LocationRouteCalculatorState<'CalculatorName, 'DataSource> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LocationRouteCalculatorState<'CalculatorName, 'DataSource>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_route_calculator#tags_all-1">LocationRouteCalculator#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LocationRouteCalculatorState<'CalculatorName, 'DataSource>, value: seq<string * string>) : LocationRouteCalculatorState<'CalculatorName, 'DataSource> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LocationRouteCalculatorState<'CalculatorName, 'DataSource>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_route_calculator#timeouts-1">LocationRouteCalculator#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LocationRouteCalculatorState<'CalculatorName, 'DataSource>, value: aws.LocationRouteCalculator.LocationRouteCalculatorTimeouts) : LocationRouteCalculatorState<'CalculatorName, 'DataSource> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LocationRouteCalculatorState<'CalculatorName, 'DataSource>

        member _.Run(state: LocationRouteCalculatorState<Present, Present>) : aws.LocationRouteCalculator.LocationRouteCalculator =
            let config = aws.LocationRouteCalculator.LocationRouteCalculatorConfig()
            for setter in state.assignments do
                setter config
            aws.LocationRouteCalculator.LocationRouteCalculator(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.locationRouteCalculator: missing required arguments. Must call: calculator_name, data_source.", 9999, IsError = true)>]
        member _.Run(_: LocationRouteCalculatorState<_, _>) : aws.LocationRouteCalculator.LocationRouteCalculator =
            Unchecked.defaultof<aws.LocationRouteCalculator.LocationRouteCalculator>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityhubFindingAggregatorState<'LinkingMode> = { assignments: ResizeArray<aws.SecurityhubFindingAggregator.SecurityhubFindingAggregatorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_finding_aggregator">aws_securityhub_finding_aggregator</a>.
    /// </summary>
    type SecurityhubFindingAggregatorBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityhubFindingAggregatorState<Missing> =
            ({ assignments = ResizeArray() } : SecurityhubFindingAggregatorState<Missing>)

        member _.Zero(()) : SecurityhubFindingAggregatorState<Missing> =
            ({ assignments = ResizeArray() } : SecurityhubFindingAggregatorState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_finding_aggregator#linking_mode-1">SecurityhubFindingAggregator#linking_mode</a>.
        /// </summary>
        [<CustomOperation "linking_mode">]
        member _.LinkingMode(state: SecurityhubFindingAggregatorState<Missing>, value: string) : SecurityhubFindingAggregatorState<Present> =
            state.assignments.Add(fun config -> config.LinkingMode <- value)
            ({ assignments = state.assignments } : SecurityhubFindingAggregatorState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_finding_aggregator#id-1">SecurityhubFindingAggregator#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityhubFindingAggregatorState<'LinkingMode>, value: string) : SecurityhubFindingAggregatorState<'LinkingMode> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityhubFindingAggregatorState<'LinkingMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_finding_aggregator#specified_regions-1">SecurityhubFindingAggregator#specified_regions</a>.
        /// </summary>
        [<CustomOperation "specified_regions">]
        member _.SpecifiedRegions(state: SecurityhubFindingAggregatorState<'LinkingMode>, value: seq<string>) : SecurityhubFindingAggregatorState<'LinkingMode> =
            state.assignments.Add(fun config -> config.SpecifiedRegions <- (value |> Seq.toArray))
            state : SecurityhubFindingAggregatorState<'LinkingMode>

        member _.Run(state: SecurityhubFindingAggregatorState<Present>) : aws.SecurityhubFindingAggregator.SecurityhubFindingAggregator =
            let config = aws.SecurityhubFindingAggregator.SecurityhubFindingAggregatorConfig()
            for setter in state.assignments do
                setter config
            aws.SecurityhubFindingAggregator.SecurityhubFindingAggregator(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.securityhubFindingAggregator: missing required arguments. Must call: linking_mode.", 9999, IsError = true)>]
        member _.Run(_: SecurityhubFindingAggregatorState<_>) : aws.SecurityhubFindingAggregator.SecurityhubFindingAggregator =
            Unchecked.defaultof<aws.SecurityhubFindingAggregator.SecurityhubFindingAggregator>

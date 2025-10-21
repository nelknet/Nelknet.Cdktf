namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53RecoveryreadinessCellState<'CellName> = { assignments: ResizeArray<aws.Route53RecoveryreadinessCell.Route53RecoveryreadinessCellConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_cell">aws_route53recoveryreadiness_cell</a>.
    /// </summary>
    type Route53RecoveryreadinessCellBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53RecoveryreadinessCellState<Missing> =
            ({ assignments = ResizeArray() } : Route53RecoveryreadinessCellState<Missing>)

        member _.Zero(()) : Route53RecoveryreadinessCellState<Missing> =
            ({ assignments = ResizeArray() } : Route53RecoveryreadinessCellState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_cell#cell_name-1">Route53RecoveryreadinessCell#cell_name</a>.
        /// </summary>
        [<CustomOperation "cell_name">]
        member _.CellName(state: Route53RecoveryreadinessCellState<Missing>, value: string) : Route53RecoveryreadinessCellState<Present> =
            state.assignments.Add(fun config -> config.CellName <- value)
            ({ assignments = state.assignments } : Route53RecoveryreadinessCellState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_cell#cells-1">Route53RecoveryreadinessCell#cells</a>.
        /// </summary>
        [<CustomOperation "cells">]
        member _.Cells(state: Route53RecoveryreadinessCellState<'CellName>, value: seq<string>) : Route53RecoveryreadinessCellState<'CellName> =
            state.assignments.Add(fun config -> config.Cells <- (value |> Seq.toArray))
            state : Route53RecoveryreadinessCellState<'CellName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_cell#id-1">Route53RecoveryreadinessCell#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53RecoveryreadinessCellState<'CellName>, value: string) : Route53RecoveryreadinessCellState<'CellName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53RecoveryreadinessCellState<'CellName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_cell#tags-1">Route53RecoveryreadinessCell#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Route53RecoveryreadinessCellState<'CellName>, value: seq<string * string>) : Route53RecoveryreadinessCellState<'CellName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Route53RecoveryreadinessCellState<'CellName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_cell#tags_all-1">Route53RecoveryreadinessCell#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Route53RecoveryreadinessCellState<'CellName>, value: seq<string * string>) : Route53RecoveryreadinessCellState<'CellName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Route53RecoveryreadinessCellState<'CellName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_cell#timeouts-1">Route53RecoveryreadinessCell#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53RecoveryreadinessCellState<'CellName>, value: aws.Route53RecoveryreadinessCell.Route53RecoveryreadinessCellTimeouts) : Route53RecoveryreadinessCellState<'CellName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53RecoveryreadinessCellState<'CellName>

        member _.Run(state: Route53RecoveryreadinessCellState<Present>) : aws.Route53RecoveryreadinessCell.Route53RecoveryreadinessCell =
            let config = aws.Route53RecoveryreadinessCell.Route53RecoveryreadinessCellConfig()
            for setter in state.assignments do
                setter config
            aws.Route53RecoveryreadinessCell.Route53RecoveryreadinessCell(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53RecoveryreadinessCell: missing required arguments. Must call: cell_name.", 9999, IsError = true)>]
        member _.Run(_: Route53RecoveryreadinessCellState<_>) : aws.Route53RecoveryreadinessCell.Route53RecoveryreadinessCell =
            Unchecked.defaultof<aws.Route53RecoveryreadinessCell.Route53RecoveryreadinessCell>

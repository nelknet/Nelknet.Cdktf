namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LakeformationDataCellsFilterState = { assignments: ResizeArray<aws.LakeformationDataCellsFilter.LakeformationDataCellsFilterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_cells_filter">aws_lakeformation_data_cells_filter</a>.
    /// </summary>
    type LakeformationDataCellsFilterBuilder(logicalId: string) =
        member _.Yield(_: unit) : LakeformationDataCellsFilterState =
            { assignments = ResizeArray() }

        member _.Zero(()) : LakeformationDataCellsFilterState =
            { assignments = ResizeArray() }

        /// <summary>
        /// table_data block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_cells_filter#table_data-1">LakeformationDataCellsFilter#table_data</a> Accepts: aws.IResolvable | aws.LakeformationDataCellsFilter.LakeformationDataCellsFilterTableData[]
        /// </summary>
        [<CustomOperation "table_data">]
        member _.TableData(state: LakeformationDataCellsFilterState, value: HashiCorp.Cdktf.IResolvable) : LakeformationDataCellsFilterState =
            state.assignments.Add(fun config -> config.TableData <- value)
            state : LakeformationDataCellsFilterState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_cells_filter#timeouts-1">LakeformationDataCellsFilter#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LakeformationDataCellsFilterState, value: aws.LakeformationDataCellsFilter.LakeformationDataCellsFilterTimeouts) : LakeformationDataCellsFilterState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LakeformationDataCellsFilterState

        member _.Run(state: LakeformationDataCellsFilterState) : aws.LakeformationDataCellsFilter.LakeformationDataCellsFilter =
            let config = aws.LakeformationDataCellsFilter.LakeformationDataCellsFilterConfig()
            for setter in state.assignments do
                setter config
            aws.LakeformationDataCellsFilter.LakeformationDataCellsFilter(StackContext.get (), logicalId, config)

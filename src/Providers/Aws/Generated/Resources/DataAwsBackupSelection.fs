namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsBackupSelectionState<'PlanId, 'SelectionId> = { assignments: ResizeArray<aws.DataAwsBackupSelection.DataAwsBackupSelectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_selection">aws_backup_selection</a>.
    /// </summary>
    type DataAwsBackupSelectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsBackupSelectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsBackupSelectionState<Missing, Missing>)

        member _.Zero(()) : DataAwsBackupSelectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsBackupSelectionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_selection#plan_id-1">DataAwsBackupSelection#plan_id</a>.
        /// </summary>
        [<CustomOperation "plan_id">]
        member _.PlanId(state: DataAwsBackupSelectionState<Missing, 'SelectionId>, value: string) : DataAwsBackupSelectionState<Present, 'SelectionId> =
            state.assignments.Add(fun config -> config.PlanId <- value)
            ({ assignments = state.assignments } : DataAwsBackupSelectionState<Present, 'SelectionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_selection#selection_id-1">DataAwsBackupSelection#selection_id</a>.
        /// </summary>
        [<CustomOperation "selection_id">]
        member _.SelectionId(state: DataAwsBackupSelectionState<'PlanId, Missing>, value: string) : DataAwsBackupSelectionState<'PlanId, Present> =
            state.assignments.Add(fun config -> config.SelectionId <- value)
            ({ assignments = state.assignments } : DataAwsBackupSelectionState<'PlanId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/backup_selection#id-1">DataAwsBackupSelection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsBackupSelectionState<'PlanId, 'SelectionId>, value: string) : DataAwsBackupSelectionState<'PlanId, 'SelectionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsBackupSelectionState<'PlanId, 'SelectionId>

        member _.Run(state: DataAwsBackupSelectionState<Present, Present>) : aws.DataAwsBackupSelection.DataAwsBackupSelection =
            let config = aws.DataAwsBackupSelection.DataAwsBackupSelectionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsBackupSelection.DataAwsBackupSelection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsBackupSelection: missing required arguments. Must call: plan_id, selection_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsBackupSelectionState<_, _>) : aws.DataAwsBackupSelection.DataAwsBackupSelection =
            Unchecked.defaultof<aws.DataAwsBackupSelection.DataAwsBackupSelection>

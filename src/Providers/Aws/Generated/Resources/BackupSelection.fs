namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BackupSelectionState<'IamRoleArn, 'Name, 'PlanId> = { assignments: ResizeArray<aws.BackupSelection.BackupSelectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_selection">aws_backup_selection</a>.
    /// </summary>
    type BackupSelectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : BackupSelectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupSelectionState<Missing, Missing, Missing>)

        member _.Zero(()) : BackupSelectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupSelectionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_selection#iam_role_arn-1">BackupSelection#iam_role_arn</a>.
        /// </summary>
        [<CustomOperation "iam_role_arn">]
        member _.IamRoleArn(state: BackupSelectionState<Missing, 'Name, 'PlanId>, value: string) : BackupSelectionState<Present, 'Name, 'PlanId> =
            state.assignments.Add(fun config -> config.IamRoleArn <- value)
            ({ assignments = state.assignments } : BackupSelectionState<Present, 'Name, 'PlanId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_selection#name-1">BackupSelection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BackupSelectionState<'IamRoleArn, Missing, 'PlanId>, value: string) : BackupSelectionState<'IamRoleArn, Present, 'PlanId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BackupSelectionState<'IamRoleArn, Present, 'PlanId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_selection#plan_id-1">BackupSelection#plan_id</a>.
        /// </summary>
        [<CustomOperation "plan_id">]
        member _.PlanId(state: BackupSelectionState<'IamRoleArn, 'Name, Missing>, value: string) : BackupSelectionState<'IamRoleArn, 'Name, Present> =
            state.assignments.Add(fun config -> config.PlanId <- value)
            ({ assignments = state.assignments } : BackupSelectionState<'IamRoleArn, 'Name, Present>)

        /// <summary>
        /// condition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_selection#condition-1">BackupSelection#condition</a> Accepts: aws.IResolvable | aws.BackupSelection.BackupSelectionCondition[]
        /// </summary>
        [<CustomOperation "condition">]
        member _.Condition(state: BackupSelectionState<'IamRoleArn, 'Name, 'PlanId>, value: HashiCorp.Cdktf.IResolvable) : BackupSelectionState<'IamRoleArn, 'Name, 'PlanId> =
            state.assignments.Add(fun config -> config.Condition <- value)
            state : BackupSelectionState<'IamRoleArn, 'Name, 'PlanId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_selection#id-1">BackupSelection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BackupSelectionState<'IamRoleArn, 'Name, 'PlanId>, value: string) : BackupSelectionState<'IamRoleArn, 'Name, 'PlanId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BackupSelectionState<'IamRoleArn, 'Name, 'PlanId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_selection#not_resources-1">BackupSelection#not_resources</a>.
        /// </summary>
        [<CustomOperation "not_resources">]
        member _.NotResources(state: BackupSelectionState<'IamRoleArn, 'Name, 'PlanId>, value: seq<string>) : BackupSelectionState<'IamRoleArn, 'Name, 'PlanId> =
            state.assignments.Add(fun config -> config.NotResources <- (value |> Seq.toArray))
            state : BackupSelectionState<'IamRoleArn, 'Name, 'PlanId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_selection#resources-1">BackupSelection#resources</a>.
        /// </summary>
        [<CustomOperation "resources">]
        member _.Resources(state: BackupSelectionState<'IamRoleArn, 'Name, 'PlanId>, value: seq<string>) : BackupSelectionState<'IamRoleArn, 'Name, 'PlanId> =
            state.assignments.Add(fun config -> config.Resources <- (value |> Seq.toArray))
            state : BackupSelectionState<'IamRoleArn, 'Name, 'PlanId>

        /// <summary>
        /// selection_tag block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_selection#selection_tag-1">BackupSelection#selection_tag</a> Accepts: aws.IResolvable | aws.BackupSelection.BackupSelectionSelectionTag[]
        /// </summary>
        [<CustomOperation "selection_tag">]
        member _.SelectionTag(state: BackupSelectionState<'IamRoleArn, 'Name, 'PlanId>, value: HashiCorp.Cdktf.IResolvable) : BackupSelectionState<'IamRoleArn, 'Name, 'PlanId> =
            state.assignments.Add(fun config -> config.SelectionTag <- value)
            state : BackupSelectionState<'IamRoleArn, 'Name, 'PlanId>

        member _.Run(state: BackupSelectionState<Present, Present, Present>) : aws.BackupSelection.BackupSelection =
            let config = aws.BackupSelection.BackupSelectionConfig()
            for setter in state.assignments do
                setter config
            aws.BackupSelection.BackupSelection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.backupSelection: missing required arguments. Must call: iam_role_arn, name, plan_id.", 9999, IsError = true)>]
        member _.Run(_: BackupSelectionState<_, _, _>) : aws.BackupSelection.BackupSelection =
            Unchecked.defaultof<aws.BackupSelection.BackupSelection>

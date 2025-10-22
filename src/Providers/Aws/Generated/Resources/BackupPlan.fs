namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BackupPlanState<'Name, 'Rule> = { assignments: ResizeArray<aws.BackupPlan.BackupPlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_plan">aws_backup_plan</a>.
    /// </summary>
    type BackupPlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : BackupPlanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupPlanState<Missing, Missing>)

        member _.Zero(()) : BackupPlanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BackupPlanState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_plan#name-1">BackupPlan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BackupPlanState<Missing, 'Rule>, value: string) : BackupPlanState<Present, 'Rule> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BackupPlanState<Present, 'Rule>)

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_plan#rule-1">BackupPlan#rule</a> Accepts: aws.IResolvable | aws.BackupPlan.BackupPlanRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: BackupPlanState<'Name, Missing>, value: HashiCorp.Cdktf.IResolvable) : BackupPlanState<'Name, Present> =
            state.assignments.Add(fun config -> config.Rule <- value)
            ({ assignments = state.assignments } : BackupPlanState<'Name, Present>)

        /// <summary>
        /// advanced_backup_setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_plan#advanced_backup_setting-1">BackupPlan#advanced_backup_setting</a> Accepts: aws.IResolvable | aws.BackupPlan.BackupPlanAdvancedBackupSetting[]
        /// </summary>
        [<CustomOperation "advanced_backup_setting">]
        member _.AdvancedBackupSetting(state: BackupPlanState<'Name, 'Rule>, value: HashiCorp.Cdktf.IResolvable) : BackupPlanState<'Name, 'Rule> =
            state.assignments.Add(fun config -> config.AdvancedBackupSetting <- value)
            state : BackupPlanState<'Name, 'Rule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_plan#id-1">BackupPlan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BackupPlanState<'Name, 'Rule>, value: string) : BackupPlanState<'Name, 'Rule> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BackupPlanState<'Name, 'Rule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_plan#tags-1">BackupPlan#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BackupPlanState<'Name, 'Rule>, value: seq<string * string>) : BackupPlanState<'Name, 'Rule> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BackupPlanState<'Name, 'Rule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/backup_plan#tags_all-1">BackupPlan#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: BackupPlanState<'Name, 'Rule>, value: seq<string * string>) : BackupPlanState<'Name, 'Rule> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : BackupPlanState<'Name, 'Rule>

        member _.Run(state: BackupPlanState<Present, Present>) : aws.BackupPlan.BackupPlan =
            let config = aws.BackupPlan.BackupPlanConfig()
            for setter in state.assignments do
                setter config
            aws.BackupPlan.BackupPlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.backupPlan: missing required arguments. Must call: name, rule.", 9999, IsError = true)>]
        member _.Run(_: BackupPlanState<_, _>) : aws.BackupPlan.BackupPlan =
            Unchecked.defaultof<aws.BackupPlan.BackupPlan>

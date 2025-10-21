namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, 'TargetAction> = { assignments: ResizeArray<aws.RedshiftScheduledAction.RedshiftScheduledActionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action">aws_redshift_scheduled_action</a>.
    /// </summary>
    type RedshiftScheduledActionBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftScheduledActionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftScheduledActionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : RedshiftScheduledActionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftScheduledActionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#iam_role-1">RedshiftScheduledAction#iam_role</a>.
        /// </summary>
        [<CustomOperation "iam_role">]
        member _.IamRole(state: RedshiftScheduledActionState<Missing, 'Name, 'Schedule, 'TargetAction>, value: string) : RedshiftScheduledActionState<Present, 'Name, 'Schedule, 'TargetAction> =
            state.assignments.Add(fun config -> config.IamRole <- value)
            ({ assignments = state.assignments } : RedshiftScheduledActionState<Present, 'Name, 'Schedule, 'TargetAction>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#name-1">RedshiftScheduledAction#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RedshiftScheduledActionState<'IamRole, Missing, 'Schedule, 'TargetAction>, value: string) : RedshiftScheduledActionState<'IamRole, Present, 'Schedule, 'TargetAction> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RedshiftScheduledActionState<'IamRole, Present, 'Schedule, 'TargetAction>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#schedule-1">RedshiftScheduledAction#schedule</a>.
        /// </summary>
        [<CustomOperation "schedule">]
        member _.Schedule(state: RedshiftScheduledActionState<'IamRole, 'Name, Missing, 'TargetAction>, value: string) : RedshiftScheduledActionState<'IamRole, 'Name, Present, 'TargetAction> =
            state.assignments.Add(fun config -> config.Schedule <- value)
            ({ assignments = state.assignments } : RedshiftScheduledActionState<'IamRole, 'Name, Present, 'TargetAction>)

        /// <summary>
        /// target_action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#target_action-1">RedshiftScheduledAction#target_action</a>
        /// </summary>
        [<CustomOperation "target_action">]
        member _.TargetAction(state: RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, Missing>, value: aws.RedshiftScheduledAction.RedshiftScheduledActionTargetAction) : RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, Present> =
            state.assignments.Add(fun config -> config.TargetAction <- value)
            ({ assignments = state.assignments } : RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#description-1">RedshiftScheduledAction#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, 'TargetAction>, value: string) : RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, 'TargetAction> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, 'TargetAction>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#enable-1">RedshiftScheduledAction#enable</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable">]
        member _.Enable(state: RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, 'TargetAction>, value: bool) : RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, 'TargetAction> =
            state.assignments.Add(fun config -> config.Enable <- value)
            state : RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, 'TargetAction>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#enable-1">RedshiftScheduledAction#enable</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable">]
        member _.Enable(state: RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, 'TargetAction>, value: HashiCorp.Cdktf.IResolvable) : RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, 'TargetAction> =
            state.assignments.Add(fun config -> config.Enable <- value)
            state : RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, 'TargetAction>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#end_time-1">RedshiftScheduledAction#end_time</a>.
        /// </summary>
        [<CustomOperation "end_time">]
        member _.EndTime(state: RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, 'TargetAction>, value: string) : RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, 'TargetAction> =
            state.assignments.Add(fun config -> config.EndTime <- value)
            state : RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, 'TargetAction>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#id-1">RedshiftScheduledAction#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, 'TargetAction>, value: string) : RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, 'TargetAction> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, 'TargetAction>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_scheduled_action#start_time-1">RedshiftScheduledAction#start_time</a>.
        /// </summary>
        [<CustomOperation "start_time">]
        member _.StartTime(state: RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, 'TargetAction>, value: string) : RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, 'TargetAction> =
            state.assignments.Add(fun config -> config.StartTime <- value)
            state : RedshiftScheduledActionState<'IamRole, 'Name, 'Schedule, 'TargetAction>

        member _.Run(state: RedshiftScheduledActionState<Present, Present, Present, Present>) : aws.RedshiftScheduledAction.RedshiftScheduledAction =
            let config = aws.RedshiftScheduledAction.RedshiftScheduledActionConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftScheduledAction.RedshiftScheduledAction(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftScheduledAction: missing required arguments. Must call: iam_role, name, schedule, target_action.", 9999, IsError = true)>]
        member _.Run(_: RedshiftScheduledActionState<_, _, _, _>) : aws.RedshiftScheduledAction.RedshiftScheduledAction =
            Unchecked.defaultof<aws.RedshiftScheduledAction.RedshiftScheduledAction>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType> = { assignments: ResizeArray<azurerm.AutomationRunbook.AutomationRunbookConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook">azurerm_automation_runbook</a>.
    /// </summary>
    type AutomationRunbookBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationRunbookState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationRunbookState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AutomationRunbookState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationRunbookState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#automation_account_name-1">AutomationRunbook#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationRunbookState<Missing, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>, value: string) : AutomationRunbookState<Present, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationRunbookState<Present, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#location-1">AutomationRunbook#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: AutomationRunbookState<'AutomationAccountName, Missing, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>, value: string) : AutomationRunbookState<'AutomationAccountName, Present, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : AutomationRunbookState<'AutomationAccountName, Present, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#log_progress-1">AutomationRunbook#log_progress</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_progress">]
        member _.LogProgress(state: AutomationRunbookState<'AutomationAccountName, 'Location, Missing, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>, value: bool) : AutomationRunbookState<'AutomationAccountName, 'Location, Present, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType> =
            state.assignments.Add(fun config -> config.LogProgress <- value)
            ({ assignments = state.assignments } : AutomationRunbookState<'AutomationAccountName, 'Location, Present, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#log_progress-1">AutomationRunbook#log_progress</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_progress">]
        member _.LogProgress(state: AutomationRunbookState<'AutomationAccountName, 'Location, Missing, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>, value: HashiCorp.Cdktf.IResolvable) : AutomationRunbookState<'AutomationAccountName, 'Location, Present, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType> =
            state.assignments.Add(fun config -> config.LogProgress <- value)
            ({ assignments = state.assignments } : AutomationRunbookState<'AutomationAccountName, 'Location, Present, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#log_verbose-1">AutomationRunbook#log_verbose</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_verbose">]
        member _.LogVerbose(state: AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, Missing, 'Name, 'ResourceGroupName, 'RunbookType>, value: bool) : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, Present, 'Name, 'ResourceGroupName, 'RunbookType> =
            state.assignments.Add(fun config -> config.LogVerbose <- value)
            ({ assignments = state.assignments } : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, Present, 'Name, 'ResourceGroupName, 'RunbookType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#log_verbose-1">AutomationRunbook#log_verbose</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_verbose">]
        member _.LogVerbose(state: AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, Missing, 'Name, 'ResourceGroupName, 'RunbookType>, value: HashiCorp.Cdktf.IResolvable) : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, Present, 'Name, 'ResourceGroupName, 'RunbookType> =
            state.assignments.Add(fun config -> config.LogVerbose <- value)
            ({ assignments = state.assignments } : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, Present, 'Name, 'ResourceGroupName, 'RunbookType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#name-1">AutomationRunbook#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, Missing, 'ResourceGroupName, 'RunbookType>, value: string) : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, Present, 'ResourceGroupName, 'RunbookType> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, Present, 'ResourceGroupName, 'RunbookType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#resource_group_name-1">AutomationRunbook#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, Missing, 'RunbookType>, value: string) : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, Present, 'RunbookType> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, Present, 'RunbookType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#runbook_type-1">AutomationRunbook#runbook_type</a>.
        /// </summary>
        [<CustomOperation "runbook_type">]
        member _.RunbookType(state: AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, Missing>, value: string) : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.RunbookType <- value)
            ({ assignments = state.assignments } : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#content-1">AutomationRunbook#content</a>.
        /// </summary>
        [<CustomOperation "content">]
        member _.Content(state: AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>, value: string) : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType> =
            state.assignments.Add(fun config -> config.Content <- value)
            state : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#description-1">AutomationRunbook#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>, value: string) : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>

        /// <summary>
        /// draft block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#draft-1">AutomationRunbook#draft</a>
        /// </summary>
        [<CustomOperation "draft">]
        member _.Draft(state: AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>, value: azurerm.AutomationRunbook.AutomationRunbookDraft) : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType> =
            state.assignments.Add(fun config -> config.Draft <- value)
            state : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#id-1">AutomationRunbook#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>, value: string) : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#job_schedule-1">AutomationRunbook#job_schedule</a>. Accepts: azurerm.IResolvable | azurerm.AutomationRunbook.AutomationRunbookJobSchedule[]
        /// </summary>
        [<CustomOperation "job_schedule">]
        member _.JobSchedule(state: AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>, value: HashiCorp.Cdktf.IResolvable) : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType> =
            state.assignments.Add(fun config -> config.JobSchedule <- value)
            state : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#log_activity_trace_level-1">AutomationRunbook#log_activity_trace_level</a>.
        /// </summary>
        [<CustomOperation "log_activity_trace_level">]
        member _.LogActivityTraceLevel(state: AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>, value: double) : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType> =
            state.assignments.Add(fun config -> config.LogActivityTraceLevel <- value)
            state : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>

        /// <summary>
        /// publish_content_link block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#publish_content_link-1">AutomationRunbook#publish_content_link</a>
        /// </summary>
        [<CustomOperation "publish_content_link">]
        member _.PublishContentLink(state: AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>, value: azurerm.AutomationRunbook.AutomationRunbookPublishContentLink) : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType> =
            state.assignments.Add(fun config -> config.PublishContentLink <- value)
            state : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#tags-1">AutomationRunbook#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>, value: seq<string * string>) : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#timeouts-1">AutomationRunbook#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>, value: azurerm.AutomationRunbook.AutomationRunbookTimeouts) : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationRunbookState<'AutomationAccountName, 'Location, 'LogProgress, 'LogVerbose, 'Name, 'ResourceGroupName, 'RunbookType>

        member _.Run(state: AutomationRunbookState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.AutomationRunbook.AutomationRunbook =
            let config = azurerm.AutomationRunbook.AutomationRunbookConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationRunbook.AutomationRunbook(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationRunbook: missing required arguments. Must call: automation_account_name, location, log_progress, log_verbose, name, resource_group_name, runbook_type.", 9999, IsError = true)>]
        member _.Run(_: AutomationRunbookState<_, _, _, _, _, _, _>) : azurerm.AutomationRunbook.AutomationRunbook =
            Unchecked.defaultof<azurerm.AutomationRunbook.AutomationRunbook>

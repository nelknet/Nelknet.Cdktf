namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType> = { assignments: ResizeArray<azurerm.AutomationSourceControl.AutomationSourceControlConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control">azurerm_automation_source_control</a>.
    /// </summary>
    type AutomationSourceControlBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationSourceControlState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationSourceControlState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AutomationSourceControlState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationSourceControlState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#automation_account_id-1">AutomationSourceControl#automation_account_id</a>.
        /// </summary>
        [<CustomOperation "automation_account_id">]
        member _.AutomationAccountId(state: AutomationSourceControlState<Missing, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>, value: string) : AutomationSourceControlState<Present, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType> =
            state.assignments.Add(fun config -> config.AutomationAccountId <- value)
            ({ assignments = state.assignments } : AutomationSourceControlState<Present, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#folder_path-1">AutomationSourceControl#folder_path</a>.
        /// </summary>
        [<CustomOperation "folder_path">]
        member _.FolderPath(state: AutomationSourceControlState<'AutomationAccountId, Missing, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>, value: string) : AutomationSourceControlState<'AutomationAccountId, Present, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType> =
            state.assignments.Add(fun config -> config.FolderPath <- value)
            ({ assignments = state.assignments } : AutomationSourceControlState<'AutomationAccountId, Present, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#name-1">AutomationSourceControl#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationSourceControlState<'AutomationAccountId, 'FolderPath, Missing, 'RepositoryUrl, 'Security, 'SourceControlType>, value: string) : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, Present, 'RepositoryUrl, 'Security, 'SourceControlType> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, Present, 'RepositoryUrl, 'Security, 'SourceControlType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#repository_url-1">AutomationSourceControl#repository_url</a>.
        /// </summary>
        [<CustomOperation "repository_url">]
        member _.RepositoryUrl(state: AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, Missing, 'Security, 'SourceControlType>, value: string) : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, Present, 'Security, 'SourceControlType> =
            state.assignments.Add(fun config -> config.RepositoryUrl <- value)
            ({ assignments = state.assignments } : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, Present, 'Security, 'SourceControlType>)

        /// <summary>
        /// security block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#security-1">AutomationSourceControl#security</a>
        /// </summary>
        [<CustomOperation "security">]
        member _.Security(state: AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, Missing, 'SourceControlType>, value: azurerm.AutomationSourceControl.AutomationSourceControlSecurity) : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, Present, 'SourceControlType> =
            state.assignments.Add(fun config -> config.Security <- value)
            ({ assignments = state.assignments } : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, Present, 'SourceControlType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#source_control_type-1">AutomationSourceControl#source_control_type</a>.
        /// </summary>
        [<CustomOperation "source_control_type">]
        member _.SourceControlType(state: AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, Missing>, value: string) : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, Present> =
            state.assignments.Add(fun config -> config.SourceControlType <- value)
            ({ assignments = state.assignments } : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#automatic_sync-1">AutomationSourceControl#automatic_sync</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "automatic_sync">]
        member _.AutomaticSync(state: AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>, value: bool) : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType> =
            state.assignments.Add(fun config -> config.AutomaticSync <- value)
            state : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#automatic_sync-1">AutomationSourceControl#automatic_sync</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "automatic_sync">]
        member _.AutomaticSync(state: AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>, value: HashiCorp.Cdktf.IResolvable) : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType> =
            state.assignments.Add(fun config -> config.AutomaticSync <- value)
            state : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#branch-1">AutomationSourceControl#branch</a>.
        /// </summary>
        [<CustomOperation "branch">]
        member _.Branch(state: AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>, value: string) : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType> =
            state.assignments.Add(fun config -> config.Branch <- value)
            state : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#description-1">AutomationSourceControl#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>, value: string) : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#id-1">AutomationSourceControl#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>, value: string) : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#publish_runbook_enabled-1">AutomationSourceControl#publish_runbook_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "publish_runbook_enabled">]
        member _.PublishRunbookEnabled(state: AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>, value: bool) : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType> =
            state.assignments.Add(fun config -> config.PublishRunbookEnabled <- value)
            state : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#publish_runbook_enabled-1">AutomationSourceControl#publish_runbook_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "publish_runbook_enabled">]
        member _.PublishRunbookEnabled(state: AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>, value: HashiCorp.Cdktf.IResolvable) : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType> =
            state.assignments.Add(fun config -> config.PublishRunbookEnabled <- value)
            state : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#timeouts-1">AutomationSourceControl#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>, value: azurerm.AutomationSourceControl.AutomationSourceControlTimeouts) : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationSourceControlState<'AutomationAccountId, 'FolderPath, 'Name, 'RepositoryUrl, 'Security, 'SourceControlType>

        member _.Run(state: AutomationSourceControlState<Present, Present, Present, Present, Present, Present>) : azurerm.AutomationSourceControl.AutomationSourceControl =
            let config = azurerm.AutomationSourceControl.AutomationSourceControlConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationSourceControl.AutomationSourceControl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationSourceControl: missing required arguments. Must call: automation_account_id, folder_path, name, repository_url, security, source_control_type.", 9999, IsError = true)>]
        member _.Run(_: AutomationSourceControlState<_, _, _, _, _, _>) : azurerm.AutomationSourceControl.AutomationSourceControl =
            Unchecked.defaultof<azurerm.AutomationSourceControl.AutomationSourceControl>

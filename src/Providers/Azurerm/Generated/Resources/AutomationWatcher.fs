namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn> = { assignments: ResizeArray<azurerm.AutomationWatcher.AutomationWatcherConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_watcher">azurerm_automation_watcher</a>.
    /// </summary>
    type AutomationWatcherBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationWatcherState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationWatcherState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AutomationWatcherState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationWatcherState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_watcher#automation_account_id-1">AutomationWatcher#automation_account_id</a>.
        /// </summary>
        [<CustomOperation "automation_account_id">]
        member _.AutomationAccountId(state: AutomationWatcherState<Missing, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn>, value: string) : AutomationWatcherState<Present, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn> =
            state.assignments.Add(fun config -> config.AutomationAccountId <- value)
            ({ assignments = state.assignments } : AutomationWatcherState<Present, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_watcher#execution_frequency_in_seconds-1">AutomationWatcher#execution_frequency_in_seconds</a>.
        /// </summary>
        [<CustomOperation "execution_frequency_in_seconds">]
        member _.ExecutionFrequencyInSeconds(state: AutomationWatcherState<'AutomationAccountId, Missing, 'Location, 'Name, 'ScriptName, 'ScriptRunOn>, value: double) : AutomationWatcherState<'AutomationAccountId, Present, 'Location, 'Name, 'ScriptName, 'ScriptRunOn> =
            state.assignments.Add(fun config -> config.ExecutionFrequencyInSeconds <- value)
            ({ assignments = state.assignments } : AutomationWatcherState<'AutomationAccountId, Present, 'Location, 'Name, 'ScriptName, 'ScriptRunOn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_watcher#location-1">AutomationWatcher#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, Missing, 'Name, 'ScriptName, 'ScriptRunOn>, value: string) : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, Present, 'Name, 'ScriptName, 'ScriptRunOn> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, Present, 'Name, 'ScriptName, 'ScriptRunOn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_watcher#name-1">AutomationWatcher#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, Missing, 'ScriptName, 'ScriptRunOn>, value: string) : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, Present, 'ScriptName, 'ScriptRunOn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, Present, 'ScriptName, 'ScriptRunOn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_watcher#script_name-1">AutomationWatcher#script_name</a>.
        /// </summary>
        [<CustomOperation "script_name">]
        member _.ScriptName(state: AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, Missing, 'ScriptRunOn>, value: string) : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, Present, 'ScriptRunOn> =
            state.assignments.Add(fun config -> config.ScriptName <- value)
            ({ assignments = state.assignments } : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, Present, 'ScriptRunOn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_watcher#script_run_on-1">AutomationWatcher#script_run_on</a>.
        /// </summary>
        [<CustomOperation "script_run_on">]
        member _.ScriptRunOn(state: AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, Missing>, value: string) : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, Present> =
            state.assignments.Add(fun config -> config.ScriptRunOn <- value)
            ({ assignments = state.assignments } : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_watcher#description-1">AutomationWatcher#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn>, value: string) : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_watcher#etag-1">AutomationWatcher#etag</a>.
        /// </summary>
        [<CustomOperation "etag">]
        member _.Etag(state: AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn>, value: string) : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn> =
            state.assignments.Add(fun config -> config.Etag <- value)
            state : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_watcher#id-1">AutomationWatcher#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn>, value: string) : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_watcher#script_parameters-1">AutomationWatcher#script_parameters</a>.
        /// </summary>
        [<CustomOperation "script_parameters">]
        member _.ScriptParameters(state: AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn>, value: seq<string * string>) : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn> =
            state.assignments.Add(fun config -> config.ScriptParameters <- dict value)
            state : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_watcher#tags-1">AutomationWatcher#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn>, value: seq<string * string>) : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_watcher#timeouts-1">AutomationWatcher#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn>, value: azurerm.AutomationWatcher.AutomationWatcherTimeouts) : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationWatcherState<'AutomationAccountId, 'ExecutionFrequencyInSeconds, 'Location, 'Name, 'ScriptName, 'ScriptRunOn>

        member _.Run(state: AutomationWatcherState<Present, Present, Present, Present, Present, Present>) : azurerm.AutomationWatcher.AutomationWatcher =
            let config = azurerm.AutomationWatcher.AutomationWatcherConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationWatcher.AutomationWatcher(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationWatcher: missing required arguments. Must call: automation_account_id, execution_frequency_in_seconds, location, name, script_name, script_run_on.", 9999, IsError = true)>]
        member _.Run(_: AutomationWatcherState<_, _, _, _, _, _>) : azurerm.AutomationWatcher.AutomationWatcher =
            Unchecked.defaultof<azurerm.AutomationWatcher.AutomationWatcher>

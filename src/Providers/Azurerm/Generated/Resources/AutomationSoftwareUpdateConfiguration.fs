namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule> = { assignments: ResizeArray<azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration">azurerm_automation_software_update_configuration</a>.
    /// </summary>
    type AutomationSoftwareUpdateConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationSoftwareUpdateConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationSoftwareUpdateConfigurationState<Missing, Missing, Missing>)

        member _.Zero(()) : AutomationSoftwareUpdateConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationSoftwareUpdateConfigurationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#automation_account_id-1">AutomationSoftwareUpdateConfiguration#automation_account_id</a>.
        /// </summary>
        [<CustomOperation "automation_account_id">]
        member _.AutomationAccountId(state: AutomationSoftwareUpdateConfigurationState<Missing, 'Name, 'Schedule>, value: string) : AutomationSoftwareUpdateConfigurationState<Present, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.AutomationAccountId <- value)
            ({ assignments = state.assignments } : AutomationSoftwareUpdateConfigurationState<Present, 'Name, 'Schedule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#name-1">AutomationSoftwareUpdateConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, Missing, 'Schedule>, value: string) : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, Present, 'Schedule> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, Present, 'Schedule>)

        /// <summary>
        /// schedule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#schedule-1">AutomationSoftwareUpdateConfiguration#schedule</a>
        /// </summary>
        [<CustomOperation "schedule">]
        member _.Schedule(state: AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, Missing>, value: azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationSchedule) : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Schedule <- value)
            ({ assignments = state.assignments } : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#duration-1">AutomationSoftwareUpdateConfiguration#duration</a>.
        /// </summary>
        [<CustomOperation "duration">]
        member _.Duration(state: AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>, value: string) : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.Duration <- value)
            state : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#id-1">AutomationSoftwareUpdateConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>, value: string) : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>

        /// <summary>
        /// linux block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#linux-1">AutomationSoftwareUpdateConfiguration#linux</a>
        /// </summary>
        [<CustomOperation "linux">]
        member _.Linux(state: AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>, value: azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationLinux) : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.Linux <- value)
            state : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#non_azure_computer_names-1">AutomationSoftwareUpdateConfiguration#non_azure_computer_names</a>.
        /// </summary>
        [<CustomOperation "non_azure_computer_names">]
        member _.NonAzureComputerNames(state: AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>, value: seq<string>) : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.NonAzureComputerNames <- (value |> Seq.toArray))
            state : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>

        /// <summary>
        /// post_task block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#post_task-1">AutomationSoftwareUpdateConfiguration#post_task</a>
        /// </summary>
        [<CustomOperation "post_task">]
        member _.PostTask(state: AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>, value: azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationPostTask) : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.PostTask <- value)
            state : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>

        /// <summary>
        /// pre_task block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#pre_task-1">AutomationSoftwareUpdateConfiguration#pre_task</a>
        /// </summary>
        [<CustomOperation "pre_task">]
        member _.PreTask(state: AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>, value: azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationPreTask) : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.PreTask <- value)
            state : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>

        /// <summary>
        /// target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#target-1">AutomationSoftwareUpdateConfiguration#target</a>
        /// </summary>
        [<CustomOperation "target">]
        member _.Target(state: AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>, value: azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTarget) : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.Target <- value)
            state : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#timeouts-1">AutomationSoftwareUpdateConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>, value: azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTimeouts) : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#virtual_machine_ids-1">AutomationSoftwareUpdateConfiguration#virtual_machine_ids</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_ids">]
        member _.VirtualMachineIds(state: AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>, value: seq<string>) : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.VirtualMachineIds <- (value |> Seq.toArray))
            state : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>

        /// <summary>
        /// windows block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#windows-1">AutomationSoftwareUpdateConfiguration#windows</a>
        /// </summary>
        [<CustomOperation "windows">]
        member _.Windows(state: AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>, value: azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationWindows) : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.Windows <- value)
            state : AutomationSoftwareUpdateConfigurationState<'AutomationAccountId, 'Name, 'Schedule>

        member _.Run(state: AutomationSoftwareUpdateConfigurationState<Present, Present, Present>) : azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfiguration =
            let config = azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationSoftwareUpdateConfiguration: missing required arguments. Must call: automation_account_id, name, schedule.", 9999, IsError = true)>]
        member _.Run(_: AutomationSoftwareUpdateConfigurationState<_, _, _>) : azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfiguration =
            Unchecked.defaultof<azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfiguration>

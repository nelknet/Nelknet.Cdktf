namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AutomationDscConfiguration.AutomationDscConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_dsc_configuration">azurerm_automation_dsc_configuration</a>.
    /// </summary>
    type AutomationDscConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationDscConfigurationState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationDscConfigurationState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AutomationDscConfigurationState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationDscConfigurationState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_dsc_configuration#automation_account_name-1">AutomationDscConfiguration#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationDscConfigurationState<Missing, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName>, value: string) : AutomationDscConfigurationState<Present, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationDscConfigurationState<Present, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_dsc_configuration#content_embedded-1">AutomationDscConfiguration#content_embedded</a>.
        /// </summary>
        [<CustomOperation "content_embedded">]
        member _.ContentEmbedded(state: AutomationDscConfigurationState<'AutomationAccountName, Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : AutomationDscConfigurationState<'AutomationAccountName, Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ContentEmbedded <- value)
            ({ assignments = state.assignments } : AutomationDscConfigurationState<'AutomationAccountName, Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_dsc_configuration#location-1">AutomationDscConfiguration#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, Missing, 'Name, 'ResourceGroupName>, value: string) : AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_dsc_configuration#name-1">AutomationDscConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, Missing, 'ResourceGroupName>, value: string) : AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_dsc_configuration#resource_group_name-1">AutomationDscConfiguration#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, Missing>, value: string) : AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_dsc_configuration#description-1">AutomationDscConfiguration#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName>, value: string) : AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_dsc_configuration#id-1">AutomationDscConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName>, value: string) : AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_dsc_configuration#log_verbose-1">AutomationDscConfiguration#log_verbose</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_verbose">]
        member _.LogVerbose(state: AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName>, value: bool) : AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LogVerbose <- value)
            state : AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_dsc_configuration#log_verbose-1">AutomationDscConfiguration#log_verbose</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_verbose">]
        member _.LogVerbose(state: AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LogVerbose <- value)
            state : AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_dsc_configuration#tags-1">AutomationDscConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_dsc_configuration#timeouts-1">AutomationDscConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.AutomationDscConfiguration.AutomationDscConfigurationTimeouts) : AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationDscConfigurationState<'AutomationAccountName, 'ContentEmbedded, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: AutomationDscConfigurationState<Present, Present, Present, Present, Present>) : azurerm.AutomationDscConfiguration.AutomationDscConfiguration =
            let config = azurerm.AutomationDscConfiguration.AutomationDscConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationDscConfiguration.AutomationDscConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationDscConfiguration: missing required arguments. Must call: automation_account_name, content_embedded, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AutomationDscConfigurationState<_, _, _, _, _>) : azurerm.AutomationDscConfiguration.AutomationDscConfiguration =
            Unchecked.defaultof<azurerm.AutomationDscConfiguration.AutomationDscConfiguration>

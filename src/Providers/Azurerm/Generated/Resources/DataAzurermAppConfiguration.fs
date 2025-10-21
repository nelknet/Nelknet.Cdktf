namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermAppConfigurationState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermAppConfiguration.DataAzurermAppConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration">azurerm_app_configuration</a>.
    /// </summary>
    type DataAzurermAppConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermAppConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAppConfigurationState<Missing, Missing>)

        member _.Zero(()) : DataAzurermAppConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAppConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration#name-1">DataAzurermAppConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermAppConfigurationState<Missing, 'ResourceGroupName>, value: string) : DataAzurermAppConfigurationState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermAppConfigurationState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration#resource_group_name-1">DataAzurermAppConfiguration#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermAppConfigurationState<'Name, Missing>, value: string) : DataAzurermAppConfigurationState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermAppConfigurationState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration#id-1">DataAzurermAppConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermAppConfigurationState<'Name, 'ResourceGroupName>, value: string) : DataAzurermAppConfigurationState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermAppConfigurationState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration#timeouts-1">DataAzurermAppConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermAppConfigurationState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermAppConfiguration.DataAzurermAppConfigurationTimeouts) : DataAzurermAppConfigurationState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermAppConfigurationState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermAppConfigurationState<Present, Present>) : azurerm.DataAzurermAppConfiguration.DataAzurermAppConfiguration =
            let config = azurerm.DataAzurermAppConfiguration.DataAzurermAppConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermAppConfiguration.DataAzurermAppConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermAppConfiguration: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermAppConfigurationState<_, _>) : azurerm.DataAzurermAppConfiguration.DataAzurermAppConfiguration =
            Unchecked.defaultof<azurerm.DataAzurermAppConfiguration.DataAzurermAppConfiguration>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermManagedApplicationDefinitionState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermManagedApplicationDefinition.DataAzurermManagedApplicationDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_application_definition">azurerm_managed_application_definition</a>.
    /// </summary>
    type DataAzurermManagedApplicationDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermManagedApplicationDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermManagedApplicationDefinitionState<Missing, Missing>)

        member _.Zero(()) : DataAzurermManagedApplicationDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermManagedApplicationDefinitionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_application_definition#name-1">DataAzurermManagedApplicationDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermManagedApplicationDefinitionState<Missing, 'ResourceGroupName>, value: string) : DataAzurermManagedApplicationDefinitionState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermManagedApplicationDefinitionState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_application_definition#resource_group_name-1">DataAzurermManagedApplicationDefinition#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermManagedApplicationDefinitionState<'Name, Missing>, value: string) : DataAzurermManagedApplicationDefinitionState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermManagedApplicationDefinitionState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_application_definition#id-1">DataAzurermManagedApplicationDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermManagedApplicationDefinitionState<'Name, 'ResourceGroupName>, value: string) : DataAzurermManagedApplicationDefinitionState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermManagedApplicationDefinitionState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_application_definition#timeouts-1">DataAzurermManagedApplicationDefinition#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermManagedApplicationDefinitionState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermManagedApplicationDefinition.DataAzurermManagedApplicationDefinitionTimeouts) : DataAzurermManagedApplicationDefinitionState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermManagedApplicationDefinitionState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermManagedApplicationDefinitionState<Present, Present>) : azurerm.DataAzurermManagedApplicationDefinition.DataAzurermManagedApplicationDefinition =
            let config = azurerm.DataAzurermManagedApplicationDefinition.DataAzurermManagedApplicationDefinitionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermManagedApplicationDefinition.DataAzurermManagedApplicationDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermManagedApplicationDefinition: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermManagedApplicationDefinitionState<_, _>) : azurerm.DataAzurermManagedApplicationDefinition.DataAzurermManagedApplicationDefinition =
            Unchecked.defaultof<azurerm.DataAzurermManagedApplicationDefinition.DataAzurermManagedApplicationDefinition>

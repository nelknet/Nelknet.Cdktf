namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermServicebusNamespaceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermServicebusNamespace.DataAzurermServicebusNamespaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace">azurerm_servicebus_namespace</a>.
    /// </summary>
    type DataAzurermServicebusNamespaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermServicebusNamespaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermServicebusNamespaceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermServicebusNamespaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermServicebusNamespaceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace#name-1">DataAzurermServicebusNamespace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermServicebusNamespaceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermServicebusNamespaceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermServicebusNamespaceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace#resource_group_name-1">DataAzurermServicebusNamespace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermServicebusNamespaceState<'Name, Missing>, value: string) : DataAzurermServicebusNamespaceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermServicebusNamespaceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace#id-1">DataAzurermServicebusNamespace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermServicebusNamespaceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermServicebusNamespaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermServicebusNamespaceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace#timeouts-1">DataAzurermServicebusNamespace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermServicebusNamespaceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermServicebusNamespace.DataAzurermServicebusNamespaceTimeouts) : DataAzurermServicebusNamespaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermServicebusNamespaceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermServicebusNamespaceState<Present, Present>) : azurerm.DataAzurermServicebusNamespace.DataAzurermServicebusNamespace =
            let config = azurerm.DataAzurermServicebusNamespace.DataAzurermServicebusNamespaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermServicebusNamespace.DataAzurermServicebusNamespace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermServicebusNamespace: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermServicebusNamespaceState<_, _>) : azurerm.DataAzurermServicebusNamespace.DataAzurermServicebusNamespace =
            Unchecked.defaultof<azurerm.DataAzurermServicebusNamespace.DataAzurermServicebusNamespace>

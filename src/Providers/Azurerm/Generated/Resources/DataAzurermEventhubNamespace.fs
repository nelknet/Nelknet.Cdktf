namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermEventhubNamespaceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermEventhubNamespace.DataAzurermEventhubNamespaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_namespace">azurerm_eventhub_namespace</a>.
    /// </summary>
    type DataAzurermEventhubNamespaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermEventhubNamespaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventhubNamespaceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermEventhubNamespaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventhubNamespaceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_namespace#name-1">DataAzurermEventhubNamespace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermEventhubNamespaceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermEventhubNamespaceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermEventhubNamespaceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_namespace#resource_group_name-1">DataAzurermEventhubNamespace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermEventhubNamespaceState<'Name, Missing>, value: string) : DataAzurermEventhubNamespaceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermEventhubNamespaceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_namespace#id-1">DataAzurermEventhubNamespace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermEventhubNamespaceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermEventhubNamespaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermEventhubNamespaceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_namespace#timeouts-1">DataAzurermEventhubNamespace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermEventhubNamespaceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermEventhubNamespace.DataAzurermEventhubNamespaceTimeouts) : DataAzurermEventhubNamespaceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermEventhubNamespaceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermEventhubNamespaceState<Present, Present>) : azurerm.DataAzurermEventhubNamespace.DataAzurermEventhubNamespace =
            let config = azurerm.DataAzurermEventhubNamespace.DataAzurermEventhubNamespaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermEventhubNamespace.DataAzurermEventhubNamespace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermEventhubNamespace: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermEventhubNamespaceState<_, _>) : azurerm.DataAzurermEventhubNamespace.DataAzurermEventhubNamespace =
            Unchecked.defaultof<azurerm.DataAzurermEventhubNamespace.DataAzurermEventhubNamespace>

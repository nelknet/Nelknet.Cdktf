namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMssqlManagedInstanceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermMssqlManagedInstance.DataAzurermMssqlManagedInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_managed_instance">azurerm_mssql_managed_instance</a>.
    /// </summary>
    type DataAzurermMssqlManagedInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMssqlManagedInstanceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMssqlManagedInstanceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMssqlManagedInstanceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMssqlManagedInstanceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_managed_instance#name-1">DataAzurermMssqlManagedInstance#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMssqlManagedInstanceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermMssqlManagedInstanceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMssqlManagedInstanceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_managed_instance#resource_group_name-1">DataAzurermMssqlManagedInstance#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermMssqlManagedInstanceState<'Name, Missing>, value: string) : DataAzurermMssqlManagedInstanceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermMssqlManagedInstanceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_managed_instance#id-1">DataAzurermMssqlManagedInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMssqlManagedInstanceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermMssqlManagedInstanceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMssqlManagedInstanceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_managed_instance#timeouts-1">DataAzurermMssqlManagedInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMssqlManagedInstanceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermMssqlManagedInstance.DataAzurermMssqlManagedInstanceTimeouts) : DataAzurermMssqlManagedInstanceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMssqlManagedInstanceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermMssqlManagedInstanceState<Present, Present>) : azurerm.DataAzurermMssqlManagedInstance.DataAzurermMssqlManagedInstance =
            let config = azurerm.DataAzurermMssqlManagedInstance.DataAzurermMssqlManagedInstanceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMssqlManagedInstance.DataAzurermMssqlManagedInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMssqlManagedInstance: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMssqlManagedInstanceState<_, _>) : azurerm.DataAzurermMssqlManagedInstance.DataAzurermMssqlManagedInstance =
            Unchecked.defaultof<azurerm.DataAzurermMssqlManagedInstance.DataAzurermMssqlManagedInstance>

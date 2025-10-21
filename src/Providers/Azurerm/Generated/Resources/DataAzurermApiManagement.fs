namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermApiManagementState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermApiManagement.DataAzurermApiManagementConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management">azurerm_api_management</a>.
    /// </summary>
    type DataAzurermApiManagementBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermApiManagementState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApiManagementState<Missing, Missing>)

        member _.Zero(()) : DataAzurermApiManagementState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApiManagementState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management#name-1">DataAzurermApiManagement#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermApiManagementState<Missing, 'ResourceGroupName>, value: string) : DataAzurermApiManagementState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management#resource_group_name-1">DataAzurermApiManagement#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermApiManagementState<'Name, Missing>, value: string) : DataAzurermApiManagementState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management#id-1">DataAzurermApiManagement#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermApiManagementState<'Name, 'ResourceGroupName>, value: string) : DataAzurermApiManagementState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermApiManagementState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management#tags-1">DataAzurermApiManagement#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAzurermApiManagementState<'Name, 'ResourceGroupName>, value: seq<string * string>) : DataAzurermApiManagementState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAzurermApiManagementState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management#timeouts-1">DataAzurermApiManagement#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermApiManagementState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermApiManagement.DataAzurermApiManagementTimeouts) : DataAzurermApiManagementState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermApiManagementState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermApiManagementState<Present, Present>) : azurerm.DataAzurermApiManagement.DataAzurermApiManagement =
            let config = azurerm.DataAzurermApiManagement.DataAzurermApiManagementConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermApiManagement.DataAzurermApiManagement(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermApiManagement: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermApiManagementState<_, _>) : azurerm.DataAzurermApiManagement.DataAzurermApiManagement =
            Unchecked.defaultof<azurerm.DataAzurermApiManagement.DataAzurermApiManagement>

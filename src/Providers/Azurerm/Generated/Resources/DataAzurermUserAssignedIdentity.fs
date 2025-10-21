namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermUserAssignedIdentityState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermUserAssignedIdentity.DataAzurermUserAssignedIdentityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/user_assigned_identity">azurerm_user_assigned_identity</a>.
    /// </summary>
    type DataAzurermUserAssignedIdentityBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermUserAssignedIdentityState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermUserAssignedIdentityState<Missing, Missing>)

        member _.Zero(()) : DataAzurermUserAssignedIdentityState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermUserAssignedIdentityState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/user_assigned_identity#name-1">DataAzurermUserAssignedIdentity#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermUserAssignedIdentityState<Missing, 'ResourceGroupName>, value: string) : DataAzurermUserAssignedIdentityState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermUserAssignedIdentityState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/user_assigned_identity#resource_group_name-1">DataAzurermUserAssignedIdentity#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermUserAssignedIdentityState<'Name, Missing>, value: string) : DataAzurermUserAssignedIdentityState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermUserAssignedIdentityState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/user_assigned_identity#id-1">DataAzurermUserAssignedIdentity#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermUserAssignedIdentityState<'Name, 'ResourceGroupName>, value: string) : DataAzurermUserAssignedIdentityState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermUserAssignedIdentityState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/user_assigned_identity#timeouts-1">DataAzurermUserAssignedIdentity#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermUserAssignedIdentityState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermUserAssignedIdentity.DataAzurermUserAssignedIdentityTimeouts) : DataAzurermUserAssignedIdentityState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermUserAssignedIdentityState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermUserAssignedIdentityState<Present, Present>) : azurerm.DataAzurermUserAssignedIdentity.DataAzurermUserAssignedIdentity =
            let config = azurerm.DataAzurermUserAssignedIdentity.DataAzurermUserAssignedIdentityConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermUserAssignedIdentity.DataAzurermUserAssignedIdentity(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermUserAssignedIdentity: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermUserAssignedIdentityState<_, _>) : azurerm.DataAzurermUserAssignedIdentity.DataAzurermUserAssignedIdentity =
            Unchecked.defaultof<azurerm.DataAzurermUserAssignedIdentity.DataAzurermUserAssignedIdentity>

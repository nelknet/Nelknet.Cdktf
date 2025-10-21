namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type UserAssignedIdentityState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.UserAssignedIdentity.UserAssignedIdentityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/user_assigned_identity">azurerm_user_assigned_identity</a>.
    /// </summary>
    type UserAssignedIdentityBuilder(logicalId: string) =
        member _.Yield(_: unit) : UserAssignedIdentityState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : UserAssignedIdentityState<Missing, Missing, Missing>)

        member _.Zero(()) : UserAssignedIdentityState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : UserAssignedIdentityState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/user_assigned_identity#location-1">UserAssignedIdentity#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: UserAssignedIdentityState<Missing, 'Name, 'ResourceGroupName>, value: string) : UserAssignedIdentityState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : UserAssignedIdentityState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/user_assigned_identity#name-1">UserAssignedIdentity#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: UserAssignedIdentityState<'Location, Missing, 'ResourceGroupName>, value: string) : UserAssignedIdentityState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : UserAssignedIdentityState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/user_assigned_identity#resource_group_name-1">UserAssignedIdentity#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: UserAssignedIdentityState<'Location, 'Name, Missing>, value: string) : UserAssignedIdentityState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : UserAssignedIdentityState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/user_assigned_identity#id-1">UserAssignedIdentity#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: UserAssignedIdentityState<'Location, 'Name, 'ResourceGroupName>, value: string) : UserAssignedIdentityState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : UserAssignedIdentityState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/user_assigned_identity#tags-1">UserAssignedIdentity#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: UserAssignedIdentityState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : UserAssignedIdentityState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : UserAssignedIdentityState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/user_assigned_identity#timeouts-1">UserAssignedIdentity#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: UserAssignedIdentityState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.UserAssignedIdentity.UserAssignedIdentityTimeouts) : UserAssignedIdentityState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : UserAssignedIdentityState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: UserAssignedIdentityState<Present, Present, Present>) : azurerm.UserAssignedIdentity.UserAssignedIdentity =
            let config = azurerm.UserAssignedIdentity.UserAssignedIdentityConfig()
            for setter in state.assignments do
                setter config
            azurerm.UserAssignedIdentity.UserAssignedIdentity(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.userAssignedIdentity: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: UserAssignedIdentityState<_, _, _>) : azurerm.UserAssignedIdentity.UserAssignedIdentity =
            Unchecked.defaultof<azurerm.UserAssignedIdentity.UserAssignedIdentity>

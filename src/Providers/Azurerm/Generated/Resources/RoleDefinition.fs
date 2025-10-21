namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RoleDefinitionState<'Name, 'Scope> = { assignments: ResizeArray<azurerm.RoleDefinition.RoleDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_definition">azurerm_role_definition</a>.
    /// </summary>
    type RoleDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : RoleDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RoleDefinitionState<Missing, Missing>)

        member _.Zero(()) : RoleDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RoleDefinitionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_definition#name-1">RoleDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RoleDefinitionState<Missing, 'Scope>, value: string) : RoleDefinitionState<Present, 'Scope> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RoleDefinitionState<Present, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_definition#scope-1">RoleDefinition#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: RoleDefinitionState<'Name, Missing>, value: string) : RoleDefinitionState<'Name, Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : RoleDefinitionState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_definition#assignable_scopes-1">RoleDefinition#assignable_scopes</a>.
        /// </summary>
        [<CustomOperation "assignable_scopes">]
        member _.AssignableScopes(state: RoleDefinitionState<'Name, 'Scope>, value: seq<string>) : RoleDefinitionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.AssignableScopes <- (value |> Seq.toArray))
            state : RoleDefinitionState<'Name, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_definition#description-1">RoleDefinition#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: RoleDefinitionState<'Name, 'Scope>, value: string) : RoleDefinitionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : RoleDefinitionState<'Name, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_definition#id-1">RoleDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RoleDefinitionState<'Name, 'Scope>, value: string) : RoleDefinitionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RoleDefinitionState<'Name, 'Scope>

        /// <summary>
        /// permissions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_definition#permissions-1">RoleDefinition#permissions</a> Accepts: azurerm.IResolvable | azurerm.RoleDefinition.RoleDefinitionPermissions[]
        /// </summary>
        [<CustomOperation "permissions">]
        member _.Permissions(state: RoleDefinitionState<'Name, 'Scope>, value: HashiCorp.Cdktf.IResolvable) : RoleDefinitionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.Permissions <- value)
            state : RoleDefinitionState<'Name, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_definition#role_definition_id-1">RoleDefinition#role_definition_id</a>.
        /// </summary>
        [<CustomOperation "role_definition_id">]
        member _.RoleDefinitionId(state: RoleDefinitionState<'Name, 'Scope>, value: string) : RoleDefinitionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.RoleDefinitionId <- value)
            state : RoleDefinitionState<'Name, 'Scope>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_definition#timeouts-1">RoleDefinition#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RoleDefinitionState<'Name, 'Scope>, value: azurerm.RoleDefinition.RoleDefinitionTimeouts) : RoleDefinitionState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RoleDefinitionState<'Name, 'Scope>

        member _.Run(state: RoleDefinitionState<Present, Present>) : azurerm.RoleDefinition.RoleDefinition =
            let config = azurerm.RoleDefinition.RoleDefinitionConfig()
            for setter in state.assignments do
                setter config
            azurerm.RoleDefinition.RoleDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.roleDefinition: missing required arguments. Must call: name, scope.", 9999, IsError = true)>]
        member _.Run(_: RoleDefinitionState<_, _>) : azurerm.RoleDefinition.RoleDefinition =
            Unchecked.defaultof<azurerm.RoleDefinition.RoleDefinition>

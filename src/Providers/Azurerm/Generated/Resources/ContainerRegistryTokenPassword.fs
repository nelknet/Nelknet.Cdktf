namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ContainerRegistryTokenPasswordState<'ContainerRegistryTokenId, 'Password1> = { assignments: ResizeArray<azurerm.ContainerRegistryTokenPassword.ContainerRegistryTokenPasswordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password">azurerm_container_registry_token_password</a>.
    /// </summary>
    type ContainerRegistryTokenPasswordBuilder(logicalId: string) =
        member _.Yield(_: unit) : ContainerRegistryTokenPasswordState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerRegistryTokenPasswordState<Missing, Missing>)

        member _.Zero(()) : ContainerRegistryTokenPasswordState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerRegistryTokenPasswordState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password#container_registry_token_id-1">ContainerRegistryTokenPassword#container_registry_token_id</a>.
        /// </summary>
        [<CustomOperation "container_registry_token_id">]
        member _.ContainerRegistryTokenId(state: ContainerRegistryTokenPasswordState<Missing, 'Password1>, value: string) : ContainerRegistryTokenPasswordState<Present, 'Password1> =
            state.assignments.Add(fun config -> config.ContainerRegistryTokenId <- value)
            ({ assignments = state.assignments } : ContainerRegistryTokenPasswordState<Present, 'Password1>)

        /// <summary>
        /// password1 block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password#password1-1">ContainerRegistryTokenPassword#password1</a>
        /// </summary>
        [<CustomOperation "password1">]
        member _.Password1(state: ContainerRegistryTokenPasswordState<'ContainerRegistryTokenId, Missing>, value: azurerm.ContainerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword1) : ContainerRegistryTokenPasswordState<'ContainerRegistryTokenId, Present> =
            state.assignments.Add(fun config -> config.Password1 <- value)
            ({ assignments = state.assignments } : ContainerRegistryTokenPasswordState<'ContainerRegistryTokenId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password#id-1">ContainerRegistryTokenPassword#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ContainerRegistryTokenPasswordState<'ContainerRegistryTokenId, 'Password1>, value: string) : ContainerRegistryTokenPasswordState<'ContainerRegistryTokenId, 'Password1> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ContainerRegistryTokenPasswordState<'ContainerRegistryTokenId, 'Password1>

        /// <summary>
        /// password2 block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password#password2-1">ContainerRegistryTokenPassword#password2</a>
        /// </summary>
        [<CustomOperation "password2">]
        member _.Password2(state: ContainerRegistryTokenPasswordState<'ContainerRegistryTokenId, 'Password1>, value: azurerm.ContainerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword2) : ContainerRegistryTokenPasswordState<'ContainerRegistryTokenId, 'Password1> =
            state.assignments.Add(fun config -> config.Password2 <- value)
            state : ContainerRegistryTokenPasswordState<'ContainerRegistryTokenId, 'Password1>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password#timeouts-1">ContainerRegistryTokenPassword#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ContainerRegistryTokenPasswordState<'ContainerRegistryTokenId, 'Password1>, value: azurerm.ContainerRegistryTokenPassword.ContainerRegistryTokenPasswordTimeouts) : ContainerRegistryTokenPasswordState<'ContainerRegistryTokenId, 'Password1> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ContainerRegistryTokenPasswordState<'ContainerRegistryTokenId, 'Password1>

        member _.Run(state: ContainerRegistryTokenPasswordState<Present, Present>) : azurerm.ContainerRegistryTokenPassword.ContainerRegistryTokenPassword =
            let config = azurerm.ContainerRegistryTokenPassword.ContainerRegistryTokenPasswordConfig()
            for setter in state.assignments do
                setter config
            azurerm.ContainerRegistryTokenPassword.ContainerRegistryTokenPassword(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.containerRegistryTokenPassword: missing required arguments. Must call: container_registry_token_id, password1.", 9999, IsError = true)>]
        member _.Run(_: ContainerRegistryTokenPasswordState<_, _>) : azurerm.ContainerRegistryTokenPassword.ContainerRegistryTokenPassword =
            Unchecked.defaultof<azurerm.ContainerRegistryTokenPassword.ContainerRegistryTokenPassword>

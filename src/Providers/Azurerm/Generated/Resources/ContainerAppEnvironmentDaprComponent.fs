namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version> = { assignments: ResizeArray<azurerm.ContainerAppEnvironmentDaprComponent.ContainerAppEnvironmentDaprComponentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_dapr_component">azurerm_container_app_environment_dapr_component</a>.
    /// </summary>
    type ContainerAppEnvironmentDaprComponentBuilder(logicalId: string) =
        member _.Yield(_: unit) : ContainerAppEnvironmentDaprComponentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerAppEnvironmentDaprComponentState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ContainerAppEnvironmentDaprComponentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerAppEnvironmentDaprComponentState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// The Dapr Component Type. For example `state.azure.blobstorage`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_dapr_component#component_type-1">ContainerAppEnvironmentDaprComponent#component_type</a>
        /// </summary>
        [<CustomOperation "component_type">]
        member _.ComponentType(state: ContainerAppEnvironmentDaprComponentState<Missing, 'ContainerAppEnvironmentId, 'Name, 'Version>, value: string) : ContainerAppEnvironmentDaprComponentState<Present, 'ContainerAppEnvironmentId, 'Name, 'Version> =
            state.assignments.Add(fun config -> config.ComponentType <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentDaprComponentState<Present, 'ContainerAppEnvironmentId, 'Name, 'Version>)

        /// <summary>
        /// The Container App Managed Environment ID to configure this Dapr component on. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_dapr_component#container_app_environment_id-1">ContainerAppEnvironmentDaprComponent#container_app_environment_id</a>
        /// </summary>
        [<CustomOperation "container_app_environment_id">]
        member _.ContainerAppEnvironmentId(state: ContainerAppEnvironmentDaprComponentState<'ComponentType, Missing, 'Name, 'Version>, value: string) : ContainerAppEnvironmentDaprComponentState<'ComponentType, Present, 'Name, 'Version> =
            state.assignments.Add(fun config -> config.ContainerAppEnvironmentId <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentDaprComponentState<'ComponentType, Present, 'Name, 'Version>)

        /// <summary>
        /// The name for this Dapr Component. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_dapr_component#name-1">ContainerAppEnvironmentDaprComponent#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, Missing, 'Version>, value: string) : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, Present, 'Version> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, Present, 'Version>)

        /// <summary>
        /// The version of the component. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_dapr_component#version-1">ContainerAppEnvironmentDaprComponent#version</a>
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, Missing>, value: string) : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Version <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_dapr_component#id-1">ContainerAppEnvironmentDaprComponent#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version>, value: string) : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version>

        /// <summary>
        /// Should the Dapr sidecar to continue initialisation if the component fails to load. Defaults to `false`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_dapr_component#ignore_errors-1">ContainerAppEnvironmentDaprComponent#ignore_errors</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ignore_errors">]
        member _.IgnoreErrors(state: ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version>, value: bool) : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version> =
            state.assignments.Add(fun config -> config.IgnoreErrors <- value)
            state : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version>

        /// <summary>
        /// Should the Dapr sidecar to continue initialisation if the component fails to load. Defaults to `false`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_dapr_component#ignore_errors-1">ContainerAppEnvironmentDaprComponent#ignore_errors</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ignore_errors">]
        member _.IgnoreErrors(state: ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version>, value: HashiCorp.Cdktf.IResolvable) : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version> =
            state.assignments.Add(fun config -> config.IgnoreErrors <- value)
            state : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version>

        /// <summary>
        /// The component initialisation timeout in ISO8601 format. e.g. `5s`, `2h`, `1m`. Defaults to `5s`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_dapr_component#init_timeout-1">ContainerAppEnvironmentDaprComponent#init_timeout</a>
        /// </summary>
        [<CustomOperation "init_timeout">]
        member _.InitTimeout(state: ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version>, value: string) : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version> =
            state.assignments.Add(fun config -> config.InitTimeout <- value)
            state : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version>

        /// <summary>
        /// metadata block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_dapr_component#metadata-1">ContainerAppEnvironmentDaprComponent#metadata</a> Accepts: azurerm.IResolvable | azurerm.ContainerAppEnvironmentDaprComponent.ContainerAppEnvironmentDaprComponentMetadata[]
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version>, value: HashiCorp.Cdktf.IResolvable) : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version> =
            state.assignments.Add(fun config -> config.Metadata <- value)
            state : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version>

        /// <summary>
        /// A list of scopes to which this component applies. e.g. a Container App's `dapr.app_id` value. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_dapr_component#scopes-1">ContainerAppEnvironmentDaprComponent#scopes</a>
        /// </summary>
        [<CustomOperation "scopes">]
        member _.Scopes(state: ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version>, value: seq<string>) : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version> =
            state.assignments.Add(fun config -> config.Scopes <- (value |> Seq.toArray))
            state : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version>

        /// <summary>
        /// secret block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_dapr_component#secret-1">ContainerAppEnvironmentDaprComponent#secret</a> Accepts: azurerm.IResolvable | azurerm.ContainerAppEnvironmentDaprComponent.ContainerAppEnvironmentDaprComponentSecret[]
        /// </summary>
        [<CustomOperation "secret">]
        member _.Secret(state: ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version>, value: HashiCorp.Cdktf.IResolvable) : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version> =
            state.assignments.Add(fun config -> config.Secret <- value)
            state : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_dapr_component#timeouts-1">ContainerAppEnvironmentDaprComponent#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version>, value: azurerm.ContainerAppEnvironmentDaprComponent.ContainerAppEnvironmentDaprComponentTimeouts) : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ContainerAppEnvironmentDaprComponentState<'ComponentType, 'ContainerAppEnvironmentId, 'Name, 'Version>

        member _.Run(state: ContainerAppEnvironmentDaprComponentState<Present, Present, Present, Present>) : azurerm.ContainerAppEnvironmentDaprComponent.ContainerAppEnvironmentDaprComponent =
            let config = azurerm.ContainerAppEnvironmentDaprComponent.ContainerAppEnvironmentDaprComponentConfig()
            for setter in state.assignments do
                setter config
            azurerm.ContainerAppEnvironmentDaprComponent.ContainerAppEnvironmentDaprComponent(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.containerAppEnvironmentDaprComponent: missing required arguments. Must call: component_type, container_app_environment_id, name, version.", 9999, IsError = true)>]
        member _.Run(_: ContainerAppEnvironmentDaprComponentState<_, _, _, _>) : azurerm.ContainerAppEnvironmentDaprComponent.ContainerAppEnvironmentDaprComponent =
            Unchecked.defaultof<azurerm.ContainerAppEnvironmentDaprComponent.ContainerAppEnvironmentDaprComponent>

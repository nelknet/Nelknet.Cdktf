namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri> = { assignments: ResizeArray<azurerm.ContainerRegistryWebhook.ContainerRegistryWebhookConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_webhook">azurerm_container_registry_webhook</a>.
    /// </summary>
    type ContainerRegistryWebhookBuilder(logicalId: string) =
        member _.Yield(_: unit) : ContainerRegistryWebhookState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerRegistryWebhookState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ContainerRegistryWebhookState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerRegistryWebhookState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_webhook#actions-1">ContainerRegistryWebhook#actions</a>.
        /// </summary>
        [<CustomOperation "actions">]
        member _.Actions(state: ContainerRegistryWebhookState<Missing, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri>, value: seq<string>) : ContainerRegistryWebhookState<Present, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri> =
            state.assignments.Add(fun config -> config.Actions <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ContainerRegistryWebhookState<Present, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_webhook#location-1">ContainerRegistryWebhook#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ContainerRegistryWebhookState<'Actions, Missing, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri>, value: string) : ContainerRegistryWebhookState<'Actions, Present, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ContainerRegistryWebhookState<'Actions, Present, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_webhook#name-1">ContainerRegistryWebhook#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ContainerRegistryWebhookState<'Actions, 'Location, Missing, 'RegistryName, 'ResourceGroupName, 'ServiceUri>, value: string) : ContainerRegistryWebhookState<'Actions, 'Location, Present, 'RegistryName, 'ResourceGroupName, 'ServiceUri> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ContainerRegistryWebhookState<'Actions, 'Location, Present, 'RegistryName, 'ResourceGroupName, 'ServiceUri>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_webhook#registry_name-1">ContainerRegistryWebhook#registry_name</a>.
        /// </summary>
        [<CustomOperation "registry_name">]
        member _.RegistryName(state: ContainerRegistryWebhookState<'Actions, 'Location, 'Name, Missing, 'ResourceGroupName, 'ServiceUri>, value: string) : ContainerRegistryWebhookState<'Actions, 'Location, 'Name, Present, 'ResourceGroupName, 'ServiceUri> =
            state.assignments.Add(fun config -> config.RegistryName <- value)
            ({ assignments = state.assignments } : ContainerRegistryWebhookState<'Actions, 'Location, 'Name, Present, 'ResourceGroupName, 'ServiceUri>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_webhook#resource_group_name-1">ContainerRegistryWebhook#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, Missing, 'ServiceUri>, value: string) : ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, Present, 'ServiceUri> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, Present, 'ServiceUri>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_webhook#service_uri-1">ContainerRegistryWebhook#service_uri</a>.
        /// </summary>
        [<CustomOperation "service_uri">]
        member _.ServiceUri(state: ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, Missing>, value: string) : ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ServiceUri <- value)
            ({ assignments = state.assignments } : ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_webhook#custom_headers-1">ContainerRegistryWebhook#custom_headers</a>.
        /// </summary>
        [<CustomOperation "custom_headers">]
        member _.CustomHeaders(state: ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri>, value: seq<string * string>) : ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri> =
            state.assignments.Add(fun config -> config.CustomHeaders <- dict value)
            state : ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_webhook#id-1">ContainerRegistryWebhook#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri>, value: string) : ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_webhook#scope-1">ContainerRegistryWebhook#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri>, value: string) : ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri> =
            state.assignments.Add(fun config -> config.Scope <- value)
            state : ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_webhook#status-1">ContainerRegistryWebhook#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri>, value: string) : ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_webhook#tags-1">ContainerRegistryWebhook#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri>, value: seq<string * string>) : ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_webhook#timeouts-1">ContainerRegistryWebhook#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri>, value: azurerm.ContainerRegistryWebhook.ContainerRegistryWebhookTimeouts) : ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ContainerRegistryWebhookState<'Actions, 'Location, 'Name, 'RegistryName, 'ResourceGroupName, 'ServiceUri>

        member _.Run(state: ContainerRegistryWebhookState<Present, Present, Present, Present, Present, Present>) : azurerm.ContainerRegistryWebhook.ContainerRegistryWebhook =
            let config = azurerm.ContainerRegistryWebhook.ContainerRegistryWebhookConfig()
            for setter in state.assignments do
                setter config
            azurerm.ContainerRegistryWebhook.ContainerRegistryWebhook(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.containerRegistryWebhook: missing required arguments. Must call: actions, location, name, registry_name, resource_group_name, service_uri.", 9999, IsError = true)>]
        member _.Run(_: ContainerRegistryWebhookState<_, _, _, _, _, _>) : azurerm.ContainerRegistryWebhook.ContainerRegistryWebhook =
            Unchecked.defaultof<azurerm.ContainerRegistryWebhook.ContainerRegistryWebhook>

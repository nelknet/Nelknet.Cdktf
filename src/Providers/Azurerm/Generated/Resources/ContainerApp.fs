namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template> = { assignments: ResizeArray<azurerm.ContainerApp.ContainerAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app">azurerm_container_app</a>.
    /// </summary>
    type ContainerAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : ContainerAppState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerAppState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ContainerAppState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerAppState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// The ID of the Container App Environment to host this Container App. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#container_app_environment_id-1">ContainerApp#container_app_environment_id</a>
        /// </summary>
        [<CustomOperation "container_app_environment_id">]
        member _.ContainerAppEnvironmentId(state: ContainerAppState<Missing, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>, value: string) : ContainerAppState<Present, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template> =
            state.assignments.Add(fun config -> config.ContainerAppEnvironmentId <- value)
            ({ assignments = state.assignments } : ContainerAppState<Present, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>)

        /// <summary>
        /// The name for this Container App. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#name-1">ContainerApp#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ContainerAppState<'ContainerAppEnvironmentId, Missing, 'ResourceGroupName, 'RevisionMode, 'Template>, value: string) : ContainerAppState<'ContainerAppEnvironmentId, Present, 'ResourceGroupName, 'RevisionMode, 'Template> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ContainerAppState<'ContainerAppEnvironmentId, Present, 'ResourceGroupName, 'RevisionMode, 'Template>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#resource_group_name-1">ContainerApp#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ContainerAppState<'ContainerAppEnvironmentId, 'Name, Missing, 'RevisionMode, 'Template>, value: string) : ContainerAppState<'ContainerAppEnvironmentId, 'Name, Present, 'RevisionMode, 'Template> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ContainerAppState<'ContainerAppEnvironmentId, 'Name, Present, 'RevisionMode, 'Template>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#revision_mode-1">ContainerApp#revision_mode</a>.
        /// </summary>
        [<CustomOperation "revision_mode">]
        member _.RevisionMode(state: ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, Missing, 'Template>, value: string) : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, Present, 'Template> =
            state.assignments.Add(fun config -> config.RevisionMode <- value)
            ({ assignments = state.assignments } : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, Present, 'Template>)

        /// <summary>
        /// template block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#template-1">ContainerApp#template</a>
        /// </summary>
        [<CustomOperation "template">]
        member _.Template(state: ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, Missing>, value: azurerm.ContainerApp.ContainerAppTemplate) : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, Present> =
            state.assignments.Add(fun config -> config.Template <- value)
            ({ assignments = state.assignments } : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, Present>)

        /// <summary>
        /// dapr block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#dapr-1">ContainerApp#dapr</a>
        /// </summary>
        [<CustomOperation "dapr">]
        member _.Dapr(state: ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>, value: azurerm.ContainerApp.ContainerAppDapr) : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template> =
            state.assignments.Add(fun config -> config.Dapr <- value)
            state : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#id-1">ContainerApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>, value: string) : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#identity-1">ContainerApp#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>, value: azurerm.ContainerApp.ContainerAppIdentity) : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>

        /// <summary>
        /// ingress block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#ingress-1">ContainerApp#ingress</a>
        /// </summary>
        [<CustomOperation "ingress">]
        member _.Ingress(state: ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>, value: azurerm.ContainerApp.ContainerAppIngress) : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template> =
            state.assignments.Add(fun config -> config.Ingress <- value)
            state : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>

        /// <summary>
        /// registry block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#registry-1">ContainerApp#registry</a> Accepts: azurerm.IResolvable | azurerm.ContainerApp.ContainerAppRegistry[]
        /// </summary>
        [<CustomOperation "registry">]
        member _.Registry(state: ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>, value: HashiCorp.Cdktf.IResolvable) : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template> =
            state.assignments.Add(fun config -> config.Registry <- value)
            state : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>

        /// <summary>
        /// secret block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#secret-1">ContainerApp#secret</a> Accepts: azurerm.IResolvable | azurerm.ContainerApp.ContainerAppSecret[]
        /// </summary>
        [<CustomOperation "secret">]
        member _.Secret(state: ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>, value: HashiCorp.Cdktf.IResolvable) : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template> =
            state.assignments.Add(fun config -> config.Secret <- value)
            state : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#tags-1">ContainerApp#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>, value: seq<string * string>) : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#timeouts-1">ContainerApp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>, value: azurerm.ContainerApp.ContainerAppTimeouts) : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#workload_profile_name-1">ContainerApp#workload_profile_name</a>.
        /// </summary>
        [<CustomOperation "workload_profile_name">]
        member _.WorkloadProfileName(state: ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>, value: string) : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template> =
            state.assignments.Add(fun config -> config.WorkloadProfileName <- value)
            state : ContainerAppState<'ContainerAppEnvironmentId, 'Name, 'ResourceGroupName, 'RevisionMode, 'Template>

        member _.Run(state: ContainerAppState<Present, Present, Present, Present, Present>) : azurerm.ContainerApp.ContainerApp =
            let config = azurerm.ContainerApp.ContainerAppConfig()
            for setter in state.assignments do
                setter config
            azurerm.ContainerApp.ContainerApp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.containerApp: missing required arguments. Must call: container_app_environment_id, name, resource_group_name, revision_mode, template.", 9999, IsError = true)>]
        member _.Run(_: ContainerAppState<_, _, _, _, _>) : azurerm.ContainerApp.ContainerApp =
            Unchecked.defaultof<azurerm.ContainerApp.ContainerApp>

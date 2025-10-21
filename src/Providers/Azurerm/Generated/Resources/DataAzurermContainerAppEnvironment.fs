namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermContainerAppEnvironmentState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermContainerAppEnvironment.DataAzurermContainerAppEnvironmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app_environment">azurerm_container_app_environment</a>.
    /// </summary>
    type DataAzurermContainerAppEnvironmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermContainerAppEnvironmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermContainerAppEnvironmentState<Missing, Missing>)

        member _.Zero(()) : DataAzurermContainerAppEnvironmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermContainerAppEnvironmentState<Missing, Missing>)

        /// <summary>
        /// The name of the Container Apps Managed Environment. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app_environment#name-1">DataAzurermContainerAppEnvironment#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermContainerAppEnvironmentState<Missing, 'ResourceGroupName>, value: string) : DataAzurermContainerAppEnvironmentState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermContainerAppEnvironmentState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app_environment#resource_group_name-1">DataAzurermContainerAppEnvironment#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermContainerAppEnvironmentState<'Name, Missing>, value: string) : DataAzurermContainerAppEnvironmentState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermContainerAppEnvironmentState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app_environment#id-1">DataAzurermContainerAppEnvironment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermContainerAppEnvironmentState<'Name, 'ResourceGroupName>, value: string) : DataAzurermContainerAppEnvironmentState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermContainerAppEnvironmentState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app_environment#timeouts-1">DataAzurermContainerAppEnvironment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermContainerAppEnvironmentState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermContainerAppEnvironment.DataAzurermContainerAppEnvironmentTimeouts) : DataAzurermContainerAppEnvironmentState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermContainerAppEnvironmentState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermContainerAppEnvironmentState<Present, Present>) : azurerm.DataAzurermContainerAppEnvironment.DataAzurermContainerAppEnvironment =
            let config = azurerm.DataAzurermContainerAppEnvironment.DataAzurermContainerAppEnvironmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermContainerAppEnvironment.DataAzurermContainerAppEnvironment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermContainerAppEnvironment: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermContainerAppEnvironmentState<_, _>) : azurerm.DataAzurermContainerAppEnvironment.DataAzurermContainerAppEnvironment =
            Unchecked.defaultof<azurerm.DataAzurermContainerAppEnvironment.DataAzurermContainerAppEnvironment>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPrivateLinkServiceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermPrivateLinkService.DataAzurermPrivateLinkServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_link_service">azurerm_private_link_service</a>.
    /// </summary>
    type DataAzurermPrivateLinkServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPrivateLinkServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateLinkServiceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermPrivateLinkServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateLinkServiceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_link_service#name-1">DataAzurermPrivateLinkService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPrivateLinkServiceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermPrivateLinkServiceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateLinkServiceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_link_service#resource_group_name-1">DataAzurermPrivateLinkService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPrivateLinkServiceState<'Name, Missing>, value: string) : DataAzurermPrivateLinkServiceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateLinkServiceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_link_service#id-1">DataAzurermPrivateLinkService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPrivateLinkServiceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermPrivateLinkServiceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPrivateLinkServiceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_link_service#timeouts-1">DataAzurermPrivateLinkService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPrivateLinkServiceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermPrivateLinkService.DataAzurermPrivateLinkServiceTimeouts) : DataAzurermPrivateLinkServiceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPrivateLinkServiceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermPrivateLinkServiceState<Present, Present>) : azurerm.DataAzurermPrivateLinkService.DataAzurermPrivateLinkService =
            let config = azurerm.DataAzurermPrivateLinkService.DataAzurermPrivateLinkServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPrivateLinkService.DataAzurermPrivateLinkService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPrivateLinkService: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPrivateLinkServiceState<_, _>) : azurerm.DataAzurermPrivateLinkService.DataAzurermPrivateLinkService =
            Unchecked.defaultof<azurerm.DataAzurermPrivateLinkService.DataAzurermPrivateLinkService>

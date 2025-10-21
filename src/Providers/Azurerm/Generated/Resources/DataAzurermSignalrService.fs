namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSignalrServiceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermSignalrService.DataAzurermSignalrServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/signalr_service">azurerm_signalr_service</a>.
    /// </summary>
    type DataAzurermSignalrServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSignalrServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSignalrServiceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermSignalrServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSignalrServiceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/signalr_service#name-1">DataAzurermSignalrService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermSignalrServiceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermSignalrServiceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermSignalrServiceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/signalr_service#resource_group_name-1">DataAzurermSignalrService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermSignalrServiceState<'Name, Missing>, value: string) : DataAzurermSignalrServiceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermSignalrServiceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/signalr_service#id-1">DataAzurermSignalrService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSignalrServiceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermSignalrServiceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSignalrServiceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/signalr_service#timeouts-1">DataAzurermSignalrService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSignalrServiceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermSignalrService.DataAzurermSignalrServiceTimeouts) : DataAzurermSignalrServiceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSignalrServiceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermSignalrServiceState<Present, Present>) : azurerm.DataAzurermSignalrService.DataAzurermSignalrService =
            let config = azurerm.DataAzurermSignalrService.DataAzurermSignalrServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSignalrService.DataAzurermSignalrService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSignalrService: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSignalrServiceState<_, _>) : azurerm.DataAzurermSignalrService.DataAzurermSignalrService =
            Unchecked.defaultof<azurerm.DataAzurermSignalrService.DataAzurermSignalrService>

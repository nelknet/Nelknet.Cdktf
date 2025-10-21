namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermHealthcareMedtechServiceState<'Name, 'WorkspaceId> = { assignments: ResizeArray<azurerm.DataAzurermHealthcareMedtechService.DataAzurermHealthcareMedtechServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_medtech_service">azurerm_healthcare_medtech_service</a>.
    /// </summary>
    type DataAzurermHealthcareMedtechServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermHealthcareMedtechServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermHealthcareMedtechServiceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermHealthcareMedtechServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermHealthcareMedtechServiceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_medtech_service#name-1">DataAzurermHealthcareMedtechService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermHealthcareMedtechServiceState<Missing, 'WorkspaceId>, value: string) : DataAzurermHealthcareMedtechServiceState<Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermHealthcareMedtechServiceState<Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_medtech_service#workspace_id-1">DataAzurermHealthcareMedtechService#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: DataAzurermHealthcareMedtechServiceState<'Name, Missing>, value: string) : DataAzurermHealthcareMedtechServiceState<'Name, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : DataAzurermHealthcareMedtechServiceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_medtech_service#id-1">DataAzurermHealthcareMedtechService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermHealthcareMedtechServiceState<'Name, 'WorkspaceId>, value: string) : DataAzurermHealthcareMedtechServiceState<'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermHealthcareMedtechServiceState<'Name, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_medtech_service#timeouts-1">DataAzurermHealthcareMedtechService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermHealthcareMedtechServiceState<'Name, 'WorkspaceId>, value: azurerm.DataAzurermHealthcareMedtechService.DataAzurermHealthcareMedtechServiceTimeouts) : DataAzurermHealthcareMedtechServiceState<'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermHealthcareMedtechServiceState<'Name, 'WorkspaceId>

        member _.Run(state: DataAzurermHealthcareMedtechServiceState<Present, Present>) : azurerm.DataAzurermHealthcareMedtechService.DataAzurermHealthcareMedtechService =
            let config = azurerm.DataAzurermHealthcareMedtechService.DataAzurermHealthcareMedtechServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermHealthcareMedtechService.DataAzurermHealthcareMedtechService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermHealthcareMedtechService: missing required arguments. Must call: name, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermHealthcareMedtechServiceState<_, _>) : azurerm.DataAzurermHealthcareMedtechService.DataAzurermHealthcareMedtechService =
            Unchecked.defaultof<azurerm.DataAzurermHealthcareMedtechService.DataAzurermHealthcareMedtechService>

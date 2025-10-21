namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermHealthcareDicomServiceState<'Name, 'WorkspaceId> = { assignments: ResizeArray<azurerm.DataAzurermHealthcareDicomService.DataAzurermHealthcareDicomServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_dicom_service">azurerm_healthcare_dicom_service</a>.
    /// </summary>
    type DataAzurermHealthcareDicomServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermHealthcareDicomServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermHealthcareDicomServiceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermHealthcareDicomServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermHealthcareDicomServiceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_dicom_service#name-1">DataAzurermHealthcareDicomService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermHealthcareDicomServiceState<Missing, 'WorkspaceId>, value: string) : DataAzurermHealthcareDicomServiceState<Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermHealthcareDicomServiceState<Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_dicom_service#workspace_id-1">DataAzurermHealthcareDicomService#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: DataAzurermHealthcareDicomServiceState<'Name, Missing>, value: string) : DataAzurermHealthcareDicomServiceState<'Name, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : DataAzurermHealthcareDicomServiceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_dicom_service#id-1">DataAzurermHealthcareDicomService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermHealthcareDicomServiceState<'Name, 'WorkspaceId>, value: string) : DataAzurermHealthcareDicomServiceState<'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermHealthcareDicomServiceState<'Name, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_dicom_service#timeouts-1">DataAzurermHealthcareDicomService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermHealthcareDicomServiceState<'Name, 'WorkspaceId>, value: azurerm.DataAzurermHealthcareDicomService.DataAzurermHealthcareDicomServiceTimeouts) : DataAzurermHealthcareDicomServiceState<'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermHealthcareDicomServiceState<'Name, 'WorkspaceId>

        member _.Run(state: DataAzurermHealthcareDicomServiceState<Present, Present>) : azurerm.DataAzurermHealthcareDicomService.DataAzurermHealthcareDicomService =
            let config = azurerm.DataAzurermHealthcareDicomService.DataAzurermHealthcareDicomServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermHealthcareDicomService.DataAzurermHealthcareDicomService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermHealthcareDicomService: missing required arguments. Must call: name, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermHealthcareDicomServiceState<_, _>) : azurerm.DataAzurermHealthcareDicomService.DataAzurermHealthcareDicomService =
            Unchecked.defaultof<azurerm.DataAzurermHealthcareDicomService.DataAzurermHealthcareDicomService>

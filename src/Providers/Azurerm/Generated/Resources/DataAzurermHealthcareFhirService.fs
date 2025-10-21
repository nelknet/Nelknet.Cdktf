namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermHealthcareFhirServiceState<'Name, 'WorkspaceId> = { assignments: ResizeArray<azurerm.DataAzurermHealthcareFhirService.DataAzurermHealthcareFhirServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_fhir_service">azurerm_healthcare_fhir_service</a>.
    /// </summary>
    type DataAzurermHealthcareFhirServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermHealthcareFhirServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermHealthcareFhirServiceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermHealthcareFhirServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermHealthcareFhirServiceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_fhir_service#name-1">DataAzurermHealthcareFhirService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermHealthcareFhirServiceState<Missing, 'WorkspaceId>, value: string) : DataAzurermHealthcareFhirServiceState<Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermHealthcareFhirServiceState<Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_fhir_service#workspace_id-1">DataAzurermHealthcareFhirService#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: DataAzurermHealthcareFhirServiceState<'Name, Missing>, value: string) : DataAzurermHealthcareFhirServiceState<'Name, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : DataAzurermHealthcareFhirServiceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_fhir_service#id-1">DataAzurermHealthcareFhirService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermHealthcareFhirServiceState<'Name, 'WorkspaceId>, value: string) : DataAzurermHealthcareFhirServiceState<'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermHealthcareFhirServiceState<'Name, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_fhir_service#tags-1">DataAzurermHealthcareFhirService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAzurermHealthcareFhirServiceState<'Name, 'WorkspaceId>, value: seq<string * string>) : DataAzurermHealthcareFhirServiceState<'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAzurermHealthcareFhirServiceState<'Name, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_fhir_service#timeouts-1">DataAzurermHealthcareFhirService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermHealthcareFhirServiceState<'Name, 'WorkspaceId>, value: azurerm.DataAzurermHealthcareFhirService.DataAzurermHealthcareFhirServiceTimeouts) : DataAzurermHealthcareFhirServiceState<'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermHealthcareFhirServiceState<'Name, 'WorkspaceId>

        member _.Run(state: DataAzurermHealthcareFhirServiceState<Present, Present>) : azurerm.DataAzurermHealthcareFhirService.DataAzurermHealthcareFhirService =
            let config = azurerm.DataAzurermHealthcareFhirService.DataAzurermHealthcareFhirServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermHealthcareFhirService.DataAzurermHealthcareFhirService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermHealthcareFhirService: missing required arguments. Must call: name, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermHealthcareFhirServiceState<_, _>) : azurerm.DataAzurermHealthcareFhirService.DataAzurermHealthcareFhirService =
            Unchecked.defaultof<azurerm.DataAzurermHealthcareFhirService.DataAzurermHealthcareFhirService>

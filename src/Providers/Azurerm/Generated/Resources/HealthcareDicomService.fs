namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type HealthcareDicomServiceState<'Location, 'Name, 'WorkspaceId> = { assignments: ResizeArray<azurerm.HealthcareDicomService.HealthcareDicomServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_dicom_service">azurerm_healthcare_dicom_service</a>.
    /// </summary>
    type HealthcareDicomServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : HealthcareDicomServiceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HealthcareDicomServiceState<Missing, Missing, Missing>)

        member _.Zero(()) : HealthcareDicomServiceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HealthcareDicomServiceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_dicom_service#location-1">HealthcareDicomService#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: HealthcareDicomServiceState<Missing, 'Name, 'WorkspaceId>, value: string) : HealthcareDicomServiceState<Present, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : HealthcareDicomServiceState<Present, 'Name, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_dicom_service#name-1">HealthcareDicomService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: HealthcareDicomServiceState<'Location, Missing, 'WorkspaceId>, value: string) : HealthcareDicomServiceState<'Location, Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : HealthcareDicomServiceState<'Location, Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_dicom_service#workspace_id-1">HealthcareDicomService#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: HealthcareDicomServiceState<'Location, 'Name, Missing>, value: string) : HealthcareDicomServiceState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : HealthcareDicomServiceState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_dicom_service#id-1">HealthcareDicomService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: HealthcareDicomServiceState<'Location, 'Name, 'WorkspaceId>, value: string) : HealthcareDicomServiceState<'Location, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : HealthcareDicomServiceState<'Location, 'Name, 'WorkspaceId>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_dicom_service#identity-1">HealthcareDicomService#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: HealthcareDicomServiceState<'Location, 'Name, 'WorkspaceId>, value: azurerm.HealthcareDicomService.HealthcareDicomServiceIdentity) : HealthcareDicomServiceState<'Location, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : HealthcareDicomServiceState<'Location, 'Name, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_dicom_service#public_network_access_enabled-1">HealthcareDicomService#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: HealthcareDicomServiceState<'Location, 'Name, 'WorkspaceId>, value: bool) : HealthcareDicomServiceState<'Location, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : HealthcareDicomServiceState<'Location, 'Name, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_dicom_service#public_network_access_enabled-1">HealthcareDicomService#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: HealthcareDicomServiceState<'Location, 'Name, 'WorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : HealthcareDicomServiceState<'Location, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : HealthcareDicomServiceState<'Location, 'Name, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_dicom_service#tags-1">HealthcareDicomService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: HealthcareDicomServiceState<'Location, 'Name, 'WorkspaceId>, value: seq<string * string>) : HealthcareDicomServiceState<'Location, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : HealthcareDicomServiceState<'Location, 'Name, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_dicom_service#timeouts-1">HealthcareDicomService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: HealthcareDicomServiceState<'Location, 'Name, 'WorkspaceId>, value: azurerm.HealthcareDicomService.HealthcareDicomServiceTimeouts) : HealthcareDicomServiceState<'Location, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : HealthcareDicomServiceState<'Location, 'Name, 'WorkspaceId>

        member _.Run(state: HealthcareDicomServiceState<Present, Present, Present>) : azurerm.HealthcareDicomService.HealthcareDicomService =
            let config = azurerm.HealthcareDicomService.HealthcareDicomServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.HealthcareDicomService.HealthcareDicomService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.healthcareDicomService: missing required arguments. Must call: location, name, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: HealthcareDicomServiceState<_, _, _>) : azurerm.HealthcareDicomService.HealthcareDicomService =
            Unchecked.defaultof<azurerm.HealthcareDicomService.HealthcareDicomService>

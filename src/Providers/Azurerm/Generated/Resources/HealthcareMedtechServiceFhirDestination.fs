namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, 'DestinationFhirServiceId, 'DestinationIdentityResolutionType, 'Location, 'MedtechServiceId, 'Name> = { assignments: ResizeArray<azurerm.HealthcareMedtechServiceFhirDestination.HealthcareMedtechServiceFhirDestinationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service_fhir_destination">azurerm_healthcare_medtech_service_fhir_destination</a>.
    /// </summary>
    type HealthcareMedtechServiceFhirDestinationBuilder(logicalId: string) =
        member _.Yield(_: unit) : HealthcareMedtechServiceFhirDestinationState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HealthcareMedtechServiceFhirDestinationState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : HealthcareMedtechServiceFhirDestinationState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HealthcareMedtechServiceFhirDestinationState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service_fhir_destination#destination_fhir_mapping_json-1">HealthcareMedtechServiceFhirDestination#destination_fhir_mapping_json</a>.
        /// </summary>
        [<CustomOperation "destination_fhir_mapping_json">]
        member _.DestinationFhirMappingJson(state: HealthcareMedtechServiceFhirDestinationState<Missing, 'DestinationFhirServiceId, 'DestinationIdentityResolutionType, 'Location, 'MedtechServiceId, 'Name>, value: string) : HealthcareMedtechServiceFhirDestinationState<Present, 'DestinationFhirServiceId, 'DestinationIdentityResolutionType, 'Location, 'MedtechServiceId, 'Name> =
            state.assignments.Add(fun config -> config.DestinationFhirMappingJson <- value)
            ({ assignments = state.assignments } : HealthcareMedtechServiceFhirDestinationState<Present, 'DestinationFhirServiceId, 'DestinationIdentityResolutionType, 'Location, 'MedtechServiceId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service_fhir_destination#destination_fhir_service_id-1">HealthcareMedtechServiceFhirDestination#destination_fhir_service_id</a>.
        /// </summary>
        [<CustomOperation "destination_fhir_service_id">]
        member _.DestinationFhirServiceId(state: HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, Missing, 'DestinationIdentityResolutionType, 'Location, 'MedtechServiceId, 'Name>, value: string) : HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, Present, 'DestinationIdentityResolutionType, 'Location, 'MedtechServiceId, 'Name> =
            state.assignments.Add(fun config -> config.DestinationFhirServiceId <- value)
            ({ assignments = state.assignments } : HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, Present, 'DestinationIdentityResolutionType, 'Location, 'MedtechServiceId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service_fhir_destination#destination_identity_resolution_type-1">HealthcareMedtechServiceFhirDestination#destination_identity_resolution_type</a>.
        /// </summary>
        [<CustomOperation "destination_identity_resolution_type">]
        member _.DestinationIdentityResolutionType(state: HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, 'DestinationFhirServiceId, Missing, 'Location, 'MedtechServiceId, 'Name>, value: string) : HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, 'DestinationFhirServiceId, Present, 'Location, 'MedtechServiceId, 'Name> =
            state.assignments.Add(fun config -> config.DestinationIdentityResolutionType <- value)
            ({ assignments = state.assignments } : HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, 'DestinationFhirServiceId, Present, 'Location, 'MedtechServiceId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service_fhir_destination#location-1">HealthcareMedtechServiceFhirDestination#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, 'DestinationFhirServiceId, 'DestinationIdentityResolutionType, Missing, 'MedtechServiceId, 'Name>, value: string) : HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, 'DestinationFhirServiceId, 'DestinationIdentityResolutionType, Present, 'MedtechServiceId, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, 'DestinationFhirServiceId, 'DestinationIdentityResolutionType, Present, 'MedtechServiceId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service_fhir_destination#medtech_service_id-1">HealthcareMedtechServiceFhirDestination#medtech_service_id</a>.
        /// </summary>
        [<CustomOperation "medtech_service_id">]
        member _.MedtechServiceId(state: HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, 'DestinationFhirServiceId, 'DestinationIdentityResolutionType, 'Location, Missing, 'Name>, value: string) : HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, 'DestinationFhirServiceId, 'DestinationIdentityResolutionType, 'Location, Present, 'Name> =
            state.assignments.Add(fun config -> config.MedtechServiceId <- value)
            ({ assignments = state.assignments } : HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, 'DestinationFhirServiceId, 'DestinationIdentityResolutionType, 'Location, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service_fhir_destination#name-1">HealthcareMedtechServiceFhirDestination#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, 'DestinationFhirServiceId, 'DestinationIdentityResolutionType, 'Location, 'MedtechServiceId, Missing>, value: string) : HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, 'DestinationFhirServiceId, 'DestinationIdentityResolutionType, 'Location, 'MedtechServiceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, 'DestinationFhirServiceId, 'DestinationIdentityResolutionType, 'Location, 'MedtechServiceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service_fhir_destination#id-1">HealthcareMedtechServiceFhirDestination#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, 'DestinationFhirServiceId, 'DestinationIdentityResolutionType, 'Location, 'MedtechServiceId, 'Name>, value: string) : HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, 'DestinationFhirServiceId, 'DestinationIdentityResolutionType, 'Location, 'MedtechServiceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, 'DestinationFhirServiceId, 'DestinationIdentityResolutionType, 'Location, 'MedtechServiceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service_fhir_destination#timeouts-1">HealthcareMedtechServiceFhirDestination#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, 'DestinationFhirServiceId, 'DestinationIdentityResolutionType, 'Location, 'MedtechServiceId, 'Name>, value: azurerm.HealthcareMedtechServiceFhirDestination.HealthcareMedtechServiceFhirDestinationTimeouts) : HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, 'DestinationFhirServiceId, 'DestinationIdentityResolutionType, 'Location, 'MedtechServiceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : HealthcareMedtechServiceFhirDestinationState<'DestinationFhirMappingJson, 'DestinationFhirServiceId, 'DestinationIdentityResolutionType, 'Location, 'MedtechServiceId, 'Name>

        member _.Run(state: HealthcareMedtechServiceFhirDestinationState<Present, Present, Present, Present, Present, Present>) : azurerm.HealthcareMedtechServiceFhirDestination.HealthcareMedtechServiceFhirDestination =
            let config = azurerm.HealthcareMedtechServiceFhirDestination.HealthcareMedtechServiceFhirDestinationConfig()
            for setter in state.assignments do
                setter config
            azurerm.HealthcareMedtechServiceFhirDestination.HealthcareMedtechServiceFhirDestination(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.healthcareMedtechServiceFhirDestination: missing required arguments. Must call: destination_fhir_mapping_json, destination_fhir_service_id, destination_identity_resolution_type, location, medtech_service_id, name.", 9999, IsError = true)>]
        member _.Run(_: HealthcareMedtechServiceFhirDestinationState<_, _, _, _, _, _>) : azurerm.HealthcareMedtechServiceFhirDestination.HealthcareMedtechServiceFhirDestination =
            Unchecked.defaultof<azurerm.HealthcareMedtechServiceFhirDestination.HealthcareMedtechServiceFhirDestination>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId> = { assignments: ResizeArray<azurerm.HealthcareFhirService.HealthcareFhirServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service">azurerm_healthcare_fhir_service</a>.
    /// </summary>
    type HealthcareFhirServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : HealthcareFhirServiceState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HealthcareFhirServiceState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : HealthcareFhirServiceState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HealthcareFhirServiceState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// authentication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#authentication-1">HealthcareFhirService#authentication</a>
        /// </summary>
        [<CustomOperation "authentication">]
        member _.Authentication(state: HealthcareFhirServiceState<Missing, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>, value: azurerm.HealthcareFhirService.HealthcareFhirServiceAuthentication) : HealthcareFhirServiceState<Present, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Authentication <- value)
            ({ assignments = state.assignments } : HealthcareFhirServiceState<Present, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#location-1">HealthcareFhirService#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: HealthcareFhirServiceState<'Authentication, Missing, 'Name, 'ResourceGroupName, 'WorkspaceId>, value: string) : HealthcareFhirServiceState<'Authentication, Present, 'Name, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : HealthcareFhirServiceState<'Authentication, Present, 'Name, 'ResourceGroupName, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#name-1">HealthcareFhirService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: HealthcareFhirServiceState<'Authentication, 'Location, Missing, 'ResourceGroupName, 'WorkspaceId>, value: string) : HealthcareFhirServiceState<'Authentication, 'Location, Present, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : HealthcareFhirServiceState<'Authentication, 'Location, Present, 'ResourceGroupName, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#resource_group_name-1">HealthcareFhirService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: HealthcareFhirServiceState<'Authentication, 'Location, 'Name, Missing, 'WorkspaceId>, value: string) : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#workspace_id-1">HealthcareFhirService#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#access_policy_object_ids-1">HealthcareFhirService#access_policy_object_ids</a>.
        /// </summary>
        [<CustomOperation "access_policy_object_ids">]
        member _.AccessPolicyObjectIds(state: HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>, value: seq<string>) : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.AccessPolicyObjectIds <- (value |> Seq.toArray))
            state : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#configuration_export_storage_account_name-1">HealthcareFhirService#configuration_export_storage_account_name</a>.
        /// </summary>
        [<CustomOperation "configuration_export_storage_account_name">]
        member _.ConfigurationExportStorageAccountName(state: HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>, value: string) : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ConfigurationExportStorageAccountName <- value)
            state : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#container_registry_login_server_url-1">HealthcareFhirService#container_registry_login_server_url</a>.
        /// </summary>
        [<CustomOperation "container_registry_login_server_url">]
        member _.ContainerRegistryLoginServerUrl(state: HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>, value: seq<string>) : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ContainerRegistryLoginServerUrl <- (value |> Seq.toArray))
            state : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// cors block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#cors-1">HealthcareFhirService#cors</a>
        /// </summary>
        [<CustomOperation "cors">]
        member _.Cors(state: HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>, value: azurerm.HealthcareFhirService.HealthcareFhirServiceCors) : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Cors <- value)
            state : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#id-1">HealthcareFhirService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>, value: string) : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#identity-1">HealthcareFhirService#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>, value: azurerm.HealthcareFhirService.HealthcareFhirServiceIdentity) : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#kind-1">HealthcareFhirService#kind</a>.
        /// </summary>
        [<CustomOperation "kind">]
        member _.Kind(state: HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>, value: string) : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Kind <- value)
            state : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// oci_artifact block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#oci_artifact-1">HealthcareFhirService#oci_artifact</a> Accepts: azurerm.IResolvable | azurerm.HealthcareFhirService.HealthcareFhirServiceOciArtifact[]
        /// </summary>
        [<CustomOperation "oci_artifact">]
        member _.OciArtifact(state: HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.OciArtifact <- value)
            state : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#tags-1">HealthcareFhirService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>, value: seq<string * string>) : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#timeouts-1">HealthcareFhirService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>, value: azurerm.HealthcareFhirService.HealthcareFhirServiceTimeouts) : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : HealthcareFhirServiceState<'Authentication, 'Location, 'Name, 'ResourceGroupName, 'WorkspaceId>

        member _.Run(state: HealthcareFhirServiceState<Present, Present, Present, Present, Present>) : azurerm.HealthcareFhirService.HealthcareFhirService =
            let config = azurerm.HealthcareFhirService.HealthcareFhirServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.HealthcareFhirService.HealthcareFhirService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.healthcareFhirService: missing required arguments. Must call: authentication, location, name, resource_group_name, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: HealthcareFhirServiceState<_, _, _, _, _>) : azurerm.HealthcareFhirService.HealthcareFhirService =
            Unchecked.defaultof<azurerm.HealthcareFhirService.HealthcareFhirService>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId> = { assignments: ResizeArray<azurerm.HealthcareMedtechService.HealthcareMedtechServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service">azurerm_healthcare_medtech_service</a>.
    /// </summary>
    type HealthcareMedtechServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : HealthcareMedtechServiceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HealthcareMedtechServiceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : HealthcareMedtechServiceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HealthcareMedtechServiceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service#device_mapping_json-1">HealthcareMedtechService#device_mapping_json</a>.
        /// </summary>
        [<CustomOperation "device_mapping_json">]
        member _.DeviceMappingJson(state: HealthcareMedtechServiceState<Missing, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId>, value: string) : HealthcareMedtechServiceState<Present, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.DeviceMappingJson <- value)
            ({ assignments = state.assignments } : HealthcareMedtechServiceState<Present, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service#eventhub_consumer_group_name-1">HealthcareMedtechService#eventhub_consumer_group_name</a>.
        /// </summary>
        [<CustomOperation "eventhub_consumer_group_name">]
        member _.EventhubConsumerGroupName(state: HealthcareMedtechServiceState<'DeviceMappingJson, Missing, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId>, value: string) : HealthcareMedtechServiceState<'DeviceMappingJson, Present, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.EventhubConsumerGroupName <- value)
            ({ assignments = state.assignments } : HealthcareMedtechServiceState<'DeviceMappingJson, Present, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service#eventhub_name-1">HealthcareMedtechService#eventhub_name</a>.
        /// </summary>
        [<CustomOperation "eventhub_name">]
        member _.EventhubName(state: HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, Missing, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId>, value: string) : HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, Present, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.EventhubName <- value)
            ({ assignments = state.assignments } : HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, Present, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service#eventhub_namespace_name-1">HealthcareMedtechService#eventhub_namespace_name</a>.
        /// </summary>
        [<CustomOperation "eventhub_namespace_name">]
        member _.EventhubNamespaceName(state: HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, Missing, 'Location, 'Name, 'WorkspaceId>, value: string) : HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, Present, 'Location, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.EventhubNamespaceName <- value)
            ({ assignments = state.assignments } : HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, Present, 'Location, 'Name, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service#location-1">HealthcareMedtechService#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, Missing, 'Name, 'WorkspaceId>, value: string) : HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, Present, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, Present, 'Name, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service#name-1">HealthcareMedtechService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, Missing, 'WorkspaceId>, value: string) : HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service#workspace_id-1">HealthcareMedtechService#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, Missing>, value: string) : HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service#id-1">HealthcareMedtechService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId>, value: string) : HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service#identity-1">HealthcareMedtechService#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId>, value: azurerm.HealthcareMedtechService.HealthcareMedtechServiceIdentity) : HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service#tags-1">HealthcareMedtechService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId>, value: seq<string * string>) : HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_medtech_service#timeouts-1">HealthcareMedtechService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId>, value: azurerm.HealthcareMedtechService.HealthcareMedtechServiceTimeouts) : HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : HealthcareMedtechServiceState<'DeviceMappingJson, 'EventhubConsumerGroupName, 'EventhubName, 'EventhubNamespaceName, 'Location, 'Name, 'WorkspaceId>

        member _.Run(state: HealthcareMedtechServiceState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.HealthcareMedtechService.HealthcareMedtechService =
            let config = azurerm.HealthcareMedtechService.HealthcareMedtechServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.HealthcareMedtechService.HealthcareMedtechService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.healthcareMedtechService: missing required arguments. Must call: device_mapping_json, eventhub_consumer_group_name, eventhub_name, eventhub_namespace_name, location, name, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: HealthcareMedtechServiceState<_, _, _, _, _, _, _>) : azurerm.HealthcareMedtechService.HealthcareMedtechService =
            Unchecked.defaultof<azurerm.HealthcareMedtechService.HealthcareMedtechService>

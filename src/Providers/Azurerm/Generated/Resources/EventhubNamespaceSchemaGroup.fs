namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EventhubNamespaceSchemaGroupState<'Name, 'NamespaceId, 'SchemaCompatibility, 'SchemaType> = { assignments: ResizeArray<azurerm.EventhubNamespaceSchemaGroup.EventhubNamespaceSchemaGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_schema_group">azurerm_eventhub_namespace_schema_group</a>.
    /// </summary>
    type EventhubNamespaceSchemaGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : EventhubNamespaceSchemaGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventhubNamespaceSchemaGroupState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : EventhubNamespaceSchemaGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventhubNamespaceSchemaGroupState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_schema_group#name-1">EventhubNamespaceSchemaGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EventhubNamespaceSchemaGroupState<Missing, 'NamespaceId, 'SchemaCompatibility, 'SchemaType>, value: string) : EventhubNamespaceSchemaGroupState<Present, 'NamespaceId, 'SchemaCompatibility, 'SchemaType> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EventhubNamespaceSchemaGroupState<Present, 'NamespaceId, 'SchemaCompatibility, 'SchemaType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_schema_group#namespace_id-1">EventhubNamespaceSchemaGroup#namespace_id</a>.
        /// </summary>
        [<CustomOperation "namespace_id">]
        member _.NamespaceId(state: EventhubNamespaceSchemaGroupState<'Name, Missing, 'SchemaCompatibility, 'SchemaType>, value: string) : EventhubNamespaceSchemaGroupState<'Name, Present, 'SchemaCompatibility, 'SchemaType> =
            state.assignments.Add(fun config -> config.NamespaceId <- value)
            ({ assignments = state.assignments } : EventhubNamespaceSchemaGroupState<'Name, Present, 'SchemaCompatibility, 'SchemaType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_schema_group#schema_compatibility-1">EventhubNamespaceSchemaGroup#schema_compatibility</a>.
        /// </summary>
        [<CustomOperation "schema_compatibility">]
        member _.SchemaCompatibility(state: EventhubNamespaceSchemaGroupState<'Name, 'NamespaceId, Missing, 'SchemaType>, value: string) : EventhubNamespaceSchemaGroupState<'Name, 'NamespaceId, Present, 'SchemaType> =
            state.assignments.Add(fun config -> config.SchemaCompatibility <- value)
            ({ assignments = state.assignments } : EventhubNamespaceSchemaGroupState<'Name, 'NamespaceId, Present, 'SchemaType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_schema_group#schema_type-1">EventhubNamespaceSchemaGroup#schema_type</a>.
        /// </summary>
        [<CustomOperation "schema_type">]
        member _.SchemaType(state: EventhubNamespaceSchemaGroupState<'Name, 'NamespaceId, 'SchemaCompatibility, Missing>, value: string) : EventhubNamespaceSchemaGroupState<'Name, 'NamespaceId, 'SchemaCompatibility, Present> =
            state.assignments.Add(fun config -> config.SchemaType <- value)
            ({ assignments = state.assignments } : EventhubNamespaceSchemaGroupState<'Name, 'NamespaceId, 'SchemaCompatibility, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_schema_group#id-1">EventhubNamespaceSchemaGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EventhubNamespaceSchemaGroupState<'Name, 'NamespaceId, 'SchemaCompatibility, 'SchemaType>, value: string) : EventhubNamespaceSchemaGroupState<'Name, 'NamespaceId, 'SchemaCompatibility, 'SchemaType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EventhubNamespaceSchemaGroupState<'Name, 'NamespaceId, 'SchemaCompatibility, 'SchemaType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_schema_group#timeouts-1">EventhubNamespaceSchemaGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EventhubNamespaceSchemaGroupState<'Name, 'NamespaceId, 'SchemaCompatibility, 'SchemaType>, value: azurerm.EventhubNamespaceSchemaGroup.EventhubNamespaceSchemaGroupTimeouts) : EventhubNamespaceSchemaGroupState<'Name, 'NamespaceId, 'SchemaCompatibility, 'SchemaType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EventhubNamespaceSchemaGroupState<'Name, 'NamespaceId, 'SchemaCompatibility, 'SchemaType>

        member _.Run(state: EventhubNamespaceSchemaGroupState<Present, Present, Present, Present>) : azurerm.EventhubNamespaceSchemaGroup.EventhubNamespaceSchemaGroup =
            let config = azurerm.EventhubNamespaceSchemaGroup.EventhubNamespaceSchemaGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.EventhubNamespaceSchemaGroup.EventhubNamespaceSchemaGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.eventhubNamespaceSchemaGroup: missing required arguments. Must call: name, namespace_id, schema_compatibility, schema_type.", 9999, IsError = true)>]
        member _.Run(_: EventhubNamespaceSchemaGroupState<_, _, _, _>) : azurerm.EventhubNamespaceSchemaGroup.EventhubNamespaceSchemaGroup =
            Unchecked.defaultof<azurerm.EventhubNamespaceSchemaGroup.EventhubNamespaceSchemaGroup>

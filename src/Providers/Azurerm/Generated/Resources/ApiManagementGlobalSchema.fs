namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementGlobalSchemaState<'ApiManagementName, 'ResourceGroupName, 'SchemaId, 'Type, 'Value> = { assignments: ResizeArray<azurerm.ApiManagementGlobalSchema.ApiManagementGlobalSchemaConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_global_schema">azurerm_api_management_global_schema</a>.
    /// </summary>
    type ApiManagementGlobalSchemaBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementGlobalSchemaState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementGlobalSchemaState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementGlobalSchemaState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementGlobalSchemaState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_global_schema#api_management_name-1">ApiManagementGlobalSchema#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementGlobalSchemaState<Missing, 'ResourceGroupName, 'SchemaId, 'Type, 'Value>, value: string) : ApiManagementGlobalSchemaState<Present, 'ResourceGroupName, 'SchemaId, 'Type, 'Value> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementGlobalSchemaState<Present, 'ResourceGroupName, 'SchemaId, 'Type, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_global_schema#resource_group_name-1">ApiManagementGlobalSchema#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementGlobalSchemaState<'ApiManagementName, Missing, 'SchemaId, 'Type, 'Value>, value: string) : ApiManagementGlobalSchemaState<'ApiManagementName, Present, 'SchemaId, 'Type, 'Value> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementGlobalSchemaState<'ApiManagementName, Present, 'SchemaId, 'Type, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_global_schema#schema_id-1">ApiManagementGlobalSchema#schema_id</a>.
        /// </summary>
        [<CustomOperation "schema_id">]
        member _.SchemaId(state: ApiManagementGlobalSchemaState<'ApiManagementName, 'ResourceGroupName, Missing, 'Type, 'Value>, value: string) : ApiManagementGlobalSchemaState<'ApiManagementName, 'ResourceGroupName, Present, 'Type, 'Value> =
            state.assignments.Add(fun config -> config.SchemaId <- value)
            ({ assignments = state.assignments } : ApiManagementGlobalSchemaState<'ApiManagementName, 'ResourceGroupName, Present, 'Type, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_global_schema#type-1">ApiManagementGlobalSchema#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: ApiManagementGlobalSchemaState<'ApiManagementName, 'ResourceGroupName, 'SchemaId, Missing, 'Value>, value: string) : ApiManagementGlobalSchemaState<'ApiManagementName, 'ResourceGroupName, 'SchemaId, Present, 'Value> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : ApiManagementGlobalSchemaState<'ApiManagementName, 'ResourceGroupName, 'SchemaId, Present, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_global_schema#value-1">ApiManagementGlobalSchema#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: ApiManagementGlobalSchemaState<'ApiManagementName, 'ResourceGroupName, 'SchemaId, 'Type, Missing>, value: string) : ApiManagementGlobalSchemaState<'ApiManagementName, 'ResourceGroupName, 'SchemaId, 'Type, Present> =
            state.assignments.Add(fun config -> config.Value <- value)
            ({ assignments = state.assignments } : ApiManagementGlobalSchemaState<'ApiManagementName, 'ResourceGroupName, 'SchemaId, 'Type, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_global_schema#description-1">ApiManagementGlobalSchema#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiManagementGlobalSchemaState<'ApiManagementName, 'ResourceGroupName, 'SchemaId, 'Type, 'Value>, value: string) : ApiManagementGlobalSchemaState<'ApiManagementName, 'ResourceGroupName, 'SchemaId, 'Type, 'Value> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiManagementGlobalSchemaState<'ApiManagementName, 'ResourceGroupName, 'SchemaId, 'Type, 'Value>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_global_schema#id-1">ApiManagementGlobalSchema#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementGlobalSchemaState<'ApiManagementName, 'ResourceGroupName, 'SchemaId, 'Type, 'Value>, value: string) : ApiManagementGlobalSchemaState<'ApiManagementName, 'ResourceGroupName, 'SchemaId, 'Type, 'Value> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementGlobalSchemaState<'ApiManagementName, 'ResourceGroupName, 'SchemaId, 'Type, 'Value>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_global_schema#timeouts-1">ApiManagementGlobalSchema#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementGlobalSchemaState<'ApiManagementName, 'ResourceGroupName, 'SchemaId, 'Type, 'Value>, value: azurerm.ApiManagementGlobalSchema.ApiManagementGlobalSchemaTimeouts) : ApiManagementGlobalSchemaState<'ApiManagementName, 'ResourceGroupName, 'SchemaId, 'Type, 'Value> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementGlobalSchemaState<'ApiManagementName, 'ResourceGroupName, 'SchemaId, 'Type, 'Value>

        member _.Run(state: ApiManagementGlobalSchemaState<Present, Present, Present, Present, Present>) : azurerm.ApiManagementGlobalSchema.ApiManagementGlobalSchema =
            let config = azurerm.ApiManagementGlobalSchema.ApiManagementGlobalSchemaConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementGlobalSchema.ApiManagementGlobalSchema(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementGlobalSchema: missing required arguments. Must call: api_management_name, resource_group_name, schema_id, type, value.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementGlobalSchemaState<_, _, _, _, _>) : azurerm.ApiManagementGlobalSchema.ApiManagementGlobalSchema =
            Unchecked.defaultof<azurerm.ApiManagementGlobalSchema.ApiManagementGlobalSchema>

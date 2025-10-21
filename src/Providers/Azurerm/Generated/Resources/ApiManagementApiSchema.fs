namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, 'ResourceGroupName, 'SchemaId> = { assignments: ResizeArray<azurerm.ApiManagementApiSchema.ApiManagementApiSchemaConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_schema">azurerm_api_management_api_schema</a>.
    /// </summary>
    type ApiManagementApiSchemaBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementApiSchemaState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiSchemaState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementApiSchemaState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiSchemaState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_schema#api_management_name-1">ApiManagementApiSchema#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementApiSchemaState<Missing, 'ApiName, 'ContentType, 'ResourceGroupName, 'SchemaId>, value: string) : ApiManagementApiSchemaState<Present, 'ApiName, 'ContentType, 'ResourceGroupName, 'SchemaId> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementApiSchemaState<Present, 'ApiName, 'ContentType, 'ResourceGroupName, 'SchemaId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_schema#api_name-1">ApiManagementApiSchema#api_name</a>.
        /// </summary>
        [<CustomOperation "api_name">]
        member _.ApiName(state: ApiManagementApiSchemaState<'ApiManagementName, Missing, 'ContentType, 'ResourceGroupName, 'SchemaId>, value: string) : ApiManagementApiSchemaState<'ApiManagementName, Present, 'ContentType, 'ResourceGroupName, 'SchemaId> =
            state.assignments.Add(fun config -> config.ApiName <- value)
            ({ assignments = state.assignments } : ApiManagementApiSchemaState<'ApiManagementName, Present, 'ContentType, 'ResourceGroupName, 'SchemaId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_schema#content_type-1">ApiManagementApiSchema#content_type</a>.
        /// </summary>
        [<CustomOperation "content_type">]
        member _.ContentType(state: ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, Missing, 'ResourceGroupName, 'SchemaId>, value: string) : ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, Present, 'ResourceGroupName, 'SchemaId> =
            state.assignments.Add(fun config -> config.ContentType <- value)
            ({ assignments = state.assignments } : ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, Present, 'ResourceGroupName, 'SchemaId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_schema#resource_group_name-1">ApiManagementApiSchema#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, Missing, 'SchemaId>, value: string) : ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, Present, 'SchemaId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, Present, 'SchemaId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_schema#schema_id-1">ApiManagementApiSchema#schema_id</a>.
        /// </summary>
        [<CustomOperation "schema_id">]
        member _.SchemaId(state: ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, 'ResourceGroupName, Missing>, value: string) : ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SchemaId <- value)
            ({ assignments = state.assignments } : ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_schema#components-1">ApiManagementApiSchema#components</a>.
        /// </summary>
        [<CustomOperation "components">]
        member _.Components(state: ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, 'ResourceGroupName, 'SchemaId>, value: string) : ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, 'ResourceGroupName, 'SchemaId> =
            state.assignments.Add(fun config -> config.Components <- value)
            state : ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, 'ResourceGroupName, 'SchemaId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_schema#definitions-1">ApiManagementApiSchema#definitions</a>.
        /// </summary>
        [<CustomOperation "definitions">]
        member _.Definitions(state: ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, 'ResourceGroupName, 'SchemaId>, value: string) : ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, 'ResourceGroupName, 'SchemaId> =
            state.assignments.Add(fun config -> config.Definitions <- value)
            state : ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, 'ResourceGroupName, 'SchemaId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_schema#id-1">ApiManagementApiSchema#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, 'ResourceGroupName, 'SchemaId>, value: string) : ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, 'ResourceGroupName, 'SchemaId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, 'ResourceGroupName, 'SchemaId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_schema#timeouts-1">ApiManagementApiSchema#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, 'ResourceGroupName, 'SchemaId>, value: azurerm.ApiManagementApiSchema.ApiManagementApiSchemaTimeouts) : ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, 'ResourceGroupName, 'SchemaId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, 'ResourceGroupName, 'SchemaId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_schema#value-1">ApiManagementApiSchema#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, 'ResourceGroupName, 'SchemaId>, value: string) : ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, 'ResourceGroupName, 'SchemaId> =
            state.assignments.Add(fun config -> config.Value <- value)
            state : ApiManagementApiSchemaState<'ApiManagementName, 'ApiName, 'ContentType, 'ResourceGroupName, 'SchemaId>

        member _.Run(state: ApiManagementApiSchemaState<Present, Present, Present, Present, Present>) : azurerm.ApiManagementApiSchema.ApiManagementApiSchema =
            let config = azurerm.ApiManagementApiSchema.ApiManagementApiSchemaConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementApiSchema.ApiManagementApiSchema(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementApiSchema: missing required arguments. Must call: api_management_name, api_name, content_type, resource_group_name, schema_id.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementApiSchemaState<_, _, _, _, _>) : azurerm.ApiManagementApiSchema.ApiManagementApiSchema =
            Unchecked.defaultof<azurerm.ApiManagementApiSchema.ApiManagementApiSchema>

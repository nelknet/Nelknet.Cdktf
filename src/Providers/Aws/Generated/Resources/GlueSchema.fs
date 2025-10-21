namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlueSchemaState<'Compatibility, 'DataFormat, 'SchemaDefinition, 'SchemaName> = { assignments: ResizeArray<aws.GlueSchema.GlueSchemaConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_schema">aws_glue_schema</a>.
    /// </summary>
    type GlueSchemaBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlueSchemaState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueSchemaState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : GlueSchemaState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueSchemaState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_schema#compatibility-1">GlueSchema#compatibility</a>.
        /// </summary>
        [<CustomOperation "compatibility">]
        member _.Compatibility(state: GlueSchemaState<Missing, 'DataFormat, 'SchemaDefinition, 'SchemaName>, value: string) : GlueSchemaState<Present, 'DataFormat, 'SchemaDefinition, 'SchemaName> =
            state.assignments.Add(fun config -> config.Compatibility <- value)
            ({ assignments = state.assignments } : GlueSchemaState<Present, 'DataFormat, 'SchemaDefinition, 'SchemaName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_schema#data_format-1">GlueSchema#data_format</a>.
        /// </summary>
        [<CustomOperation "data_format">]
        member _.DataFormat(state: GlueSchemaState<'Compatibility, Missing, 'SchemaDefinition, 'SchemaName>, value: string) : GlueSchemaState<'Compatibility, Present, 'SchemaDefinition, 'SchemaName> =
            state.assignments.Add(fun config -> config.DataFormat <- value)
            ({ assignments = state.assignments } : GlueSchemaState<'Compatibility, Present, 'SchemaDefinition, 'SchemaName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_schema#schema_definition-1">GlueSchema#schema_definition</a>.
        /// </summary>
        [<CustomOperation "schema_definition">]
        member _.SchemaDefinition(state: GlueSchemaState<'Compatibility, 'DataFormat, Missing, 'SchemaName>, value: string) : GlueSchemaState<'Compatibility, 'DataFormat, Present, 'SchemaName> =
            state.assignments.Add(fun config -> config.SchemaDefinition <- value)
            ({ assignments = state.assignments } : GlueSchemaState<'Compatibility, 'DataFormat, Present, 'SchemaName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_schema#schema_name-1">GlueSchema#schema_name</a>.
        /// </summary>
        [<CustomOperation "schema_name">]
        member _.SchemaName(state: GlueSchemaState<'Compatibility, 'DataFormat, 'SchemaDefinition, Missing>, value: string) : GlueSchemaState<'Compatibility, 'DataFormat, 'SchemaDefinition, Present> =
            state.assignments.Add(fun config -> config.SchemaName <- value)
            ({ assignments = state.assignments } : GlueSchemaState<'Compatibility, 'DataFormat, 'SchemaDefinition, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_schema#description-1">GlueSchema#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: GlueSchemaState<'Compatibility, 'DataFormat, 'SchemaDefinition, 'SchemaName>, value: string) : GlueSchemaState<'Compatibility, 'DataFormat, 'SchemaDefinition, 'SchemaName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : GlueSchemaState<'Compatibility, 'DataFormat, 'SchemaDefinition, 'SchemaName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_schema#id-1">GlueSchema#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlueSchemaState<'Compatibility, 'DataFormat, 'SchemaDefinition, 'SchemaName>, value: string) : GlueSchemaState<'Compatibility, 'DataFormat, 'SchemaDefinition, 'SchemaName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlueSchemaState<'Compatibility, 'DataFormat, 'SchemaDefinition, 'SchemaName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_schema#registry_arn-1">GlueSchema#registry_arn</a>.
        /// </summary>
        [<CustomOperation "registry_arn">]
        member _.RegistryArn(state: GlueSchemaState<'Compatibility, 'DataFormat, 'SchemaDefinition, 'SchemaName>, value: string) : GlueSchemaState<'Compatibility, 'DataFormat, 'SchemaDefinition, 'SchemaName> =
            state.assignments.Add(fun config -> config.RegistryArn <- value)
            state : GlueSchemaState<'Compatibility, 'DataFormat, 'SchemaDefinition, 'SchemaName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_schema#tags-1">GlueSchema#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GlueSchemaState<'Compatibility, 'DataFormat, 'SchemaDefinition, 'SchemaName>, value: seq<string * string>) : GlueSchemaState<'Compatibility, 'DataFormat, 'SchemaDefinition, 'SchemaName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GlueSchemaState<'Compatibility, 'DataFormat, 'SchemaDefinition, 'SchemaName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_schema#tags_all-1">GlueSchema#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GlueSchemaState<'Compatibility, 'DataFormat, 'SchemaDefinition, 'SchemaName>, value: seq<string * string>) : GlueSchemaState<'Compatibility, 'DataFormat, 'SchemaDefinition, 'SchemaName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GlueSchemaState<'Compatibility, 'DataFormat, 'SchemaDefinition, 'SchemaName>

        member _.Run(state: GlueSchemaState<Present, Present, Present, Present>) : aws.GlueSchema.GlueSchema =
            let config = aws.GlueSchema.GlueSchemaConfig()
            for setter in state.assignments do
                setter config
            aws.GlueSchema.GlueSchema(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.glueSchema: missing required arguments. Must call: compatibility, data_format, schema_definition, schema_name.", 9999, IsError = true)>]
        member _.Run(_: GlueSchemaState<_, _, _, _>) : aws.GlueSchema.GlueSchema =
            Unchecked.defaultof<aws.GlueSchema.GlueSchema>

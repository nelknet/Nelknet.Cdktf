namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SchemasSchemaState<'Content, 'Name, 'RegistryName, 'Type> = { assignments: ResizeArray<aws.SchemasSchema.SchemasSchemaConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_schema">aws_schemas_schema</a>.
    /// </summary>
    type SchemasSchemaBuilder(logicalId: string) =
        member _.Yield(_: unit) : SchemasSchemaState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SchemasSchemaState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SchemasSchemaState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SchemasSchemaState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_schema#content-1">SchemasSchema#content</a>.
        /// </summary>
        [<CustomOperation "content">]
        member _.Content(state: SchemasSchemaState<Missing, 'Name, 'RegistryName, 'Type>, value: string) : SchemasSchemaState<Present, 'Name, 'RegistryName, 'Type> =
            state.assignments.Add(fun config -> config.Content <- value)
            ({ assignments = state.assignments } : SchemasSchemaState<Present, 'Name, 'RegistryName, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_schema#name-1">SchemasSchema#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SchemasSchemaState<'Content, Missing, 'RegistryName, 'Type>, value: string) : SchemasSchemaState<'Content, Present, 'RegistryName, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SchemasSchemaState<'Content, Present, 'RegistryName, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_schema#registry_name-1">SchemasSchema#registry_name</a>.
        /// </summary>
        [<CustomOperation "registry_name">]
        member _.RegistryName(state: SchemasSchemaState<'Content, 'Name, Missing, 'Type>, value: string) : SchemasSchemaState<'Content, 'Name, Present, 'Type> =
            state.assignments.Add(fun config -> config.RegistryName <- value)
            ({ assignments = state.assignments } : SchemasSchemaState<'Content, 'Name, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_schema#type-1">SchemasSchema#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: SchemasSchemaState<'Content, 'Name, 'RegistryName, Missing>, value: string) : SchemasSchemaState<'Content, 'Name, 'RegistryName, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : SchemasSchemaState<'Content, 'Name, 'RegistryName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_schema#description-1">SchemasSchema#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SchemasSchemaState<'Content, 'Name, 'RegistryName, 'Type>, value: string) : SchemasSchemaState<'Content, 'Name, 'RegistryName, 'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SchemasSchemaState<'Content, 'Name, 'RegistryName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_schema#id-1">SchemasSchema#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SchemasSchemaState<'Content, 'Name, 'RegistryName, 'Type>, value: string) : SchemasSchemaState<'Content, 'Name, 'RegistryName, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SchemasSchemaState<'Content, 'Name, 'RegistryName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_schema#tags-1">SchemasSchema#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SchemasSchemaState<'Content, 'Name, 'RegistryName, 'Type>, value: seq<string * string>) : SchemasSchemaState<'Content, 'Name, 'RegistryName, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SchemasSchemaState<'Content, 'Name, 'RegistryName, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_schema#tags_all-1">SchemasSchema#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SchemasSchemaState<'Content, 'Name, 'RegistryName, 'Type>, value: seq<string * string>) : SchemasSchemaState<'Content, 'Name, 'RegistryName, 'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SchemasSchemaState<'Content, 'Name, 'RegistryName, 'Type>

        member _.Run(state: SchemasSchemaState<Present, Present, Present, Present>) : aws.SchemasSchema.SchemasSchema =
            let config = aws.SchemasSchema.SchemasSchemaConfig()
            for setter in state.assignments do
                setter config
            aws.SchemasSchema.SchemasSchema(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.schemasSchema: missing required arguments. Must call: content, name, registry_name, type.", 9999, IsError = true)>]
        member _.Run(_: SchemasSchemaState<_, _, _, _>) : aws.SchemasSchema.SchemasSchema =
            Unchecked.defaultof<aws.SchemasSchema.SchemasSchema>

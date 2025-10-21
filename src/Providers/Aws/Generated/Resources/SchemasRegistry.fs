namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SchemasRegistryState<'Name> = { assignments: ResizeArray<aws.SchemasRegistry.SchemasRegistryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_registry">aws_schemas_registry</a>.
    /// </summary>
    type SchemasRegistryBuilder(logicalId: string) =
        member _.Yield(_: unit) : SchemasRegistryState<Missing> =
            ({ assignments = ResizeArray() } : SchemasRegistryState<Missing>)

        member _.Zero(()) : SchemasRegistryState<Missing> =
            ({ assignments = ResizeArray() } : SchemasRegistryState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_registry#name-1">SchemasRegistry#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SchemasRegistryState<Missing>, value: string) : SchemasRegistryState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SchemasRegistryState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_registry#description-1">SchemasRegistry#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SchemasRegistryState<'Name>, value: string) : SchemasRegistryState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SchemasRegistryState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_registry#id-1">SchemasRegistry#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SchemasRegistryState<'Name>, value: string) : SchemasRegistryState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SchemasRegistryState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_registry#tags-1">SchemasRegistry#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SchemasRegistryState<'Name>, value: seq<string * string>) : SchemasRegistryState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SchemasRegistryState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_registry#tags_all-1">SchemasRegistry#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SchemasRegistryState<'Name>, value: seq<string * string>) : SchemasRegistryState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SchemasRegistryState<'Name>

        member _.Run(state: SchemasRegistryState<Present>) : aws.SchemasRegistry.SchemasRegistry =
            let config = aws.SchemasRegistry.SchemasRegistryConfig()
            for setter in state.assignments do
                setter config
            aws.SchemasRegistry.SchemasRegistry(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.schemasRegistry: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: SchemasRegistryState<_>) : aws.SchemasRegistry.SchemasRegistry =
            Unchecked.defaultof<aws.SchemasRegistry.SchemasRegistry>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlueRegistryState<'RegistryName> = { assignments: ResizeArray<aws.GlueRegistry.GlueRegistryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_registry">aws_glue_registry</a>.
    /// </summary>
    type GlueRegistryBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlueRegistryState<Missing> =
            ({ assignments = ResizeArray() } : GlueRegistryState<Missing>)

        member _.Zero(()) : GlueRegistryState<Missing> =
            ({ assignments = ResizeArray() } : GlueRegistryState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_registry#registry_name-1">GlueRegistry#registry_name</a>.
        /// </summary>
        [<CustomOperation "registry_name">]
        member _.RegistryName(state: GlueRegistryState<Missing>, value: string) : GlueRegistryState<Present> =
            state.assignments.Add(fun config -> config.RegistryName <- value)
            ({ assignments = state.assignments } : GlueRegistryState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_registry#description-1">GlueRegistry#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: GlueRegistryState<'RegistryName>, value: string) : GlueRegistryState<'RegistryName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : GlueRegistryState<'RegistryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_registry#id-1">GlueRegistry#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlueRegistryState<'RegistryName>, value: string) : GlueRegistryState<'RegistryName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlueRegistryState<'RegistryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_registry#tags-1">GlueRegistry#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GlueRegistryState<'RegistryName>, value: seq<string * string>) : GlueRegistryState<'RegistryName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GlueRegistryState<'RegistryName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_registry#tags_all-1">GlueRegistry#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GlueRegistryState<'RegistryName>, value: seq<string * string>) : GlueRegistryState<'RegistryName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GlueRegistryState<'RegistryName>

        member _.Run(state: GlueRegistryState<Present>) : aws.GlueRegistry.GlueRegistry =
            let config = aws.GlueRegistry.GlueRegistryConfig()
            for setter in state.assignments do
                setter config
            aws.GlueRegistry.GlueRegistry(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.glueRegistry: missing required arguments. Must call: registry_name.", 9999, IsError = true)>]
        member _.Run(_: GlueRegistryState<_>) : aws.GlueRegistry.GlueRegistry =
            Unchecked.defaultof<aws.GlueRegistry.GlueRegistry>

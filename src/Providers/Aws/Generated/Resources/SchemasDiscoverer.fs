namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SchemasDiscovererState<'SourceArn> = { assignments: ResizeArray<aws.SchemasDiscoverer.SchemasDiscovererConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_discoverer">aws_schemas_discoverer</a>.
    /// </summary>
    type SchemasDiscovererBuilder(logicalId: string) =
        member _.Yield(_: unit) : SchemasDiscovererState<Missing> =
            ({ assignments = ResizeArray() } : SchemasDiscovererState<Missing>)

        member _.Zero(()) : SchemasDiscovererState<Missing> =
            ({ assignments = ResizeArray() } : SchemasDiscovererState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_discoverer#source_arn-1">SchemasDiscoverer#source_arn</a>.
        /// </summary>
        [<CustomOperation "source_arn">]
        member _.SourceArn(state: SchemasDiscovererState<Missing>, value: string) : SchemasDiscovererState<Present> =
            state.assignments.Add(fun config -> config.SourceArn <- value)
            ({ assignments = state.assignments } : SchemasDiscovererState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_discoverer#description-1">SchemasDiscoverer#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SchemasDiscovererState<'SourceArn>, value: string) : SchemasDiscovererState<'SourceArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SchemasDiscovererState<'SourceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_discoverer#id-1">SchemasDiscoverer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SchemasDiscovererState<'SourceArn>, value: string) : SchemasDiscovererState<'SourceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SchemasDiscovererState<'SourceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_discoverer#tags-1">SchemasDiscoverer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SchemasDiscovererState<'SourceArn>, value: seq<string * string>) : SchemasDiscovererState<'SourceArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SchemasDiscovererState<'SourceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_discoverer#tags_all-1">SchemasDiscoverer#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SchemasDiscovererState<'SourceArn>, value: seq<string * string>) : SchemasDiscovererState<'SourceArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SchemasDiscovererState<'SourceArn>

        member _.Run(state: SchemasDiscovererState<Present>) : aws.SchemasDiscoverer.SchemasDiscoverer =
            let config = aws.SchemasDiscoverer.SchemasDiscovererConfig()
            for setter in state.assignments do
                setter config
            aws.SchemasDiscoverer.SchemasDiscoverer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.schemasDiscoverer: missing required arguments. Must call: source_arn.", 9999, IsError = true)>]
        member _.Run(_: SchemasDiscovererState<_>) : aws.SchemasDiscoverer.SchemasDiscoverer =
            Unchecked.defaultof<aws.SchemasDiscoverer.SchemasDiscoverer>

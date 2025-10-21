namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlueConnectionState<'Name> = { assignments: ResizeArray<aws.GlueConnection.GlueConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_connection">aws_glue_connection</a>.
    /// </summary>
    type GlueConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlueConnectionState<Missing> =
            ({ assignments = ResizeArray() } : GlueConnectionState<Missing>)

        member _.Zero(()) : GlueConnectionState<Missing> =
            ({ assignments = ResizeArray() } : GlueConnectionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_connection#name-1">GlueConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GlueConnectionState<Missing>, value: string) : GlueConnectionState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GlueConnectionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_connection#athena_properties-1">GlueConnection#athena_properties</a>.
        /// </summary>
        [<CustomOperation "athena_properties">]
        member _.AthenaProperties(state: GlueConnectionState<'Name>, value: seq<string * string>) : GlueConnectionState<'Name> =
            state.assignments.Add(fun config -> config.AthenaProperties <- dict value)
            state : GlueConnectionState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_connection#catalog_id-1">GlueConnection#catalog_id</a>.
        /// </summary>
        [<CustomOperation "catalog_id">]
        member _.CatalogId(state: GlueConnectionState<'Name>, value: string) : GlueConnectionState<'Name> =
            state.assignments.Add(fun config -> config.CatalogId <- value)
            state : GlueConnectionState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_connection#connection_properties-1">GlueConnection#connection_properties</a>.
        /// </summary>
        [<CustomOperation "connection_properties">]
        member _.ConnectionProperties(state: GlueConnectionState<'Name>, value: seq<string * string>) : GlueConnectionState<'Name> =
            state.assignments.Add(fun config -> config.ConnectionProperties <- dict value)
            state : GlueConnectionState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_connection#connection_type-1">GlueConnection#connection_type</a>.
        /// </summary>
        [<CustomOperation "connection_type">]
        member _.ConnectionType(state: GlueConnectionState<'Name>, value: string) : GlueConnectionState<'Name> =
            state.assignments.Add(fun config -> config.ConnectionType <- value)
            state : GlueConnectionState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_connection#description-1">GlueConnection#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: GlueConnectionState<'Name>, value: string) : GlueConnectionState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : GlueConnectionState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_connection#id-1">GlueConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlueConnectionState<'Name>, value: string) : GlueConnectionState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlueConnectionState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_connection#match_criteria-1">GlueConnection#match_criteria</a>.
        /// </summary>
        [<CustomOperation "match_criteria">]
        member _.MatchCriteria(state: GlueConnectionState<'Name>, value: seq<string>) : GlueConnectionState<'Name> =
            state.assignments.Add(fun config -> config.MatchCriteria <- (value |> Seq.toArray))
            state : GlueConnectionState<'Name>

        /// <summary>
        /// physical_connection_requirements block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_connection#physical_connection_requirements-1">GlueConnection#physical_connection_requirements</a>
        /// </summary>
        [<CustomOperation "physical_connection_requirements">]
        member _.PhysicalConnectionRequirements(state: GlueConnectionState<'Name>, value: aws.GlueConnection.GlueConnectionPhysicalConnectionRequirements) : GlueConnectionState<'Name> =
            state.assignments.Add(fun config -> config.PhysicalConnectionRequirements <- value)
            state : GlueConnectionState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_connection#tags-1">GlueConnection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GlueConnectionState<'Name>, value: seq<string * string>) : GlueConnectionState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GlueConnectionState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_connection#tags_all-1">GlueConnection#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GlueConnectionState<'Name>, value: seq<string * string>) : GlueConnectionState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GlueConnectionState<'Name>

        member _.Run(state: GlueConnectionState<Present>) : aws.GlueConnection.GlueConnection =
            let config = aws.GlueConnection.GlueConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.GlueConnection.GlueConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.glueConnection: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: GlueConnectionState<_>) : aws.GlueConnection.GlueConnection =
            Unchecked.defaultof<aws.GlueConnection.GlueConnection>

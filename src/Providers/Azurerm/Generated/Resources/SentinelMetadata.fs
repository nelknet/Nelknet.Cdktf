namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId> = { assignments: ResizeArray<azurerm.SentinelMetadata.SentinelMetadataConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata">azurerm_sentinel_metadata</a>.
    /// </summary>
    type SentinelMetadataBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelMetadataState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelMetadataState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SentinelMetadataState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SentinelMetadataState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#content_id-1">SentinelMetadata#content_id</a>.
        /// </summary>
        [<CustomOperation "content_id">]
        member _.ContentId(state: SentinelMetadataState<Missing, 'Kind, 'Name, 'ParentId, 'WorkspaceId>, value: string) : SentinelMetadataState<Present, 'Kind, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ContentId <- value)
            ({ assignments = state.assignments } : SentinelMetadataState<Present, 'Kind, 'Name, 'ParentId, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#kind-1">SentinelMetadata#kind</a>.
        /// </summary>
        [<CustomOperation "kind">]
        member _.Kind(state: SentinelMetadataState<'ContentId, Missing, 'Name, 'ParentId, 'WorkspaceId>, value: string) : SentinelMetadataState<'ContentId, Present, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Kind <- value)
            ({ assignments = state.assignments } : SentinelMetadataState<'ContentId, Present, 'Name, 'ParentId, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#name-1">SentinelMetadata#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SentinelMetadataState<'ContentId, 'Kind, Missing, 'ParentId, 'WorkspaceId>, value: string) : SentinelMetadataState<'ContentId, 'Kind, Present, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SentinelMetadataState<'ContentId, 'Kind, Present, 'ParentId, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#parent_id-1">SentinelMetadata#parent_id</a>.
        /// </summary>
        [<CustomOperation "parent_id">]
        member _.ParentId(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, Missing, 'WorkspaceId>, value: string) : SentinelMetadataState<'ContentId, 'Kind, 'Name, Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ParentId <- value)
            ({ assignments = state.assignments } : SentinelMetadataState<'ContentId, 'Kind, 'Name, Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#workspace_id-1">SentinelMetadata#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, Missing>, value: string) : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, Present>)

        /// <summary>
        /// author block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#author-1">SentinelMetadata#author</a>
        /// </summary>
        [<CustomOperation "author">]
        member _.Author(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>, value: azurerm.SentinelMetadata.SentinelMetadataAuthor) : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Author <- value)
            state : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>

        /// <summary>
        /// category block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#category-1">SentinelMetadata#category</a>
        /// </summary>
        [<CustomOperation "category">]
        member _.Category(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>, value: azurerm.SentinelMetadata.SentinelMetadataCategory) : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Category <- value)
            state : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#content_schema_version-1">SentinelMetadata#content_schema_version</a>.
        /// </summary>
        [<CustomOperation "content_schema_version">]
        member _.ContentSchemaVersion(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>, value: string) : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ContentSchemaVersion <- value)
            state : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#custom_version-1">SentinelMetadata#custom_version</a>.
        /// </summary>
        [<CustomOperation "custom_version">]
        member _.CustomVersion(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>, value: string) : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.CustomVersion <- value)
            state : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#dependency-1">SentinelMetadata#dependency</a>.
        /// </summary>
        [<CustomOperation "dependency">]
        member _.Dependency(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>, value: string) : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Dependency <- value)
            state : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#first_publish_date-1">SentinelMetadata#first_publish_date</a>.
        /// </summary>
        [<CustomOperation "first_publish_date">]
        member _.FirstPublishDate(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>, value: string) : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.FirstPublishDate <- value)
            state : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#icon_id-1">SentinelMetadata#icon_id</a>.
        /// </summary>
        [<CustomOperation "icon_id">]
        member _.IconId(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>, value: string) : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.IconId <- value)
            state : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#id-1">SentinelMetadata#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>, value: string) : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#last_publish_date-1">SentinelMetadata#last_publish_date</a>.
        /// </summary>
        [<CustomOperation "last_publish_date">]
        member _.LastPublishDate(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>, value: string) : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.LastPublishDate <- value)
            state : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#preview_images-1">SentinelMetadata#preview_images</a>.
        /// </summary>
        [<CustomOperation "preview_images">]
        member _.PreviewImages(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>, value: seq<string>) : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.PreviewImages <- (value |> Seq.toArray))
            state : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#preview_images_dark-1">SentinelMetadata#preview_images_dark</a>.
        /// </summary>
        [<CustomOperation "preview_images_dark">]
        member _.PreviewImagesDark(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>, value: seq<string>) : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.PreviewImagesDark <- (value |> Seq.toArray))
            state : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#providers-1">SentinelMetadata#providers</a>.
        /// </summary>
        [<CustomOperation "providers">]
        member _.Providers(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>, value: seq<string>) : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Providers <- (value |> Seq.toArray))
            state : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>

        /// <summary>
        /// source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#source-1">SentinelMetadata#source</a>
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>, value: azurerm.SentinelMetadata.SentinelMetadataSource) : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Source <- value)
            state : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>

        /// <summary>
        /// support block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#support-1">SentinelMetadata#support</a>
        /// </summary>
        [<CustomOperation "support">]
        member _.Support(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>, value: azurerm.SentinelMetadata.SentinelMetadataSupport) : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Support <- value)
            state : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#threat_analysis_tactics-1">SentinelMetadata#threat_analysis_tactics</a>.
        /// </summary>
        [<CustomOperation "threat_analysis_tactics">]
        member _.ThreatAnalysisTactics(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>, value: seq<string>) : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ThreatAnalysisTactics <- (value |> Seq.toArray))
            state : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#threat_analysis_techniques-1">SentinelMetadata#threat_analysis_techniques</a>.
        /// </summary>
        [<CustomOperation "threat_analysis_techniques">]
        member _.ThreatAnalysisTechniques(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>, value: seq<string>) : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ThreatAnalysisTechniques <- (value |> Seq.toArray))
            state : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#timeouts-1">SentinelMetadata#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>, value: azurerm.SentinelMetadata.SentinelMetadataTimeouts) : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#version-1">SentinelMetadata#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>, value: string) : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : SentinelMetadataState<'ContentId, 'Kind, 'Name, 'ParentId, 'WorkspaceId>

        member _.Run(state: SentinelMetadataState<Present, Present, Present, Present, Present>) : azurerm.SentinelMetadata.SentinelMetadata =
            let config = azurerm.SentinelMetadata.SentinelMetadataConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelMetadata.SentinelMetadata(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelMetadata: missing required arguments. Must call: content_id, kind, name, parent_id, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: SentinelMetadataState<_, _, _, _, _>) : azurerm.SentinelMetadata.SentinelMetadata =
            Unchecked.defaultof<azurerm.SentinelMetadata.SentinelMetadata>

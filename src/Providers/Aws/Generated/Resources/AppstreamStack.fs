namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppstreamStackState<'Name> = { assignments: ResizeArray<aws.AppstreamStack.AppstreamStackConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack">aws_appstream_stack</a>.
    /// </summary>
    type AppstreamStackBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppstreamStackState<Missing> =
            ({ assignments = ResizeArray() } : AppstreamStackState<Missing>)

        member _.Zero(()) : AppstreamStackState<Missing> =
            ({ assignments = ResizeArray() } : AppstreamStackState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#name-1">AppstreamStack#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppstreamStackState<Missing>, value: string) : AppstreamStackState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppstreamStackState<Present>)

        /// <summary>
        /// access_endpoints block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#access_endpoints-1">AppstreamStack#access_endpoints</a> Accepts: aws.IResolvable | aws.AppstreamStack.AppstreamStackAccessEndpoints[]
        /// </summary>
        [<CustomOperation "access_endpoints">]
        member _.AccessEndpoints(state: AppstreamStackState<'Name>, value: HashiCorp.Cdktf.IResolvable) : AppstreamStackState<'Name> =
            state.assignments.Add(fun config -> config.AccessEndpoints <- value)
            state : AppstreamStackState<'Name>

        /// <summary>
        /// application_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#application_settings-1">AppstreamStack#application_settings</a>
        /// </summary>
        [<CustomOperation "application_settings">]
        member _.ApplicationSettings(state: AppstreamStackState<'Name>, value: aws.AppstreamStack.AppstreamStackApplicationSettings) : AppstreamStackState<'Name> =
            state.assignments.Add(fun config -> config.ApplicationSettings <- value)
            state : AppstreamStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#description-1">AppstreamStack#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AppstreamStackState<'Name>, value: string) : AppstreamStackState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AppstreamStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#display_name-1">AppstreamStack#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: AppstreamStackState<'Name>, value: string) : AppstreamStackState<'Name> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : AppstreamStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#embed_host_domains-1">AppstreamStack#embed_host_domains</a>.
        /// </summary>
        [<CustomOperation "embed_host_domains">]
        member _.EmbedHostDomains(state: AppstreamStackState<'Name>, value: seq<string>) : AppstreamStackState<'Name> =
            state.assignments.Add(fun config -> config.EmbedHostDomains <- (value |> Seq.toArray))
            state : AppstreamStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#feedback_url-1">AppstreamStack#feedback_url</a>.
        /// </summary>
        [<CustomOperation "feedback_url">]
        member _.FeedbackUrl(state: AppstreamStackState<'Name>, value: string) : AppstreamStackState<'Name> =
            state.assignments.Add(fun config -> config.FeedbackUrl <- value)
            state : AppstreamStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#id-1">AppstreamStack#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppstreamStackState<'Name>, value: string) : AppstreamStackState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppstreamStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#redirect_url-1">AppstreamStack#redirect_url</a>.
        /// </summary>
        [<CustomOperation "redirect_url">]
        member _.RedirectUrl(state: AppstreamStackState<'Name>, value: string) : AppstreamStackState<'Name> =
            state.assignments.Add(fun config -> config.RedirectUrl <- value)
            state : AppstreamStackState<'Name>

        /// <summary>
        /// storage_connectors block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#storage_connectors-1">AppstreamStack#storage_connectors</a> Accepts: aws.IResolvable | aws.AppstreamStack.AppstreamStackStorageConnectors[]
        /// </summary>
        [<CustomOperation "storage_connectors">]
        member _.StorageConnectors(state: AppstreamStackState<'Name>, value: HashiCorp.Cdktf.IResolvable) : AppstreamStackState<'Name> =
            state.assignments.Add(fun config -> config.StorageConnectors <- value)
            state : AppstreamStackState<'Name>

        /// <summary>
        /// streaming_experience_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#streaming_experience_settings-1">AppstreamStack#streaming_experience_settings</a>
        /// </summary>
        [<CustomOperation "streaming_experience_settings">]
        member _.StreamingExperienceSettings(state: AppstreamStackState<'Name>, value: aws.AppstreamStack.AppstreamStackStreamingExperienceSettings) : AppstreamStackState<'Name> =
            state.assignments.Add(fun config -> config.StreamingExperienceSettings <- value)
            state : AppstreamStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#tags-1">AppstreamStack#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppstreamStackState<'Name>, value: seq<string * string>) : AppstreamStackState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppstreamStackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#tags_all-1">AppstreamStack#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppstreamStackState<'Name>, value: seq<string * string>) : AppstreamStackState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppstreamStackState<'Name>

        /// <summary>
        /// user_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#user_settings-1">AppstreamStack#user_settings</a> Accepts: aws.IResolvable | aws.AppstreamStack.AppstreamStackUserSettings[]
        /// </summary>
        [<CustomOperation "user_settings">]
        member _.UserSettings(state: AppstreamStackState<'Name>, value: HashiCorp.Cdktf.IResolvable) : AppstreamStackState<'Name> =
            state.assignments.Add(fun config -> config.UserSettings <- value)
            state : AppstreamStackState<'Name>

        member _.Run(state: AppstreamStackState<Present>) : aws.AppstreamStack.AppstreamStack =
            let config = aws.AppstreamStack.AppstreamStackConfig()
            for setter in state.assignments do
                setter config
            aws.AppstreamStack.AppstreamStack(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appstreamStack: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: AppstreamStackState<_>) : aws.AppstreamStack.AppstreamStack =
            Unchecked.defaultof<aws.AppstreamStack.AppstreamStack>

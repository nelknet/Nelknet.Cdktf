namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MediaStoreContainerState<'Name> = { assignments: ResizeArray<aws.MediaStoreContainer.MediaStoreContainerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_store_container">aws_media_store_container</a>.
    /// </summary>
    type MediaStoreContainerBuilder(logicalId: string) =
        member _.Yield(_: unit) : MediaStoreContainerState<Missing> =
            ({ assignments = ResizeArray() } : MediaStoreContainerState<Missing>)

        member _.Zero(()) : MediaStoreContainerState<Missing> =
            ({ assignments = ResizeArray() } : MediaStoreContainerState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_store_container#name-1">MediaStoreContainer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MediaStoreContainerState<Missing>, value: string) : MediaStoreContainerState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MediaStoreContainerState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_store_container#id-1">MediaStoreContainer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MediaStoreContainerState<'Name>, value: string) : MediaStoreContainerState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MediaStoreContainerState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_store_container#tags-1">MediaStoreContainer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MediaStoreContainerState<'Name>, value: seq<string * string>) : MediaStoreContainerState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MediaStoreContainerState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_store_container#tags_all-1">MediaStoreContainer#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MediaStoreContainerState<'Name>, value: seq<string * string>) : MediaStoreContainerState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MediaStoreContainerState<'Name>

        member _.Run(state: MediaStoreContainerState<Present>) : aws.MediaStoreContainer.MediaStoreContainer =
            let config = aws.MediaStoreContainer.MediaStoreContainerConfig()
            for setter in state.assignments do
                setter config
            aws.MediaStoreContainer.MediaStoreContainer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mediaStoreContainer: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: MediaStoreContainerState<_>) : aws.MediaStoreContainer.MediaStoreContainer =
            Unchecked.defaultof<aws.MediaStoreContainer.MediaStoreContainer>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ImagebuilderComponentState<'Name, 'Platform, 'Version> = { assignments: ResizeArray<aws.ImagebuilderComponent.ImagebuilderComponentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_component">aws_imagebuilder_component</a>.
    /// </summary>
    type ImagebuilderComponentBuilder(logicalId: string) =
        member _.Yield(_: unit) : ImagebuilderComponentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ImagebuilderComponentState<Missing, Missing, Missing>)

        member _.Zero(()) : ImagebuilderComponentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ImagebuilderComponentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_component#name-1">ImagebuilderComponent#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ImagebuilderComponentState<Missing, 'Platform, 'Version>, value: string) : ImagebuilderComponentState<Present, 'Platform, 'Version> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ImagebuilderComponentState<Present, 'Platform, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_component#platform-1">ImagebuilderComponent#platform</a>.
        /// </summary>
        [<CustomOperation "platform">]
        member _.Platform(state: ImagebuilderComponentState<'Name, Missing, 'Version>, value: string) : ImagebuilderComponentState<'Name, Present, 'Version> =
            state.assignments.Add(fun config -> config.Platform <- value)
            ({ assignments = state.assignments } : ImagebuilderComponentState<'Name, Present, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_component#version-1">ImagebuilderComponent#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: ImagebuilderComponentState<'Name, 'Platform, Missing>, value: string) : ImagebuilderComponentState<'Name, 'Platform, Present> =
            state.assignments.Add(fun config -> config.Version <- value)
            ({ assignments = state.assignments } : ImagebuilderComponentState<'Name, 'Platform, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_component#change_description-1">ImagebuilderComponent#change_description</a>.
        /// </summary>
        [<CustomOperation "change_description">]
        member _.ChangeDescription(state: ImagebuilderComponentState<'Name, 'Platform, 'Version>, value: string) : ImagebuilderComponentState<'Name, 'Platform, 'Version> =
            state.assignments.Add(fun config -> config.ChangeDescription <- value)
            state : ImagebuilderComponentState<'Name, 'Platform, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_component#data-1">ImagebuilderComponent#data</a>.
        /// </summary>
        [<CustomOperation "data">]
        member _.Data(state: ImagebuilderComponentState<'Name, 'Platform, 'Version>, value: string) : ImagebuilderComponentState<'Name, 'Platform, 'Version> =
            state.assignments.Add(fun config -> config.Data <- value)
            state : ImagebuilderComponentState<'Name, 'Platform, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_component#description-1">ImagebuilderComponent#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ImagebuilderComponentState<'Name, 'Platform, 'Version>, value: string) : ImagebuilderComponentState<'Name, 'Platform, 'Version> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ImagebuilderComponentState<'Name, 'Platform, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_component#id-1">ImagebuilderComponent#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ImagebuilderComponentState<'Name, 'Platform, 'Version>, value: string) : ImagebuilderComponentState<'Name, 'Platform, 'Version> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ImagebuilderComponentState<'Name, 'Platform, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_component#kms_key_id-1">ImagebuilderComponent#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: ImagebuilderComponentState<'Name, 'Platform, 'Version>, value: string) : ImagebuilderComponentState<'Name, 'Platform, 'Version> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : ImagebuilderComponentState<'Name, 'Platform, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_component#skip_destroy-1">ImagebuilderComponent#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: ImagebuilderComponentState<'Name, 'Platform, 'Version>, value: bool) : ImagebuilderComponentState<'Name, 'Platform, 'Version> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : ImagebuilderComponentState<'Name, 'Platform, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_component#skip_destroy-1">ImagebuilderComponent#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: ImagebuilderComponentState<'Name, 'Platform, 'Version>, value: HashiCorp.Cdktf.IResolvable) : ImagebuilderComponentState<'Name, 'Platform, 'Version> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : ImagebuilderComponentState<'Name, 'Platform, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_component#supported_os_versions-1">ImagebuilderComponent#supported_os_versions</a>.
        /// </summary>
        [<CustomOperation "supported_os_versions">]
        member _.SupportedOsVersions(state: ImagebuilderComponentState<'Name, 'Platform, 'Version>, value: seq<string>) : ImagebuilderComponentState<'Name, 'Platform, 'Version> =
            state.assignments.Add(fun config -> config.SupportedOsVersions <- (value |> Seq.toArray))
            state : ImagebuilderComponentState<'Name, 'Platform, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_component#tags-1">ImagebuilderComponent#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ImagebuilderComponentState<'Name, 'Platform, 'Version>, value: seq<string * string>) : ImagebuilderComponentState<'Name, 'Platform, 'Version> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ImagebuilderComponentState<'Name, 'Platform, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_component#tags_all-1">ImagebuilderComponent#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ImagebuilderComponentState<'Name, 'Platform, 'Version>, value: seq<string * string>) : ImagebuilderComponentState<'Name, 'Platform, 'Version> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ImagebuilderComponentState<'Name, 'Platform, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_component#uri-1">ImagebuilderComponent#uri</a>.
        /// </summary>
        [<CustomOperation "uri">]
        member _.Uri(state: ImagebuilderComponentState<'Name, 'Platform, 'Version>, value: string) : ImagebuilderComponentState<'Name, 'Platform, 'Version> =
            state.assignments.Add(fun config -> config.Uri <- value)
            state : ImagebuilderComponentState<'Name, 'Platform, 'Version>

        member _.Run(state: ImagebuilderComponentState<Present, Present, Present>) : aws.ImagebuilderComponent.ImagebuilderComponent =
            let config = aws.ImagebuilderComponent.ImagebuilderComponentConfig()
            for setter in state.assignments do
                setter config
            aws.ImagebuilderComponent.ImagebuilderComponent(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.imagebuilderComponent: missing required arguments. Must call: name, platform, version.", 9999, IsError = true)>]
        member _.Run(_: ImagebuilderComponentState<_, _, _>) : aws.ImagebuilderComponent.ImagebuilderComponent =
            Unchecked.defaultof<aws.ImagebuilderComponent.ImagebuilderComponent>

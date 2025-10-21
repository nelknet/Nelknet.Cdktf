namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version> = { assignments: ResizeArray<aws.ImagebuilderContainerRecipe.ImagebuilderContainerRecipeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe">aws_imagebuilder_container_recipe</a>.
    /// </summary>
    type ImagebuilderContainerRecipeBuilder(logicalId: string) =
        member _.Yield(_: unit) : ImagebuilderContainerRecipeState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ImagebuilderContainerRecipeState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ImagebuilderContainerRecipeState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ImagebuilderContainerRecipeState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// component block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#component-1">ImagebuilderContainerRecipe#component</a> Accepts: aws.IResolvable | aws.ImagebuilderContainerRecipe.ImagebuilderContainerRecipeComponent[]
        /// </summary>
        [<CustomOperation "component">]
        member _.Component(state: ImagebuilderContainerRecipeState<Missing, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>, value: HashiCorp.Cdktf.IResolvable) : ImagebuilderContainerRecipeState<Present, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version> =
            state.assignments.Add(fun config -> config.Component <- value)
            ({ assignments = state.assignments } : ImagebuilderContainerRecipeState<Present, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#container_type-1">ImagebuilderContainerRecipe#container_type</a>.
        /// </summary>
        [<CustomOperation "container_type">]
        member _.ContainerType(state: ImagebuilderContainerRecipeState<'Component, Missing, 'Name, 'ParentImage, 'TargetRepository, 'Version>, value: string) : ImagebuilderContainerRecipeState<'Component, Present, 'Name, 'ParentImage, 'TargetRepository, 'Version> =
            state.assignments.Add(fun config -> config.ContainerType <- value)
            ({ assignments = state.assignments } : ImagebuilderContainerRecipeState<'Component, Present, 'Name, 'ParentImage, 'TargetRepository, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#name-1">ImagebuilderContainerRecipe#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ImagebuilderContainerRecipeState<'Component, 'ContainerType, Missing, 'ParentImage, 'TargetRepository, 'Version>, value: string) : ImagebuilderContainerRecipeState<'Component, 'ContainerType, Present, 'ParentImage, 'TargetRepository, 'Version> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ImagebuilderContainerRecipeState<'Component, 'ContainerType, Present, 'ParentImage, 'TargetRepository, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#parent_image-1">ImagebuilderContainerRecipe#parent_image</a>.
        /// </summary>
        [<CustomOperation "parent_image">]
        member _.ParentImage(state: ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, Missing, 'TargetRepository, 'Version>, value: string) : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, Present, 'TargetRepository, 'Version> =
            state.assignments.Add(fun config -> config.ParentImage <- value)
            ({ assignments = state.assignments } : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, Present, 'TargetRepository, 'Version>)

        /// <summary>
        /// target_repository block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#target_repository-1">ImagebuilderContainerRecipe#target_repository</a>
        /// </summary>
        [<CustomOperation "target_repository">]
        member _.TargetRepository(state: ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, Missing, 'Version>, value: aws.ImagebuilderContainerRecipe.ImagebuilderContainerRecipeTargetRepository) : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, Present, 'Version> =
            state.assignments.Add(fun config -> config.TargetRepository <- value)
            ({ assignments = state.assignments } : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, Present, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#version-1">ImagebuilderContainerRecipe#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, Missing>, value: string) : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, Present> =
            state.assignments.Add(fun config -> config.Version <- value)
            ({ assignments = state.assignments } : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#description-1">ImagebuilderContainerRecipe#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>, value: string) : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#dockerfile_template_data-1">ImagebuilderContainerRecipe#dockerfile_template_data</a>.
        /// </summary>
        [<CustomOperation "dockerfile_template_data">]
        member _.DockerfileTemplateData(state: ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>, value: string) : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version> =
            state.assignments.Add(fun config -> config.DockerfileTemplateData <- value)
            state : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#dockerfile_template_uri-1">ImagebuilderContainerRecipe#dockerfile_template_uri</a>.
        /// </summary>
        [<CustomOperation "dockerfile_template_uri">]
        member _.DockerfileTemplateUri(state: ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>, value: string) : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version> =
            state.assignments.Add(fun config -> config.DockerfileTemplateUri <- value)
            state : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#id-1">ImagebuilderContainerRecipe#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>, value: string) : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>

        /// <summary>
        /// instance_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#instance_configuration-1">ImagebuilderContainerRecipe#instance_configuration</a>
        /// </summary>
        [<CustomOperation "instance_configuration">]
        member _.InstanceConfiguration(state: ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>, value: aws.ImagebuilderContainerRecipe.ImagebuilderContainerRecipeInstanceConfiguration) : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version> =
            state.assignments.Add(fun config -> config.InstanceConfiguration <- value)
            state : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#kms_key_id-1">ImagebuilderContainerRecipe#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>, value: string) : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#platform_override-1">ImagebuilderContainerRecipe#platform_override</a>.
        /// </summary>
        [<CustomOperation "platform_override">]
        member _.PlatformOverride(state: ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>, value: string) : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version> =
            state.assignments.Add(fun config -> config.PlatformOverride <- value)
            state : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#tags-1">ImagebuilderContainerRecipe#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>, value: seq<string * string>) : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#tags_all-1">ImagebuilderContainerRecipe#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>, value: seq<string * string>) : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#working_directory-1">ImagebuilderContainerRecipe#working_directory</a>.
        /// </summary>
        [<CustomOperation "working_directory">]
        member _.WorkingDirectory(state: ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>, value: string) : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version> =
            state.assignments.Add(fun config -> config.WorkingDirectory <- value)
            state : ImagebuilderContainerRecipeState<'Component, 'ContainerType, 'Name, 'ParentImage, 'TargetRepository, 'Version>

        member _.Run(state: ImagebuilderContainerRecipeState<Present, Present, Present, Present, Present, Present>) : aws.ImagebuilderContainerRecipe.ImagebuilderContainerRecipe =
            let config = aws.ImagebuilderContainerRecipe.ImagebuilderContainerRecipeConfig()
            for setter in state.assignments do
                setter config
            aws.ImagebuilderContainerRecipe.ImagebuilderContainerRecipe(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.imagebuilderContainerRecipe: missing required arguments. Must call: component, container_type, name, parent_image, target_repository, version.", 9999, IsError = true)>]
        member _.Run(_: ImagebuilderContainerRecipeState<_, _, _, _, _, _>) : aws.ImagebuilderContainerRecipe.ImagebuilderContainerRecipe =
            Unchecked.defaultof<aws.ImagebuilderContainerRecipe.ImagebuilderContainerRecipe>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version> = { assignments: ResizeArray<aws.ImagebuilderImageRecipe.ImagebuilderImageRecipeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe">aws_imagebuilder_image_recipe</a>.
    /// </summary>
    type ImagebuilderImageRecipeBuilder(logicalId: string) =
        member _.Yield(_: unit) : ImagebuilderImageRecipeState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ImagebuilderImageRecipeState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ImagebuilderImageRecipeState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ImagebuilderImageRecipeState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// component block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#component-1">ImagebuilderImageRecipe#component</a> Accepts: aws.IResolvable | aws.ImagebuilderImageRecipe.ImagebuilderImageRecipeComponent[]
        /// </summary>
        [<CustomOperation "component">]
        member _.Component(state: ImagebuilderImageRecipeState<Missing, 'Name, 'ParentImage, 'Version>, value: HashiCorp.Cdktf.IResolvable) : ImagebuilderImageRecipeState<Present, 'Name, 'ParentImage, 'Version> =
            state.assignments.Add(fun config -> config.Component <- value)
            ({ assignments = state.assignments } : ImagebuilderImageRecipeState<Present, 'Name, 'ParentImage, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#name-1">ImagebuilderImageRecipe#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ImagebuilderImageRecipeState<'Component, Missing, 'ParentImage, 'Version>, value: string) : ImagebuilderImageRecipeState<'Component, Present, 'ParentImage, 'Version> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ImagebuilderImageRecipeState<'Component, Present, 'ParentImage, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#parent_image-1">ImagebuilderImageRecipe#parent_image</a>.
        /// </summary>
        [<CustomOperation "parent_image">]
        member _.ParentImage(state: ImagebuilderImageRecipeState<'Component, 'Name, Missing, 'Version>, value: string) : ImagebuilderImageRecipeState<'Component, 'Name, Present, 'Version> =
            state.assignments.Add(fun config -> config.ParentImage <- value)
            ({ assignments = state.assignments } : ImagebuilderImageRecipeState<'Component, 'Name, Present, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#version-1">ImagebuilderImageRecipe#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, Missing>, value: string) : ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, Present> =
            state.assignments.Add(fun config -> config.Version <- value)
            ({ assignments = state.assignments } : ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, Present>)

        /// <summary>
        /// block_device_mapping block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#block_device_mapping-1">ImagebuilderImageRecipe#block_device_mapping</a> Accepts: aws.IResolvable | aws.ImagebuilderImageRecipe.ImagebuilderImageRecipeBlockDeviceMapping[]
        /// </summary>
        [<CustomOperation "block_device_mapping">]
        member _.BlockDeviceMapping(state: ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version>, value: HashiCorp.Cdktf.IResolvable) : ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version> =
            state.assignments.Add(fun config -> config.BlockDeviceMapping <- value)
            state : ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#description-1">ImagebuilderImageRecipe#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version>, value: string) : ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#id-1">ImagebuilderImageRecipe#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version>, value: string) : ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version>

        /// <summary>
        /// systems_manager_agent block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#systems_manager_agent-1">ImagebuilderImageRecipe#systems_manager_agent</a>
        /// </summary>
        [<CustomOperation "systems_manager_agent">]
        member _.SystemsManagerAgent(state: ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version>, value: aws.ImagebuilderImageRecipe.ImagebuilderImageRecipeSystemsManagerAgent) : ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version> =
            state.assignments.Add(fun config -> config.SystemsManagerAgent <- value)
            state : ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#tags-1">ImagebuilderImageRecipe#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version>, value: seq<string * string>) : ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#tags_all-1">ImagebuilderImageRecipe#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version>, value: seq<string * string>) : ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#user_data_base64-1">ImagebuilderImageRecipe#user_data_base64</a>.
        /// </summary>
        [<CustomOperation "user_data_base64">]
        member _.UserDataBase64(state: ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version>, value: string) : ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version> =
            state.assignments.Add(fun config -> config.UserDataBase64 <- value)
            state : ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#working_directory-1">ImagebuilderImageRecipe#working_directory</a>.
        /// </summary>
        [<CustomOperation "working_directory">]
        member _.WorkingDirectory(state: ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version>, value: string) : ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version> =
            state.assignments.Add(fun config -> config.WorkingDirectory <- value)
            state : ImagebuilderImageRecipeState<'Component, 'Name, 'ParentImage, 'Version>

        member _.Run(state: ImagebuilderImageRecipeState<Present, Present, Present, Present>) : aws.ImagebuilderImageRecipe.ImagebuilderImageRecipe =
            let config = aws.ImagebuilderImageRecipe.ImagebuilderImageRecipeConfig()
            for setter in state.assignments do
                setter config
            aws.ImagebuilderImageRecipe.ImagebuilderImageRecipe(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.imagebuilderImageRecipe: missing required arguments. Must call: component, name, parent_image, version.", 9999, IsError = true)>]
        member _.Run(_: ImagebuilderImageRecipeState<_, _, _, _>) : aws.ImagebuilderImageRecipe.ImagebuilderImageRecipe =
            Unchecked.defaultof<aws.ImagebuilderImageRecipe.ImagebuilderImageRecipe>

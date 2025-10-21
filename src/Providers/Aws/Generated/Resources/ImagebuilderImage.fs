namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ImagebuilderImageState<'InfrastructureConfigurationArn> = { assignments: ResizeArray<aws.ImagebuilderImage.ImagebuilderImageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image">aws_imagebuilder_image</a>.
    /// </summary>
    type ImagebuilderImageBuilder(logicalId: string) =
        member _.Yield(_: unit) : ImagebuilderImageState<Missing> =
            ({ assignments = ResizeArray() } : ImagebuilderImageState<Missing>)

        member _.Zero(()) : ImagebuilderImageState<Missing> =
            ({ assignments = ResizeArray() } : ImagebuilderImageState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#infrastructure_configuration_arn-1">ImagebuilderImage#infrastructure_configuration_arn</a>.
        /// </summary>
        [<CustomOperation "infrastructure_configuration_arn">]
        member _.InfrastructureConfigurationArn(state: ImagebuilderImageState<Missing>, value: string) : ImagebuilderImageState<Present> =
            state.assignments.Add(fun config -> config.InfrastructureConfigurationArn <- value)
            ({ assignments = state.assignments } : ImagebuilderImageState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#container_recipe_arn-1">ImagebuilderImage#container_recipe_arn</a>.
        /// </summary>
        [<CustomOperation "container_recipe_arn">]
        member _.ContainerRecipeArn(state: ImagebuilderImageState<'InfrastructureConfigurationArn>, value: string) : ImagebuilderImageState<'InfrastructureConfigurationArn> =
            state.assignments.Add(fun config -> config.ContainerRecipeArn <- value)
            state : ImagebuilderImageState<'InfrastructureConfigurationArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#distribution_configuration_arn-1">ImagebuilderImage#distribution_configuration_arn</a>.
        /// </summary>
        [<CustomOperation "distribution_configuration_arn">]
        member _.DistributionConfigurationArn(state: ImagebuilderImageState<'InfrastructureConfigurationArn>, value: string) : ImagebuilderImageState<'InfrastructureConfigurationArn> =
            state.assignments.Add(fun config -> config.DistributionConfigurationArn <- value)
            state : ImagebuilderImageState<'InfrastructureConfigurationArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#enhanced_image_metadata_enabled-1">ImagebuilderImage#enhanced_image_metadata_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enhanced_image_metadata_enabled">]
        member _.EnhancedImageMetadataEnabled(state: ImagebuilderImageState<'InfrastructureConfigurationArn>, value: bool) : ImagebuilderImageState<'InfrastructureConfigurationArn> =
            state.assignments.Add(fun config -> config.EnhancedImageMetadataEnabled <- value)
            state : ImagebuilderImageState<'InfrastructureConfigurationArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#enhanced_image_metadata_enabled-1">ImagebuilderImage#enhanced_image_metadata_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enhanced_image_metadata_enabled">]
        member _.EnhancedImageMetadataEnabled(state: ImagebuilderImageState<'InfrastructureConfigurationArn>, value: HashiCorp.Cdktf.IResolvable) : ImagebuilderImageState<'InfrastructureConfigurationArn> =
            state.assignments.Add(fun config -> config.EnhancedImageMetadataEnabled <- value)
            state : ImagebuilderImageState<'InfrastructureConfigurationArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#execution_role-1">ImagebuilderImage#execution_role</a>.
        /// </summary>
        [<CustomOperation "execution_role">]
        member _.ExecutionRole(state: ImagebuilderImageState<'InfrastructureConfigurationArn>, value: string) : ImagebuilderImageState<'InfrastructureConfigurationArn> =
            state.assignments.Add(fun config -> config.ExecutionRole <- value)
            state : ImagebuilderImageState<'InfrastructureConfigurationArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#id-1">ImagebuilderImage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ImagebuilderImageState<'InfrastructureConfigurationArn>, value: string) : ImagebuilderImageState<'InfrastructureConfigurationArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ImagebuilderImageState<'InfrastructureConfigurationArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#image_recipe_arn-1">ImagebuilderImage#image_recipe_arn</a>.
        /// </summary>
        [<CustomOperation "image_recipe_arn">]
        member _.ImageRecipeArn(state: ImagebuilderImageState<'InfrastructureConfigurationArn>, value: string) : ImagebuilderImageState<'InfrastructureConfigurationArn> =
            state.assignments.Add(fun config -> config.ImageRecipeArn <- value)
            state : ImagebuilderImageState<'InfrastructureConfigurationArn>

        /// <summary>
        /// image_scanning_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#image_scanning_configuration-1">ImagebuilderImage#image_scanning_configuration</a>
        /// </summary>
        [<CustomOperation "image_scanning_configuration">]
        member _.ImageScanningConfiguration(state: ImagebuilderImageState<'InfrastructureConfigurationArn>, value: aws.ImagebuilderImage.ImagebuilderImageImageScanningConfiguration) : ImagebuilderImageState<'InfrastructureConfigurationArn> =
            state.assignments.Add(fun config -> config.ImageScanningConfiguration <- value)
            state : ImagebuilderImageState<'InfrastructureConfigurationArn>

        /// <summary>
        /// image_tests_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#image_tests_configuration-1">ImagebuilderImage#image_tests_configuration</a>
        /// </summary>
        [<CustomOperation "image_tests_configuration">]
        member _.ImageTestsConfiguration(state: ImagebuilderImageState<'InfrastructureConfigurationArn>, value: aws.ImagebuilderImage.ImagebuilderImageImageTestsConfiguration) : ImagebuilderImageState<'InfrastructureConfigurationArn> =
            state.assignments.Add(fun config -> config.ImageTestsConfiguration <- value)
            state : ImagebuilderImageState<'InfrastructureConfigurationArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#tags-1">ImagebuilderImage#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ImagebuilderImageState<'InfrastructureConfigurationArn>, value: seq<string * string>) : ImagebuilderImageState<'InfrastructureConfigurationArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ImagebuilderImageState<'InfrastructureConfigurationArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#tags_all-1">ImagebuilderImage#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ImagebuilderImageState<'InfrastructureConfigurationArn>, value: seq<string * string>) : ImagebuilderImageState<'InfrastructureConfigurationArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ImagebuilderImageState<'InfrastructureConfigurationArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#timeouts-1">ImagebuilderImage#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ImagebuilderImageState<'InfrastructureConfigurationArn>, value: aws.ImagebuilderImage.ImagebuilderImageTimeouts) : ImagebuilderImageState<'InfrastructureConfigurationArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ImagebuilderImageState<'InfrastructureConfigurationArn>

        /// <summary>
        /// workflow block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#workflow-1">ImagebuilderImage#workflow</a> Accepts: aws.IResolvable | aws.ImagebuilderImage.ImagebuilderImageWorkflow[]
        /// </summary>
        [<CustomOperation "workflow">]
        member _.Workflow(state: ImagebuilderImageState<'InfrastructureConfigurationArn>, value: HashiCorp.Cdktf.IResolvable) : ImagebuilderImageState<'InfrastructureConfigurationArn> =
            state.assignments.Add(fun config -> config.Workflow <- value)
            state : ImagebuilderImageState<'InfrastructureConfigurationArn>

        member _.Run(state: ImagebuilderImageState<Present>) : aws.ImagebuilderImage.ImagebuilderImage =
            let config = aws.ImagebuilderImage.ImagebuilderImageConfig()
            for setter in state.assignments do
                setter config
            aws.ImagebuilderImage.ImagebuilderImage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.imagebuilderImage: missing required arguments. Must call: infrastructure_configuration_arn.", 9999, IsError = true)>]
        member _.Run(_: ImagebuilderImageState<_>) : aws.ImagebuilderImage.ImagebuilderImage =
            Unchecked.defaultof<aws.ImagebuilderImage.ImagebuilderImage>

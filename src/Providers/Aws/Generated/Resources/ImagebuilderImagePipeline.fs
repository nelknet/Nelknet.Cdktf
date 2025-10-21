namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name> = { assignments: ResizeArray<aws.ImagebuilderImagePipeline.ImagebuilderImagePipelineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline">aws_imagebuilder_image_pipeline</a>.
    /// </summary>
    type ImagebuilderImagePipelineBuilder(logicalId: string) =
        member _.Yield(_: unit) : ImagebuilderImagePipelineState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ImagebuilderImagePipelineState<Missing, Missing>)

        member _.Zero(()) : ImagebuilderImagePipelineState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ImagebuilderImagePipelineState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#infrastructure_configuration_arn-1">ImagebuilderImagePipeline#infrastructure_configuration_arn</a>.
        /// </summary>
        [<CustomOperation "infrastructure_configuration_arn">]
        member _.InfrastructureConfigurationArn(state: ImagebuilderImagePipelineState<Missing, 'Name>, value: string) : ImagebuilderImagePipelineState<Present, 'Name> =
            state.assignments.Add(fun config -> config.InfrastructureConfigurationArn <- value)
            ({ assignments = state.assignments } : ImagebuilderImagePipelineState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#name-1">ImagebuilderImagePipeline#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, Missing>, value: string) : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#container_recipe_arn-1">ImagebuilderImagePipeline#container_recipe_arn</a>.
        /// </summary>
        [<CustomOperation "container_recipe_arn">]
        member _.ContainerRecipeArn(state: ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>, value: string) : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name> =
            state.assignments.Add(fun config -> config.ContainerRecipeArn <- value)
            state : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#description-1">ImagebuilderImagePipeline#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>, value: string) : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#distribution_configuration_arn-1">ImagebuilderImagePipeline#distribution_configuration_arn</a>.
        /// </summary>
        [<CustomOperation "distribution_configuration_arn">]
        member _.DistributionConfigurationArn(state: ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>, value: string) : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name> =
            state.assignments.Add(fun config -> config.DistributionConfigurationArn <- value)
            state : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#enhanced_image_metadata_enabled-1">ImagebuilderImagePipeline#enhanced_image_metadata_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enhanced_image_metadata_enabled">]
        member _.EnhancedImageMetadataEnabled(state: ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>, value: bool) : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name> =
            state.assignments.Add(fun config -> config.EnhancedImageMetadataEnabled <- value)
            state : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#enhanced_image_metadata_enabled-1">ImagebuilderImagePipeline#enhanced_image_metadata_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enhanced_image_metadata_enabled">]
        member _.EnhancedImageMetadataEnabled(state: ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name> =
            state.assignments.Add(fun config -> config.EnhancedImageMetadataEnabled <- value)
            state : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#execution_role-1">ImagebuilderImagePipeline#execution_role</a>.
        /// </summary>
        [<CustomOperation "execution_role">]
        member _.ExecutionRole(state: ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>, value: string) : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name> =
            state.assignments.Add(fun config -> config.ExecutionRole <- value)
            state : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#id-1">ImagebuilderImagePipeline#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>, value: string) : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#image_recipe_arn-1">ImagebuilderImagePipeline#image_recipe_arn</a>.
        /// </summary>
        [<CustomOperation "image_recipe_arn">]
        member _.ImageRecipeArn(state: ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>, value: string) : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name> =
            state.assignments.Add(fun config -> config.ImageRecipeArn <- value)
            state : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>

        /// <summary>
        /// image_scanning_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#image_scanning_configuration-1">ImagebuilderImagePipeline#image_scanning_configuration</a>
        /// </summary>
        [<CustomOperation "image_scanning_configuration">]
        member _.ImageScanningConfiguration(state: ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>, value: aws.ImagebuilderImagePipeline.ImagebuilderImagePipelineImageScanningConfiguration) : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name> =
            state.assignments.Add(fun config -> config.ImageScanningConfiguration <- value)
            state : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>

        /// <summary>
        /// image_tests_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#image_tests_configuration-1">ImagebuilderImagePipeline#image_tests_configuration</a>
        /// </summary>
        [<CustomOperation "image_tests_configuration">]
        member _.ImageTestsConfiguration(state: ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>, value: aws.ImagebuilderImagePipeline.ImagebuilderImagePipelineImageTestsConfiguration) : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name> =
            state.assignments.Add(fun config -> config.ImageTestsConfiguration <- value)
            state : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>

        /// <summary>
        /// schedule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#schedule-1">ImagebuilderImagePipeline#schedule</a>
        /// </summary>
        [<CustomOperation "schedule">]
        member _.Schedule(state: ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>, value: aws.ImagebuilderImagePipeline.ImagebuilderImagePipelineSchedule) : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name> =
            state.assignments.Add(fun config -> config.Schedule <- value)
            state : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#status-1">ImagebuilderImagePipeline#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>, value: string) : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#tags-1">ImagebuilderImagePipeline#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>, value: seq<string * string>) : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#tags_all-1">ImagebuilderImagePipeline#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>, value: seq<string * string>) : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>

        /// <summary>
        /// workflow block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#workflow-1">ImagebuilderImagePipeline#workflow</a> Accepts: aws.IResolvable | aws.ImagebuilderImagePipeline.ImagebuilderImagePipelineWorkflow[]
        /// </summary>
        [<CustomOperation "workflow">]
        member _.Workflow(state: ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name> =
            state.assignments.Add(fun config -> config.Workflow <- value)
            state : ImagebuilderImagePipelineState<'InfrastructureConfigurationArn, 'Name>

        member _.Run(state: ImagebuilderImagePipelineState<Present, Present>) : aws.ImagebuilderImagePipeline.ImagebuilderImagePipeline =
            let config = aws.ImagebuilderImagePipeline.ImagebuilderImagePipelineConfig()
            for setter in state.assignments do
                setter config
            aws.ImagebuilderImagePipeline.ImagebuilderImagePipeline(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.imagebuilderImagePipeline: missing required arguments. Must call: infrastructure_configuration_arn, name.", 9999, IsError = true)>]
        member _.Run(_: ImagebuilderImagePipelineState<_, _>) : aws.ImagebuilderImagePipeline.ImagebuilderImagePipeline =
            Unchecked.defaultof<aws.ImagebuilderImagePipeline.ImagebuilderImagePipeline>

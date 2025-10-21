using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderImagePipeline
{
    [JsiiByValue(fqn: "aws.imagebuilderImagePipeline.ImagebuilderImagePipelineImageScanningConfigurationEcrConfiguration")]
    public class ImagebuilderImagePipelineImageScanningConfigurationEcrConfiguration : aws.ImagebuilderImagePipeline.IImagebuilderImagePipelineImageScanningConfigurationEcrConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#container_tags ImagebuilderImagePipeline#container_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ContainerTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#repository_name ImagebuilderImagePipeline#repository_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryName
        {
            get;
            set;
        }
    }
}

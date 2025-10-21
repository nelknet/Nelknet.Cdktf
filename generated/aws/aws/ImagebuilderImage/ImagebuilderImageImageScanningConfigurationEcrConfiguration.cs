using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderImage
{
    [JsiiByValue(fqn: "aws.imagebuilderImage.ImagebuilderImageImageScanningConfigurationEcrConfiguration")]
    public class ImagebuilderImageImageScanningConfigurationEcrConfiguration : aws.ImagebuilderImage.IImagebuilderImageImageScanningConfigurationEcrConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#container_tags ImagebuilderImage#container_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ContainerTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#repository_name ImagebuilderImage#repository_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryName
        {
            get;
            set;
        }
    }
}

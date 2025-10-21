using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderImagePipeline
{
    [JsiiInterface(nativeType: typeof(IImagebuilderImagePipelineImageScanningConfiguration), fullyQualifiedName: "aws.imagebuilderImagePipeline.ImagebuilderImagePipelineImageScanningConfiguration")]
    public interface IImagebuilderImagePipelineImageScanningConfiguration
    {
        /// <summary>ecr_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#ecr_configuration ImagebuilderImagePipeline#ecr_configuration}
        /// </remarks>
        [JsiiProperty(name: "ecrConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderImagePipeline.ImagebuilderImagePipelineImageScanningConfigurationEcrConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ImagebuilderImagePipeline.IImagebuilderImagePipelineImageScanningConfigurationEcrConfiguration? EcrConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#image_scanning_enabled ImagebuilderImagePipeline#image_scanning_enabled}.</summary>
        [JsiiProperty(name: "imageScanningEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ImageScanningEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IImagebuilderImagePipelineImageScanningConfiguration), fullyQualifiedName: "aws.imagebuilderImagePipeline.ImagebuilderImagePipelineImageScanningConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ImagebuilderImagePipeline.IImagebuilderImagePipelineImageScanningConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ecr_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#ecr_configuration ImagebuilderImagePipeline#ecr_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecrConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderImagePipeline.ImagebuilderImagePipelineImageScanningConfigurationEcrConfiguration\"}", isOptional: true)]
            public aws.ImagebuilderImagePipeline.IImagebuilderImagePipelineImageScanningConfigurationEcrConfiguration? EcrConfiguration
            {
                get => GetInstanceProperty<aws.ImagebuilderImagePipeline.IImagebuilderImagePipelineImageScanningConfigurationEcrConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_pipeline#image_scanning_enabled ImagebuilderImagePipeline#image_scanning_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageScanningEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ImageScanningEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderImage
{
    [JsiiInterface(nativeType: typeof(IImagebuilderImageImageScanningConfiguration), fullyQualifiedName: "aws.imagebuilderImage.ImagebuilderImageImageScanningConfiguration")]
    public interface IImagebuilderImageImageScanningConfiguration
    {
        /// <summary>ecr_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#ecr_configuration ImagebuilderImage#ecr_configuration}
        /// </remarks>
        [JsiiProperty(name: "ecrConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderImage.ImagebuilderImageImageScanningConfigurationEcrConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ImagebuilderImage.IImagebuilderImageImageScanningConfigurationEcrConfiguration? EcrConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#image_scanning_enabled ImagebuilderImage#image_scanning_enabled}.</summary>
        [JsiiProperty(name: "imageScanningEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ImageScanningEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IImagebuilderImageImageScanningConfiguration), fullyQualifiedName: "aws.imagebuilderImage.ImagebuilderImageImageScanningConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ImagebuilderImage.IImagebuilderImageImageScanningConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ecr_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#ecr_configuration ImagebuilderImage#ecr_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecrConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderImage.ImagebuilderImageImageScanningConfigurationEcrConfiguration\"}", isOptional: true)]
            public aws.ImagebuilderImage.IImagebuilderImageImageScanningConfigurationEcrConfiguration? EcrConfiguration
            {
                get => GetInstanceProperty<aws.ImagebuilderImage.IImagebuilderImageImageScanningConfigurationEcrConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#image_scanning_enabled ImagebuilderImage#image_scanning_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageScanningEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ImageScanningEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

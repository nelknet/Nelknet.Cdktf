using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderImage
{
    [JsiiByValue(fqn: "aws.imagebuilderImage.ImagebuilderImageImageScanningConfiguration")]
    public class ImagebuilderImageImageScanningConfiguration : aws.ImagebuilderImage.IImagebuilderImageImageScanningConfiguration
    {
        /// <summary>ecr_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#ecr_configuration ImagebuilderImage#ecr_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ecrConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderImage.ImagebuilderImageImageScanningConfigurationEcrConfiguration\"}", isOptional: true)]
        public aws.ImagebuilderImage.IImagebuilderImageImageScanningConfigurationEcrConfiguration? EcrConfiguration
        {
            get;
            set;
        }

        private object? _imageScanningEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image#image_scanning_enabled ImagebuilderImage#image_scanning_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageScanningEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ImageScanningEnabled
        {
            get => _imageScanningEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _imageScanningEnabled = value;
            }
        }
    }
}

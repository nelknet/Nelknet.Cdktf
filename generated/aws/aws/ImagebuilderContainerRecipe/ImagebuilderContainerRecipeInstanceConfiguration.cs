using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderContainerRecipe
{
    [JsiiByValue(fqn: "aws.imagebuilderContainerRecipe.ImagebuilderContainerRecipeInstanceConfiguration")]
    public class ImagebuilderContainerRecipeInstanceConfiguration : aws.ImagebuilderContainerRecipe.IImagebuilderContainerRecipeInstanceConfiguration
    {
        private object? _blockDeviceMapping;

        /// <summary>block_device_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#block_device_mapping ImagebuilderContainerRecipe#block_device_mapping}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockDeviceMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderContainerRecipe.ImagebuilderContainerRecipeInstanceConfigurationBlockDeviceMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BlockDeviceMapping
        {
            get => _blockDeviceMapping;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ImagebuilderContainerRecipe.IImagebuilderContainerRecipeInstanceConfigurationBlockDeviceMapping[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ImagebuilderContainerRecipe.IImagebuilderContainerRecipeInstanceConfigurationBlockDeviceMapping).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _blockDeviceMapping = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#image ImagebuilderContainerRecipe#image}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Image
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderContainerRecipe
{
    [JsiiInterface(nativeType: typeof(IImagebuilderContainerRecipeInstanceConfiguration), fullyQualifiedName: "aws.imagebuilderContainerRecipe.ImagebuilderContainerRecipeInstanceConfiguration")]
    public interface IImagebuilderContainerRecipeInstanceConfiguration
    {
        /// <summary>block_device_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#block_device_mapping ImagebuilderContainerRecipe#block_device_mapping}
        /// </remarks>
        [JsiiProperty(name: "blockDeviceMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderContainerRecipe.ImagebuilderContainerRecipeInstanceConfigurationBlockDeviceMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BlockDeviceMapping
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#image ImagebuilderContainerRecipe#image}.</summary>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Image
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IImagebuilderContainerRecipeInstanceConfiguration), fullyQualifiedName: "aws.imagebuilderContainerRecipe.ImagebuilderContainerRecipeInstanceConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ImagebuilderContainerRecipe.IImagebuilderContainerRecipeInstanceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>block_device_mapping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#block_device_mapping ImagebuilderContainerRecipe#block_device_mapping}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blockDeviceMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderContainerRecipe.ImagebuilderContainerRecipeInstanceConfigurationBlockDeviceMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BlockDeviceMapping
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#image ImagebuilderContainerRecipe#image}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Image
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

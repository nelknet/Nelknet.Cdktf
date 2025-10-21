using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderImageRecipe
{
    [JsiiInterface(nativeType: typeof(IImagebuilderImageRecipeBlockDeviceMapping), fullyQualifiedName: "aws.imagebuilderImageRecipe.ImagebuilderImageRecipeBlockDeviceMapping")]
    public interface IImagebuilderImageRecipeBlockDeviceMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#device_name ImagebuilderImageRecipe#device_name}.</summary>
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeviceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>ebs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#ebs ImagebuilderImageRecipe#ebs}
        /// </remarks>
        [JsiiProperty(name: "ebs", typeJson: "{\"fqn\":\"aws.imagebuilderImageRecipe.ImagebuilderImageRecipeBlockDeviceMappingEbs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ImagebuilderImageRecipe.IImagebuilderImageRecipeBlockDeviceMappingEbs? Ebs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#no_device ImagebuilderImageRecipe#no_device}.</summary>
        [JsiiProperty(name: "noDevice", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NoDevice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#virtual_name ImagebuilderImageRecipe#virtual_name}.</summary>
        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VirtualName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IImagebuilderImageRecipeBlockDeviceMapping), fullyQualifiedName: "aws.imagebuilderImageRecipe.ImagebuilderImageRecipeBlockDeviceMapping")]
        internal sealed class _Proxy : DeputyBase, aws.ImagebuilderImageRecipe.IImagebuilderImageRecipeBlockDeviceMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#device_name ImagebuilderImageRecipe#device_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeviceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ebs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#ebs ImagebuilderImageRecipe#ebs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ebs", typeJson: "{\"fqn\":\"aws.imagebuilderImageRecipe.ImagebuilderImageRecipeBlockDeviceMappingEbs\"}", isOptional: true)]
            public aws.ImagebuilderImageRecipe.IImagebuilderImageRecipeBlockDeviceMappingEbs? Ebs
            {
                get => GetInstanceProperty<aws.ImagebuilderImageRecipe.IImagebuilderImageRecipeBlockDeviceMappingEbs?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#no_device ImagebuilderImageRecipe#no_device}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "noDevice", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? NoDevice
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#virtual_name ImagebuilderImageRecipe#virtual_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VirtualName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

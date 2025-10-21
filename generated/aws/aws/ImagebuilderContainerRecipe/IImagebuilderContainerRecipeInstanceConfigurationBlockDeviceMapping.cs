using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderContainerRecipe
{
    [JsiiInterface(nativeType: typeof(IImagebuilderContainerRecipeInstanceConfigurationBlockDeviceMapping), fullyQualifiedName: "aws.imagebuilderContainerRecipe.ImagebuilderContainerRecipeInstanceConfigurationBlockDeviceMapping")]
    public interface IImagebuilderContainerRecipeInstanceConfigurationBlockDeviceMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#device_name ImagebuilderContainerRecipe#device_name}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#ebs ImagebuilderContainerRecipe#ebs}
        /// </remarks>
        [JsiiProperty(name: "ebs", typeJson: "{\"fqn\":\"aws.imagebuilderContainerRecipe.ImagebuilderContainerRecipeInstanceConfigurationBlockDeviceMappingEbs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ImagebuilderContainerRecipe.IImagebuilderContainerRecipeInstanceConfigurationBlockDeviceMappingEbs? Ebs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#no_device ImagebuilderContainerRecipe#no_device}.</summary>
        [JsiiProperty(name: "noDevice", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NoDevice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#virtual_name ImagebuilderContainerRecipe#virtual_name}.</summary>
        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VirtualName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IImagebuilderContainerRecipeInstanceConfigurationBlockDeviceMapping), fullyQualifiedName: "aws.imagebuilderContainerRecipe.ImagebuilderContainerRecipeInstanceConfigurationBlockDeviceMapping")]
        internal sealed class _Proxy : DeputyBase, aws.ImagebuilderContainerRecipe.IImagebuilderContainerRecipeInstanceConfigurationBlockDeviceMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#device_name ImagebuilderContainerRecipe#device_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeviceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ebs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#ebs ImagebuilderContainerRecipe#ebs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ebs", typeJson: "{\"fqn\":\"aws.imagebuilderContainerRecipe.ImagebuilderContainerRecipeInstanceConfigurationBlockDeviceMappingEbs\"}", isOptional: true)]
            public aws.ImagebuilderContainerRecipe.IImagebuilderContainerRecipeInstanceConfigurationBlockDeviceMappingEbs? Ebs
            {
                get => GetInstanceProperty<aws.ImagebuilderContainerRecipe.IImagebuilderContainerRecipeInstanceConfigurationBlockDeviceMappingEbs?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#no_device ImagebuilderContainerRecipe#no_device}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "noDevice", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? NoDevice
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#virtual_name ImagebuilderContainerRecipe#virtual_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VirtualName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

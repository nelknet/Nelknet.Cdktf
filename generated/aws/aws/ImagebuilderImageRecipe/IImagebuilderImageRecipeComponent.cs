using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderImageRecipe
{
    [JsiiInterface(nativeType: typeof(IImagebuilderImageRecipeComponent), fullyQualifiedName: "aws.imagebuilderImageRecipe.ImagebuilderImageRecipeComponent")]
    public interface IImagebuilderImageRecipeComponent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#component_arn ImagebuilderImageRecipe#component_arn}.</summary>
        [JsiiProperty(name: "componentArn", typeJson: "{\"primitive\":\"string\"}")]
        string ComponentArn
        {
            get;
        }

        /// <summary>parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#parameter ImagebuilderImageRecipe#parameter}
        /// </remarks>
        [JsiiProperty(name: "parameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderImageRecipe.ImagebuilderImageRecipeComponentParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Parameter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IImagebuilderImageRecipeComponent), fullyQualifiedName: "aws.imagebuilderImageRecipe.ImagebuilderImageRecipeComponent")]
        internal sealed class _Proxy : DeputyBase, aws.ImagebuilderImageRecipe.IImagebuilderImageRecipeComponent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#component_arn ImagebuilderImageRecipe#component_arn}.</summary>
            [JsiiProperty(name: "componentArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ComponentArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>parameter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#parameter ImagebuilderImageRecipe#parameter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderImageRecipe.ImagebuilderImageRecipeComponentParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Parameter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

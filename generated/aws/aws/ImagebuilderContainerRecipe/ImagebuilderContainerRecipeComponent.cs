using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderContainerRecipe
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.imagebuilderContainerRecipe.ImagebuilderContainerRecipeComponent")]
    public class ImagebuilderContainerRecipeComponent : aws.ImagebuilderContainerRecipe.IImagebuilderContainerRecipeComponent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#component_arn ImagebuilderContainerRecipe#component_arn}.</summary>
        [JsiiProperty(name: "componentArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ComponentArn
        {
            get;
            set;
        }

        private object? _parameter;

        /// <summary>parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#parameter ImagebuilderContainerRecipe#parameter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderContainerRecipe.ImagebuilderContainerRecipeComponentParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Parameter
        {
            get => _parameter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ImagebuilderContainerRecipe.IImagebuilderContainerRecipeComponentParameter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ImagebuilderContainerRecipe.IImagebuilderContainerRecipeComponentParameter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parameter = value;
            }
        }
    }
}

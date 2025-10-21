using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsImagebuilderImageRecipes
{
    [JsiiInterface(nativeType: typeof(IDataAwsImagebuilderImageRecipesFilter), fullyQualifiedName: "aws.dataAwsImagebuilderImageRecipes.DataAwsImagebuilderImageRecipesFilter")]
    public interface IDataAwsImagebuilderImageRecipesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_recipes#name DataAwsImagebuilderImageRecipes#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_recipes#values DataAwsImagebuilderImageRecipes#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsImagebuilderImageRecipesFilter), fullyQualifiedName: "aws.dataAwsImagebuilderImageRecipes.DataAwsImagebuilderImageRecipesFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsImagebuilderImageRecipes.IDataAwsImagebuilderImageRecipesFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_recipes#name DataAwsImagebuilderImageRecipes#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_recipes#values DataAwsImagebuilderImageRecipes#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsImagebuilderContainerRecipes
{
    [JsiiInterface(nativeType: typeof(IDataAwsImagebuilderContainerRecipesFilter), fullyQualifiedName: "aws.dataAwsImagebuilderContainerRecipes.DataAwsImagebuilderContainerRecipesFilter")]
    public interface IDataAwsImagebuilderContainerRecipesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_container_recipes#name DataAwsImagebuilderContainerRecipes#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_container_recipes#values DataAwsImagebuilderContainerRecipes#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsImagebuilderContainerRecipesFilter), fullyQualifiedName: "aws.dataAwsImagebuilderContainerRecipes.DataAwsImagebuilderContainerRecipesFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsImagebuilderContainerRecipes.IDataAwsImagebuilderContainerRecipesFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_container_recipes#name DataAwsImagebuilderContainerRecipes#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_container_recipes#values DataAwsImagebuilderContainerRecipes#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderImageRecipe
{
    [JsiiInterface(nativeType: typeof(IImagebuilderImageRecipeSystemsManagerAgent), fullyQualifiedName: "aws.imagebuilderImageRecipe.ImagebuilderImageRecipeSystemsManagerAgent")]
    public interface IImagebuilderImageRecipeSystemsManagerAgent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#uninstall_after_build ImagebuilderImageRecipe#uninstall_after_build}.</summary>
        [JsiiProperty(name: "uninstallAfterBuild", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object UninstallAfterBuild
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IImagebuilderImageRecipeSystemsManagerAgent), fullyQualifiedName: "aws.imagebuilderImageRecipe.ImagebuilderImageRecipeSystemsManagerAgent")]
        internal sealed class _Proxy : DeputyBase, aws.ImagebuilderImageRecipe.IImagebuilderImageRecipeSystemsManagerAgent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_image_recipe#uninstall_after_build ImagebuilderImageRecipe#uninstall_after_build}.</summary>
            [JsiiProperty(name: "uninstallAfterBuild", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object UninstallAfterBuild
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}

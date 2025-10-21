using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderLifecyclePolicy
{
    [JsiiInterface(nativeType: typeof(IImagebuilderLifecyclePolicyResourceSelectionRecipe), fullyQualifiedName: "aws.imagebuilderLifecyclePolicy.ImagebuilderLifecyclePolicyResourceSelectionRecipe")]
    public interface IImagebuilderLifecyclePolicyResourceSelectionRecipe
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#name ImagebuilderLifecyclePolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#semantic_version ImagebuilderLifecyclePolicy#semantic_version}.</summary>
        [JsiiProperty(name: "semanticVersion", typeJson: "{\"primitive\":\"string\"}")]
        string SemanticVersion
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IImagebuilderLifecyclePolicyResourceSelectionRecipe), fullyQualifiedName: "aws.imagebuilderLifecyclePolicy.ImagebuilderLifecyclePolicyResourceSelectionRecipe")]
        internal sealed class _Proxy : DeputyBase, aws.ImagebuilderLifecyclePolicy.IImagebuilderLifecyclePolicyResourceSelectionRecipe
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#name ImagebuilderLifecyclePolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#semantic_version ImagebuilderLifecyclePolicy#semantic_version}.</summary>
            [JsiiProperty(name: "semanticVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string SemanticVersion
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

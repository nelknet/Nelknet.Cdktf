using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resourceexplorer2View
{
    [JsiiInterface(nativeType: typeof(IResourceexplorer2ViewIncludedProperty), fullyQualifiedName: "aws.resourceexplorer2View.Resourceexplorer2ViewIncludedProperty")]
    public interface IResourceexplorer2ViewIncludedProperty
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourceexplorer2_view#name Resourceexplorer2View#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IResourceexplorer2ViewIncludedProperty), fullyQualifiedName: "aws.resourceexplorer2View.Resourceexplorer2ViewIncludedProperty")]
        internal sealed class _Proxy : DeputyBase, aws.Resourceexplorer2View.IResourceexplorer2ViewIncludedProperty
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourceexplorer2_view#name Resourceexplorer2View#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

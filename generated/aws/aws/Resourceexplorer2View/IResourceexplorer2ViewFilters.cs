using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resourceexplorer2View
{
    [JsiiInterface(nativeType: typeof(IResourceexplorer2ViewFilters), fullyQualifiedName: "aws.resourceexplorer2View.Resourceexplorer2ViewFilters")]
    public interface IResourceexplorer2ViewFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourceexplorer2_view#filter_string Resourceexplorer2View#filter_string}.</summary>
        [JsiiProperty(name: "filterString", typeJson: "{\"primitive\":\"string\"}")]
        string FilterString
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IResourceexplorer2ViewFilters), fullyQualifiedName: "aws.resourceexplorer2View.Resourceexplorer2ViewFilters")]
        internal sealed class _Proxy : DeputyBase, aws.Resourceexplorer2View.IResourceexplorer2ViewFilters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourceexplorer2_view#filter_string Resourceexplorer2View#filter_string}.</summary>
            [JsiiProperty(name: "filterString", typeJson: "{\"primitive\":\"string\"}")]
            public string FilterString
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

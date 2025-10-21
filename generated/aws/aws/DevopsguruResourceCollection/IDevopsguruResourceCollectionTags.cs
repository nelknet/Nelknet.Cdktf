using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsguruResourceCollection
{
    [JsiiInterface(nativeType: typeof(IDevopsguruResourceCollectionTags), fullyQualifiedName: "aws.devopsguruResourceCollection.DevopsguruResourceCollectionTags")]
    public interface IDevopsguruResourceCollectionTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_resource_collection#app_boundary_key DevopsguruResourceCollection#app_boundary_key}.</summary>
        [JsiiProperty(name: "appBoundaryKey", typeJson: "{\"primitive\":\"string\"}")]
        string AppBoundaryKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_resource_collection#tag_values DevopsguruResourceCollection#tag_values}.</summary>
        [JsiiProperty(name: "tagValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] TagValues
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsguruResourceCollectionTags), fullyQualifiedName: "aws.devopsguruResourceCollection.DevopsguruResourceCollectionTags")]
        internal sealed class _Proxy : DeputyBase, aws.DevopsguruResourceCollection.IDevopsguruResourceCollectionTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_resource_collection#app_boundary_key DevopsguruResourceCollection#app_boundary_key}.</summary>
            [JsiiProperty(name: "appBoundaryKey", typeJson: "{\"primitive\":\"string\"}")]
            public string AppBoundaryKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_resource_collection#tag_values DevopsguruResourceCollection#tag_values}.</summary>
            [JsiiProperty(name: "tagValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] TagValues
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}

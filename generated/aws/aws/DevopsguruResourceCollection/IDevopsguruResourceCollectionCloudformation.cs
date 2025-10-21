using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsguruResourceCollection
{
    [JsiiInterface(nativeType: typeof(IDevopsguruResourceCollectionCloudformation), fullyQualifiedName: "aws.devopsguruResourceCollection.DevopsguruResourceCollectionCloudformation")]
    public interface IDevopsguruResourceCollectionCloudformation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_resource_collection#stack_names DevopsguruResourceCollection#stack_names}.</summary>
        [JsiiProperty(name: "stackNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] StackNames
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsguruResourceCollectionCloudformation), fullyQualifiedName: "aws.devopsguruResourceCollection.DevopsguruResourceCollectionCloudformation")]
        internal sealed class _Proxy : DeputyBase, aws.DevopsguruResourceCollection.IDevopsguruResourceCollectionCloudformation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_resource_collection#stack_names DevopsguruResourceCollection#stack_names}.</summary>
            [JsiiProperty(name: "stackNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] StackNames
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}

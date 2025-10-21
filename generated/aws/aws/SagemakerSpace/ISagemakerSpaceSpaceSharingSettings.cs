using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    [JsiiInterface(nativeType: typeof(ISagemakerSpaceSpaceSharingSettings), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSharingSettings")]
    public interface ISagemakerSpaceSpaceSharingSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#sharing_type SagemakerSpace#sharing_type}.</summary>
        [JsiiProperty(name: "sharingType", typeJson: "{\"primitive\":\"string\"}")]
        string SharingType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerSpaceSpaceSharingSettings), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSharingSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerSpace.ISagemakerSpaceSpaceSharingSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#sharing_type SagemakerSpace#sharing_type}.</summary>
            [JsiiProperty(name: "sharingType", typeJson: "{\"primitive\":\"string\"}")]
            public string SharingType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

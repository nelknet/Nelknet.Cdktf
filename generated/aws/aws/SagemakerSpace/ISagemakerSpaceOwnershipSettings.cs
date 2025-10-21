using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    [JsiiInterface(nativeType: typeof(ISagemakerSpaceOwnershipSettings), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceOwnershipSettings")]
    public interface ISagemakerSpaceOwnershipSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#owner_user_profile_name SagemakerSpace#owner_user_profile_name}.</summary>
        [JsiiProperty(name: "ownerUserProfileName", typeJson: "{\"primitive\":\"string\"}")]
        string OwnerUserProfileName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerSpaceOwnershipSettings), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceOwnershipSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerSpace.ISagemakerSpaceOwnershipSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#owner_user_profile_name SagemakerSpace#owner_user_profile_name}.</summary>
            [JsiiProperty(name: "ownerUserProfileName", typeJson: "{\"primitive\":\"string\"}")]
            public string OwnerUserProfileName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

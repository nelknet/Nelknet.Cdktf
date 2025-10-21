using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedpermissionsPolicyStore
{
    [JsiiInterface(nativeType: typeof(IVerifiedpermissionsPolicyStoreValidationSettings), fullyQualifiedName: "aws.verifiedpermissionsPolicyStore.VerifiedpermissionsPolicyStoreValidationSettings")]
    public interface IVerifiedpermissionsPolicyStoreValidationSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy_store#mode VerifiedpermissionsPolicyStore#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVerifiedpermissionsPolicyStoreValidationSettings), fullyQualifiedName: "aws.verifiedpermissionsPolicyStore.VerifiedpermissionsPolicyStoreValidationSettings")]
        internal sealed class _Proxy : DeputyBase, aws.VerifiedpermissionsPolicyStore.IVerifiedpermissionsPolicyStoreValidationSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy_store#mode VerifiedpermissionsPolicyStore#mode}.</summary>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

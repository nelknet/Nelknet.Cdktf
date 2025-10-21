using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedaccessTrustProvider
{
    [JsiiInterface(nativeType: typeof(IVerifiedaccessTrustProviderDeviceOptions), fullyQualifiedName: "aws.verifiedaccessTrustProvider.VerifiedaccessTrustProviderDeviceOptions")]
    public interface IVerifiedaccessTrustProviderDeviceOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_trust_provider#tenant_id VerifiedaccessTrustProvider#tenant_id}.</summary>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TenantId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVerifiedaccessTrustProviderDeviceOptions), fullyQualifiedName: "aws.verifiedaccessTrustProvider.VerifiedaccessTrustProviderDeviceOptions")]
        internal sealed class _Proxy : DeputyBase, aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderDeviceOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_trust_provider#tenant_id VerifiedaccessTrustProvider#tenant_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TenantId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

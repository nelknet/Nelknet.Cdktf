using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecuritylakeCustomLogSource
{
    [JsiiInterface(nativeType: typeof(ISecuritylakeCustomLogSourceConfigurationProviderIdentity), fullyQualifiedName: "aws.securitylakeCustomLogSource.SecuritylakeCustomLogSourceConfigurationProviderIdentity")]
    public interface ISecuritylakeCustomLogSourceConfigurationProviderIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_custom_log_source#external_id SecuritylakeCustomLogSource#external_id}.</summary>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        string ExternalId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_custom_log_source#principal SecuritylakeCustomLogSource#principal}.</summary>
        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
        string Principal
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISecuritylakeCustomLogSourceConfigurationProviderIdentity), fullyQualifiedName: "aws.securitylakeCustomLogSource.SecuritylakeCustomLogSourceConfigurationProviderIdentity")]
        internal sealed class _Proxy : DeputyBase, aws.SecuritylakeCustomLogSource.ISecuritylakeCustomLogSourceConfigurationProviderIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_custom_log_source#external_id SecuritylakeCustomLogSource#external_id}.</summary>
            [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
            public string ExternalId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_custom_log_source#principal SecuritylakeCustomLogSource#principal}.</summary>
            [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
            public string Principal
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

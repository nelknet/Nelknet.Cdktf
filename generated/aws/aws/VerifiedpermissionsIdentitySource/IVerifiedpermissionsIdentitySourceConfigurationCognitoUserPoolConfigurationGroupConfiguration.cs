using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedpermissionsIdentitySource
{
    [JsiiInterface(nativeType: typeof(IVerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfigurationGroupConfiguration), fullyQualifiedName: "aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfigurationGroupConfiguration")]
    public interface IVerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfigurationGroupConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source#group_entity_type VerifiedpermissionsIdentitySource#group_entity_type}.</summary>
        [JsiiProperty(name: "groupEntityType", typeJson: "{\"primitive\":\"string\"}")]
        string GroupEntityType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfigurationGroupConfiguration), fullyQualifiedName: "aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfigurationGroupConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.VerifiedpermissionsIdentitySource.IVerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfigurationGroupConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source#group_entity_type VerifiedpermissionsIdentitySource#group_entity_type}.</summary>
            [JsiiProperty(name: "groupEntityType", typeJson: "{\"primitive\":\"string\"}")]
            public string GroupEntityType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

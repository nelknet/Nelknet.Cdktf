using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedpermissionsIdentitySource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfigurationGroupConfiguration")]
    public class VerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfigurationGroupConfiguration : aws.VerifiedpermissionsIdentitySource.IVerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfigurationGroupConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source#group_entity_type VerifiedpermissionsIdentitySource#group_entity_type}.</summary>
        [JsiiProperty(name: "groupEntityType", typeJson: "{\"primitive\":\"string\"}")]
        public string GroupEntityType
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedpermissionsIdentitySource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfiguration")]
    public class VerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfiguration : aws.VerifiedpermissionsIdentitySource.IVerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source#user_pool_arn VerifiedpermissionsIdentitySource#user_pool_arn}.</summary>
        [JsiiProperty(name: "userPoolArn", typeJson: "{\"primitive\":\"string\"}")]
        public string UserPoolArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source#client_ids VerifiedpermissionsIdentitySource#client_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ClientIds
        {
            get;
            set;
        }

        private object? _groupConfiguration;

        /// <summary>group_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source#group_configuration VerifiedpermissionsIdentitySource#group_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "groupConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfigurationGroupConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GroupConfiguration
        {
            get => _groupConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.VerifiedpermissionsIdentitySource.IVerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfigurationGroupConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.VerifiedpermissionsIdentitySource.IVerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfigurationGroupConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _groupConfiguration = value;
            }
        }
    }
}

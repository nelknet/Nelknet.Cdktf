using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedpermissionsIdentitySource
{
    [JsiiByValue(fqn: "aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfiguration")]
    public class VerifiedpermissionsIdentitySourceConfiguration : aws.VerifiedpermissionsIdentitySource.IVerifiedpermissionsIdentitySourceConfiguration
    {
        private object? _cognitoUserPoolConfiguration;

        /// <summary>cognito_user_pool_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source#cognito_user_pool_configuration VerifiedpermissionsIdentitySource#cognito_user_pool_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cognitoUserPoolConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CognitoUserPoolConfiguration
        {
            get => _cognitoUserPoolConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.VerifiedpermissionsIdentitySource.IVerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.VerifiedpermissionsIdentitySource.IVerifiedpermissionsIdentitySourceConfigurationCognitoUserPoolConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cognitoUserPoolConfiguration = value;
            }
        }

        private object? _openIdConnectConfiguration;

        /// <summary>open_id_connect_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source#open_id_connect_configuration VerifiedpermissionsIdentitySource#open_id_connect_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openIdConnectConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfigurationOpenIdConnectConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OpenIdConnectConfiguration
        {
            get => _openIdConnectConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.VerifiedpermissionsIdentitySource.IVerifiedpermissionsIdentitySourceConfigurationOpenIdConnectConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.VerifiedpermissionsIdentitySource.IVerifiedpermissionsIdentitySourceConfigurationOpenIdConnectConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _openIdConnectConfiguration = value;
            }
        }
    }
}

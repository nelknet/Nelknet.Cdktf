using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminTrustedTokenIssuer
{
    [JsiiByValue(fqn: "aws.ssoadminTrustedTokenIssuer.SsoadminTrustedTokenIssuerTrustedTokenIssuerConfiguration")]
    public class SsoadminTrustedTokenIssuerTrustedTokenIssuerConfiguration : aws.SsoadminTrustedTokenIssuer.ISsoadminTrustedTokenIssuerTrustedTokenIssuerConfiguration
    {
        private object? _oidcJwtConfiguration;

        /// <summary>oidc_jwt_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#oidc_jwt_configuration SsoadminTrustedTokenIssuer#oidc_jwt_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oidcJwtConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssoadminTrustedTokenIssuer.SsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationOidcJwtConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OidcJwtConfiguration
        {
            get => _oidcJwtConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SsoadminTrustedTokenIssuer.ISsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationOidcJwtConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsoadminTrustedTokenIssuer.ISsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationOidcJwtConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _oidcJwtConfiguration = value;
            }
        }
    }
}

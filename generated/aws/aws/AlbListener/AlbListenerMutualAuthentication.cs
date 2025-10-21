using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListener
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.albListener.AlbListenerMutualAuthentication")]
    public class AlbListenerMutualAuthentication : aws.AlbListener.IAlbListenerMutualAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#mode AlbListener#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#advertise_trust_store_ca_names AlbListener#advertise_trust_store_ca_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "advertiseTrustStoreCaNames", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdvertiseTrustStoreCaNames
        {
            get;
            set;
        }

        private object? _ignoreClientCertificateExpiry;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#ignore_client_certificate_expiry AlbListener#ignore_client_certificate_expiry}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ignoreClientCertificateExpiry", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IgnoreClientCertificateExpiry
        {
            get => _ignoreClientCertificateExpiry;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ignoreClientCertificateExpiry = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#trust_store_arn AlbListener#trust_store_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustStoreArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrustStoreArn
        {
            get;
            set;
        }
    }
}

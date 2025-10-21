using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiByValue(fqn: "aws.mskCluster.MskClusterClientAuthentication")]
    public class MskClusterClientAuthentication : aws.MskCluster.IMskClusterClientAuthentication
    {
        /// <summary>sasl block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#sasl MskCluster#sasl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sasl", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterClientAuthenticationSasl\"}", isOptional: true)]
        public aws.MskCluster.IMskClusterClientAuthenticationSasl? Sasl
        {
            get;
            set;
        }

        /// <summary>tls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#tls MskCluster#tls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterClientAuthenticationTls\"}", isOptional: true)]
        public aws.MskCluster.IMskClusterClientAuthenticationTls? Tls
        {
            get;
            set;
        }

        private object? _unauthenticated;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#unauthenticated MskCluster#unauthenticated}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unauthenticated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Unauthenticated
        {
            get => _unauthenticated;
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
                _unauthenticated = value;
            }
        }
    }
}

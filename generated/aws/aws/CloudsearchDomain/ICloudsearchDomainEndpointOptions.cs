using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudsearchDomain
{
    [JsiiInterface(nativeType: typeof(ICloudsearchDomainEndpointOptions), fullyQualifiedName: "aws.cloudsearchDomain.CloudsearchDomainEndpointOptions")]
    public interface ICloudsearchDomainEndpointOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#enforce_https CloudsearchDomain#enforce_https}.</summary>
        [JsiiProperty(name: "enforceHttps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnforceHttps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#tls_security_policy CloudsearchDomain#tls_security_policy}.</summary>
        [JsiiProperty(name: "tlsSecurityPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TlsSecurityPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudsearchDomainEndpointOptions), fullyQualifiedName: "aws.cloudsearchDomain.CloudsearchDomainEndpointOptions")]
        internal sealed class _Proxy : DeputyBase, aws.CloudsearchDomain.ICloudsearchDomainEndpointOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#enforce_https CloudsearchDomain#enforce_https}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enforceHttps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnforceHttps
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#tls_security_policy CloudsearchDomain#tls_security_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tlsSecurityPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TlsSecurityPolicy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

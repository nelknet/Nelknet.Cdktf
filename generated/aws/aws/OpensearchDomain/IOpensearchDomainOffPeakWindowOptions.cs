using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiInterface(nativeType: typeof(IOpensearchDomainOffPeakWindowOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainOffPeakWindowOptions")]
    public interface IOpensearchDomainOffPeakWindowOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#enabled OpensearchDomain#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>off_peak_window block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#off_peak_window OpensearchDomain#off_peak_window}
        /// </remarks>
        [JsiiProperty(name: "offPeakWindow", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainOffPeakWindowOptionsOffPeakWindow\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptionsOffPeakWindow? OffPeakWindow
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDomainOffPeakWindowOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainOffPeakWindowOptions")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#enabled OpensearchDomain#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>off_peak_window block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#off_peak_window OpensearchDomain#off_peak_window}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "offPeakWindow", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainOffPeakWindowOptionsOffPeakWindow\"}", isOptional: true)]
            public aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptionsOffPeakWindow? OffPeakWindow
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptionsOffPeakWindow?>();
            }
        }
    }
}

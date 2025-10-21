using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiInterface(nativeType: typeof(IOpensearchDomainOffPeakWindowOptionsOffPeakWindow), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainOffPeakWindowOptionsOffPeakWindow")]
    public interface IOpensearchDomainOffPeakWindowOptionsOffPeakWindow
    {
        /// <summary>window_start_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#window_start_time OpensearchDomain#window_start_time}
        /// </remarks>
        [JsiiProperty(name: "windowStartTime", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime? WindowStartTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDomainOffPeakWindowOptionsOffPeakWindow), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainOffPeakWindowOptionsOffPeakWindow")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptionsOffPeakWindow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>window_start_time block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#window_start_time OpensearchDomain#window_start_time}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "windowStartTime", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime\"}", isOptional: true)]
            public aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime? WindowStartTime
            {
                get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime?>();
            }
        }
    }
}

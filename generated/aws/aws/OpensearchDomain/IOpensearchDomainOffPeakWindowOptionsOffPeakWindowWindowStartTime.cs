using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiInterface(nativeType: typeof(IOpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime")]
    public interface IOpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#hours OpensearchDomain#hours}.</summary>
        [JsiiProperty(name: "hours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Hours
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#minutes OpensearchDomain#minutes}.</summary>
        [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Minutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#hours OpensearchDomain#hours}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Hours
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#minutes OpensearchDomain#minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Minutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

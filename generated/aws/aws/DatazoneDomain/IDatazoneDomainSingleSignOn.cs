using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazoneDomain
{
    [JsiiInterface(nativeType: typeof(IDatazoneDomainSingleSignOn), fullyQualifiedName: "aws.datazoneDomain.DatazoneDomainSingleSignOn")]
    public interface IDatazoneDomainSingleSignOn
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_domain#type DatazoneDomain#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_domain#user_assignment DatazoneDomain#user_assignment}.</summary>
        [JsiiProperty(name: "userAssignment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserAssignment
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatazoneDomainSingleSignOn), fullyQualifiedName: "aws.datazoneDomain.DatazoneDomainSingleSignOn")]
        internal sealed class _Proxy : DeputyBase, aws.DatazoneDomain.IDatazoneDomainSingleSignOn
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_domain#type DatazoneDomain#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_domain#user_assignment DatazoneDomain#user_assignment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userAssignment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserAssignment
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2FindingsFilter
{
    [JsiiInterface(nativeType: typeof(IMacie2FindingsFilterTimeouts), fullyQualifiedName: "aws.macie2FindingsFilter.Macie2FindingsFilterTimeouts")]
    public interface IMacie2FindingsFilterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#create Macie2FindingsFilter#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMacie2FindingsFilterTimeouts), fullyQualifiedName: "aws.macie2FindingsFilter.Macie2FindingsFilterTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Macie2FindingsFilter.IMacie2FindingsFilterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#create Macie2FindingsFilter#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

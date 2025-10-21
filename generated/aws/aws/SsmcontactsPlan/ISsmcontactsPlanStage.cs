using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsPlan
{
    [JsiiInterface(nativeType: typeof(ISsmcontactsPlanStage), fullyQualifiedName: "aws.ssmcontactsPlan.SsmcontactsPlanStage")]
    public interface ISsmcontactsPlanStage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#duration_in_minutes SsmcontactsPlan#duration_in_minutes}.</summary>
        [JsiiProperty(name: "durationInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        double DurationInMinutes
        {
            get;
        }

        /// <summary>target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#target SsmcontactsPlan#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsPlan.SsmcontactsPlanStageTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Target
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmcontactsPlanStage), fullyQualifiedName: "aws.ssmcontactsPlan.SsmcontactsPlanStage")]
        internal sealed class _Proxy : DeputyBase, aws.SsmcontactsPlan.ISsmcontactsPlanStage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#duration_in_minutes SsmcontactsPlan#duration_in_minutes}.</summary>
            [JsiiProperty(name: "durationInMinutes", typeJson: "{\"primitive\":\"number\"}")]
            public double DurationInMinutes
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#target SsmcontactsPlan#target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsPlan.SsmcontactsPlanStageTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Target
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

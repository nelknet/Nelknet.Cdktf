using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsPlan
{
    [JsiiInterface(nativeType: typeof(ISsmcontactsPlanStageTargetContactTargetInfo), fullyQualifiedName: "aws.ssmcontactsPlan.SsmcontactsPlanStageTargetContactTargetInfo")]
    public interface ISsmcontactsPlanStageTargetContactTargetInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#is_essential SsmcontactsPlan#is_essential}.</summary>
        [JsiiProperty(name: "isEssential", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object IsEssential
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#contact_id SsmcontactsPlan#contact_id}.</summary>
        [JsiiProperty(name: "contactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContactId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmcontactsPlanStageTargetContactTargetInfo), fullyQualifiedName: "aws.ssmcontactsPlan.SsmcontactsPlanStageTargetContactTargetInfo")]
        internal sealed class _Proxy : DeputyBase, aws.SsmcontactsPlan.ISsmcontactsPlanStageTargetContactTargetInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#is_essential SsmcontactsPlan#is_essential}.</summary>
            [JsiiProperty(name: "isEssential", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object IsEssential
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#contact_id SsmcontactsPlan#contact_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContactId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

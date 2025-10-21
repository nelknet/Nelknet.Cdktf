using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsPlan
{
    [JsiiInterface(nativeType: typeof(ISsmcontactsPlanStageTargetChannelTargetInfo), fullyQualifiedName: "aws.ssmcontactsPlan.SsmcontactsPlanStageTargetChannelTargetInfo")]
    public interface ISsmcontactsPlanStageTargetChannelTargetInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#contact_channel_id SsmcontactsPlan#contact_channel_id}.</summary>
        [JsiiProperty(name: "contactChannelId", typeJson: "{\"primitive\":\"string\"}")]
        string ContactChannelId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#retry_interval_in_minutes SsmcontactsPlan#retry_interval_in_minutes}.</summary>
        [JsiiProperty(name: "retryIntervalInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetryIntervalInMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmcontactsPlanStageTargetChannelTargetInfo), fullyQualifiedName: "aws.ssmcontactsPlan.SsmcontactsPlanStageTargetChannelTargetInfo")]
        internal sealed class _Proxy : DeputyBase, aws.SsmcontactsPlan.ISsmcontactsPlanStageTargetChannelTargetInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#contact_channel_id SsmcontactsPlan#contact_channel_id}.</summary>
            [JsiiProperty(name: "contactChannelId", typeJson: "{\"primitive\":\"string\"}")]
            public string ContactChannelId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#retry_interval_in_minutes SsmcontactsPlan#retry_interval_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retryIntervalInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetryIntervalInMinutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

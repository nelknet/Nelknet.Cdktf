using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrBlockPublicAccessConfiguration
{
    [JsiiInterface(nativeType: typeof(IEmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRange), fullyQualifiedName: "aws.emrBlockPublicAccessConfiguration.EmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRange")]
    public interface IEmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_block_public_access_configuration#max_range EmrBlockPublicAccessConfiguration#max_range}.</summary>
        [JsiiProperty(name: "maxRange", typeJson: "{\"primitive\":\"number\"}")]
        double MaxRange
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_block_public_access_configuration#min_range EmrBlockPublicAccessConfiguration#min_range}.</summary>
        [JsiiProperty(name: "minRange", typeJson: "{\"primitive\":\"number\"}")]
        double MinRange
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRange), fullyQualifiedName: "aws.emrBlockPublicAccessConfiguration.EmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRange")]
        internal sealed class _Proxy : DeputyBase, aws.EmrBlockPublicAccessConfiguration.IEmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRange
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_block_public_access_configuration#max_range EmrBlockPublicAccessConfiguration#max_range}.</summary>
            [JsiiProperty(name: "maxRange", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxRange
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_block_public_access_configuration#min_range EmrBlockPublicAccessConfiguration#min_range}.</summary>
            [JsiiProperty(name: "minRange", typeJson: "{\"primitive\":\"number\"}")]
            public double MinRange
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontContinuousDeploymentPolicy
{
    [JsiiInterface(nativeType: typeof(ICloudfrontContinuousDeploymentPolicyTrafficConfigSingleWeightConfigSessionStickinessConfig), fullyQualifiedName: "aws.cloudfrontContinuousDeploymentPolicy.CloudfrontContinuousDeploymentPolicyTrafficConfigSingleWeightConfigSessionStickinessConfig")]
    public interface ICloudfrontContinuousDeploymentPolicyTrafficConfigSingleWeightConfigSessionStickinessConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_continuous_deployment_policy#idle_ttl CloudfrontContinuousDeploymentPolicy#idle_ttl}.</summary>
        [JsiiProperty(name: "idleTtl", typeJson: "{\"primitive\":\"number\"}")]
        double IdleTtl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_continuous_deployment_policy#maximum_ttl CloudfrontContinuousDeploymentPolicy#maximum_ttl}.</summary>
        [JsiiProperty(name: "maximumTtl", typeJson: "{\"primitive\":\"number\"}")]
        double MaximumTtl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontContinuousDeploymentPolicyTrafficConfigSingleWeightConfigSessionStickinessConfig), fullyQualifiedName: "aws.cloudfrontContinuousDeploymentPolicy.CloudfrontContinuousDeploymentPolicyTrafficConfigSingleWeightConfigSessionStickinessConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontContinuousDeploymentPolicy.ICloudfrontContinuousDeploymentPolicyTrafficConfigSingleWeightConfigSessionStickinessConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_continuous_deployment_policy#idle_ttl CloudfrontContinuousDeploymentPolicy#idle_ttl}.</summary>
            [JsiiProperty(name: "idleTtl", typeJson: "{\"primitive\":\"number\"}")]
            public double IdleTtl
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_continuous_deployment_policy#maximum_ttl CloudfrontContinuousDeploymentPolicy#maximum_ttl}.</summary>
            [JsiiProperty(name: "maximumTtl", typeJson: "{\"primitive\":\"number\"}")]
            public double MaximumTtl
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}

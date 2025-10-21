using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontContinuousDeploymentPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontContinuousDeploymentPolicy.CloudfrontContinuousDeploymentPolicyTrafficConfigSingleHeaderConfig")]
    public class CloudfrontContinuousDeploymentPolicyTrafficConfigSingleHeaderConfig : aws.CloudfrontContinuousDeploymentPolicy.ICloudfrontContinuousDeploymentPolicyTrafficConfigSingleHeaderConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_continuous_deployment_policy#header CloudfrontContinuousDeploymentPolicy#header}.</summary>
        [JsiiProperty(name: "header", typeJson: "{\"primitive\":\"string\"}")]
        public string Header
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_continuous_deployment_policy#value CloudfrontContinuousDeploymentPolicy#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}

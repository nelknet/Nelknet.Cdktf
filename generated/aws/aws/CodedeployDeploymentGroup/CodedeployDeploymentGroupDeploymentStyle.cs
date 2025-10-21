using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodedeployDeploymentGroup
{
    [JsiiByValue(fqn: "aws.codedeployDeploymentGroup.CodedeployDeploymentGroupDeploymentStyle")]
    public class CodedeployDeploymentGroupDeploymentStyle : aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupDeploymentStyle
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#deployment_option CodedeployDeploymentGroup#deployment_option}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeploymentOption
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#deployment_type CodedeployDeploymentGroup#deployment_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeploymentType
        {
            get;
            set;
        }
    }
}

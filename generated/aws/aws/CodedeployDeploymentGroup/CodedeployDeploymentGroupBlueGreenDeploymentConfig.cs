using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodedeployDeploymentGroup
{
    [JsiiByValue(fqn: "aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfig")]
    public class CodedeployDeploymentGroupBlueGreenDeploymentConfig : aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfig
    {
        /// <summary>deployment_ready_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#deployment_ready_option CodedeployDeploymentGroup#deployment_ready_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentReadyOption", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption\"}", isOptional: true)]
        public aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption? DeploymentReadyOption
        {
            get;
            set;
        }

        /// <summary>green_fleet_provisioning_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#green_fleet_provisioning_option CodedeployDeploymentGroup#green_fleet_provisioning_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "greenFleetProvisioningOption", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption\"}", isOptional: true)]
        public aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption? GreenFleetProvisioningOption
        {
            get;
            set;
        }

        /// <summary>terminate_blue_instances_on_deployment_success block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_group#terminate_blue_instances_on_deployment_success CodedeployDeploymentGroup#terminate_blue_instances_on_deployment_success}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "terminateBlueInstancesOnDeploymentSuccess", typeJson: "{\"fqn\":\"aws.codedeployDeploymentGroup.CodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess\"}", isOptional: true)]
        public aws.CodedeployDeploymentGroup.ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess? TerminateBlueInstancesOnDeploymentSuccess
        {
            get;
            set;
        }
    }
}

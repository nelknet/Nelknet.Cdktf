using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodedeployDeploymentConfig
{
    [JsiiByValue(fqn: "aws.codedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfig")]
    public class CodedeployDeploymentConfigZonalConfig : aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigZonalConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#first_zone_monitor_duration_in_seconds CodedeployDeploymentConfig#first_zone_monitor_duration_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "firstZoneMonitorDurationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FirstZoneMonitorDurationInSeconds
        {
            get;
            set;
        }

        /// <summary>minimum_healthy_hosts_per_zone block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#minimum_healthy_hosts_per_zone CodedeployDeploymentConfig#minimum_healthy_hosts_per_zone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minimumHealthyHostsPerZone", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfigMinimumHealthyHostsPerZone\"}", isOptional: true)]
        public aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigZonalConfigMinimumHealthyHostsPerZone? MinimumHealthyHostsPerZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#monitor_duration_in_seconds CodedeployDeploymentConfig#monitor_duration_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "monitorDurationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MonitorDurationInSeconds
        {
            get;
            set;
        }
    }
}

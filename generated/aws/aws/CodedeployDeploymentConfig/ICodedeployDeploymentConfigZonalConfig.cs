using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodedeployDeploymentConfig
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentConfigZonalConfig), fullyQualifiedName: "aws.codedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfig")]
    public interface ICodedeployDeploymentConfigZonalConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#first_zone_monitor_duration_in_seconds CodedeployDeploymentConfig#first_zone_monitor_duration_in_seconds}.</summary>
        [JsiiProperty(name: "firstZoneMonitorDurationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FirstZoneMonitorDurationInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>minimum_healthy_hosts_per_zone block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#minimum_healthy_hosts_per_zone CodedeployDeploymentConfig#minimum_healthy_hosts_per_zone}
        /// </remarks>
        [JsiiProperty(name: "minimumHealthyHostsPerZone", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfigMinimumHealthyHostsPerZone\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigZonalConfigMinimumHealthyHostsPerZone? MinimumHealthyHostsPerZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#monitor_duration_in_seconds CodedeployDeploymentConfig#monitor_duration_in_seconds}.</summary>
        [JsiiProperty(name: "monitorDurationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MonitorDurationInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentConfigZonalConfig), fullyQualifiedName: "aws.codedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigZonalConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#first_zone_monitor_duration_in_seconds CodedeployDeploymentConfig#first_zone_monitor_duration_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "firstZoneMonitorDurationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FirstZoneMonitorDurationInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>minimum_healthy_hosts_per_zone block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#minimum_healthy_hosts_per_zone CodedeployDeploymentConfig#minimum_healthy_hosts_per_zone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minimumHealthyHostsPerZone", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfigMinimumHealthyHostsPerZone\"}", isOptional: true)]
            public aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigZonalConfigMinimumHealthyHostsPerZone? MinimumHealthyHostsPerZone
            {
                get => GetInstanceProperty<aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigZonalConfigMinimumHealthyHostsPerZone?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#monitor_duration_in_seconds CodedeployDeploymentConfig#monitor_duration_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "monitorDurationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MonitorDurationInSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

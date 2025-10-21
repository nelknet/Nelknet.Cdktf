using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmquicksetupConfigurationManager
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssmquicksetupConfigurationManager.SsmquicksetupConfigurationManagerConfigurationDefinition")]
    public class SsmquicksetupConfigurationManagerConfigurationDefinition : aws.SsmquicksetupConfigurationManager.ISsmquicksetupConfigurationManagerConfigurationDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmquicksetup_configuration_manager#parameters SsmquicksetupConfigurationManager#parameters}.</summary>
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, string> Parameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmquicksetup_configuration_manager#type SsmquicksetupConfigurationManager#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmquicksetup_configuration_manager#local_deployment_administration_role_arn SsmquicksetupConfigurationManager#local_deployment_administration_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localDeploymentAdministrationRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalDeploymentAdministrationRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmquicksetup_configuration_manager#local_deployment_execution_role_name SsmquicksetupConfigurationManager#local_deployment_execution_role_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localDeploymentExecutionRoleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalDeploymentExecutionRoleName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmquicksetup_configuration_manager#type_version SsmquicksetupConfigurationManager#type_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "typeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TypeVersion
        {
            get;
            set;
        }
    }
}

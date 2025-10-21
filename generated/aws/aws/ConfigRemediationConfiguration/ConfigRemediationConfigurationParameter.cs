using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigRemediationConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.configRemediationConfiguration.ConfigRemediationConfigurationParameter")]
    public class ConfigRemediationConfigurationParameter : aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#name ConfigRemediationConfiguration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#resource_value ConfigRemediationConfiguration#resource_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#static_value ConfigRemediationConfiguration#static_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "staticValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StaticValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#static_values ConfigRemediationConfiguration#static_values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "staticValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? StaticValues
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConformancePack
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.configConformancePack.ConfigConformancePackInputParameter")]
    public class ConfigConformancePackInputParameter : aws.ConfigConformancePack.IConfigConformancePackInputParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_conformance_pack#parameter_name ConfigConformancePack#parameter_name}.</summary>
        [JsiiProperty(name: "parameterName", typeJson: "{\"primitive\":\"string\"}")]
        public string ParameterName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_conformance_pack#parameter_value ConfigConformancePack#parameter_value}.</summary>
        [JsiiProperty(name: "parameterValue", typeJson: "{\"primitive\":\"string\"}")]
        public string ParameterValue
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftserverlessWorkgroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.redshiftserverlessWorkgroup.RedshiftserverlessWorkgroupConfigParameter")]
    public class RedshiftserverlessWorkgroupConfigParameter : aws.RedshiftserverlessWorkgroup.IRedshiftserverlessWorkgroupConfigParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#parameter_key RedshiftserverlessWorkgroup#parameter_key}.</summary>
        [JsiiProperty(name: "parameterKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ParameterKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#parameter_value RedshiftserverlessWorkgroup#parameter_value}.</summary>
        [JsiiProperty(name: "parameterValue", typeJson: "{\"primitive\":\"string\"}")]
        public string ParameterValue
        {
            get;
            set;
        }
    }
}

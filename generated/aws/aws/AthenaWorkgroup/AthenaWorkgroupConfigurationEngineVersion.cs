using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaWorkgroup
{
    [JsiiByValue(fqn: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationEngineVersion")]
    public class AthenaWorkgroupConfigurationEngineVersion : aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationEngineVersion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_workgroup#selected_engine_version AthenaWorkgroup#selected_engine_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "selectedEngineVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SelectedEngineVersion
        {
            get;
            set;
        }
    }
}

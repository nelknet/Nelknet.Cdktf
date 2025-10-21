using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConfigurationRecorder
{
    [JsiiByValue(fqn: "aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingGroupRecordingStrategy")]
    public class ConfigConfigurationRecorderRecordingGroupRecordingStrategy : aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingGroupRecordingStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_recorder#use_only ConfigConfigurationRecorder#use_only}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useOnly", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UseOnly
        {
            get;
            set;
        }
    }
}

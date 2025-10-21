using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConfigurationRecorder
{
    [JsiiByValue(fqn: "aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingGroupExclusionByResourceTypes")]
    public class ConfigConfigurationRecorderRecordingGroupExclusionByResourceTypes : aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingGroupExclusionByResourceTypes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_recorder#resource_types ConfigConfigurationRecorder#resource_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ResourceTypes
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyProject
{
    [JsiiByValue(fqn: "aws.evidentlyProject.EvidentlyProjectDataDeliveryCloudwatchLogs")]
    public class EvidentlyProjectDataDeliveryCloudwatchLogs : aws.EvidentlyProject.IEvidentlyProjectDataDeliveryCloudwatchLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_project#log_group EvidentlyProject#log_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogGroup
        {
            get;
            set;
        }
    }
}

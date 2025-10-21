using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Instance
{
    [JsiiByValue(fqn: "aws.instance.InstanceMaintenanceOptions")]
    public class InstanceMaintenanceOptions : aws.Instance.IInstanceMaintenanceOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#auto_recovery Instance#auto_recovery}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoRecovery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutoRecovery
        {
            get;
            set;
        }
    }
}

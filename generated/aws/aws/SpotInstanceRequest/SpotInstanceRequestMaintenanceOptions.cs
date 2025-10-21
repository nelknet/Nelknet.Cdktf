using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotInstanceRequest
{
    [JsiiByValue(fqn: "aws.spotInstanceRequest.SpotInstanceRequestMaintenanceOptions")]
    public class SpotInstanceRequestMaintenanceOptions : aws.SpotInstanceRequest.ISpotInstanceRequestMaintenanceOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#auto_recovery SpotInstanceRequest#auto_recovery}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoRecovery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutoRecovery
        {
            get;
            set;
        }
    }
}

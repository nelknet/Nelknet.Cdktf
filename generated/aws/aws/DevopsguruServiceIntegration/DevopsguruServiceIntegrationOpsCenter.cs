using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsguruServiceIntegration
{
    [JsiiByValue(fqn: "aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationOpsCenter")]
    public class DevopsguruServiceIntegrationOpsCenter : aws.DevopsguruServiceIntegration.IDevopsguruServiceIntegrationOpsCenter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_service_integration#opt_in_status DevopsguruServiceIntegration#opt_in_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "optInStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OptInStatus
        {
            get;
            set;
        }
    }
}

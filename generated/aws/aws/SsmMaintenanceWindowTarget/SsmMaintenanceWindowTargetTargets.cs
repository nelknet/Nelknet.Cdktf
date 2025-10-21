using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmMaintenanceWindowTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssmMaintenanceWindowTarget.SsmMaintenanceWindowTargetTargets")]
    public class SsmMaintenanceWindowTargetTargets : aws.SsmMaintenanceWindowTarget.ISsmMaintenanceWindowTargetTargets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_target#key SsmMaintenanceWindowTarget#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_target#values SsmMaintenanceWindowTarget#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}

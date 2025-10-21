using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSsmMaintenanceWindows
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsSsmMaintenanceWindows.DataAwsSsmMaintenanceWindowsFilter")]
    public class DataAwsSsmMaintenanceWindowsFilter : aws.DataAwsSsmMaintenanceWindows.IDataAwsSsmMaintenanceWindowsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_maintenance_windows#name DataAwsSsmMaintenanceWindows#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssm_maintenance_windows#values DataAwsSsmMaintenanceWindows#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataShare
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dataShare.DataShareSnapshotSchedule")]
    public class DataShareSnapshotSchedule : azurerm.DataShare.IDataShareSnapshotSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share#name DataShare#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share#recurrence DataShare#recurrence}.</summary>
        [JsiiProperty(name: "recurrence", typeJson: "{\"primitive\":\"string\"}")]
        public string Recurrence
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share#start_time DataShare#start_time}.</summary>
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        public string StartTime
        {
            get;
            set;
        }
    }
}

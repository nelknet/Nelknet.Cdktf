using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyLaunch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.evidentlyLaunch.EvidentlyLaunchMetricMonitorsMetricDefinition")]
    public class EvidentlyLaunchMetricMonitorsMetricDefinition : aws.EvidentlyLaunch.IEvidentlyLaunchMetricMonitorsMetricDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#entity_id_key EvidentlyLaunch#entity_id_key}.</summary>
        [JsiiProperty(name: "entityIdKey", typeJson: "{\"primitive\":\"string\"}")]
        public string EntityIdKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#name EvidentlyLaunch#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#value_key EvidentlyLaunch#value_key}.</summary>
        [JsiiProperty(name: "valueKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ValueKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#event_pattern EvidentlyLaunch#event_pattern}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EventPattern
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#unit_label EvidentlyLaunch#unit_label}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unitLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UnitLabel
        {
            get;
            set;
        }
    }
}

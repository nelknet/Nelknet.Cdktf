using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyLaunch
{
    [JsiiInterface(nativeType: typeof(IEvidentlyLaunchMetricMonitorsMetricDefinition), fullyQualifiedName: "aws.evidentlyLaunch.EvidentlyLaunchMetricMonitorsMetricDefinition")]
    public interface IEvidentlyLaunchMetricMonitorsMetricDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#entity_id_key EvidentlyLaunch#entity_id_key}.</summary>
        [JsiiProperty(name: "entityIdKey", typeJson: "{\"primitive\":\"string\"}")]
        string EntityIdKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#name EvidentlyLaunch#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#value_key EvidentlyLaunch#value_key}.</summary>
        [JsiiProperty(name: "valueKey", typeJson: "{\"primitive\":\"string\"}")]
        string ValueKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#event_pattern EvidentlyLaunch#event_pattern}.</summary>
        [JsiiProperty(name: "eventPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventPattern
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#unit_label EvidentlyLaunch#unit_label}.</summary>
        [JsiiProperty(name: "unitLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UnitLabel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEvidentlyLaunchMetricMonitorsMetricDefinition), fullyQualifiedName: "aws.evidentlyLaunch.EvidentlyLaunchMetricMonitorsMetricDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.EvidentlyLaunch.IEvidentlyLaunchMetricMonitorsMetricDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#entity_id_key EvidentlyLaunch#entity_id_key}.</summary>
            [JsiiProperty(name: "entityIdKey", typeJson: "{\"primitive\":\"string\"}")]
            public string EntityIdKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#name EvidentlyLaunch#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#value_key EvidentlyLaunch#value_key}.</summary>
            [JsiiProperty(name: "valueKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ValueKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#event_pattern EvidentlyLaunch#event_pattern}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventPattern
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#unit_label EvidentlyLaunch#unit_label}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "unitLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UnitLabel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueMlTransform
{
    [JsiiInterface(nativeType: typeof(IGlueMlTransformParametersFindMatchesParameters), fullyQualifiedName: "aws.glueMlTransform.GlueMlTransformParametersFindMatchesParameters")]
    public interface IGlueMlTransformParametersFindMatchesParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#accuracy_cost_trade_off GlueMlTransform#accuracy_cost_trade_off}.</summary>
        [JsiiProperty(name: "accuracyCostTradeOff", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AccuracyCostTradeOff
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#enforce_provided_labels GlueMlTransform#enforce_provided_labels}.</summary>
        [JsiiProperty(name: "enforceProvidedLabels", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnforceProvidedLabels
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#precision_recall_trade_off GlueMlTransform#precision_recall_trade_off}.</summary>
        [JsiiProperty(name: "precisionRecallTradeOff", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PrecisionRecallTradeOff
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#primary_key_column_name GlueMlTransform#primary_key_column_name}.</summary>
        [JsiiProperty(name: "primaryKeyColumnName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrimaryKeyColumnName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueMlTransformParametersFindMatchesParameters), fullyQualifiedName: "aws.glueMlTransform.GlueMlTransformParametersFindMatchesParameters")]
        internal sealed class _Proxy : DeputyBase, aws.GlueMlTransform.IGlueMlTransformParametersFindMatchesParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#accuracy_cost_trade_off GlueMlTransform#accuracy_cost_trade_off}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accuracyCostTradeOff", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AccuracyCostTradeOff
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#enforce_provided_labels GlueMlTransform#enforce_provided_labels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enforceProvidedLabels", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnforceProvidedLabels
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#precision_recall_trade_off GlueMlTransform#precision_recall_trade_off}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "precisionRecallTradeOff", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PrecisionRecallTradeOff
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#primary_key_column_name GlueMlTransform#primary_key_column_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "primaryKeyColumnName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrimaryKeyColumnName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

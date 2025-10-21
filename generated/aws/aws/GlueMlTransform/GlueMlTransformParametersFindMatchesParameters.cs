using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueMlTransform
{
    [JsiiByValue(fqn: "aws.glueMlTransform.GlueMlTransformParametersFindMatchesParameters")]
    public class GlueMlTransformParametersFindMatchesParameters : aws.GlueMlTransform.IGlueMlTransformParametersFindMatchesParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#accuracy_cost_trade_off GlueMlTransform#accuracy_cost_trade_off}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accuracyCostTradeOff", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AccuracyCostTradeOff
        {
            get;
            set;
        }

        private object? _enforceProvidedLabels;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#enforce_provided_labels GlueMlTransform#enforce_provided_labels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enforceProvidedLabels", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnforceProvidedLabels
        {
            get => _enforceProvidedLabels;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enforceProvidedLabels = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#precision_recall_trade_off GlueMlTransform#precision_recall_trade_off}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "precisionRecallTradeOff", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PrecisionRecallTradeOff
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#primary_key_column_name GlueMlTransform#primary_key_column_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "primaryKeyColumnName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrimaryKeyColumnName
        {
            get;
            set;
        }
    }
}

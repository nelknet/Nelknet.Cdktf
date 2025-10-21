using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FisExperimentTemplate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fisExperimentTemplate.FisExperimentTemplateTarget")]
    public class FisExperimentTemplateTarget : aws.FisExperimentTemplate.IFisExperimentTemplateTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#name FisExperimentTemplate#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#resource_type FisExperimentTemplate#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#selection_mode FisExperimentTemplate#selection_mode}.</summary>
        [JsiiProperty(name: "selectionMode", typeJson: "{\"primitive\":\"string\"}")]
        public string SelectionMode
        {
            get;
            set;
        }

        private object? _filter;

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#filter FisExperimentTemplate#filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateTargetFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Filter
        {
            get => _filter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.FisExperimentTemplate.IFisExperimentTemplateTargetFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FisExperimentTemplate.IFisExperimentTemplateTargetFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _filter = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#parameters FisExperimentTemplate#parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#resource_arns FisExperimentTemplate#resource_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ResourceArns
        {
            get;
            set;
        }

        private object? _resourceTag;

        /// <summary>resource_tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#resource_tag FisExperimentTemplate#resource_tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateTargetResourceTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceTag
        {
            get => _resourceTag;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.FisExperimentTemplate.IFisExperimentTemplateTargetResourceTag[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FisExperimentTemplate.IFisExperimentTemplateTargetResourceTag).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceTag = value;
            }
        }
    }
}

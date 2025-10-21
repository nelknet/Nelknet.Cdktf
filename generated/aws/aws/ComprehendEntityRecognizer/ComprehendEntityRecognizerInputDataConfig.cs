using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ComprehendEntityRecognizer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfig")]
    public class ComprehendEntityRecognizerInputDataConfig : aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfig
    {
        private object _entityTypes;

        /// <summary>entity_types block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#entity_types ComprehendEntityRecognizer#entity_types}
        /// </remarks>
        [JsiiProperty(name: "entityTypes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigEntityTypes\"},\"kind\":\"array\"}}]}}")]
        public object EntityTypes
        {
            get => _entityTypes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigEntityTypes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigEntityTypes).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigEntityTypes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _entityTypes = value;
            }
        }

        /// <summary>annotations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#annotations ComprehendEntityRecognizer#annotations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "annotations", typeJson: "{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigAnnotations\"}", isOptional: true)]
        public aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigAnnotations? Annotations
        {
            get;
            set;
        }

        private object? _augmentedManifests;

        /// <summary>augmented_manifests block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#augmented_manifests ComprehendEntityRecognizer#augmented_manifests}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "augmentedManifests", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigAugmentedManifests\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AugmentedManifests
        {
            get => _augmentedManifests;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigAugmentedManifests[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigAugmentedManifests).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _augmentedManifests = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#data_format ComprehendEntityRecognizer#data_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataFormat
        {
            get;
            set;
        }

        /// <summary>documents block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#documents ComprehendEntityRecognizer#documents}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "documents", typeJson: "{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigDocuments\"}", isOptional: true)]
        public aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigDocuments? Documents
        {
            get;
            set;
        }

        /// <summary>entity_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#entity_list ComprehendEntityRecognizer#entity_list}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "entityList", typeJson: "{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigEntityListStruct\"}", isOptional: true)]
        public aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigEntityListStruct? EntityList
        {
            get;
            set;
        }
    }
}

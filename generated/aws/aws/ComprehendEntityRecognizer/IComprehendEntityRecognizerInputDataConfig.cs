using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ComprehendEntityRecognizer
{
    [JsiiInterface(nativeType: typeof(IComprehendEntityRecognizerInputDataConfig), fullyQualifiedName: "aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfig")]
    public interface IComprehendEntityRecognizerInputDataConfig
    {
        /// <summary>entity_types block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#entity_types ComprehendEntityRecognizer#entity_types}
        /// </remarks>
        [JsiiProperty(name: "entityTypes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigEntityTypes\"},\"kind\":\"array\"}}]}}")]
        object EntityTypes
        {
            get;
        }

        /// <summary>annotations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#annotations ComprehendEntityRecognizer#annotations}
        /// </remarks>
        [JsiiProperty(name: "annotations", typeJson: "{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigAnnotations\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigAnnotations? Annotations
        {
            get
            {
                return null;
            }
        }

        /// <summary>augmented_manifests block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#augmented_manifests ComprehendEntityRecognizer#augmented_manifests}
        /// </remarks>
        [JsiiProperty(name: "augmentedManifests", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigAugmentedManifests\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AugmentedManifests
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#data_format ComprehendEntityRecognizer#data_format}.</summary>
        [JsiiProperty(name: "dataFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>documents block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#documents ComprehendEntityRecognizer#documents}
        /// </remarks>
        [JsiiProperty(name: "documents", typeJson: "{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigDocuments\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigDocuments? Documents
        {
            get
            {
                return null;
            }
        }

        /// <summary>entity_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#entity_list ComprehendEntityRecognizer#entity_list}
        /// </remarks>
        [JsiiProperty(name: "entityList", typeJson: "{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigEntityListStruct\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigEntityListStruct? EntityList
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IComprehendEntityRecognizerInputDataConfig), fullyQualifiedName: "aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>entity_types block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#entity_types ComprehendEntityRecognizer#entity_types}
            /// </remarks>
            [JsiiProperty(name: "entityTypes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigEntityTypes\"},\"kind\":\"array\"}}]}}")]
            public object EntityTypes
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>annotations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#annotations ComprehendEntityRecognizer#annotations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "annotations", typeJson: "{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigAnnotations\"}", isOptional: true)]
            public aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigAnnotations? Annotations
            {
                get => GetInstanceProperty<aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigAnnotations?>();
            }

            /// <summary>augmented_manifests block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#augmented_manifests ComprehendEntityRecognizer#augmented_manifests}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "augmentedManifests", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigAugmentedManifests\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AugmentedManifests
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#data_format ComprehendEntityRecognizer#data_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>documents block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#documents ComprehendEntityRecognizer#documents}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "documents", typeJson: "{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigDocuments\"}", isOptional: true)]
            public aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigDocuments? Documents
            {
                get => GetInstanceProperty<aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigDocuments?>();
            }

            /// <summary>entity_list block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_entity_recognizer#entity_list ComprehendEntityRecognizer#entity_list}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "entityList", typeJson: "{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigEntityListStruct\"}", isOptional: true)]
            public aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigEntityListStruct? EntityList
            {
                get => GetInstanceProperty<aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigEntityListStruct?>();
            }
        }
    }
}

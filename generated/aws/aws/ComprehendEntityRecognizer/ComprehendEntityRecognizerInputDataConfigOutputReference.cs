using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ComprehendEntityRecognizer
{
    [JsiiClass(nativeType: typeof(aws.ComprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigOutputReference), fullyQualifiedName: "aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ComprehendEntityRecognizerInputDataConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ComprehendEntityRecognizerInputDataConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComprehendEntityRecognizerInputDataConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComprehendEntityRecognizerInputDataConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnnotations", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigAnnotations\"}}]")]
        public virtual void PutAnnotations(aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigAnnotations @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigAnnotations)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAugmentedManifests", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigAugmentedManifests\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAugmentedManifests(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigAugmentedManifests[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigAugmentedManifests).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigAugmentedManifests).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDocuments", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigDocuments\"}}]")]
        public virtual void PutDocuments(aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigDocuments @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigDocuments)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEntityList", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigEntityListStruct\"}}]")]
        public virtual void PutEntityList(aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigEntityListStruct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigEntityListStruct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEntityTypes", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigEntityTypes\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEntityTypes(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigEntityTypes[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigEntityTypes).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigEntityTypes).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAnnotations")]
        public virtual void ResetAnnotations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAugmentedManifests")]
        public virtual void ResetAugmentedManifests()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataFormat")]
        public virtual void ResetDataFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDocuments")]
        public virtual void ResetDocuments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEntityList")]
        public virtual void ResetEntityList()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "annotations", typeJson: "{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigAnnotationsOutputReference\"}")]
        public virtual aws.ComprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigAnnotationsOutputReference Annotations
        {
            get => GetInstanceProperty<aws.ComprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigAnnotationsOutputReference>()!;
        }

        [JsiiProperty(name: "augmentedManifests", typeJson: "{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigAugmentedManifestsList\"}")]
        public virtual aws.ComprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigAugmentedManifestsList AugmentedManifests
        {
            get => GetInstanceProperty<aws.ComprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigAugmentedManifestsList>()!;
        }

        [JsiiProperty(name: "documents", typeJson: "{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigDocumentsOutputReference\"}")]
        public virtual aws.ComprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigDocumentsOutputReference Documents
        {
            get => GetInstanceProperty<aws.ComprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigDocumentsOutputReference>()!;
        }

        [JsiiProperty(name: "entityList", typeJson: "{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigEntityListStructOutputReference\"}")]
        public virtual aws.ComprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigEntityListStructOutputReference EntityList
        {
            get => GetInstanceProperty<aws.ComprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigEntityListStructOutputReference>()!;
        }

        [JsiiProperty(name: "entityTypes", typeJson: "{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigEntityTypesList\"}")]
        public virtual aws.ComprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigEntityTypesList EntityTypes
        {
            get => GetInstanceProperty<aws.ComprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigEntityTypesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "annotationsInput", typeJson: "{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigAnnotations\"}", isOptional: true)]
        public virtual aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigAnnotations? AnnotationsInput
        {
            get => GetInstanceProperty<aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigAnnotations?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "augmentedManifestsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigAugmentedManifests\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AugmentedManifestsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "documentsInput", typeJson: "{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigDocuments\"}", isOptional: true)]
        public virtual aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigDocuments? DocumentsInput
        {
            get => GetInstanceProperty<aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigDocuments?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "entityListInput", typeJson: "{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigEntityListStruct\"}", isOptional: true)]
        public virtual aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigEntityListStruct? EntityListInput
        {
            get => GetInstanceProperty<aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfigEntityListStruct?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "entityTypesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfigEntityTypes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EntityTypesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "dataFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataFormat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.comprehendEntityRecognizer.ComprehendEntityRecognizerInputDataConfig\"}", isOptional: true)]
        public virtual aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfig? InternalValue
        {
            get => GetInstanceProperty<aws.ComprehendEntityRecognizer.IComprehendEntityRecognizerInputDataConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}

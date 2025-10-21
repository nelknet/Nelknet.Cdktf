using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryFlowletDataFlow
{
    [JsiiClass(nativeType: typeof(azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTransformationOutputReference), fullyQualifiedName: "azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTransformationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataFactoryFlowletDataFlowTransformationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataFactoryFlowletDataFlowTransformationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataFactoryFlowletDataFlowTransformationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataFactoryFlowletDataFlowTransformationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDataset", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTransformationDataset\"}}]")]
        public virtual void PutDataset(azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowTransformationDataset @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowTransformationDataset)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFlowlet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTransformationFlowlet\"}}]")]
        public virtual void PutFlowlet(azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowTransformationFlowlet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowTransformationFlowlet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLinkedService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTransformationLinkedService\"}}]")]
        public virtual void PutLinkedService(azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowTransformationLinkedService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowTransformationLinkedService)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDataset")]
        public virtual void ResetDataset()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFlowlet")]
        public virtual void ResetFlowlet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLinkedService")]
        public virtual void ResetLinkedService()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dataset", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTransformationDatasetOutputReference\"}")]
        public virtual azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTransformationDatasetOutputReference Dataset
        {
            get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTransformationDatasetOutputReference>()!;
        }

        [JsiiProperty(name: "flowlet", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTransformationFlowletOutputReference\"}")]
        public virtual azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTransformationFlowletOutputReference Flowlet
        {
            get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTransformationFlowletOutputReference>()!;
        }

        [JsiiProperty(name: "linkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTransformationLinkedServiceOutputReference\"}")]
        public virtual azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTransformationLinkedServiceOutputReference LinkedService
        {
            get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTransformationLinkedServiceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "datasetInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTransformationDataset\"}", isOptional: true)]
        public virtual azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowTransformationDataset? DatasetInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowTransformationDataset?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "flowletInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTransformationFlowlet\"}", isOptional: true)]
        public virtual azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowTransformationFlowlet? FlowletInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowTransformationFlowlet?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linkedServiceInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTransformationLinkedService\"}", isOptional: true)]
        public virtual azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowTransformationLinkedService? LinkedServiceInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowTransformationLinkedService?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTransformation\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowTransformation cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowTransformation).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}

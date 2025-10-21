using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryDataFlow
{
    [JsiiClass(nativeType: typeof(azurerm.DataFactoryDataFlow.DataFactoryDataFlowTransformationOutputReference), fullyQualifiedName: "azurerm.dataFactoryDataFlow.DataFactoryDataFlowTransformationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataFactoryDataFlowTransformationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataFactoryDataFlowTransformationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataFactoryDataFlowTransformationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataFactoryDataFlowTransformationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDataset", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowTransformationDataset\"}}]")]
        public virtual void PutDataset(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationDataset @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationDataset)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFlowlet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowTransformationFlowlet\"}}]")]
        public virtual void PutFlowlet(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationFlowlet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationFlowlet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLinkedService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowTransformationLinkedService\"}}]")]
        public virtual void PutLinkedService(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationLinkedService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationLinkedService)}, new object[]{@value});
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

        [JsiiProperty(name: "dataset", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowTransformationDatasetOutputReference\"}")]
        public virtual azurerm.DataFactoryDataFlow.DataFactoryDataFlowTransformationDatasetOutputReference Dataset
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.DataFactoryDataFlowTransformationDatasetOutputReference>()!;
        }

        [JsiiProperty(name: "flowlet", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowTransformationFlowletOutputReference\"}")]
        public virtual azurerm.DataFactoryDataFlow.DataFactoryDataFlowTransformationFlowletOutputReference Flowlet
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.DataFactoryDataFlowTransformationFlowletOutputReference>()!;
        }

        [JsiiProperty(name: "linkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowTransformationLinkedServiceOutputReference\"}")]
        public virtual azurerm.DataFactoryDataFlow.DataFactoryDataFlowTransformationLinkedServiceOutputReference LinkedService
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.DataFactoryDataFlowTransformationLinkedServiceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "datasetInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowTransformationDataset\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationDataset? DatasetInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationDataset?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "flowletInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowTransformationFlowlet\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationFlowlet? FlowletInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationFlowlet?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linkedServiceInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowTransformationLinkedService\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationLinkedService? LinkedServiceInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationLinkedService?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowTransformation\"}]}}", isOptional: true)]
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
                        case azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformation cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformation).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}

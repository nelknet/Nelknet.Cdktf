using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryDataFlow
{
    [JsiiClass(nativeType: typeof(azurerm.DataFactoryDataFlow.DataFactoryDataFlowSinkOutputReference), fullyQualifiedName: "azurerm.dataFactoryDataFlow.DataFactoryDataFlowSinkOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataFactoryDataFlowSinkOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataFactoryDataFlowSinkOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataFactoryDataFlowSinkOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataFactoryDataFlowSinkOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDataset", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSinkDataset\"}}]")]
        public virtual void PutDataset(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkDataset @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkDataset)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFlowlet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSinkFlowlet\"}}]")]
        public virtual void PutFlowlet(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkFlowlet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkFlowlet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLinkedService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSinkLinkedService\"}}]")]
        public virtual void PutLinkedService(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkLinkedService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkLinkedService)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRejectedLinkedService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSinkRejectedLinkedService\"}}]")]
        public virtual void PutRejectedLinkedService(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkRejectedLinkedService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkRejectedLinkedService)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchemaLinkedService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSinkSchemaLinkedService\"}}]")]
        public virtual void PutSchemaLinkedService(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkSchemaLinkedService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkSchemaLinkedService)}, new object[]{@value});
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

        [JsiiMethod(name: "resetRejectedLinkedService")]
        public virtual void ResetRejectedLinkedService()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchemaLinkedService")]
        public virtual void ResetSchemaLinkedService()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dataset", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSinkDatasetOutputReference\"}")]
        public virtual azurerm.DataFactoryDataFlow.DataFactoryDataFlowSinkDatasetOutputReference Dataset
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.DataFactoryDataFlowSinkDatasetOutputReference>()!;
        }

        [JsiiProperty(name: "flowlet", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSinkFlowletOutputReference\"}")]
        public virtual azurerm.DataFactoryDataFlow.DataFactoryDataFlowSinkFlowletOutputReference Flowlet
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.DataFactoryDataFlowSinkFlowletOutputReference>()!;
        }

        [JsiiProperty(name: "linkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSinkLinkedServiceOutputReference\"}")]
        public virtual azurerm.DataFactoryDataFlow.DataFactoryDataFlowSinkLinkedServiceOutputReference LinkedService
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.DataFactoryDataFlowSinkLinkedServiceOutputReference>()!;
        }

        [JsiiProperty(name: "rejectedLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSinkRejectedLinkedServiceOutputReference\"}")]
        public virtual azurerm.DataFactoryDataFlow.DataFactoryDataFlowSinkRejectedLinkedServiceOutputReference RejectedLinkedService
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.DataFactoryDataFlowSinkRejectedLinkedServiceOutputReference>()!;
        }

        [JsiiProperty(name: "schemaLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSinkSchemaLinkedServiceOutputReference\"}")]
        public virtual azurerm.DataFactoryDataFlow.DataFactoryDataFlowSinkSchemaLinkedServiceOutputReference SchemaLinkedService
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.DataFactoryDataFlowSinkSchemaLinkedServiceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "datasetInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSinkDataset\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkDataset? DatasetInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkDataset?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "flowletInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSinkFlowlet\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkFlowlet? FlowletInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkFlowlet?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linkedServiceInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSinkLinkedService\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkLinkedService? LinkedServiceInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkLinkedService?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rejectedLinkedServiceInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSinkRejectedLinkedService\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkRejectedLinkedService? RejectedLinkedServiceInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkRejectedLinkedService?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaLinkedServiceInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSinkSchemaLinkedService\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkSchemaLinkedService? SchemaLinkedServiceInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSinkSchemaLinkedService?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSink\"}]}}", isOptional: true)]
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
                        case azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSink cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSink).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}

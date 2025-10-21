using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryDataFlow
{
    [JsiiClass(nativeType: typeof(azurerm.DataFactoryDataFlow.DataFactoryDataFlowSourceOutputReference), fullyQualifiedName: "azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataFactoryDataFlowSourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataFactoryDataFlowSourceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataFactoryDataFlowSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataFactoryDataFlowSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDataset", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceDataset\"}}]")]
        public virtual void PutDataset(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceDataset @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceDataset)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFlowlet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceFlowlet\"}}]")]
        public virtual void PutFlowlet(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceFlowlet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceFlowlet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLinkedService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceLinkedService\"}}]")]
        public virtual void PutLinkedService(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceLinkedService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceLinkedService)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRejectedLinkedService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceRejectedLinkedService\"}}]")]
        public virtual void PutRejectedLinkedService(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceRejectedLinkedService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceRejectedLinkedService)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchemaLinkedService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceSchemaLinkedService\"}}]")]
        public virtual void PutSchemaLinkedService(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceSchemaLinkedService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceSchemaLinkedService)}, new object[]{@value});
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

        [JsiiProperty(name: "dataset", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceDatasetOutputReference\"}")]
        public virtual azurerm.DataFactoryDataFlow.DataFactoryDataFlowSourceDatasetOutputReference Dataset
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.DataFactoryDataFlowSourceDatasetOutputReference>()!;
        }

        [JsiiProperty(name: "flowlet", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceFlowletOutputReference\"}")]
        public virtual azurerm.DataFactoryDataFlow.DataFactoryDataFlowSourceFlowletOutputReference Flowlet
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.DataFactoryDataFlowSourceFlowletOutputReference>()!;
        }

        [JsiiProperty(name: "linkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceLinkedServiceOutputReference\"}")]
        public virtual azurerm.DataFactoryDataFlow.DataFactoryDataFlowSourceLinkedServiceOutputReference LinkedService
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.DataFactoryDataFlowSourceLinkedServiceOutputReference>()!;
        }

        [JsiiProperty(name: "rejectedLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceRejectedLinkedServiceOutputReference\"}")]
        public virtual azurerm.DataFactoryDataFlow.DataFactoryDataFlowSourceRejectedLinkedServiceOutputReference RejectedLinkedService
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.DataFactoryDataFlowSourceRejectedLinkedServiceOutputReference>()!;
        }

        [JsiiProperty(name: "schemaLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceSchemaLinkedServiceOutputReference\"}")]
        public virtual azurerm.DataFactoryDataFlow.DataFactoryDataFlowSourceSchemaLinkedServiceOutputReference SchemaLinkedService
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.DataFactoryDataFlowSourceSchemaLinkedServiceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "datasetInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceDataset\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceDataset? DatasetInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceDataset?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "flowletInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceFlowlet\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceFlowlet? FlowletInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceFlowlet?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linkedServiceInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceLinkedService\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceLinkedService? LinkedServiceInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceLinkedService?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rejectedLinkedServiceInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceRejectedLinkedService\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceRejectedLinkedService? RejectedLinkedServiceInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceRejectedLinkedService?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaLinkedServiceInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceSchemaLinkedService\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceSchemaLinkedService? SchemaLinkedServiceInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceSchemaLinkedService?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSource\"}]}}", isOptional: true)]
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
                        case azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSource cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSource).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}

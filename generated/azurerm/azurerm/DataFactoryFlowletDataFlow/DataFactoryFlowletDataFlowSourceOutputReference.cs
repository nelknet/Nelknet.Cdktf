using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryFlowletDataFlow
{
    [JsiiClass(nativeType: typeof(azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceOutputReference), fullyQualifiedName: "azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataFactoryFlowletDataFlowSourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataFactoryFlowletDataFlowSourceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataFactoryFlowletDataFlowSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataFactoryFlowletDataFlowSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDataset", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceDataset\"}}]")]
        public virtual void PutDataset(azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceDataset @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceDataset)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFlowlet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceFlowlet\"}}]")]
        public virtual void PutFlowlet(azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceFlowlet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceFlowlet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLinkedService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceLinkedService\"}}]")]
        public virtual void PutLinkedService(azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceLinkedService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceLinkedService)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRejectedLinkedService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceRejectedLinkedService\"}}]")]
        public virtual void PutRejectedLinkedService(azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceRejectedLinkedService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceRejectedLinkedService)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchemaLinkedService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceSchemaLinkedService\"}}]")]
        public virtual void PutSchemaLinkedService(azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceSchemaLinkedService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceSchemaLinkedService)}, new object[]{@value});
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

        [JsiiProperty(name: "dataset", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceDatasetOutputReference\"}")]
        public virtual azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceDatasetOutputReference Dataset
        {
            get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceDatasetOutputReference>()!;
        }

        [JsiiProperty(name: "flowlet", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceFlowletOutputReference\"}")]
        public virtual azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceFlowletOutputReference Flowlet
        {
            get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceFlowletOutputReference>()!;
        }

        [JsiiProperty(name: "linkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceLinkedServiceOutputReference\"}")]
        public virtual azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceLinkedServiceOutputReference LinkedService
        {
            get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceLinkedServiceOutputReference>()!;
        }

        [JsiiProperty(name: "rejectedLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceRejectedLinkedServiceOutputReference\"}")]
        public virtual azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceRejectedLinkedServiceOutputReference RejectedLinkedService
        {
            get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceRejectedLinkedServiceOutputReference>()!;
        }

        [JsiiProperty(name: "schemaLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceSchemaLinkedServiceOutputReference\"}")]
        public virtual azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceSchemaLinkedServiceOutputReference SchemaLinkedService
        {
            get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceSchemaLinkedServiceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "datasetInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceDataset\"}", isOptional: true)]
        public virtual azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceDataset? DatasetInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceDataset?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "flowletInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceFlowlet\"}", isOptional: true)]
        public virtual azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceFlowlet? FlowletInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceFlowlet?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linkedServiceInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceLinkedService\"}", isOptional: true)]
        public virtual azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceLinkedService? LinkedServiceInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceLinkedService?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rejectedLinkedServiceInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceRejectedLinkedService\"}", isOptional: true)]
        public virtual azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceRejectedLinkedService? RejectedLinkedServiceInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceRejectedLinkedService?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaLinkedServiceInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceSchemaLinkedService\"}", isOptional: true)]
        public virtual azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceSchemaLinkedService? SchemaLinkedServiceInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceSchemaLinkedService?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSource\"}]}}", isOptional: true)]
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
                        case azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSource cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSource).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}

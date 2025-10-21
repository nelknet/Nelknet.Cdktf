using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    [JsiiClass(nativeType: typeof(aws.GlueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReferenceOutputReference), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReferenceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GlueCatalogTableStorageDescriptorSchemaReferenceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GlueCatalogTableStorageDescriptorSchemaReferenceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GlueCatalogTableStorageDescriptorSchemaReferenceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCatalogTableStorageDescriptorSchemaReferenceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSchemaId", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaId\"}}]")]
        public virtual void PutSchemaId(aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSchemaId")]
        public virtual void ResetSchemaId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchemaVersionId")]
        public virtual void ResetSchemaVersionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "schemaId", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaIdOutputReference\"}")]
        public virtual aws.GlueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaIdOutputReference SchemaId
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaIdOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaIdInput", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReferenceSchemaId\"}", isOptional: true)]
        public virtual aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId? SchemaIdInput
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSchemaReferenceSchemaId?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaVersionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SchemaVersionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaVersionNumberInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SchemaVersionNumberInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "schemaVersionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchemaVersionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schemaVersionNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SchemaVersionNumber
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableStorageDescriptorSchemaReference\"}", isOptional: true)]
        public virtual aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSchemaReference? InternalValue
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.IGlueCatalogTableStorageDescriptorSchemaReference?>();
            set => SetInstanceProperty(value);
        }
    }
}

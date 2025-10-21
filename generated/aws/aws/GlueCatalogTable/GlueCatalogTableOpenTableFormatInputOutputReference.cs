using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    [JsiiClass(nativeType: typeof(aws.GlueCatalogTable.GlueCatalogTableOpenTableFormatInputOutputReference), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GlueCatalogTableOpenTableFormatInputOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GlueCatalogTableOpenTableFormatInputOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GlueCatalogTableOpenTableFormatInputOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCatalogTableOpenTableFormatInputOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIcebergInput", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInput\"}}]")]
        public virtual void PutIcebergInput(aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInput @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInput)}, new object[]{@value});
        }

        [JsiiProperty(name: "icebergInput", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputOutputReference\"}")]
        public virtual aws.GlueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputOutputReference IcebergInput
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "icebergInputInput", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInput\"}", isOptional: true)]
        public virtual aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInput? IcebergInputInput
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInput?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInput\"}", isOptional: true)]
        public virtual aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInput? InternalValue
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInput?>();
            set => SetInstanceProperty(value);
        }
    }
}

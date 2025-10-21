using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    [JsiiClass(nativeType: typeof(aws.DynamodbTable.DynamodbTableImportTableInputFormatOptionsOutputReference), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableImportTableInputFormatOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DynamodbTableImportTableInputFormatOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DynamodbTableImportTableInputFormatOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DynamodbTableImportTableInputFormatOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynamodbTableImportTableInputFormatOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCsv", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableInputFormatOptionsCsv\"}}]")]
        public virtual void PutCsv(aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptionsCsv @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptionsCsv)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCsv")]
        public virtual void ResetCsv()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "csv", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableInputFormatOptionsCsvOutputReference\"}")]
        public virtual aws.DynamodbTable.DynamodbTableImportTableInputFormatOptionsCsvOutputReference Csv
        {
            get => GetInstanceProperty<aws.DynamodbTable.DynamodbTableImportTableInputFormatOptionsCsvOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "csvInput", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableInputFormatOptionsCsv\"}", isOptional: true)]
        public virtual aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptionsCsv? CsvInput
        {
            get => GetInstanceProperty<aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptionsCsv?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableInputFormatOptions\"}", isOptional: true)]
        public virtual aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptions? InternalValue
        {
            get => GetInstanceProperty<aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}

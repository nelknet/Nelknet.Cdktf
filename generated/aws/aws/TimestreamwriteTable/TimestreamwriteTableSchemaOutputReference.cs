using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreamwriteTable
{
    [JsiiClass(nativeType: typeof(aws.TimestreamwriteTable.TimestreamwriteTableSchemaOutputReference), fullyQualifiedName: "aws.timestreamwriteTable.TimestreamwriteTableSchemaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TimestreamwriteTableSchemaOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TimestreamwriteTableSchemaOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TimestreamwriteTableSchemaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TimestreamwriteTableSchemaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCompositePartitionKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.timestreamwriteTable.TimestreamwriteTableSchemaCompositePartitionKey\"}}]")]
        public virtual void PutCompositePartitionKey(aws.TimestreamwriteTable.ITimestreamwriteTableSchemaCompositePartitionKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TimestreamwriteTable.ITimestreamwriteTableSchemaCompositePartitionKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCompositePartitionKey")]
        public virtual void ResetCompositePartitionKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "compositePartitionKey", typeJson: "{\"fqn\":\"aws.timestreamwriteTable.TimestreamwriteTableSchemaCompositePartitionKeyOutputReference\"}")]
        public virtual aws.TimestreamwriteTable.TimestreamwriteTableSchemaCompositePartitionKeyOutputReference CompositePartitionKey
        {
            get => GetInstanceProperty<aws.TimestreamwriteTable.TimestreamwriteTableSchemaCompositePartitionKeyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compositePartitionKeyInput", typeJson: "{\"fqn\":\"aws.timestreamwriteTable.TimestreamwriteTableSchemaCompositePartitionKey\"}", isOptional: true)]
        public virtual aws.TimestreamwriteTable.ITimestreamwriteTableSchemaCompositePartitionKey? CompositePartitionKeyInput
        {
            get => GetInstanceProperty<aws.TimestreamwriteTable.ITimestreamwriteTableSchemaCompositePartitionKey?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.timestreamwriteTable.TimestreamwriteTableSchema\"}", isOptional: true)]
        public virtual aws.TimestreamwriteTable.ITimestreamwriteTableSchema? InternalValue
        {
            get => GetInstanceProperty<aws.TimestreamwriteTable.ITimestreamwriteTableSchema?>();
            set => SetInstanceProperty(value);
        }
    }
}

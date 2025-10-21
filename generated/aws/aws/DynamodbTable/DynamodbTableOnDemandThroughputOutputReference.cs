using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    [JsiiClass(nativeType: typeof(aws.DynamodbTable.DynamodbTableOnDemandThroughputOutputReference), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableOnDemandThroughputOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DynamodbTableOnDemandThroughputOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DynamodbTableOnDemandThroughputOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DynamodbTableOnDemandThroughputOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynamodbTableOnDemandThroughputOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaxReadRequestUnits")]
        public virtual void ResetMaxReadRequestUnits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxWriteRequestUnits")]
        public virtual void ResetMaxWriteRequestUnits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxReadRequestUnitsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxReadRequestUnitsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxWriteRequestUnitsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxWriteRequestUnitsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maxReadRequestUnits", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxReadRequestUnits
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxWriteRequestUnits", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxWriteRequestUnits
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableOnDemandThroughput\"}", isOptional: true)]
        public virtual aws.DynamodbTable.IDynamodbTableOnDemandThroughput? InternalValue
        {
            get => GetInstanceProperty<aws.DynamodbTable.IDynamodbTableOnDemandThroughput?>();
            set => SetInstanceProperty(value);
        }
    }
}

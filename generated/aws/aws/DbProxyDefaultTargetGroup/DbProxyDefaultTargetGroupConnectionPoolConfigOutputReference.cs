using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DbProxyDefaultTargetGroup
{
    [JsiiClass(nativeType: typeof(aws.DbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupConnectionPoolConfigOutputReference), fullyQualifiedName: "aws.dbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupConnectionPoolConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DbProxyDefaultTargetGroupConnectionPoolConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DbProxyDefaultTargetGroupConnectionPoolConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DbProxyDefaultTargetGroupConnectionPoolConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DbProxyDefaultTargetGroupConnectionPoolConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetConnectionBorrowTimeout")]
        public virtual void ResetConnectionBorrowTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitQuery")]
        public virtual void ResetInitQuery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxConnectionsPercent")]
        public virtual void ResetMaxConnectionsPercent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxIdleConnectionsPercent")]
        public virtual void ResetMaxIdleConnectionsPercent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSessionPinningFilters")]
        public virtual void ResetSessionPinningFilters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionBorrowTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConnectionBorrowTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initQueryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InitQueryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxConnectionsPercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxConnectionsPercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxIdleConnectionsPercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxIdleConnectionsPercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sessionPinningFiltersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SessionPinningFiltersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "connectionBorrowTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectionBorrowTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initQuery", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InitQuery
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxConnectionsPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxConnectionsPercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxIdleConnectionsPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxIdleConnectionsPercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sessionPinningFilters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SessionPinningFilters
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupConnectionPoolConfig\"}", isOptional: true)]
        public virtual aws.DbProxyDefaultTargetGroup.IDbProxyDefaultTargetGroupConnectionPoolConfig? InternalValue
        {
            get => GetInstanceProperty<aws.DbProxyDefaultTargetGroup.IDbProxyDefaultTargetGroupConnectionPoolConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncDatasource
{
    [JsiiClass(nativeType: typeof(aws.AppsyncDatasource.AppsyncDatasourceDynamodbConfigDeltaSyncConfigOutputReference), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasourceDynamodbConfigDeltaSyncConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppsyncDatasourceDynamodbConfigDeltaSyncConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppsyncDatasourceDynamodbConfigDeltaSyncConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppsyncDatasourceDynamodbConfigDeltaSyncConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncDatasourceDynamodbConfigDeltaSyncConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBaseTableTtl")]
        public virtual void ResetBaseTableTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeltaSyncTableTtl")]
        public virtual void ResetDeltaSyncTableTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "baseTableTtlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BaseTableTtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deltaSyncTableNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeltaSyncTableNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deltaSyncTableTtlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DeltaSyncTableTtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "baseTableTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BaseTableTtl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deltaSyncTableName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeltaSyncTableName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deltaSyncTableTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeltaSyncTableTtl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceDynamodbConfigDeltaSyncConfig\"}", isOptional: true)]
        public virtual aws.AppsyncDatasource.IAppsyncDatasourceDynamodbConfigDeltaSyncConfig? InternalValue
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceDynamodbConfigDeltaSyncConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsDmsEndpoint
{
    [JsiiClass(nativeType: typeof(aws.DataAwsDmsEndpoint.DataAwsDmsEndpointPostgresSettingsOutputReference), fullyQualifiedName: "aws.dataAwsDmsEndpoint.DataAwsDmsEndpointPostgresSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsDmsEndpointPostgresSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsDmsEndpointPostgresSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsDmsEndpointPostgresSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsDmsEndpointPostgresSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "afterConnectScript", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AfterConnectScript
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "babelfishDatabaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BabelfishDatabaseName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "captureDdls", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable CaptureDdls
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "databaseMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ddlArtifactsSchema", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DdlArtifactsSchema
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "executeTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExecuteTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "failTasksOnLobTruncation", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable FailTasksOnLobTruncation
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "heartbeatEnable", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable HeartbeatEnable
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "heartbeatFrequency", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HeartbeatFrequency
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "heartbeatSchema", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HeartbeatSchema
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mapBooleanAsBoolean", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable MapBooleanAsBoolean
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "mapJsonbAsClob", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable MapJsonbAsClob
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "mapLongVarcharAs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MapLongVarcharAs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxFileSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxFileSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "pluginName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PluginName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "slotName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SlotName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsDmsEndpoint.DataAwsDmsEndpointPostgresSettings\"}", isOptional: true)]
        public virtual aws.DataAwsDmsEndpoint.IDataAwsDmsEndpointPostgresSettings? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsDmsEndpoint.IDataAwsDmsEndpointPostgresSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsEndpoint
{
    [JsiiClass(nativeType: typeof(aws.DmsEndpoint.DmsEndpointMongodbSettingsOutputReference), fullyQualifiedName: "aws.dmsEndpoint.DmsEndpointMongodbSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DmsEndpointMongodbSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DmsEndpointMongodbSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DmsEndpointMongodbSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsEndpointMongodbSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAuthMechanism")]
        public virtual void ResetAuthMechanism()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthSource")]
        public virtual void ResetAuthSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthType")]
        public virtual void ResetAuthType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDocsToInvestigate")]
        public virtual void ResetDocsToInvestigate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtractDocId")]
        public virtual void ResetExtractDocId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNestingLevel")]
        public virtual void ResetNestingLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "authMechanismInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthMechanismInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "docsToInvestigateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DocsToInvestigateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extractDocIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExtractDocIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nestingLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NestingLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "authMechanism", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthMechanism
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthSource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "docsToInvestigate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocsToInvestigate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "extractDocId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExtractDocId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nestingLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NestingLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dmsEndpoint.DmsEndpointMongodbSettings\"}", isOptional: true)]
        public virtual aws.DmsEndpoint.IDmsEndpointMongodbSettings? InternalValue
        {
            get => GetInstanceProperty<aws.DmsEndpoint.IDmsEndpointMongodbSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}

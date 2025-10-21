using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchOutboundConnection
{
    [JsiiClass(nativeType: typeof(aws.OpensearchOutboundConnection.OpensearchOutboundConnectionConnectionPropertiesOutputReference), fullyQualifiedName: "aws.opensearchOutboundConnection.OpensearchOutboundConnectionConnectionPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OpensearchOutboundConnectionConnectionPropertiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OpensearchOutboundConnectionConnectionPropertiesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OpensearchOutboundConnectionConnectionPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchOutboundConnectionConnectionPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCrossClusterSearch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch\"}}]")]
        public virtual void PutCrossClusterSearch(aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCrossClusterSearch")]
        public virtual void ResetCrossClusterSearch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "crossClusterSearch", typeJson: "{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionConnectionPropertiesCrossClusterSearchOutputReference\"}")]
        public virtual aws.OpensearchOutboundConnection.OpensearchOutboundConnectionConnectionPropertiesCrossClusterSearchOutputReference CrossClusterSearch
        {
            get => GetInstanceProperty<aws.OpensearchOutboundConnection.OpensearchOutboundConnectionConnectionPropertiesCrossClusterSearchOutputReference>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "crossClusterSearchInput", typeJson: "{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch\"}", isOptional: true)]
        public virtual aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch? CrossClusterSearchInput
        {
            get => GetInstanceProperty<aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionConnectionProperties\"}", isOptional: true)]
        public virtual aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionProperties? InternalValue
        {
            get => GetInstanceProperty<aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchOutboundConnection
{
    [JsiiClass(nativeType: typeof(aws.OpensearchOutboundConnection.OpensearchOutboundConnectionConnectionPropertiesCrossClusterSearchOutputReference), fullyQualifiedName: "aws.opensearchOutboundConnection.OpensearchOutboundConnectionConnectionPropertiesCrossClusterSearchOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OpensearchOutboundConnectionConnectionPropertiesCrossClusterSearchOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OpensearchOutboundConnectionConnectionPropertiesCrossClusterSearchOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OpensearchOutboundConnectionConnectionPropertiesCrossClusterSearchOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchOutboundConnectionConnectionPropertiesCrossClusterSearchOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSkipUnavailable")]
        public virtual void ResetSkipUnavailable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipUnavailableInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkipUnavailableInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "skipUnavailable", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkipUnavailable
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch\"}", isOptional: true)]
        public virtual aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch? InternalValue
        {
            get => GetInstanceProperty<aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionPropertiesCrossClusterSearch?>();
            set => SetInstanceProperty(value);
        }
    }
}

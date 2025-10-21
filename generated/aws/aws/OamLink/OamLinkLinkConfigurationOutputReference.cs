using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OamLink
{
    [JsiiClass(nativeType: typeof(aws.OamLink.OamLinkLinkConfigurationOutputReference), fullyQualifiedName: "aws.oamLink.OamLinkLinkConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OamLinkLinkConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OamLinkLinkConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OamLinkLinkConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OamLinkLinkConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLogGroupConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.oamLink.OamLinkLinkConfigurationLogGroupConfiguration\"}}]")]
        public virtual void PutLogGroupConfiguration(aws.OamLink.IOamLinkLinkConfigurationLogGroupConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OamLink.IOamLinkLinkConfigurationLogGroupConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMetricConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.oamLink.OamLinkLinkConfigurationMetricConfiguration\"}}]")]
        public virtual void PutMetricConfiguration(aws.OamLink.IOamLinkLinkConfigurationMetricConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OamLink.IOamLinkLinkConfigurationMetricConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLogGroupConfiguration")]
        public virtual void ResetLogGroupConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetricConfiguration")]
        public virtual void ResetMetricConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "logGroupConfiguration", typeJson: "{\"fqn\":\"aws.oamLink.OamLinkLinkConfigurationLogGroupConfigurationOutputReference\"}")]
        public virtual aws.OamLink.OamLinkLinkConfigurationLogGroupConfigurationOutputReference LogGroupConfiguration
        {
            get => GetInstanceProperty<aws.OamLink.OamLinkLinkConfigurationLogGroupConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "metricConfiguration", typeJson: "{\"fqn\":\"aws.oamLink.OamLinkLinkConfigurationMetricConfigurationOutputReference\"}")]
        public virtual aws.OamLink.OamLinkLinkConfigurationMetricConfigurationOutputReference MetricConfiguration
        {
            get => GetInstanceProperty<aws.OamLink.OamLinkLinkConfigurationMetricConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "logGroupConfigurationInput", typeJson: "{\"fqn\":\"aws.oamLink.OamLinkLinkConfigurationLogGroupConfiguration\"}", isOptional: true)]
        public virtual aws.OamLink.IOamLinkLinkConfigurationLogGroupConfiguration? LogGroupConfigurationInput
        {
            get => GetInstanceProperty<aws.OamLink.IOamLinkLinkConfigurationLogGroupConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricConfigurationInput", typeJson: "{\"fqn\":\"aws.oamLink.OamLinkLinkConfigurationMetricConfiguration\"}", isOptional: true)]
        public virtual aws.OamLink.IOamLinkLinkConfigurationMetricConfiguration? MetricConfigurationInput
        {
            get => GetInstanceProperty<aws.OamLink.IOamLinkLinkConfigurationMetricConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.oamLink.OamLinkLinkConfiguration\"}", isOptional: true)]
        public virtual aws.OamLink.IOamLinkLinkConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.OamLink.IOamLinkLinkConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}

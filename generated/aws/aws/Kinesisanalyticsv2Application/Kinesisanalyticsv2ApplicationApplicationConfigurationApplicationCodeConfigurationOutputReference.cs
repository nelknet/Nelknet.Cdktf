using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesisanalyticsv2Application
{
    [JsiiClass(nativeType: typeof(aws.Kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationOutputReference), fullyQualifiedName: "aws.kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCodeContent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationCodeContent\"}}]")]
        public virtual void PutCodeContent(aws.Kinesisanalyticsv2Application.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationCodeContent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesisanalyticsv2Application.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationCodeContent)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCodeContent")]
        public virtual void ResetCodeContent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "codeContent", typeJson: "{\"fqn\":\"aws.kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationCodeContentOutputReference\"}")]
        public virtual aws.Kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationCodeContentOutputReference CodeContent
        {
            get => GetInstanceProperty<aws.Kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationCodeContentOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeContentInput", typeJson: "{\"fqn\":\"aws.kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationCodeContent\"}", isOptional: true)]
        public virtual aws.Kinesisanalyticsv2Application.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationCodeContent? CodeContentInput
        {
            get => GetInstanceProperty<aws.Kinesisanalyticsv2Application.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfigurationCodeContent?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeContentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CodeContentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "codeContentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CodeContentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfiguration\"}", isOptional: true)]
        public virtual aws.Kinesisanalyticsv2Application.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Kinesisanalyticsv2Application.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesisanalyticsv2Application
{
    [JsiiInterface(nativeType: typeof(IKinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentProperties), fullyQualifiedName: "aws.kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentProperties")]
    public interface IKinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentProperties
    {
        /// <summary>property_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#property_group Kinesisanalyticsv2Application#property_group}
        /// </remarks>
        [JsiiProperty(name: "propertyGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentPropertiesPropertyGroup\"},\"kind\":\"array\"}}]}}")]
        object PropertyGroup
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentProperties), fullyQualifiedName: "aws.kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentProperties")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesisanalyticsv2Application.IKinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>property_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#property_group Kinesisanalyticsv2Application#property_group}
            /// </remarks>
            [JsiiProperty(name: "propertyGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentPropertiesPropertyGroup\"},\"kind\":\"array\"}}]}}")]
            public object PropertyGroup
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}

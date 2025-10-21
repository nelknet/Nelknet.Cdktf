using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSsoadminApplicationProviders
{
    [JsiiInterface(nativeType: typeof(IDataAwsSsoadminApplicationProvidersApplicationProviders), fullyQualifiedName: "aws.dataAwsSsoadminApplicationProviders.DataAwsSsoadminApplicationProvidersApplicationProviders")]
    public interface IDataAwsSsoadminApplicationProvidersApplicationProviders
    {
        /// <summary>display_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_application_providers#display_data DataAwsSsoadminApplicationProviders#display_data}
        /// </remarks>
        [JsiiProperty(name: "displayData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsSsoadminApplicationProviders.DataAwsSsoadminApplicationProvidersApplicationProvidersDisplayData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisplayData
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsSsoadminApplicationProvidersApplicationProviders), fullyQualifiedName: "aws.dataAwsSsoadminApplicationProviders.DataAwsSsoadminApplicationProvidersApplicationProviders")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsSsoadminApplicationProviders.IDataAwsSsoadminApplicationProvidersApplicationProviders
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>display_data block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_application_providers#display_data DataAwsSsoadminApplicationProviders#display_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "displayData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsSsoadminApplicationProviders.DataAwsSsoadminApplicationProvidersApplicationProvidersDisplayData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DisplayData
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

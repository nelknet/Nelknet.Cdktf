using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSsoadminApplicationProviders
{
    [JsiiByValue(fqn: "aws.dataAwsSsoadminApplicationProviders.DataAwsSsoadminApplicationProvidersApplicationProviders")]
    public class DataAwsSsoadminApplicationProvidersApplicationProviders : aws.DataAwsSsoadminApplicationProviders.IDataAwsSsoadminApplicationProvidersApplicationProviders
    {
        private object? _displayData;

        /// <summary>display_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_application_providers#display_data DataAwsSsoadminApplicationProviders#display_data}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "displayData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsSsoadminApplicationProviders.DataAwsSsoadminApplicationProvidersApplicationProvidersDisplayData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DisplayData
        {
            get => _displayData;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsSsoadminApplicationProviders.IDataAwsSsoadminApplicationProvidersApplicationProvidersDisplayData[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsSsoadminApplicationProviders.IDataAwsSsoadminApplicationProvidersApplicationProvidersDisplayData).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _displayData = value;
            }
        }
    }
}

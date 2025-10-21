using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSsoadminApplication
{
    [JsiiByValue(fqn: "aws.dataAwsSsoadminApplication.DataAwsSsoadminApplicationPortalOptions")]
    public class DataAwsSsoadminApplicationPortalOptions : aws.DataAwsSsoadminApplication.IDataAwsSsoadminApplicationPortalOptions
    {
        private object? _signInOptions;

        /// <summary>sign_in_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_application#sign_in_options DataAwsSsoadminApplication#sign_in_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "signInOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsSsoadminApplication.DataAwsSsoadminApplicationPortalOptionsSignInOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SignInOptions
        {
            get => _signInOptions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsSsoadminApplication.IDataAwsSsoadminApplicationPortalOptionsSignInOptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsSsoadminApplication.IDataAwsSsoadminApplicationPortalOptionsSignInOptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _signInOptions = value;
            }
        }
    }
}

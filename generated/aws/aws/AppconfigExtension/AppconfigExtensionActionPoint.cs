using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppconfigExtension
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appconfigExtension.AppconfigExtensionActionPoint")]
    public class AppconfigExtensionActionPoint : aws.AppconfigExtension.IAppconfigExtensionActionPoint
    {
        private object _action;

        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_extension#action AppconfigExtension#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appconfigExtension.AppconfigExtensionActionPointAction\"},\"kind\":\"array\"}}]}}")]
        public object Action
        {
            get => _action;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AppconfigExtension.IAppconfigExtensionActionPointAction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppconfigExtension.IAppconfigExtensionActionPointAction).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppconfigExtension.IAppconfigExtensionActionPointAction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _action = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_extension#point AppconfigExtension#point}.</summary>
        [JsiiProperty(name: "point", typeJson: "{\"primitive\":\"string\"}")]
        public string Point
        {
            get;
            set;
        }
    }
}

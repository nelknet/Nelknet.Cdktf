using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AuditmanagerFramework
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.auditmanagerFramework.AuditmanagerFrameworkControlSets")]
    public class AuditmanagerFrameworkControlSets : aws.AuditmanagerFramework.IAuditmanagerFrameworkControlSets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_framework#name AuditmanagerFramework#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _controls;

        /// <summary>controls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_framework#controls AuditmanagerFramework#controls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "controls", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.auditmanagerFramework.AuditmanagerFrameworkControlSetsControls\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Controls
        {
            get => _controls;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AuditmanagerFramework.IAuditmanagerFrameworkControlSetsControls[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AuditmanagerFramework.IAuditmanagerFrameworkControlSetsControls).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _controls = value;
            }
        }
    }
}

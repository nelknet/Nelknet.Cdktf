using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAuditmanagerFramework
{
    [JsiiByValue(fqn: "aws.dataAwsAuditmanagerFramework.DataAwsAuditmanagerFrameworkControlSets")]
    public class DataAwsAuditmanagerFrameworkControlSets : aws.DataAwsAuditmanagerFramework.IDataAwsAuditmanagerFrameworkControlSets
    {
        private object? _controls;

        /// <summary>controls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/auditmanager_framework#controls DataAwsAuditmanagerFramework#controls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "controls", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsAuditmanagerFramework.DataAwsAuditmanagerFrameworkControlSetsControls\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.DataAwsAuditmanagerFramework.IDataAwsAuditmanagerFrameworkControlSetsControls[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsAuditmanagerFramework.IDataAwsAuditmanagerFrameworkControlSetsControls).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _controls = value;
            }
        }
    }
}

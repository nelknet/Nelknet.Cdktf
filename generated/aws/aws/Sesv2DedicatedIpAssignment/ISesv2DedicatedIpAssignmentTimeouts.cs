using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2DedicatedIpAssignment
{
    [JsiiInterface(nativeType: typeof(ISesv2DedicatedIpAssignmentTimeouts), fullyQualifiedName: "aws.sesv2DedicatedIpAssignment.Sesv2DedicatedIpAssignmentTimeouts")]
    public interface ISesv2DedicatedIpAssignmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_dedicated_ip_assignment#create Sesv2DedicatedIpAssignment#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_dedicated_ip_assignment#delete Sesv2DedicatedIpAssignment#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesv2DedicatedIpAssignmentTimeouts), fullyQualifiedName: "aws.sesv2DedicatedIpAssignment.Sesv2DedicatedIpAssignmentTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Sesv2DedicatedIpAssignment.ISesv2DedicatedIpAssignmentTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_dedicated_ip_assignment#create Sesv2DedicatedIpAssignment#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_dedicated_ip_assignment#delete Sesv2DedicatedIpAssignment#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
